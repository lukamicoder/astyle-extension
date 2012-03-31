namespace AStyleExtension {
    sealed partial class AStyleGeneralOptionsForm {
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.groupBoxStyle = new System.Windows.Forms.GroupBox();
            this.comboBoxStyle = new System.Windows.Forms.ComboBox();
            this.groupBoxTab = new System.Windows.Forms.GroupBox();
            this.checkBoxIndent = new System.Windows.Forms.CheckBox();
            this.comboBoxIndent = new System.Windows.Forms.ComboBox();
            this.numericUpDownIndent = new System.Windows.Forms.NumericUpDown();
            this.groupBoxIndent = new System.Windows.Forms.GroupBox();
            this.numericUpDownMaxInstateIndent = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownMinCondIndent = new System.Windows.Forms.NumericUpDown();
            this.checkBoxMaxInstateIndent = new System.Windows.Forms.CheckBox();
            this.checkBoxMinCondIndent = new System.Windows.Forms.CheckBox();
            this.checkBoxIndentCol1Com = new System.Windows.Forms.CheckBox();
            this.checkBoxIndentPreproc = new System.Windows.Forms.CheckBox();
            this.checkBoxIndentLabels = new System.Windows.Forms.CheckBox();
            this.checkBoxIndentNamesp = new System.Windows.Forms.CheckBox();
            this.checkBoxIndentCases = new System.Windows.Forms.CheckBox();
            this.checkBoxIndentSwitches = new System.Windows.Forms.CheckBox();
            this.checkBoxIndentClasses = new System.Windows.Forms.CheckBox();
            this.groupBoxPadding = new System.Windows.Forms.GroupBox();
            this.checkBoxFillEmptyLines = new System.Windows.Forms.CheckBox();
            this.checkBoxDelEmptyLines = new System.Windows.Forms.CheckBox();
            this.checkBoxUnpadParen = new System.Windows.Forms.CheckBox();
            this.checkBoxPadHeader = new System.Windows.Forms.CheckBox();
            this.checkBoxPadParen = new System.Windows.Forms.CheckBox();
            this.checkBoxPadParenIn = new System.Windows.Forms.CheckBox();
            this.checkBoxPadParenOut = new System.Windows.Forms.CheckBox();
            this.checkBoxPadOper = new System.Windows.Forms.CheckBox();
            this.checkBoxBreakBlocksAll = new System.Windows.Forms.CheckBox();
            this.checkBoxBreakBlocks = new System.Windows.Forms.CheckBox();
            this.groupBoxFormat = new System.Windows.Forms.GroupBox();
            this.checkBoxAlignReference = new System.Windows.Forms.CheckBox();
            this.checkBoxAlignPointer = new System.Windows.Forms.CheckBox();
            this.comboBoxAlignPointer = new System.Windows.Forms.ComboBox();
            this.comboBoxAlignReference = new System.Windows.Forms.ComboBox();
            this.checkBoxConvertTabs = new System.Windows.Forms.CheckBox();
            this.checkBoxKeepOneLineStat = new System.Windows.Forms.CheckBox();
            this.checkBoxKeepOneLineBlocks = new System.Windows.Forms.CheckBox();
            this.checkBoxAddOneLineBrackets = new System.Windows.Forms.CheckBox();
            this.checkBoxAddBrackets = new System.Windows.Forms.CheckBox();
            this.checkBoxBreakElseIfs = new System.Windows.Forms.CheckBox();
            this.checkBoxBreakClosingBrackets = new System.Windows.Forms.CheckBox();
            this.linkLabelHelp = new System.Windows.Forms.LinkLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.checkBoxMode = new System.Windows.Forms.CheckBox();
            this.comboBoxMode = new System.Windows.Forms.ComboBox();
            this.groupBoxStyle.SuspendLayout();
            this.groupBoxTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownIndent)).BeginInit();
            this.groupBoxIndent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxInstateIndent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMinCondIndent)).BeginInit();
            this.groupBoxPadding.SuspendLayout();
            this.groupBoxFormat.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonOK
            // 
            this.buttonOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonOK.Location = new System.Drawing.Point(315, 592);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 5;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(233, 592);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 6;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // groupBoxStyle
            // 
            this.groupBoxStyle.Controls.Add(this.comboBoxStyle);
            this.groupBoxStyle.Location = new System.Drawing.Point(12, 9);
            this.groupBoxStyle.Name = "groupBoxStyle";
            this.groupBoxStyle.Size = new System.Drawing.Size(377, 54);
            this.groupBoxStyle.TabIndex = 7;
            this.groupBoxStyle.TabStop = false;
            this.groupBoxStyle.Text = "Bracket Style Options";
            // 
            // comboBoxStyle
            // 
            this.comboBoxStyle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxStyle.FormattingEnabled = true;
            this.comboBoxStyle.Items.AddRange(new object[] {
            "None",
            "Allman",
            "Java",
            "K&R",
            "Stroustrup",
            "Whitesmith",
            "Banner",
            "GNU",
            "Linux",
            "Horstmann",
            "1TBS",
            "Pico",
            "Lisp"});
            this.comboBoxStyle.Location = new System.Drawing.Point(9, 19);
            this.comboBoxStyle.Name = "comboBoxStyle";
            this.comboBoxStyle.Size = new System.Drawing.Size(105, 21);
            this.comboBoxStyle.TabIndex = 0;
            // 
            // groupBoxTab
            // 
            this.groupBoxTab.Controls.Add(this.checkBoxIndent);
            this.groupBoxTab.Controls.Add(this.comboBoxIndent);
            this.groupBoxTab.Controls.Add(this.numericUpDownIndent);
            this.groupBoxTab.Location = new System.Drawing.Point(12, 70);
            this.groupBoxTab.Name = "groupBoxTab";
            this.groupBoxTab.Size = new System.Drawing.Size(377, 48);
            this.groupBoxTab.TabIndex = 8;
            this.groupBoxTab.TabStop = false;
            this.groupBoxTab.Text = "Tab Options";
            // 
            // checkBoxIndent
            // 
            this.checkBoxIndent.AutoSize = true;
            this.checkBoxIndent.Location = new System.Drawing.Point(9, 20);
            this.checkBoxIndent.Name = "checkBoxIndent";
            this.checkBoxIndent.Size = new System.Drawing.Size(67, 17);
            this.checkBoxIndent.TabIndex = 15;
            this.checkBoxIndent.Text = "--indent=";
            this.checkBoxIndent.UseVisualStyleBackColor = true;
            this.checkBoxIndent.CheckedChanged += new System.EventHandler(this.OnCheckBoxIndentCheckedChanged);
            // 
            // comboBoxIndent
            // 
            this.comboBoxIndent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxIndent.Enabled = false;
            this.comboBoxIndent.FormattingEnabled = true;
            this.comboBoxIndent.Items.AddRange(new object[] {
            "spaces",
            "tab",
            "force-tab"});
            this.comboBoxIndent.Location = new System.Drawing.Point(76, 16);
            this.comboBoxIndent.Name = "comboBoxIndent";
            this.comboBoxIndent.Size = new System.Drawing.Size(73, 21);
            this.comboBoxIndent.TabIndex = 14;
            // 
            // numericUpDownIndent
            // 
            this.numericUpDownIndent.Enabled = false;
            this.numericUpDownIndent.Location = new System.Drawing.Point(157, 16);
            this.numericUpDownIndent.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numericUpDownIndent.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDownIndent.Name = "numericUpDownIndent";
            this.numericUpDownIndent.Size = new System.Drawing.Size(44, 20);
            this.numericUpDownIndent.TabIndex = 12;
            this.numericUpDownIndent.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // groupBoxIndent
            // 
            this.groupBoxIndent.Controls.Add(this.numericUpDownMaxInstateIndent);
            this.groupBoxIndent.Controls.Add(this.numericUpDownMinCondIndent);
            this.groupBoxIndent.Controls.Add(this.checkBoxMaxInstateIndent);
            this.groupBoxIndent.Controls.Add(this.checkBoxMinCondIndent);
            this.groupBoxIndent.Controls.Add(this.checkBoxIndentCol1Com);
            this.groupBoxIndent.Controls.Add(this.checkBoxIndentPreproc);
            this.groupBoxIndent.Controls.Add(this.checkBoxIndentLabels);
            this.groupBoxIndent.Controls.Add(this.checkBoxIndentNamesp);
            this.groupBoxIndent.Controls.Add(this.checkBoxIndentCases);
            this.groupBoxIndent.Controls.Add(this.checkBoxIndentSwitches);
            this.groupBoxIndent.Controls.Add(this.checkBoxIndentClasses);
            this.groupBoxIndent.Location = new System.Drawing.Point(12, 124);
            this.groupBoxIndent.Name = "groupBoxIndent";
            this.groupBoxIndent.Size = new System.Drawing.Size(377, 166);
            this.groupBoxIndent.TabIndex = 9;
            this.groupBoxIndent.TabStop = false;
            this.groupBoxIndent.Text = "Indentation Options";
            // 
            // numericUpDownMaxInstateIndent
            // 
            this.numericUpDownMaxInstateIndent.Enabled = false;
            this.numericUpDownMaxInstateIndent.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownMaxInstateIndent.Location = new System.Drawing.Point(157, 136);
            this.numericUpDownMaxInstateIndent.Maximum = new decimal(new int[] {
            120,
            0,
            0,
            0});
            this.numericUpDownMaxInstateIndent.Minimum = new decimal(new int[] {
            40,
            0,
            0,
            0});
            this.numericUpDownMaxInstateIndent.Name = "numericUpDownMaxInstateIndent";
            this.numericUpDownMaxInstateIndent.Size = new System.Drawing.Size(44, 20);
            this.numericUpDownMaxInstateIndent.TabIndex = 18;
            this.numericUpDownMaxInstateIndent.Value = new decimal(new int[] {
            40,
            0,
            0,
            0});
            // 
            // numericUpDownMinCondIndent
            // 
            this.numericUpDownMinCondIndent.Enabled = false;
            this.numericUpDownMinCondIndent.Location = new System.Drawing.Point(157, 113);
            this.numericUpDownMinCondIndent.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numericUpDownMinCondIndent.Name = "numericUpDownMinCondIndent";
            this.numericUpDownMinCondIndent.Size = new System.Drawing.Size(44, 20);
            this.numericUpDownMinCondIndent.TabIndex = 17;
            this.numericUpDownMinCondIndent.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // checkBoxMaxInstateIndent
            // 
            this.checkBoxMaxInstateIndent.AutoSize = true;
            this.checkBoxMaxInstateIndent.Location = new System.Drawing.Point(9, 137);
            this.checkBoxMaxInstateIndent.Name = "checkBoxMaxInstateIndent";
            this.checkBoxMaxInstateIndent.Size = new System.Drawing.Size(146, 17);
            this.checkBoxMaxInstateIndent.TabIndex = 16;
            this.checkBoxMaxInstateIndent.Text = "--max-instatement-indent=";
            this.checkBoxMaxInstateIndent.UseVisualStyleBackColor = true;
            this.checkBoxMaxInstateIndent.CheckedChanged += new System.EventHandler(this.OnCheckBoxMaxInstateIndentCheckedChanged);
            // 
            // checkBoxMinCondIndent
            // 
            this.checkBoxMinCondIndent.AutoSize = true;
            this.checkBoxMinCondIndent.Location = new System.Drawing.Point(9, 114);
            this.checkBoxMinCondIndent.Name = "checkBoxMinCondIndent";
            this.checkBoxMinCondIndent.Size = new System.Drawing.Size(140, 17);
            this.checkBoxMinCondIndent.TabIndex = 15;
            this.checkBoxMinCondIndent.Text = "--min-conditional-indent=";
            this.checkBoxMinCondIndent.UseVisualStyleBackColor = true;
            this.checkBoxMinCondIndent.CheckedChanged += new System.EventHandler(this.OnCheckBoxMinCondIndentCheckedChanged);
            // 
            // checkBoxIndentCol1Com
            // 
            this.checkBoxIndentCol1Com.AutoSize = true;
            this.checkBoxIndentCol1Com.Location = new System.Drawing.Point(221, 67);
            this.checkBoxIndentCol1Com.Name = "checkBoxIndentCol1Com";
            this.checkBoxIndentCol1Com.Size = new System.Drawing.Size(135, 17);
            this.checkBoxIndentCol1Com.TabIndex = 10;
            this.checkBoxIndentCol1Com.Text = "--indent-col1-comments";
            this.checkBoxIndentCol1Com.UseVisualStyleBackColor = true;
            // 
            // checkBoxIndentPreproc
            // 
            this.checkBoxIndentPreproc.AutoSize = true;
            this.checkBoxIndentPreproc.Location = new System.Drawing.Point(221, 44);
            this.checkBoxIndentPreproc.Name = "checkBoxIndentPreproc";
            this.checkBoxIndentPreproc.Size = new System.Drawing.Size(125, 17);
            this.checkBoxIndentPreproc.TabIndex = 9;
            this.checkBoxIndentPreproc.Text = "--indent-preprocessor";
            this.checkBoxIndentPreproc.UseVisualStyleBackColor = true;
            // 
            // checkBoxIndentLabels
            // 
            this.checkBoxIndentLabels.AutoSize = true;
            this.checkBoxIndentLabels.Location = new System.Drawing.Point(221, 23);
            this.checkBoxIndentLabels.Name = "checkBoxIndentLabels";
            this.checkBoxIndentLabels.Size = new System.Drawing.Size(91, 17);
            this.checkBoxIndentLabels.TabIndex = 8;
            this.checkBoxIndentLabels.Text = "--indent-labels";
            this.checkBoxIndentLabels.UseVisualStyleBackColor = true;
            // 
            // checkBoxIndentNamesp
            // 
            this.checkBoxIndentNamesp.AutoSize = true;
            this.checkBoxIndentNamesp.Location = new System.Drawing.Point(9, 91);
            this.checkBoxIndentNamesp.Name = "checkBoxIndentNamesp";
            this.checkBoxIndentNamesp.Size = new System.Drawing.Size(124, 17);
            this.checkBoxIndentNamesp.TabIndex = 7;
            this.checkBoxIndentNamesp.Text = "--indent-namespaces";
            this.checkBoxIndentNamesp.UseVisualStyleBackColor = true;
            // 
            // checkBoxIndentCases
            // 
            this.checkBoxIndentCases.AutoSize = true;
            this.checkBoxIndentCases.Location = new System.Drawing.Point(9, 67);
            this.checkBoxIndentCases.Name = "checkBoxIndentCases";
            this.checkBoxIndentCases.Size = new System.Drawing.Size(92, 17);
            this.checkBoxIndentCases.TabIndex = 6;
            this.checkBoxIndentCases.Text = "--indent-cases";
            this.checkBoxIndentCases.UseVisualStyleBackColor = true;
            // 
            // checkBoxIndentSwitches
            // 
            this.checkBoxIndentSwitches.AutoSize = true;
            this.checkBoxIndentSwitches.Location = new System.Drawing.Point(9, 43);
            this.checkBoxIndentSwitches.Name = "checkBoxIndentSwitches";
            this.checkBoxIndentSwitches.Size = new System.Drawing.Size(105, 17);
            this.checkBoxIndentSwitches.TabIndex = 5;
            this.checkBoxIndentSwitches.Text = "--indent-switches";
            this.checkBoxIndentSwitches.UseVisualStyleBackColor = true;
            // 
            // checkBoxIndentClasses
            // 
            this.checkBoxIndentClasses.AutoSize = true;
            this.checkBoxIndentClasses.Location = new System.Drawing.Point(9, 19);
            this.checkBoxIndentClasses.Name = "checkBoxIndentClasses";
            this.checkBoxIndentClasses.Size = new System.Drawing.Size(99, 17);
            this.checkBoxIndentClasses.TabIndex = 4;
            this.checkBoxIndentClasses.Text = "--indent-classes";
            this.checkBoxIndentClasses.UseVisualStyleBackColor = true;
            // 
            // groupBoxPadding
            // 
            this.groupBoxPadding.Controls.Add(this.checkBoxFillEmptyLines);
            this.groupBoxPadding.Controls.Add(this.checkBoxDelEmptyLines);
            this.groupBoxPadding.Controls.Add(this.checkBoxUnpadParen);
            this.groupBoxPadding.Controls.Add(this.checkBoxPadHeader);
            this.groupBoxPadding.Controls.Add(this.checkBoxPadParen);
            this.groupBoxPadding.Controls.Add(this.checkBoxPadParenIn);
            this.groupBoxPadding.Controls.Add(this.checkBoxPadParenOut);
            this.groupBoxPadding.Controls.Add(this.checkBoxPadOper);
            this.groupBoxPadding.Controls.Add(this.checkBoxBreakBlocksAll);
            this.groupBoxPadding.Controls.Add(this.checkBoxBreakBlocks);
            this.groupBoxPadding.Location = new System.Drawing.Point(12, 296);
            this.groupBoxPadding.Name = "groupBoxPadding";
            this.groupBoxPadding.Size = new System.Drawing.Size(377, 137);
            this.groupBoxPadding.TabIndex = 10;
            this.groupBoxPadding.TabStop = false;
            this.groupBoxPadding.Text = "Padding Options";
            // 
            // checkBoxFillEmptyLines
            // 
            this.checkBoxFillEmptyLines.AutoSize = true;
            this.checkBoxFillEmptyLines.Location = new System.Drawing.Point(221, 114);
            this.checkBoxFillEmptyLines.Name = "checkBoxFillEmptyLines";
            this.checkBoxFillEmptyLines.Size = new System.Drawing.Size(96, 17);
            this.checkBoxFillEmptyLines.TabIndex = 19;
            this.checkBoxFillEmptyLines.Text = "--fill-empty-lines";
            this.checkBoxFillEmptyLines.UseVisualStyleBackColor = true;
            // 
            // checkBoxDelEmptyLines
            // 
            this.checkBoxDelEmptyLines.AutoSize = true;
            this.checkBoxDelEmptyLines.Location = new System.Drawing.Point(221, 90);
            this.checkBoxDelEmptyLines.Name = "checkBoxDelEmptyLines";
            this.checkBoxDelEmptyLines.Size = new System.Drawing.Size(116, 17);
            this.checkBoxDelEmptyLines.TabIndex = 18;
            this.checkBoxDelEmptyLines.Text = "--delete-empty-lines";
            this.checkBoxDelEmptyLines.UseVisualStyleBackColor = true;
            // 
            // checkBoxUnpadParen
            // 
            this.checkBoxUnpadParen.AutoSize = true;
            this.checkBoxUnpadParen.Location = new System.Drawing.Point(221, 66);
            this.checkBoxUnpadParen.Name = "checkBoxUnpadParen";
            this.checkBoxUnpadParen.Size = new System.Drawing.Size(92, 17);
            this.checkBoxUnpadParen.TabIndex = 17;
            this.checkBoxUnpadParen.Text = "--unpad-paren";
            this.checkBoxUnpadParen.UseVisualStyleBackColor = true;
            // 
            // checkBoxPadHeader
            // 
            this.checkBoxPadHeader.AutoSize = true;
            this.checkBoxPadHeader.Location = new System.Drawing.Point(221, 42);
            this.checkBoxPadHeader.Name = "checkBoxPadHeader";
            this.checkBoxPadHeader.Size = new System.Drawing.Size(86, 17);
            this.checkBoxPadHeader.TabIndex = 16;
            this.checkBoxPadHeader.Text = "--pad-header";
            this.checkBoxPadHeader.UseVisualStyleBackColor = true;
            // 
            // checkBoxPadParen
            // 
            this.checkBoxPadParen.AutoSize = true;
            this.checkBoxPadParen.Location = new System.Drawing.Point(9, 66);
            this.checkBoxPadParen.Name = "checkBoxPadParen";
            this.checkBoxPadParen.Size = new System.Drawing.Size(80, 17);
            this.checkBoxPadParen.TabIndex = 15;
            this.checkBoxPadParen.Text = "--pad-paren";
            this.checkBoxPadParen.UseVisualStyleBackColor = true;
            // 
            // checkBoxPadParenIn
            // 
            this.checkBoxPadParenIn.AutoSize = true;
            this.checkBoxPadParenIn.Location = new System.Drawing.Point(9, 113);
            this.checkBoxPadParenIn.Name = "checkBoxPadParenIn";
            this.checkBoxPadParenIn.Size = new System.Drawing.Size(91, 17);
            this.checkBoxPadParenIn.TabIndex = 14;
            this.checkBoxPadParenIn.Text = "--pad-paren-in";
            this.checkBoxPadParenIn.UseVisualStyleBackColor = true;
            // 
            // checkBoxPadParenOut
            // 
            this.checkBoxPadParenOut.AutoSize = true;
            this.checkBoxPadParenOut.Location = new System.Drawing.Point(9, 89);
            this.checkBoxPadParenOut.Name = "checkBoxPadParenOut";
            this.checkBoxPadParenOut.Size = new System.Drawing.Size(98, 17);
            this.checkBoxPadParenOut.TabIndex = 13;
            this.checkBoxPadParenOut.Text = "--pad-paren-out";
            this.checkBoxPadParenOut.UseVisualStyleBackColor = true;
            // 
            // checkBoxPadOper
            // 
            this.checkBoxPadOper.AutoSize = true;
            this.checkBoxPadOper.Location = new System.Drawing.Point(221, 18);
            this.checkBoxPadOper.Name = "checkBoxPadOper";
            this.checkBoxPadOper.Size = new System.Drawing.Size(74, 17);
            this.checkBoxPadOper.TabIndex = 12;
            this.checkBoxPadOper.Text = "--pad-oper";
            this.checkBoxPadOper.UseVisualStyleBackColor = true;
            // 
            // checkBoxBreakBlocksAll
            // 
            this.checkBoxBreakBlocksAll.AutoSize = true;
            this.checkBoxBreakBlocksAll.Location = new System.Drawing.Point(9, 42);
            this.checkBoxBreakBlocksAll.Name = "checkBoxBreakBlocksAll";
            this.checkBoxBreakBlocksAll.Size = new System.Drawing.Size(109, 17);
            this.checkBoxBreakBlocksAll.TabIndex = 11;
            this.checkBoxBreakBlocksAll.Text = "--break-blocks=all";
            this.checkBoxBreakBlocksAll.UseVisualStyleBackColor = true;
            // 
            // checkBoxBreakBlocks
            // 
            this.checkBoxBreakBlocks.AutoSize = true;
            this.checkBoxBreakBlocks.Location = new System.Drawing.Point(9, 18);
            this.checkBoxBreakBlocks.Name = "checkBoxBreakBlocks";
            this.checkBoxBreakBlocks.Size = new System.Drawing.Size(93, 17);
            this.checkBoxBreakBlocks.TabIndex = 10;
            this.checkBoxBreakBlocks.Text = "--break-blocks";
            this.checkBoxBreakBlocks.UseVisualStyleBackColor = true;
            // 
            // groupBoxFormat
            // 
            this.groupBoxFormat.Controls.Add(this.checkBoxMode);
            this.groupBoxFormat.Controls.Add(this.comboBoxMode);
            this.groupBoxFormat.Controls.Add(this.checkBoxAlignReference);
            this.groupBoxFormat.Controls.Add(this.checkBoxAlignPointer);
            this.groupBoxFormat.Controls.Add(this.comboBoxAlignPointer);
            this.groupBoxFormat.Controls.Add(this.comboBoxAlignReference);
            this.groupBoxFormat.Controls.Add(this.checkBoxConvertTabs);
            this.groupBoxFormat.Controls.Add(this.checkBoxKeepOneLineStat);
            this.groupBoxFormat.Controls.Add(this.checkBoxKeepOneLineBlocks);
            this.groupBoxFormat.Controls.Add(this.checkBoxAddOneLineBrackets);
            this.groupBoxFormat.Controls.Add(this.checkBoxAddBrackets);
            this.groupBoxFormat.Controls.Add(this.checkBoxBreakElseIfs);
            this.groupBoxFormat.Controls.Add(this.checkBoxBreakClosingBrackets);
            this.groupBoxFormat.Location = new System.Drawing.Point(12, 439);
            this.groupBoxFormat.Name = "groupBoxFormat";
            this.groupBoxFormat.Size = new System.Drawing.Size(377, 142);
            this.groupBoxFormat.TabIndex = 11;
            this.groupBoxFormat.TabStop = false;
            this.groupBoxFormat.Text = "Formatting Options";
            // 
            // checkBoxAlignReference
            // 
            this.checkBoxAlignReference.AutoSize = true;
            this.checkBoxAlignReference.Location = new System.Drawing.Point(8, 89);
            this.checkBoxAlignReference.Name = "checkBoxAlignReference";
            this.checkBoxAlignReference.Size = new System.Drawing.Size(108, 17);
            this.checkBoxAlignReference.TabIndex = 16;
            this.checkBoxAlignReference.Text = "--align-reference=";
            this.checkBoxAlignReference.UseVisualStyleBackColor = true;
            this.checkBoxAlignReference.CheckedChanged += new System.EventHandler(this.OnCheckBoxAlignReferenceCheckedChanged);
            // 
            // checkBoxAlignPointer
            // 
            this.checkBoxAlignPointer.AutoSize = true;
            this.checkBoxAlignPointer.Location = new System.Drawing.Point(8, 66);
            this.checkBoxAlignPointer.Name = "checkBoxAlignPointer";
            this.checkBoxAlignPointer.Size = new System.Drawing.Size(95, 17);
            this.checkBoxAlignPointer.TabIndex = 15;
            this.checkBoxAlignPointer.Text = "--align-pointer=";
            this.checkBoxAlignPointer.UseVisualStyleBackColor = true;
            this.checkBoxAlignPointer.CheckedChanged += new System.EventHandler(this.OnCheckBoxAlignPointerCheckedChanged);
            // 
            // comboBoxAlignPointer
            // 
            this.comboBoxAlignPointer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAlignPointer.Enabled = false;
            this.comboBoxAlignPointer.FormattingEnabled = true;
            this.comboBoxAlignPointer.Items.AddRange(new object[] {
            "type",
            "middle",
            "name"});
            this.comboBoxAlignPointer.Location = new System.Drawing.Point(119, 64);
            this.comboBoxAlignPointer.Name = "comboBoxAlignPointer";
            this.comboBoxAlignPointer.Size = new System.Drawing.Size(82, 21);
            this.comboBoxAlignPointer.TabIndex = 14;
            // 
            // comboBoxAlignReference
            // 
            this.comboBoxAlignReference.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAlignReference.Enabled = false;
            this.comboBoxAlignReference.FormattingEnabled = true;
            this.comboBoxAlignReference.Items.AddRange(new object[] {
            "none",
            "type",
            "middle",
            "name"});
            this.comboBoxAlignReference.Location = new System.Drawing.Point(119, 87);
            this.comboBoxAlignReference.Name = "comboBoxAlignReference";
            this.comboBoxAlignReference.Size = new System.Drawing.Size(82, 21);
            this.comboBoxAlignReference.TabIndex = 13;
            // 
            // checkBoxConvertTabs
            // 
            this.checkBoxConvertTabs.AutoSize = true;
            this.checkBoxConvertTabs.Location = new System.Drawing.Point(216, 116);
            this.checkBoxConvertTabs.Name = "checkBoxConvertTabs";
            this.checkBoxConvertTabs.Size = new System.Drawing.Size(91, 17);
            this.checkBoxConvertTabs.TabIndex = 10;
            this.checkBoxConvertTabs.Text = "--convert-tabs";
            this.checkBoxConvertTabs.UseVisualStyleBackColor = true;
            // 
            // checkBoxKeepOneLineStat
            // 
            this.checkBoxKeepOneLineStat.AutoSize = true;
            this.checkBoxKeepOneLineStat.Location = new System.Drawing.Point(216, 91);
            this.checkBoxKeepOneLineStat.Name = "checkBoxKeepOneLineStat";
            this.checkBoxKeepOneLineStat.Size = new System.Drawing.Size(150, 17);
            this.checkBoxKeepOneLineStat.TabIndex = 9;
            this.checkBoxKeepOneLineStat.Text = "--keep-one-line-statements";
            this.checkBoxKeepOneLineStat.UseVisualStyleBackColor = true;
            // 
            // checkBoxKeepOneLineBlocks
            // 
            this.checkBoxKeepOneLineBlocks.AutoSize = true;
            this.checkBoxKeepOneLineBlocks.Location = new System.Drawing.Point(216, 66);
            this.checkBoxKeepOneLineBlocks.Name = "checkBoxKeepOneLineBlocks";
            this.checkBoxKeepOneLineBlocks.Size = new System.Drawing.Size(130, 17);
            this.checkBoxKeepOneLineBlocks.TabIndex = 8;
            this.checkBoxKeepOneLineBlocks.Text = "--keep-one-line-blocks";
            this.checkBoxKeepOneLineBlocks.UseVisualStyleBackColor = true;
            // 
            // checkBoxAddOneLineBrackets
            // 
            this.checkBoxAddOneLineBrackets.AutoSize = true;
            this.checkBoxAddOneLineBrackets.Location = new System.Drawing.Point(8, 43);
            this.checkBoxAddOneLineBrackets.Name = "checkBoxAddOneLineBrackets";
            this.checkBoxAddOneLineBrackets.Size = new System.Drawing.Size(134, 17);
            this.checkBoxAddOneLineBrackets.TabIndex = 7;
            this.checkBoxAddOneLineBrackets.Text = "--add-one-line-brackets";
            this.checkBoxAddOneLineBrackets.UseVisualStyleBackColor = true;
            // 
            // checkBoxAddBrackets
            // 
            this.checkBoxAddBrackets.AutoSize = true;
            this.checkBoxAddBrackets.Location = new System.Drawing.Point(8, 19);
            this.checkBoxAddBrackets.Name = "checkBoxAddBrackets";
            this.checkBoxAddBrackets.Size = new System.Drawing.Size(94, 17);
            this.checkBoxAddBrackets.TabIndex = 6;
            this.checkBoxAddBrackets.Text = "--add-brackets";
            this.checkBoxAddBrackets.UseVisualStyleBackColor = true;
            // 
            // checkBoxBreakElseIfs
            // 
            this.checkBoxBreakElseIfs.AutoSize = true;
            this.checkBoxBreakElseIfs.Location = new System.Drawing.Point(216, 43);
            this.checkBoxBreakElseIfs.Name = "checkBoxBreakElseIfs";
            this.checkBoxBreakElseIfs.Size = new System.Drawing.Size(91, 17);
            this.checkBoxBreakElseIfs.TabIndex = 5;
            this.checkBoxBreakElseIfs.Text = "--break-elseifs";
            this.checkBoxBreakElseIfs.UseVisualStyleBackColor = true;
            // 
            // checkBoxBreakClosingBrackets
            // 
            this.checkBoxBreakClosingBrackets.AutoSize = true;
            this.checkBoxBreakClosingBrackets.Location = new System.Drawing.Point(217, 19);
            this.checkBoxBreakClosingBrackets.Name = "checkBoxBreakClosingBrackets";
            this.checkBoxBreakClosingBrackets.Size = new System.Drawing.Size(139, 17);
            this.checkBoxBreakClosingBrackets.TabIndex = 4;
            this.checkBoxBreakClosingBrackets.Text = "--break-closing-brackets";
            this.checkBoxBreakClosingBrackets.UseVisualStyleBackColor = true;
            // 
            // linkLabelHelp
            // 
            this.linkLabelHelp.AutoSize = true;
            this.linkLabelHelp.Location = new System.Drawing.Point(12, 597);
            this.linkLabelHelp.Name = "linkLabelHelp";
            this.linkLabelHelp.Size = new System.Drawing.Size(60, 13);
            this.linkLabelHelp.TabIndex = 12;
            this.linkLabelHelp.TabStop = true;
            this.linkLabelHelp.Text = "Online help";
            this.linkLabelHelp.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.OnLinkLabelHelpClicked);
            // 
            // checkBoxMode
            // 
            this.checkBoxMode.AutoSize = true;
            this.checkBoxMode.Checked = true;
            this.checkBoxMode.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxMode.Enabled = false;
            this.checkBoxMode.Location = new System.Drawing.Point(8, 112);
            this.checkBoxMode.Name = "checkBoxMode";
            this.checkBoxMode.Size = new System.Drawing.Size(64, 17);
            this.checkBoxMode.TabIndex = 18;
            this.checkBoxMode.Text = "--mode=";
            this.checkBoxMode.UseVisualStyleBackColor = true;
            // 
            // comboBoxMode
            // 
            this.comboBoxMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMode.Enabled = false;
            this.comboBoxMode.FormattingEnabled = true;
            this.comboBoxMode.Items.AddRange(new object[] {
            "c",
            "cs",
            "java"});
            this.comboBoxMode.Location = new System.Drawing.Point(119, 110);
            this.comboBoxMode.Name = "comboBoxMode";
            this.comboBoxMode.Size = new System.Drawing.Size(56, 21);
            this.comboBoxMode.TabIndex = 17;
            // 
            // AStyleGeneralOptionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 630);
            this.Controls.Add(this.linkLabelHelp);
            this.Controls.Add(this.groupBoxFormat);
            this.Controls.Add(this.groupBoxPadding);
            this.Controls.Add(this.groupBoxIndent);
            this.Controls.Add(this.groupBoxTab);
            this.Controls.Add(this.groupBoxStyle);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AStyleGeneralOptionsForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.groupBoxStyle.ResumeLayout(false);
            this.groupBoxTab.ResumeLayout(false);
            this.groupBoxTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownIndent)).EndInit();
            this.groupBoxIndent.ResumeLayout(false);
            this.groupBoxIndent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxInstateIndent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMinCondIndent)).EndInit();
            this.groupBoxPadding.ResumeLayout(false);
            this.groupBoxPadding.PerformLayout();
            this.groupBoxFormat.ResumeLayout(false);
            this.groupBoxFormat.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.GroupBox groupBoxStyle;
        private System.Windows.Forms.ComboBox comboBoxStyle;
        private System.Windows.Forms.GroupBox groupBoxTab;
        private System.Windows.Forms.NumericUpDown numericUpDownIndent;
        private System.Windows.Forms.GroupBox groupBoxIndent;
        private System.Windows.Forms.CheckBox checkBoxMaxInstateIndent;
        private System.Windows.Forms.CheckBox checkBoxMinCondIndent;
        private System.Windows.Forms.CheckBox checkBoxIndentCol1Com;
        private System.Windows.Forms.CheckBox checkBoxIndentPreproc;
        private System.Windows.Forms.CheckBox checkBoxIndentLabels;
        private System.Windows.Forms.CheckBox checkBoxIndentNamesp;
        private System.Windows.Forms.CheckBox checkBoxIndentCases;
        private System.Windows.Forms.CheckBox checkBoxIndentSwitches;
        private System.Windows.Forms.CheckBox checkBoxIndentClasses;
        private System.Windows.Forms.GroupBox groupBoxPadding;
        private System.Windows.Forms.CheckBox checkBoxFillEmptyLines;
        private System.Windows.Forms.CheckBox checkBoxDelEmptyLines;
        private System.Windows.Forms.CheckBox checkBoxUnpadParen;
        private System.Windows.Forms.CheckBox checkBoxPadHeader;
        private System.Windows.Forms.CheckBox checkBoxPadParen;
        private System.Windows.Forms.CheckBox checkBoxPadParenIn;
        private System.Windows.Forms.CheckBox checkBoxPadParenOut;
        private System.Windows.Forms.CheckBox checkBoxPadOper;
        private System.Windows.Forms.CheckBox checkBoxBreakBlocksAll;
        private System.Windows.Forms.CheckBox checkBoxBreakBlocks;
        private System.Windows.Forms.GroupBox groupBoxFormat;
        private System.Windows.Forms.CheckBox checkBoxAlignReference;
        private System.Windows.Forms.CheckBox checkBoxAlignPointer;
        private System.Windows.Forms.ComboBox comboBoxAlignPointer;
        private System.Windows.Forms.ComboBox comboBoxAlignReference;
        private System.Windows.Forms.CheckBox checkBoxConvertTabs;
        private System.Windows.Forms.CheckBox checkBoxKeepOneLineStat;
        private System.Windows.Forms.CheckBox checkBoxKeepOneLineBlocks;
        private System.Windows.Forms.CheckBox checkBoxAddOneLineBrackets;
        private System.Windows.Forms.CheckBox checkBoxAddBrackets;
        private System.Windows.Forms.CheckBox checkBoxBreakElseIfs;
        private System.Windows.Forms.CheckBox checkBoxBreakClosingBrackets;
        private System.Windows.Forms.CheckBox checkBoxIndent;
        private System.Windows.Forms.ComboBox comboBoxIndent;
        private System.Windows.Forms.NumericUpDown numericUpDownMaxInstateIndent;
        private System.Windows.Forms.NumericUpDown numericUpDownMinCondIndent;
        private System.Windows.Forms.LinkLabel linkLabelHelp;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.CheckBox checkBoxMode;
        private System.Windows.Forms.ComboBox comboBoxMode;
    }
}