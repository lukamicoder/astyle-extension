using System.Windows.Forms;

namespace AStyleExtension {
    public sealed partial class AStyleEditForm : Form {
        public AStyleEditForm(Language language) {
            InitializeComponent();

            switch (language) {
                case Language.CSharp:
                    Text = "Edit AStyle C# Command Line";
                    break;
                case Language.Cpp:
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
