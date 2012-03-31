using System;
using System.Runtime.InteropServices;
using System.ComponentModel.Design;
using System.Windows.Forms;
using EnvDTE;
using Microsoft.VisualStudio;
using Microsoft.VisualStudio.Shell.Interop;
using Microsoft.VisualStudio.Shell;

namespace AStyleExtension {
    [PackageRegistration(UseManagedResourcesOnly = true)]
    [InstalledProductRegistration("#110", "#112", "1.0", IconResourceID = 400)]
    [ProvideMenuResource("Menus.ctmenu", 1)]
    [ProvideOptionPage(typeof(AStyleGeneralOptionsPage), "AStyle Formatter", "General", 0, 0, true)]
    [Guid(GuidList.GuidPkgString)]
    public sealed class AStyleExtensionPackage : Package {
        private static IVsOutputWindowPane _outputPane;
        private DTE _dte;
        private Document _doc;
        private MenuCommand _formatSelMenuCommand;
        private MenuCommand _formatDocMenuCommand;
        private bool _isCSharpEnabled;
        private Properties _props;

        protected override void Initialize() {
            base.Initialize();

            OleMenuCommandService mcs = GetService(typeof(IMenuCommandService)) as OleMenuCommandService;
            if (null != mcs) {
                CommandID id = new CommandID(GuidList.GuidCmdSet, (int)PkgCmdIDList.FormatDocumentCommand);
                _formatDocMenuCommand = new MenuCommand(FormatDocumentCallback, id);
                mcs.AddCommand(_formatDocMenuCommand);

                id = new CommandID(GuidList.GuidCmdSet, (int)PkgCmdIDList.FormatSelectionCommand);
                _formatSelMenuCommand = new MenuCommand(FormatSelectionCallback, id);
                mcs.AddCommand(_formatSelMenuCommand);
            }

            var outputWindow = GetService(typeof(SVsOutputWindow)) as IVsOutputWindow;
            if (outputWindow != null) {
                Guid guidPane = VSConstants.OutputWindowPaneGuid.GeneralPane_guid;
                outputWindow.GetPane(ref guidPane, out _outputPane);
            }

            _dte = (DTE)GetService(typeof(DTE));

            if (_dte.RegistryRoot.Contains("VisualStudio")) {
               _isCSharpEnabled = true;
            }

            _props = _dte.Properties["AStyle Formatter", "General"];
            _props.Item("IsCSarpEnabled").Value = _isCSharpEnabled;
        }

        private void FormatDocumentCallback(object sender, EventArgs e) {
            _doc = _dte.ActiveDocument;
            if (_doc == null) {
                return;
            }
            
            TextDocument textDoc = _doc.Object("TextDocument") as TextDocument;
            if (textDoc == null) {
                return;
            }

            string language = textDoc.Language.ToLower();
            if (language != "avrgcc" && language != "c/c++" && (language != "csharp" || !_isCSharpEnabled)) {
                return;
            }

            EditPoint sp = textDoc.StartPoint.CreateEditPoint();
            EditPoint ep = textDoc.EndPoint.CreateEditPoint();
            string text = sp.GetText(ep);

            if (!String.IsNullOrEmpty(text)) {
                string formattedText = Format(text, language);
                if (!String.IsNullOrEmpty(formattedText)) {
                    sp.ReplaceText(ep, formattedText, (int)vsEPReplaceTextOptions.vsEPReplaceTextKeepMarkers);
                }
            }
        }

        private void FormatSelectionCallback(object sender, EventArgs e) {
            _doc = _dte.ActiveDocument;
            if (_doc == null) {
                return;
            }

            TextDocument textDoc = _doc.Object("TextDocument") as TextDocument;
            if (textDoc == null) {
                return;
            }

            string language = textDoc.Language.ToLower();
            if (language != "c/c++" && (language != "csharp" || !_isCSharpEnabled)) {
                return;
            }

            if (!textDoc.Selection.IsEmpty) {
                string text = textDoc.Selection.Text;
                string formattedText = Format(text, language);
                if (!String.IsNullOrEmpty(formattedText)) {
                    textDoc.ReplaceText(text, formattedText, (int)vsEPReplaceTextOptions.vsEPReplaceTextKeepMarkers);
                }
            }
        }

        string Format(string text, string language) {
            string options; 

            if (_props == null) {
                MessageBox.Show("Unable to read AStyle Formatter settings.", "AStyle Formatter Error");
                return null;
            }

            if (_isCSharpEnabled && language == "csharp") {
                options = (string)_props.Item("CsOptions").Value;
            } else if (language == "c/c++" || language == "avrgcc") {
                options = (string)_props.Item("CppOptions").Value;
            } else {
                return null;
            }

            if (String.IsNullOrEmpty(options)) {
                return null;
            }

            AStyleInterface aStyle = new AStyleInterface();

            return aStyle.FormatSource(text, options);
        }
    }
}
