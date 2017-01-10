﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.ComponentModel.Design;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using EnvDTE;
using Microsoft.VisualStudio;
using Microsoft.VisualStudio.Shell;

namespace AStyleExtension {
	[PackageRegistration(UseManagedResourcesOnly = true)]
	[InstalledProductRegistration("#110", "#112", "2.8", IconResourceID = 400)]
	[ProvideMenuResource("Menus.ctmenu", 1)]
	[ProvideOptionPage(typeof(AStyleGeneralOptionsPage), "AStyle Formatter", "General", 1000, 1001, true)]
	[ProvideProfileAttribute(typeof(AStyleGeneralOptionsPage), "AStyle Formatter", "General", 1002, 1003, true)]
	[ProvideAutoLoad("{f1536ef8-92ec-443c-9ed7-fdadf150da82}")]
	[Guid(GuidList.GuidPkgString)]
	public sealed class AStyleExtensionPackage : Package {
		private DTE _dte;
		private OleMenuCommand _formatSelMenuCommand;
		private OleMenuCommand _formatDocMenuCommand;
		private bool _isCSharpEnabled;
		private Properties _props;
		private DocumentEventListener _documentEventListener;

		protected override void Initialize() {
			base.Initialize();

			var mcs = GetService(typeof(IMenuCommandService)) as OleMenuCommandService;
			if (null != mcs) {
				var id = new CommandID(GuidList.GuidCmdSet, (int)PkgCmdIDList.FormatDocumentCommand);
				_formatDocMenuCommand = new OleMenuCommand(FormatDocumentCallback, id);
				mcs.AddCommand(_formatDocMenuCommand);
				_formatDocMenuCommand.BeforeQueryStatus += OnBeforeQueryStatus;

				id = new CommandID(GuidList.GuidCmdSet, (int)PkgCmdIDList.FormatSelectionCommand);
				_formatSelMenuCommand = new OleMenuCommand(FormatSelectionCallback, id);
				mcs.AddCommand(_formatSelMenuCommand);
				_formatSelMenuCommand.BeforeQueryStatus += OnBeforeQueryStatus;
			}

			_dte = (DTE)GetService(typeof(DTE));

			_documentEventListener = new DocumentEventListener(this);
			_documentEventListener.BeforeSave += OnBeforeDocumentSave;

			if (_dte.RegistryRoot.Contains("VisualStudio")) {
				_isCSharpEnabled = true;
			}

			_props = _dte.Properties["AStyle Formatter", "General"];
			_props.Item("IsCSarpEnabled").Value = _isCSharpEnabled;
		}

		private TextDocument GetTextDocument(Document doc) {
			if (doc == null || doc.ReadOnly) {
				return null;
			}

			var textDoc = doc.Object("TextDocument") as TextDocument;

			return textDoc;
		}

		private Language GetLanguage(Document doc) {
			var language = Language.NA;

			string lang = doc.Language.ToLower();
			if (lang == "gcc" || lang == "avrgcc" || lang == "c/c++") {
				language = Language.Cpp;
			} else if (lang == "csharp" && _isCSharpEnabled) {
				language = Language.CSharp;
			}

			return language;
		}

		private int OnBeforeDocumentSave(uint docCookie) {
			bool csFormatOnSave = (bool)_props.Item("CsFormatOnSave").Value; ;
			bool cppFormatOnSave = (bool)_props.Item("CppFormatOnSave").Value;
            string cppIgnoredExtensions = (string)_props.Item("CppIgnoredFileExtensions").Value;

			if (!cppFormatOnSave && !csFormatOnSave) {
				return VSConstants.S_OK;
			}

            var doc = _dte.Documents.OfType<Document>().FirstOrDefault(x => x.FullName == _documentEventListener.GetDocumentName(docCookie));
            //check ignored extensions
            if (!string.IsNullOrEmpty(cppIgnoredExtensions))
            {
                List<string> fileExtensionsList = new List<string>();
                fileExtensionsList.AddRange(cppIgnoredExtensions.Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries));
                string ext = System.IO.Path.GetExtension(doc.FullName);
                if (fileExtensionsList.Contains(ext))
                {
                    return VSConstants.S_OK;
                }
            }
			var language = GetLanguage(doc);

