using System;
using System.Windows.Forms;

namespace AStyleExtension {
    public sealed partial class AStyleEditForm : Form {
        private Language _language;

        public AStyleEditForm(Language language) {
            InitializeComponent();

            _language = language;

            switch (_language) {
                case Language.CSharp:
                    Text = "Edit AStyle C# Command Line";
                    break;
                case Language.C:
                    Text = "Edit AStyle C/C++ Command Line";
                    break;
            }

            ActiveControl = buttonCancel;
        }

        public void SetCommandLine(string command) {
            textBoxCommandLine.Text = command;
        } 

        public string GetCommandLine() {
            return textBoxCommandLine.Text;
        }
    }
}
