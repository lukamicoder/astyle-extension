using System;
using System.Linq;
using System.Runtime.InteropServices;
using System.ComponentModel.Design;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using EnvDTE;
using Microsoft.VisualStudio;
using Microsoft.VisualStudio.AsyncPackageHelpers;
using Microsoft.VisualStudio.Shell;

namespace AStyleExtension {
	[ProvideMenuResource("Menus.ctmenu", 1)]
	[InstalledProductRegistration("#110", "#112", "3.1", IconResourceID = 400)]
	[Microsoft.VisualStudio.AsyncPackageHelpers.AsyncPackageRegistration(UseManagedResourcesOnly = true, AllowsBackgroundLoading = true)]
	[Microsoft.VisualStudio.AsyncPackageHelpers.ProvideAutoLoad(VSConstants.UICONTEXT.NoSolution_string, Microsoft.VisualStudio.AsyncPackageHelpers.PackageAutoLoadFlags.BackgroundLoad)]
	[Microsoft.VisualStudio.AsyncPackageHelpers.ProvideAutoLoad(VSConstants.UICONTEXT.SolutionExists_string, Microsoft.VisualStudio.AsyncPackageHelpers.PackageAutoLoadFlags.BackgroundLoad)]
	[Microsoft.VisualStudio.AsyncPackageHelpers.ProvideAutoLoad(VSConstants.UICONTEXT.SolutionHasSingleProject_string, Microsoft.VisualStudio.AsyncPackageHelpers.PackageAutoLoadFlags.BackgroundLoad)]
	[Microsoft.VisualStudio.AsyncPackageHelpers.ProvideAutoLoad(VSConstants.UICONTEXT.SolutionHasMultipleProjects_string, Microsoft.VisualStudio.AsyncPackageHelpers.PackageAutoLoadFlags.BackgroundLoad)]

	[Guid(GuidList.GuidPkgString)]
	[ProvideOptionPage(typeof(AStyleGeneralOptionsPage), "AStyle Formatter", "General", 1000, 1001, true)]
	public sealed class AStyleExtensionPackage : Package {
		private DTE _dte;
		private OleMenuCommand _formatSelMenuCommand;
		private OleMenuCommand _formatDocMenuCommand;
		private bool _isCSharpEnabled;
		private AStyleGeneralOptionsPage _dialog;
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

			_dialog = (AStyleGeneralOptionsPage)GetDialogPage(typeof(AStyleGeneralOptionsPage));
			_dialog.IsCSarpEnabled = _isCSharpEnabled;
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
			if (!_dialog.CppFormatOnSave && !_dialog.CsFormatOnSave) {
				return VSConstants.S_OK;
			}

			var doc = _dte.Documents.OfType<Document>().FirstOrDefault(x => x.FullName == _documentEventListener.GetDocumentName(docCookie));
			var language = GetLanguage(doc);

			if (language == Language.CSharp && _dialog.CsFormatOnSave) {
				FormatDocument(GetTextDocument(doc), Language.CSharp);
			} else if (language == Language.Cpp && _dialog.CppFormatOnSave) {
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

			if (_dialog == null) {
				MessageBox.Show("Unable to read AStyle Formatter settings.", "AStyle Formatter Error");
				return null;
			}

			if (language == Language.CSharp) {
				options = _dialog.CsOptions;
			} else if (language == Language.Cpp) {
				options = _dialog.CppOptions;
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