			if (language == Language.CSharp && csFormatOnSave) {
				FormatDocument(GetTextDocument(doc), Language.CSharp);
			} else if (language == Language.Cpp && cppFormatOnSave) {
				FormatDocument(GetTextDocument(doc), Language.Cpp);
			}

			return VSConstants.S_OK;
		}

		private void OnBeforeQueryStatus(object sender, EventArgs e) {
			var cmd = (OleMenuCommand)sender;
			var language = GetLanguage(_dte.ActiveDocument);

			if (language != Language.CSharp && language != Language.Cpp) {
				cmd.Visible = false;
			} else {
				cmd.Visible = true;
			}

			cmd.Enabled = cmd.Visible;
		}

		private void FormatDocumentCallback(object sender, EventArgs e) {
			var language = GetLanguage(_dte.ActiveDocument);
			var textDoc = GetTextDocument(_dte.ActiveDocument);

			FormatDocument(textDoc, language);
		}

		private void FormatDocument(TextDocument textDoc, Language language) {
			if (textDoc == null || language == Language.NA) {
				return;
			}

			EditPoint sp = textDoc.StartPoint.CreateEditPoint();
			EditPoint ep = textDoc.EndPoint.CreateEditPoint();
			string text = sp.GetText(ep);

			if (String.IsNullOrEmpty(text)) {
				return;
			}

			string formattedText = Format(text, language);
			if (!String.IsNullOrEmpty(formattedText)) {
				sp.ReplaceText(ep, formattedText, (int)vsEPReplaceTextOptions.vsEPReplaceTextKeepMarkers);
			}
		}

		private void FormatSelectionCallback(object sender, EventArgs e) {
			var language = GetLanguage(_dte.ActiveDocument);
			var textDoc = GetTextDocument(_dte.ActiveDocument);

			FormatSelection(textDoc, language);
		}

		private void FormatSelection(TextDocument textDoc, Language language) {
			if (textDoc == null || language == Language.NA) {
				return;
			}

			string newLineReplacement = "";

			if (textDoc.Selection.IsEmpty) {
				return;
			}

			EditPoint sp = textDoc.Selection.TopPoint.CreateEditPoint();
			EditPoint ep = textDoc.Selection.BottomPoint.CreateEditPoint();

			string text = textDoc.Selection.Text;

			int pos = 0;
			foreach (var c in text) {
				pos++;
				if (c != ' ' && c != '\t') {
					break;
				}
			}

			if (pos > 0) {
				newLineReplacement = text.Substring(0, pos - 1);
			}

			string formattedText = Format(text, language);

			if (!String.IsNullOrEmpty(newLineReplacement)) {
				string[] lines = Regex.Split(formattedText, "\r\n|\r|\n");

				for (int x = 0; x < lines.Length; x++) {
					if (!string.IsNullOrEmpty(lines[x])) {
						lines[x] = newLineReplacement + lines[x];
					}
				}

				formattedText = String.Join(Environment.NewLine, lines);
			}

			if (!String.IsNullOrEmpty(formattedText)) {
				sp.ReplaceText(ep, formattedText, (int)vsEPReplaceTextOptions.vsEPReplaceTextKeepMarkers);
			}
		}

		private string Format(string text, Language language) {
			string options;

			if (_props == null) {
				MessageBox.Show("Unable to read AStyle Formatter settings.", "AStyle Formatter Error");
				return null;
			}

			if (language == Language.CSharp) {
				options = (string)_props.Item("CsOptions").Value;
			} else if (language == Language.Cpp) {
				options = (string)_props.Item("CppOptions").Value;
			} else {
				return null;
			}

			if (String.IsNullOrEmpty(options)) {
				return null;
			}

			var aStyle = new AStyleInterface();
			aStyle.ErrorRaised += OnAStyleErrorRaised;

			return aStyle.FormatSource(text, options);
		}

		private void OnAStyleErrorRaised(object source, AStyleErrorArgs args) {
			MessageBox.Show(args.Message, "AStyle Formatter Error");
		}
	}
}
