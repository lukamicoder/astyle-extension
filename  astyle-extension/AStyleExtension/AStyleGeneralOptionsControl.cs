using System.Windows.Forms;

namespace AStyleExtension {
	public partial class AStyleGeneralOptionsControl : UserControl {
		private string _cppOptions;
		private string _csOptions;

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
			set {
				if (!value) {
					groupBoxCS.Visible = false;
				} 
			} 
		}

		public AStyleGeneralOptionsControl() {
			InitializeComponent();
		}

		private void OnButtonCPPSettingsClick(object sender, System.EventArgs e) {
			AStyleGeneralOptionsForm form = new AStyleGeneralOptionsForm(Language.C);
			form.SetControls(CppOptions);

			if (form.ShowDialog() == DialogResult.OK) {
				CppOptions = form.GetCommandLine();
				textBoxCPP.Text = CppOptions;
			}
		}

		private void OnButtonCSSettingsClick(object sender, System.EventArgs e) {
			AStyleGeneralOptionsForm form = new AStyleGeneralOptionsForm(Language.CSharp);
			form.SetControls(CsOptions);

			if (form.ShowDialog() == DialogResult.OK) {
				CsOptions = form.GetCommandLine();
				textBoxCS.Text = CsOptions;
			}
		}
	}
}