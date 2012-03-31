using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Microsoft.VisualStudio.Shell;

namespace AStyleExtension {
    [CLSCompliant(false), ComVisible(true)]
    public class AStyleGeneralOptionsPage : DialogPage {
        private AStyleGeneralOptionsControl _control;
        private bool _isCSarpEnabled = true;

        public string CppOptions { get; set; }
        public string CsOptions { get; set; }
        public bool IsCSarpEnabled {
            get { return _isCSarpEnabled; }
            set { _isCSarpEnabled = value; }
        }

        [Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        protected override IWin32Window Window {
            get {
                _control = new AStyleGeneralOptionsControl();

                if (CppOptions != null) {
                    _control.CppOptions = CppOptions;
                }

                if (CsOptions != null) {
                    _control.CsOptions = CsOptions;
                }

                _control.IsCSarpEnabled = IsCSarpEnabled; 

                return _control;
            }
        }

        protected override void OnActivate(CancelEventArgs e) {
            if (_control != null) {
                if (CppOptions != null) {
                    _control.CppOptions = CppOptions;
                }

                if (CsOptions != null) {
                    _control.CsOptions = CsOptions;
                }
            }

            base.OnActivate(e);
        }

        protected override void OnApply(PageApplyEventArgs e) {
            if (_control != null) {
                CppOptions = _control.CppOptions;
                CsOptions = _control.CsOptions;
            }

            base.OnApply(e);
        }
    }
}
