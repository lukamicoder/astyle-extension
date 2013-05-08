using System;
using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace AStyleExtension {
    public partial class AStyleGeneralOptionsControl : UserControl {
        private string _cppOptions;
        private string _csOptions;
        private bool _isCSarpEnabled;

        public string CppOptions {
            get { return _cppOptions; }
            set {
                _cppOptions = value;
                textBoxCPP.Text = _cppOptions;
            }
        }

        public string CsOptions {
            get { return _csOptions; }
            set {
                _csOptions = value;
                textBoxCS.Text = _csOptions;
            }
        }

        public bool IsCSarpEnabled {
            get { return _isCSarpEnabled; }
            set {
                _isCSarpEnabled = value;
                if (!_isCSarpEnabled) {
                    tabControlOptions.TabPages.Remove(tabPageCS);
                }
            }
        }

        public AStyleGeneralOptionsControl() {
            InitializeComponent();
        }

        public void ClearDetails() {
            textBoxDetails.Text = "";
        }

        private void OnButtonCPPSettingsClick(object sender, EventArgs e) {
            var form = new AStyleSettingsForm(Language.C);
            form.SetControls(CppOptions);

            if (form.ShowDialog() != DialogResult.OK) {
                return;
            }

            CppOptions = form.GetCommandLine();
            textBoxCPP.Text = CppOptions;
        }

        private void OnButtonCSSettingsClick(object sender, EventArgs e) {
            var form = new AStyleSettingsForm(Language.CSharp);
            form.SetControls(CsOptions);

            if (form.ShowDialog() != DialogResult.OK) {
                return;
            }

            CsOptions = form.GetCommandLine();
            textBoxCS.Text = CsOptions;
        }

        private void OnButtonCPPEditClick(object sender, EventArgs e) {
            var form = new AStyleEditForm(Language.C);
            form.SetCommandLine(CppOptions);

            if (form.ShowDialog() != DialogResult.OK) {
                return;
            }

            CppOptions = form.GetCommandLine();
            textBoxCPP.Text = CppOptions;
        }

        private void OnButtonCSEditClick(object sender, EventArgs e) {
            var form = new AStyleEditForm(Language.CSharp);
            form.SetCommandLine(CsOptions);

            if (form.ShowDialog() != DialogResult.OK) {
                return;
            }

            CsOptions = form.GetCommandLine();
            textBoxCS.Text = CsOptions;
        }

        private void OnButtonExportClick(object sender, EventArgs e) {
            ClearDetails();
            var folderBrowserDialog = new FolderBrowserDialog();
            var result = folderBrowserDialog.ShowDialog();

            if (result != DialogResult.OK) {
                return;
            }

            var settings = new AStyleSettings {
                CppCommandLine = CppOptions,
                CsCommandLine = CsOptions,
                Version = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString()
            };

            string filePath = String.Format("{0}\\AStyleExtension-{1}-{2}-{3}.cfg", folderBrowserDialog.SelectedPath, DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);

            var serializer = new XmlSerializer(typeof(AStyleSettings));
            try {
                using (var writer = new StreamWriter(filePath)) {
                    serializer.Serialize(writer, settings);
                } 
  
                textBoxDetails.Text = String.Format("Your settings were successfully exported to {0}.", filePath);
            } catch (Exception) {
                textBoxDetails.Text = String.Format("Failed to export settings to {0}.", filePath);
            }
        }

        private void OnButtonImportClick(object sender, EventArgs e) {
            ClearDetails();
            AStyleSettings settings = null;

            var openFileDialog = new OpenFileDialog {
                DefaultExt = ".cfg",
                Filter = "AStyle Extension Settings (*.cfg)|*.cfg"
            };

            var result = openFileDialog.ShowDialog();

            if (result != DialogResult.OK) {
                return;
            }

            using (var fs = new FileStream(openFileDialog.FileName, FileMode.Open, FileAccess.Read, FileShare.Read)) {
                var serializer = new XmlSerializer(typeof(AStyleSettings));
                try {
                    settings = (AStyleSettings) serializer.Deserialize(fs);
                } catch (Exception) {
                    textBoxDetails.Text = String.Format("Failed to import settings from {0}.", openFileDialog.FileName);
                }
            }

            if (settings == null) {
                return;
            }

            CppOptions = settings.CppCommandLine;
            if (IsCSarpEnabled) {
                CsOptions = settings.CsCommandLine;
            }

            textBoxDetails.Text = String.Format("Your settings were successfully imported from {0}.{1}Click OK to save the changes.", openFileDialog.FileName, Environment.NewLine);
        }
    }
}