namespace AStyleExtension {
    partial class AStyleGeneralOptionsControl {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.groupBoxCPP = new System.Windows.Forms.GroupBox();
            this.labelCPP = new System.Windows.Forms.Label();
            this.textBoxCPP = new System.Windows.Forms.TextBox();
            this.buttonCPPSettings = new System.Windows.Forms.Button();
            this.groupBoxCS = new System.Windows.Forms.GroupBox();
            this.labelCS = new System.Windows.Forms.Label();
            this.textBoxCS = new System.Windows.Forms.TextBox();
            this.buttonCSSettings = new System.Windows.Forms.Button();
            this.groupBoxCPP.SuspendLayout();
            this.groupBoxCS.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxCPP
            // 
            this.groupBoxCPP.Controls.Add(this.labelCPP);
            this.groupBoxCPP.Controls.Add(this.textBoxCPP);
            this.groupBoxCPP.Controls.Add(this.buttonCPPSettings);
            this.groupBoxCPP.Location = new System.Drawing.Point(0, -2);
            this.groupBoxCPP.Name = "groupBoxCPP";
            this.groupBoxCPP.Size = new System.Drawing.Size(394, 144);
            this.groupBoxCPP.TabIndex = 1;
            this.groupBoxCPP.TabStop = false;
            this.groupBoxCPP.Text = "C/C++";
            // 
            // labelCPP
            // 
            this.labelCPP.AutoSize = true;
            this.labelCPP.Location = new System.Drawing.Point(12, 54);
            this.labelCPP.Name = "labelCPP";
            this.labelCPP.Size = new System.Drawing.Size(76, 13);
            this.labelCPP.TabIndex = 2;
            this.labelCPP.Text = "Command line:";
            // 
            // textBoxCPP
            // 
            this.textBoxCPP.Location = new System.Drawing.Point(13, 70);
            this.textBoxCPP.Multiline = true;
            this.textBoxCPP.Name = "textBoxCPP";
            this.textBoxCPP.ReadOnly = true;
            this.textBoxCPP.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.textBoxCPP.Size = new System.Drawing.Size(368, 60);
            this.textBoxCPP.TabIndex = 1;
            // 
            // buttonCPPSettings
            // 
            this.buttonCPPSettings.Location = new System.Drawing.Point(13, 19);
            this.buttonCPPSettings.Name = "buttonCPPSettings";
            this.buttonCPPSettings.Size = new System.Drawing.Size(75, 23);
            this.buttonCPPSettings.TabIndex = 0;
            this.buttonCPPSettings.Text = "Settings";
            this.buttonCPPSettings.UseVisualStyleBackColor = true;
            this.buttonCPPSettings.Click += new System.EventHandler(this.OnButtonCPPSettingsClick);
            // 
            // groupBoxCS
            // 
            this.groupBoxCS.Controls.Add(this.labelCS);
            this.groupBoxCS.Controls.Add(this.textBoxCS);
            this.groupBoxCS.Controls.Add(this.buttonCSSettings);
            this.groupBoxCS.Location = new System.Drawing.Point(0, 144);
            this.groupBoxCS.Name = "groupBoxCS";
            this.groupBoxCS.Size = new System.Drawing.Size(394, 144);
            this.groupBoxCS.TabIndex = 2;
            this.groupBoxCS.TabStop = false;
            this.groupBoxCS.Text = "C#";
            // 
            // labelCS
            // 
            this.labelCS.AutoSize = true;
            this.labelCS.Location = new System.Drawing.Point(12, 54);
            this.labelCS.Name = "labelCS";
            this.labelCS.Size = new System.Drawing.Size(76, 13);
            this.labelCS.TabIndex = 3;
            this.labelCS.Text = "Command line:";
            // 
            // textBoxCS
            // 
            this.textBoxCS.Location = new System.Drawing.Point(13, 70);
            this.textBoxCS.Multiline = true;
            this.textBoxCS.Name = "textBoxCS";
            this.textBoxCS.ReadOnly = true;
            this.textBoxCS.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.textBoxCS.Size = new System.Drawing.Size(368, 60);
            this.textBoxCS.TabIndex = 2;
            // 
            // buttonCSSettings
            // 
            this.buttonCSSettings.Location = new System.Drawing.Point(13, 19);
            this.buttonCSSettings.Name = "buttonCSSettings";
            this.buttonCSSettings.Size = new System.Drawing.Size(75, 23);
            this.buttonCSSettings.TabIndex = 1;
            this.buttonCSSettings.Text = "Settings";
            this.buttonCSSettings.UseVisualStyleBackColor = true;
            this.buttonCSSettings.Click += new System.EventHandler(this.OnButtonCSSettingsClick);
            // 
            // AStyleGeneralOptionsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBoxCS);
            this.Controls.Add(this.groupBoxCPP);
            this.Name = "AStyleGeneralOptionsControl";
            this.Size = new System.Drawing.Size(433, 344);
            this.groupBoxCPP.ResumeLayout(false);
            this.groupBoxCPP.PerformLayout();
            this.groupBoxCS.ResumeLayout(false);
            this.groupBoxCS.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxCPP;
        private System.Windows.Forms.GroupBox groupBoxCS;
        private System.Windows.Forms.Button buttonCPPSettings;
        private System.Windows.Forms.Button buttonCSSettings;
        private System.Windows.Forms.Label labelCPP;
        private System.Windows.Forms.TextBox textBoxCPP;
        private System.Windows.Forms.Label labelCS;
        private System.Windows.Forms.TextBox textBoxCS;

    }
}
