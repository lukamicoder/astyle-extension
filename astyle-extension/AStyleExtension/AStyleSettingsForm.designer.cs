namespace AStyleExtension {
sealed partial class AStyleSettingsForm {
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
        this.checkBoxIndentForceTabX = new System.Windows.Forms.CheckBox();
        this.numericUpDownIndentForceTabX = new System.Windows.Forms.NumericUpDown();
        this.checkBoxIndent = new System.Windows.Forms.CheckBox();
        this.comboBoxIndent = new System.Windows.Forms.ComboBox();
        this.numericUpDownIndent = new System.Windows.Forms.NumericUpDown();
        this.groupBoxIndent = new System.Windows.Forms.GroupBox();
        this.checkBoxIndentPreprocBlock = new System.Windows.Forms.CheckBox();
        this.checkBoxIndentPreprocDefine = new System.Windows.Forms.CheckBox();
        this.checkBoxIndentModifiers = new System.Windows.Forms.CheckBox();
        this.numericUpDownMaxInstateIndent = new System.Windows.Forms.NumericUpDown();
        this.numericUpDownMinCondIndent = new System.Windows.Forms.NumericUpDown();
        this.checkBoxMaxInstateIndent = new System.Windows.Forms.CheckBox();
        this.checkBoxMinCondIndent = new System.Windows.Forms.CheckBox();
        this.checkBoxIndentCol1Com = new System.Windows.Forms.CheckBox();
        this.checkBoxIndentPreprocCond = new System.Windows.Forms.CheckBox();
        this.checkBoxIndentLabels = new System.Windows.Forms.CheckBox();
        this.checkBoxIndentNamesp = new System.Windows.Forms.CheckBox();
        this.checkBoxIndentCases = new System.Windows.Forms.CheckBox();
        this.checkBoxIndentSwitches = new System.Windows.Forms.CheckBox();
        this.checkBoxIndentClasses = new System.Windows.Forms.CheckBox();
        this.groupBoxPadding = new System.Windows.Forms.GroupBox();
        this.checkBoxPadFirstParenOut = new System.Windows.Forms.CheckBox();
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
        this.checkBoxCloseTemplates = new System.Windows.Forms.CheckBox();
        this.checkBoxRemoveCommentPrefix = new System.Windows.Forms.CheckBox();
        this.checkBoxRemoveBrackets = new System.Windows.Forms.CheckBox();
        this.checkBoxBreakAfterLogical = new System.Windows.Forms.CheckBox();
        this.numericUpDownMaxCodeLength = new System.Windows.Forms.NumericUpDown();
        this.checkBoxMaxCodeLength = new System.Windows.Forms.CheckBox();
        this.checkBoxMode = new System.Windows.Forms.CheckBox();
        this.comboBoxMode = new System.Windows.Forms.ComboBox();
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
        this.groupBox1 = new System.Windows.Forms.GroupBox();
        this.checkBoxAttachExternC = new System.Windows.Forms.CheckBox();
        this.checkBoxAttachInlines = new System.Windows.Forms.CheckBox();
        this.checkBoxAttachClasses = new System.Windows.Forms.CheckBox();
        this.checkBoxAttachNamespaces = new System.Windows.Forms.CheckBox();
        this.groupBoxStyle.SuspendLayout();
        this.groupBoxTab.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)(this.numericUpDownIndentForceTabX)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this.numericUpDownIndent)).BeginInit();
        this.groupBoxIndent.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxInstateIndent)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMinCondIndent)).BeginInit();
        this.groupBoxPadding.SuspendLayout();
        this.groupBoxFormat.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxCodeLength)).BeginInit();
        this.groupBox1.SuspendLayout();
        this.SuspendLayout();
        //
        // buttonOK
        //
        this.buttonOK.DialogResult = System.Windows.Forms.DialogResult.OK;
        this.buttonOK.Location = new System.Drawing.Point(520, 572);
        this.buttonOK.Name = "buttonOK";
        this.buttonOK.Size = new System.Drawing.Size(75, 23);
        this.buttonOK.TabIndex = 5;
        this.buttonOK.Text = "OK";
        this.buttonOK.UseVisualStyleBackColor = true;
        //
        // buttonCancel
        //
        this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        this.buttonCancel.Location = new System.Drawing.Point(438, 572);
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
        this.groupBoxStyle.Size = new System.Drawing.Size(287, 71);
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
            "VTK",
            "Banner",
            "GNU",
            "Linux",
            "Horstmann",
            "1TBS",
            "Google",
            "Pico",
            "Lisp"
        });
        this.comboBoxStyle.Location = new System.Drawing.Point(9, 27);
        this.comboBoxStyle.Name = "comboBoxStyle";
        this.comboBoxStyle.Size = new System.Drawing.Size(105, 21);
        this.comboBoxStyle.TabIndex = 0;
        //
        // groupBoxTab
        //
        this.groupBoxTab.Controls.Add(this.checkBoxIndentForceTabX);
        this.groupBoxTab.Controls.Add(this.numericUpDownIndentForceTabX);
        this.groupBoxTab.Controls.Add(this.checkBoxIndent);
        this.groupBoxTab.Controls.Add(this.comboBoxIndent);
        this.groupBoxTab.Controls.Add(this.numericUpDownIndent);
        this.groupBoxTab.Location = new System.Drawing.Point(307, 9);
        this.groupBoxTab.Name = "groupBoxTab";
        this.groupBoxTab.Size = new System.Drawing.Size(286, 71);
        this.groupBoxTab.TabIndex = 8;
        this.groupBoxTab.TabStop = false;
        this.groupBoxTab.Text = "Tab Options";
        //
        // checkBoxIndentForceTabX
        //
        this.checkBoxIndentForceTabX.AutoSize = true;
        this.checkBoxIndentForceTabX.Enabled = false;
        this.checkBoxIndentForceTabX.Location = new System.Drawing.Point(9, 44);
        this.checkBoxIndentForceTabX.Name = "checkBoxIndentForceTabX";
        this.checkBoxIndentForceTabX.Size = new System.Drawing.Size(123, 17);
        this.checkBoxIndentForceTabX.TabIndex = 18;
        this.checkBoxIndentForceTabX.Text = "--indent=force-tab-x=";
        this.checkBoxIndentForceTabX.UseVisualStyleBackColor = true;
        this.checkBoxIndentForceTabX.CheckedChanged += new System.EventHandler(this.OncheckBoxIndentForceTabXCheckedChanged);
        //
        // numericUpDownIndentForceTabX
        //
        this.numericUpDownIndentForceTabX.Enabled = false;
        this.numericUpDownIndentForceTabX.Location = new System.Drawing.Point(165, 41);
        this.numericUpDownIndentForceTabX.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0
        });
        this.numericUpDownIndentForceTabX.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0
        });
        this.numericUpDownIndentForceTabX.Name = "numericUpDownIndentForceTabX";
        this.numericUpDownIndentForceTabX.Size = new System.Drawing.Size(44, 20);
        this.numericUpDownIndentForceTabX.TabIndex = 16;
        this.numericUpDownIndentForceTabX.Value = new decimal(new int[] {
            8,
            0,
            0,
            0
        });
        //
        // checkBoxIndent
        //
        this.checkBoxIndent.AutoSize = true;
        this.checkBoxIndent.Location = new System.Drawing.Point(9, 19);
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
            "force-tab"
        });
        this.comboBoxIndent.Location = new System.Drawing.Point(76, 16);
        this.comboBoxIndent.Name = "comboBoxIndent";
        this.comboBoxIndent.Size = new System.Drawing.Size(73, 21);
        this.comboBoxIndent.TabIndex = 14;
        this.comboBoxIndent.SelectedIndexChanged += new System.EventHandler(this.OnComboBoxIndentSelectedIndexChanged);
        //
        // numericUpDownIndent
        //
        this.numericUpDownIndent.Enabled = false;
        this.numericUpDownIndent.Location = new System.Drawing.Point(165, 16);
        this.numericUpDownIndent.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0
        });
        this.numericUpDownIndent.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0
        });
        this.numericUpDownIndent.Name = "numericUpDownIndent";
        this.numericUpDownIndent.Size = new System.Drawing.Size(44, 20);
        this.numericUpDownIndent.TabIndex = 12;
        this.numericUpDownIndent.Value = new decimal(new int[] {
            4,
            0,
            0,
            0
        });
        //
        // groupBoxIndent
        //
        this.groupBoxIndent.Controls.Add(this.checkBoxIndentPreprocBlock);
        this.groupBoxIndent.Controls.Add(this.checkBoxIndentPreprocDefine);
        this.groupBoxIndent.Controls.Add(this.checkBoxIndentModifiers);
        this.groupBoxIndent.Controls.Add(this.numericUpDownMaxInstateIndent);
        this.groupBoxIndent.Controls.Add(this.numericUpDownMinCondIndent);
        this.groupBoxIndent.Controls.Add(this.checkBoxMaxInstateIndent);
        this.groupBoxIndent.Controls.Add(this.checkBoxMinCondIndent);
        this.groupBoxIndent.Controls.Add(this.checkBoxIndentCol1Com);
        this.groupBoxIndent.Controls.Add(this.checkBoxIndentPreprocCond);
        this.groupBoxIndent.Controls.Add(this.checkBoxIndentLabels);
        this.groupBoxIndent.Controls.Add(this.checkBoxIndentNamesp);
        this.groupBoxIndent.Controls.Add(this.checkBoxIndentCases);
        this.groupBoxIndent.Controls.Add(this.checkBoxIndentSwitches);
        this.groupBoxIndent.Controls.Add(this.checkBoxIndentClasses);
        this.groupBoxIndent.Location = new System.Drawing.Point(12, 163);
        this.groupBoxIndent.Name = "groupBoxIndent";
        this.groupBoxIndent.Size = new System.Drawing.Size(582, 119);
        this.groupBoxIndent.TabIndex = 9;
        this.groupBoxIndent.TabStop = false;
        this.groupBoxIndent.Text = "Indentation Options";
        //
        // checkBoxIndentPreprocBlock
        //
        this.checkBoxIndentPreprocBlock.AutoSize = true;
        this.checkBoxIndentPreprocBlock.Location = new System.Drawing.Point(431, 19);
        this.checkBoxIndentPreprocBlock.Name = "checkBoxIndentPreprocBlock";
        this.checkBoxIndentPreprocBlock.Size = new System.Drawing.Size(129, 17);
        this.checkBoxIndentPreprocBlock.TabIndex = 21;
        this.checkBoxIndentPreprocBlock.Text = "--indent-preproc-block";
        this.checkBoxIndentPreprocBlock.UseVisualStyleBackColor = true;
        //
        // checkBoxIndentPreprocDefine
        //
        this.checkBoxIndentPreprocDefine.AutoSize = true;
        this.checkBoxIndentPreprocDefine.Location = new System.Drawing.Point(431, 44);
        this.checkBoxIndentPreprocDefine.Name = "checkBoxIndentPreprocDefine";
        this.checkBoxIndentPreprocDefine.Size = new System.Drawing.Size(134, 17);
        this.checkBoxIndentPreprocDefine.TabIndex = 20;
        this.checkBoxIndentPreprocDefine.Text = "--indent‑preproc‑define";
        this.checkBoxIndentPreprocDefine.UseVisualStyleBackColor = true;
        //
        // checkBoxIndentModifiers
        //
        this.checkBoxIndentModifiers.AutoSize = true;
        this.checkBoxIndentModifiers.Location = new System.Drawing.Point(216, 19);
        this.checkBoxIndentModifiers.Name = "checkBoxIndentModifiers";
        this.checkBoxIndentModifiers.Size = new System.Drawing.Size(105, 17);
        this.checkBoxIndentModifiers.TabIndex = 19;
        this.checkBoxIndentModifiers.Text = "--indent-modifiers";
        this.checkBoxIndentModifiers.UseVisualStyleBackColor = true;
        //
        // numericUpDownMaxInstateIndent
        //
        this.numericUpDownMaxInstateIndent.Enabled = false;
        this.numericUpDownMaxInstateIndent.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0
        });
        this.numericUpDownMaxInstateIndent.Location = new System.Drawing.Point(157, 66);
        this.numericUpDownMaxInstateIndent.Maximum = new decimal(new int[] {
            120,
            0,
            0,
            0
        });
        this.numericUpDownMaxInstateIndent.Minimum = new decimal(new int[] {
            40,
            0,
            0,
            0
        });
        this.numericUpDownMaxInstateIndent.Name = "numericUpDownMaxInstateIndent";
        this.numericUpDownMaxInstateIndent.Size = new System.Drawing.Size(44, 20);
        this.numericUpDownMaxInstateIndent.TabIndex = 18;
        this.numericUpDownMaxInstateIndent.Value = new decimal(new int[] {
            40,
            0,
            0,
            0
        });
        //
        // numericUpDownMinCondIndent
        //
        this.numericUpDownMinCondIndent.Enabled = false;
        this.numericUpDownMinCondIndent.Location = new System.Drawing.Point(157, 41);
        this.numericUpDownMinCondIndent.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0
        });
        this.numericUpDownMinCondIndent.Name = "numericUpDownMinCondIndent";
        this.numericUpDownMinCondIndent.Size = new System.Drawing.Size(44, 20);
        this.numericUpDownMinCondIndent.TabIndex = 17;
        this.numericUpDownMinCondIndent.Value = new decimal(new int[] {
            2,
            0,
            0,
            0
        });
        //
        // checkBoxMaxInstateIndent
        //
        this.checkBoxMaxInstateIndent.AutoSize = true;
        this.checkBoxMaxInstateIndent.Location = new System.Drawing.Point(9, 69);
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
        this.checkBoxMinCondIndent.Location = new System.Drawing.Point(9, 44);
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
        this.checkBoxIndentCol1Com.Location = new System.Drawing.Point(431, 94);
        this.checkBoxIndentCol1Com.Name = "checkBoxIndentCol1Com";
        this.checkBoxIndentCol1Com.Size = new System.Drawing.Size(135, 17);
        this.checkBoxIndentCol1Com.TabIndex = 10;
        this.checkBoxIndentCol1Com.Text = "--indent-col1-comments";
        this.checkBoxIndentCol1Com.UseVisualStyleBackColor = true;
        //
        // checkBoxIndentPreprocCond
        //
        this.checkBoxIndentPreprocCond.AutoSize = true;
        this.checkBoxIndentPreprocCond.Location = new System.Drawing.Point(431, 69);
        this.checkBoxIndentPreprocCond.Name = "checkBoxIndentPreprocCond";
        this.checkBoxIndentPreprocCond.Size = new System.Drawing.Size(129, 17);
        this.checkBoxIndentPreprocCond.TabIndex = 9;
        this.checkBoxIndentPreprocCond.Text = "--indent‑preproc‑cond";
        this.checkBoxIndentPreprocCond.UseVisualStyleBackColor = true;
        //
        // checkBoxIndentLabels
        //
        this.checkBoxIndentLabels.AutoSize = true;
        this.checkBoxIndentLabels.Location = new System.Drawing.Point(216, 44);
        this.checkBoxIndentLabels.Name = "checkBoxIndentLabels";
        this.checkBoxIndentLabels.Size = new System.Drawing.Size(91, 17);
        this.checkBoxIndentLabels.TabIndex = 8;
        this.checkBoxIndentLabels.Text = "--indent-labels";
        this.checkBoxIndentLabels.UseVisualStyleBackColor = true;
        //
        // checkBoxIndentNamesp
        //
        this.checkBoxIndentNamesp.AutoSize = true;
        this.checkBoxIndentNamesp.Location = new System.Drawing.Point(9, 92);
        this.checkBoxIndentNamesp.Name = "checkBoxIndentNamesp";
        this.checkBoxIndentNamesp.Size = new System.Drawing.Size(124, 17);
        this.checkBoxIndentNamesp.TabIndex = 7;
        this.checkBoxIndentNamesp.Text = "--indent-namespaces";
        this.checkBoxIndentNamesp.UseVisualStyleBackColor = true;
        //
        // checkBoxIndentCases
        //
        this.checkBoxIndentCases.AutoSize = true;
        this.checkBoxIndentCases.Location = new System.Drawing.Point(216, 69);
        this.checkBoxIndentCases.Name = "checkBoxIndentCases";
        this.checkBoxIndentCases.Size = new System.Drawing.Size(92, 17);
        this.checkBoxIndentCases.TabIndex = 6;
        this.checkBoxIndentCases.Text = "--indent-cases";
        this.checkBoxIndentCases.UseVisualStyleBackColor = true;
        //
        // checkBoxIndentSwitches
        //
        this.checkBoxIndentSwitches.AutoSize = true;
        this.checkBoxIndentSwitches.Location = new System.Drawing.Point(216, 94);
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
        this.groupBoxPadding.Controls.Add(this.checkBoxPadFirstParenOut);
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
        this.groupBoxPadding.Location = new System.Drawing.Point(12, 288);
        this.groupBoxPadding.Name = "groupBoxPadding";
        this.groupBoxPadding.Size = new System.Drawing.Size(582, 119);
        this.groupBoxPadding.TabIndex = 10;
        this.groupBoxPadding.TabStop = false;
        this.groupBoxPadding.Text = "Padding Options";
        //
        // checkBoxPadFirstParenOut
        //
        this.checkBoxPadFirstParenOut.AutoSize = true;
        this.checkBoxPadFirstParenOut.Location = new System.Drawing.Point(9, 69);
        this.checkBoxPadFirstParenOut.Name = "checkBoxPadFirstParenOut";
        this.checkBoxPadFirstParenOut.Size = new System.Drawing.Size(117, 17);
        this.checkBoxPadFirstParenOut.TabIndex = 20;
        this.checkBoxPadFirstParenOut.Text = "--pad-first-paren-out";
        this.checkBoxPadFirstParenOut.UseVisualStyleBackColor = true;
        //
        // checkBoxFillEmptyLines
        //
        this.checkBoxFillEmptyLines.AutoSize = true;
        this.checkBoxFillEmptyLines.Location = new System.Drawing.Point(431, 94);
        this.checkBoxFillEmptyLines.Name = "checkBoxFillEmptyLines";
        this.checkBoxFillEmptyLines.Size = new System.Drawing.Size(96, 17);
        this.checkBoxFillEmptyLines.TabIndex = 19;
        this.checkBoxFillEmptyLines.Text = "--fill-empty-lines";
        this.checkBoxFillEmptyLines.UseVisualStyleBackColor = true;
        //
        // checkBoxDelEmptyLines
        //
        this.checkBoxDelEmptyLines.AutoSize = true;
        this.checkBoxDelEmptyLines.Location = new System.Drawing.Point(431, 69);
        this.checkBoxDelEmptyLines.Name = "checkBoxDelEmptyLines";
        this.checkBoxDelEmptyLines.Size = new System.Drawing.Size(116, 17);
        this.checkBoxDelEmptyLines.TabIndex = 18;
        this.checkBoxDelEmptyLines.Text = "--delete-empty-lines";
        this.checkBoxDelEmptyLines.UseVisualStyleBackColor = true;
        //
        // checkBoxUnpadParen
        //
        this.checkBoxUnpadParen.AutoSize = true;
        this.checkBoxUnpadParen.Location = new System.Drawing.Point(216, 19);
        this.checkBoxUnpadParen.Name = "checkBoxUnpadParen";
        this.checkBoxUnpadParen.Size = new System.Drawing.Size(92, 17);
        this.checkBoxUnpadParen.TabIndex = 17;
        this.checkBoxUnpadParen.Text = "--unpad-paren";
        this.checkBoxUnpadParen.UseVisualStyleBackColor = true;
        //
        // checkBoxPadHeader
        //
        this.checkBoxPadHeader.AutoSize = true;
        this.checkBoxPadHeader.Location = new System.Drawing.Point(216, 44);
        this.checkBoxPadHeader.Name = "checkBoxPadHeader";
        this.checkBoxPadHeader.Size = new System.Drawing.Size(86, 17);
        this.checkBoxPadHeader.TabIndex = 16;
        this.checkBoxPadHeader.Text = "--pad-header";
        this.checkBoxPadHeader.UseVisualStyleBackColor = true;
        //
        // checkBoxPadParen
        //
        this.checkBoxPadParen.AutoSize = true;
        this.checkBoxPadParen.Location = new System.Drawing.Point(9, 19);
        this.checkBoxPadParen.Name = "checkBoxPadParen";
        this.checkBoxPadParen.Size = new System.Drawing.Size(80, 17);
        this.checkBoxPadParen.TabIndex = 15;
        this.checkBoxPadParen.Text = "--pad-paren";
        this.checkBoxPadParen.UseVisualStyleBackColor = true;
        //
        // checkBoxPadParenIn
        //
        this.checkBoxPadParenIn.AutoSize = true;
        this.checkBoxPadParenIn.Location = new System.Drawing.Point(9, 94);
        this.checkBoxPadParenIn.Name = "checkBoxPadParenIn";
        this.checkBoxPadParenIn.Size = new System.Drawing.Size(91, 17);
        this.checkBoxPadParenIn.TabIndex = 14;
        this.checkBoxPadParenIn.Text = "--pad-paren-in";
        this.checkBoxPadParenIn.UseVisualStyleBackColor = true;
        //
        // checkBoxPadParenOut
        //
        this.checkBoxPadParenOut.AutoSize = true;
        this.checkBoxPadParenOut.Location = new System.Drawing.Point(9, 44);
        this.checkBoxPadParenOut.Name = "checkBoxPadParenOut";
        this.checkBoxPadParenOut.Size = new System.Drawing.Size(98, 17);
        this.checkBoxPadParenOut.TabIndex = 13;
        this.checkBoxPadParenOut.Text = "--pad-paren-out";
        this.checkBoxPadParenOut.UseVisualStyleBackColor = true;
        //
        // checkBoxPadOper
        //
        this.checkBoxPadOper.AutoSize = true;
        this.checkBoxPadOper.Location = new System.Drawing.Point(216, 69);
        this.checkBoxPadOper.Name = "checkBoxPadOper";
        this.checkBoxPadOper.Size = new System.Drawing.Size(74, 17);
        this.checkBoxPadOper.TabIndex = 12;
        this.checkBoxPadOper.Text = "--pad-oper";
        this.checkBoxPadOper.UseVisualStyleBackColor = true;
        //
        // checkBoxBreakBlocksAll
        //
        this.checkBoxBreakBlocksAll.AutoSize = true;
        this.checkBoxBreakBlocksAll.Location = new System.Drawing.Point(431, 44);
        this.checkBoxBreakBlocksAll.Name = "checkBoxBreakBlocksAll";
        this.checkBoxBreakBlocksAll.Size = new System.Drawing.Size(109, 17);
        this.checkBoxBreakBlocksAll.TabIndex = 11;
        this.checkBoxBreakBlocksAll.Text = "--break-blocks=all";
        this.checkBoxBreakBlocksAll.UseVisualStyleBackColor = true;
        //
        // checkBoxBreakBlocks
        //
        this.checkBoxBreakBlocks.AutoSize = true;
        this.checkBoxBreakBlocks.Location = new System.Drawing.Point(431, 19);
        this.checkBoxBreakBlocks.Name = "checkBoxBreakBlocks";
        this.checkBoxBreakBlocks.Size = new System.Drawing.Size(93, 17);
        this.checkBoxBreakBlocks.TabIndex = 10;
        this.checkBoxBreakBlocks.Text = "--break-blocks";
        this.checkBoxBreakBlocks.UseVisualStyleBackColor = true;
        //
        // groupBoxFormat
        //
        this.groupBoxFormat.Controls.Add(this.checkBoxCloseTemplates);
        this.groupBoxFormat.Controls.Add(this.checkBoxRemoveCommentPrefix);
        this.groupBoxFormat.Controls.Add(this.checkBoxRemoveBrackets);
        this.groupBoxFormat.Controls.Add(this.checkBoxBreakAfterLogical);
        this.groupBoxFormat.Controls.Add(this.numericUpDownMaxCodeLength);
        this.groupBoxFormat.Controls.Add(this.checkBoxMaxCodeLength);
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
        this.groupBoxFormat.Location = new System.Drawing.Point(12, 413);
        this.groupBoxFormat.Name = "groupBoxFormat";
        this.groupBoxFormat.Size = new System.Drawing.Size(582, 145);
        this.groupBoxFormat.TabIndex = 11;
        this.groupBoxFormat.TabStop = false;
        this.groupBoxFormat.Text = "Formatting Options";
        //
        // checkBoxCloseTemplates
        //
        this.checkBoxCloseTemplates.AutoSize = true;
        this.checkBoxCloseTemplates.Location = new System.Drawing.Point(9, 44);
        this.checkBoxCloseTemplates.Name = "checkBoxCloseTemplates";
        this.checkBoxCloseTemplates.Size = new System.Drawing.Size(105, 17);
        this.checkBoxCloseTemplates.TabIndex = 24;
        this.checkBoxCloseTemplates.Text = "--close-templates";
        this.checkBoxCloseTemplates.UseVisualStyleBackColor = true;
        //
        // checkBoxRemoveCommentPrefix
        //
        this.checkBoxRemoveCommentPrefix.AutoSize = true;
        this.checkBoxRemoveCommentPrefix.Location = new System.Drawing.Point(216, 119);
        this.checkBoxRemoveCommentPrefix.Name = "checkBoxRemoveCommentPrefix";
        this.checkBoxRemoveCommentPrefix.Size = new System.Drawing.Size(143, 17);
        this.checkBoxRemoveCommentPrefix.TabIndex = 23;
        this.checkBoxRemoveCommentPrefix.Text = "--remove‑comment‑prefix";
        this.checkBoxRemoveCommentPrefix.UseVisualStyleBackColor = true;
        //
        // checkBoxRemoveBrackets
        //
        this.checkBoxRemoveBrackets.AutoSize = true;
        this.checkBoxRemoveBrackets.Location = new System.Drawing.Point(431, 69);
        this.checkBoxRemoveBrackets.Name = "checkBoxRemoveBrackets";
        this.checkBoxRemoveBrackets.Size = new System.Drawing.Size(112, 17);
        this.checkBoxRemoveBrackets.TabIndex = 22;
        this.checkBoxRemoveBrackets.Text = "--remove‑brackets";
        this.checkBoxRemoveBrackets.UseVisualStyleBackColor = true;
        //
        // checkBoxBreakAfterLogical
        //
        this.checkBoxBreakAfterLogical.AutoSize = true;
        this.checkBoxBreakAfterLogical.Enabled = false;
        this.checkBoxBreakAfterLogical.Location = new System.Drawing.Point(216, 94);
        this.checkBoxBreakAfterLogical.Name = "checkBoxBreakAfterLogical";
        this.checkBoxBreakAfterLogical.Size = new System.Drawing.Size(116, 17);
        this.checkBoxBreakAfterLogical.TabIndex = 21;
        this.checkBoxBreakAfterLogical.Text = "--break-after-logical";
        this.checkBoxBreakAfterLogical.UseVisualStyleBackColor = true;
        //
        // numericUpDownMaxCodeLength
        //
        this.numericUpDownMaxCodeLength.Enabled = false;
        this.numericUpDownMaxCodeLength.Location = new System.Drawing.Point(351, 66);
        this.numericUpDownMaxCodeLength.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0
        });
        this.numericUpDownMaxCodeLength.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            0
        });
        this.numericUpDownMaxCodeLength.Name = "numericUpDownMaxCodeLength";
        this.numericUpDownMaxCodeLength.Size = new System.Drawing.Size(44, 20);
        this.numericUpDownMaxCodeLength.TabIndex = 20;
        this.numericUpDownMaxCodeLength.Value = new decimal(new int[] {
            50,
            0,
            0,
            0
        });
        //
        // checkBoxMaxCodeLength
        //
        this.checkBoxMaxCodeLength.AutoSize = true;
        this.checkBoxMaxCodeLength.Location = new System.Drawing.Point(216, 69);
        this.checkBoxMaxCodeLength.Name = "checkBoxMaxCodeLength";
        this.checkBoxMaxCodeLength.Size = new System.Drawing.Size(116, 17);
        this.checkBoxMaxCodeLength.TabIndex = 19;
        this.checkBoxMaxCodeLength.Text = "--max-code-length=";
        this.checkBoxMaxCodeLength.UseVisualStyleBackColor = true;
        this.checkBoxMaxCodeLength.CheckedChanged += new System.EventHandler(this.OncheckBoxMaxCodeLengthCheckedChanged);
        //
        // checkBoxMode
        //
        this.checkBoxMode.AutoSize = true;
        this.checkBoxMode.Checked = true;
        this.checkBoxMode.CheckState = System.Windows.Forms.CheckState.Checked;
        this.checkBoxMode.Enabled = false;
        this.checkBoxMode.Location = new System.Drawing.Point(9, 119);
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
            "java"
        });
        this.comboBoxMode.Location = new System.Drawing.Point(119, 116);
        this.comboBoxMode.Name = "comboBoxMode";
        this.comboBoxMode.Size = new System.Drawing.Size(56, 21);
        this.comboBoxMode.TabIndex = 17;
        //
        // checkBoxAlignReference
        //
        this.checkBoxAlignReference.AutoSize = true;
        this.checkBoxAlignReference.Location = new System.Drawing.Point(9, 94);
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
        this.checkBoxAlignPointer.Location = new System.Drawing.Point(9, 69);
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
            "name"
        });
        this.comboBoxAlignPointer.Location = new System.Drawing.Point(119, 66);
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
            "name"
        });
        this.comboBoxAlignReference.Location = new System.Drawing.Point(119, 91);
        this.comboBoxAlignReference.Name = "comboBoxAlignReference";
        this.comboBoxAlignReference.Size = new System.Drawing.Size(82, 21);
        this.comboBoxAlignReference.TabIndex = 13;
        //
        // checkBoxConvertTabs
        //
        this.checkBoxConvertTabs.AutoSize = true;
        this.checkBoxConvertTabs.Location = new System.Drawing.Point(9, 19);
        this.checkBoxConvertTabs.Name = "checkBoxConvertTabs";
        this.checkBoxConvertTabs.Size = new System.Drawing.Size(91, 17);
        this.checkBoxConvertTabs.TabIndex = 10;
        this.checkBoxConvertTabs.Text = "--convert-tabs";
        this.checkBoxConvertTabs.UseVisualStyleBackColor = true;
        //
        // checkBoxKeepOneLineStat
        //
        this.checkBoxKeepOneLineStat.AutoSize = true;
        this.checkBoxKeepOneLineStat.Location = new System.Drawing.Point(431, 119);
        this.checkBoxKeepOneLineStat.Name = "checkBoxKeepOneLineStat";
        this.checkBoxKeepOneLineStat.Size = new System.Drawing.Size(150, 17);
        this.checkBoxKeepOneLineStat.TabIndex = 9;
        this.checkBoxKeepOneLineStat.Text = "--keep-one-line-statements";
        this.checkBoxKeepOneLineStat.UseVisualStyleBackColor = true;
        //
        // checkBoxKeepOneLineBlocks
        //
        this.checkBoxKeepOneLineBlocks.AutoSize = true;
        this.checkBoxKeepOneLineBlocks.Location = new System.Drawing.Point(431, 94);
        this.checkBoxKeepOneLineBlocks.Name = "checkBoxKeepOneLineBlocks";
        this.checkBoxKeepOneLineBlocks.Size = new System.Drawing.Size(130, 17);
        this.checkBoxKeepOneLineBlocks.TabIndex = 8;
        this.checkBoxKeepOneLineBlocks.Text = "--keep-one-line-blocks";
        this.checkBoxKeepOneLineBlocks.UseVisualStyleBackColor = true;
        //
        // checkBoxAddOneLineBrackets
        //
        this.checkBoxAddOneLineBrackets.AutoSize = true;
        this.checkBoxAddOneLineBrackets.Location = new System.Drawing.Point(431, 44);
        this.checkBoxAddOneLineBrackets.Name = "checkBoxAddOneLineBrackets";
        this.checkBoxAddOneLineBrackets.Size = new System.Drawing.Size(134, 17);
        this.checkBoxAddOneLineBrackets.TabIndex = 7;
        this.checkBoxAddOneLineBrackets.Text = "--add-one-line-brackets";
        this.checkBoxAddOneLineBrackets.UseVisualStyleBackColor = true;
        //
        // checkBoxAddBrackets
        //
        this.checkBoxAddBrackets.AutoSize = true;
        this.checkBoxAddBrackets.Location = new System.Drawing.Point(431, 19);
        this.checkBoxAddBrackets.Name = "checkBoxAddBrackets";
        this.checkBoxAddBrackets.Size = new System.Drawing.Size(94, 17);
        this.checkBoxAddBrackets.TabIndex = 6;
        this.checkBoxAddBrackets.Text = "--add-brackets";
        this.checkBoxAddBrackets.UseVisualStyleBackColor = true;
        //
        // checkBoxBreakElseIfs
        //
        this.checkBoxBreakElseIfs.AutoSize = true;
        this.checkBoxBreakElseIfs.Location = new System.Drawing.Point(216, 44);
        this.checkBoxBreakElseIfs.Name = "checkBoxBreakElseIfs";
        this.checkBoxBreakElseIfs.Size = new System.Drawing.Size(91, 17);
        this.checkBoxBreakElseIfs.TabIndex = 5;
        this.checkBoxBreakElseIfs.Text = "--break-elseifs";
        this.checkBoxBreakElseIfs.UseVisualStyleBackColor = true;
        //
        // checkBoxBreakClosingBrackets
        //
        this.checkBoxBreakClosingBrackets.AutoSize = true;
        this.checkBoxBreakClosingBrackets.Location = new System.Drawing.Point(216, 19);
        this.checkBoxBreakClosingBrackets.Name = "checkBoxBreakClosingBrackets";
        this.checkBoxBreakClosingBrackets.Size = new System.Drawing.Size(139, 17);
        this.checkBoxBreakClosingBrackets.TabIndex = 4;
        this.checkBoxBreakClosingBrackets.Text = "--break-closing-brackets";
        this.checkBoxBreakClosingBrackets.UseVisualStyleBackColor = true;
        //
        // linkLabelHelp
        //
        this.linkLabelHelp.AutoSize = true;
        this.linkLabelHelp.Location = new System.Drawing.Point(12, 572);
        this.linkLabelHelp.Name = "linkLabelHelp";
        this.linkLabelHelp.Size = new System.Drawing.Size(60, 13);
        this.linkLabelHelp.TabIndex = 12;
        this.linkLabelHelp.TabStop = true;
        this.linkLabelHelp.Text = "Online help";
        this.linkLabelHelp.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.OnLinkLabelHelpClicked);
        //
        // groupBox1
        //
        this.groupBox1.Controls.Add(this.checkBoxAttachExternC);
        this.groupBox1.Controls.Add(this.checkBoxAttachInlines);
        this.groupBox1.Controls.Add(this.checkBoxAttachClasses);
        this.groupBox1.Controls.Add(this.checkBoxAttachNamespaces);
        this.groupBox1.Location = new System.Drawing.Point(12, 86);
        this.groupBox1.Name = "groupBox1";
        this.groupBox1.Size = new System.Drawing.Size(582, 71);
        this.groupBox1.TabIndex = 13;
        this.groupBox1.TabStop = false;
        this.groupBox1.Text = "Bracket Modify Options";
        //
        // checkBoxAttachExternC
        //
        this.checkBoxAttachExternC.AutoSize = true;
        this.checkBoxAttachExternC.Location = new System.Drawing.Point(216, 44);
        this.checkBoxAttachExternC.Name = "checkBoxAttachExternC";
        this.checkBoxAttachExternC.Size = new System.Drawing.Size(105, 17);
        this.checkBoxAttachExternC.TabIndex = 20;
        this.checkBoxAttachExternC.Text = "--attach‑extern‑c";
        this.checkBoxAttachExternC.UseVisualStyleBackColor = true;
        //
        // checkBoxAttachInlines
        //
        this.checkBoxAttachInlines.AutoSize = true;
        this.checkBoxAttachInlines.Location = new System.Drawing.Point(216, 19);
        this.checkBoxAttachInlines.Name = "checkBoxAttachInlines";
        this.checkBoxAttachInlines.Size = new System.Drawing.Size(94, 17);
        this.checkBoxAttachInlines.TabIndex = 19;
        this.checkBoxAttachInlines.Text = "--attach-inlines";
        this.checkBoxAttachInlines.UseVisualStyleBackColor = true;
        //
        // checkBoxAttachClasses
        //
        this.checkBoxAttachClasses.AutoSize = true;
        this.checkBoxAttachClasses.Location = new System.Drawing.Point(9, 44);
        this.checkBoxAttachClasses.Name = "checkBoxAttachClasses";
        this.checkBoxAttachClasses.Size = new System.Drawing.Size(100, 17);
        this.checkBoxAttachClasses.TabIndex = 18;
        this.checkBoxAttachClasses.Text = "--attach-classes";
        this.checkBoxAttachClasses.UseVisualStyleBackColor = true;
        //
        // checkBoxAttachNamespaces
        //
        this.checkBoxAttachNamespaces.AutoSize = true;
        this.checkBoxAttachNamespaces.Location = new System.Drawing.Point(9, 19);
        this.checkBoxAttachNamespaces.Name = "checkBoxAttachNamespaces";
        this.checkBoxAttachNamespaces.Size = new System.Drawing.Size(125, 17);
        this.checkBoxAttachNamespaces.TabIndex = 15;
        this.checkBoxAttachNamespaces.Text = "--attach-namespaces";
        this.checkBoxAttachNamespaces.UseVisualStyleBackColor = true;
        //
        // AStyleSettingsForm
        //
        this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(606, 612);
        this.Controls.Add(this.groupBox1);
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
        this.Name = "AStyleSettingsForm";
        this.ShowIcon = false;
        this.ShowInTaskbar = false;
        this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
        this.groupBoxStyle.ResumeLayout(false);
        this.groupBoxTab.ResumeLayout(false);
        this.groupBoxTab.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)(this.numericUpDownIndentForceTabX)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this.numericUpDownIndent)).EndInit();
        this.groupBoxIndent.ResumeLayout(false);
        this.groupBoxIndent.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxInstateIndent)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMinCondIndent)).EndInit();
        this.groupBoxPadding.ResumeLayout(false);
        this.groupBoxPadding.PerformLayout();
        this.groupBoxFormat.ResumeLayout(false);
        this.groupBoxFormat.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxCodeLength)).EndInit();
        this.groupBox1.ResumeLayout(false);
        this.groupBox1.PerformLayout();
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
    private System.Windows.Forms.CheckBox checkBoxIndentPreprocCond;
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
    private System.Windows.Forms.CheckBox checkBoxIndentForceTabX;
    private System.Windows.Forms.NumericUpDown numericUpDownIndentForceTabX;
    private System.Windows.Forms.CheckBox checkBoxPadFirstParenOut;
    private System.Windows.Forms.CheckBox checkBoxBreakAfterLogical;
    private System.Windows.Forms.NumericUpDown numericUpDownMaxCodeLength;
    private System.Windows.Forms.CheckBox checkBoxMaxCodeLength;
    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.CheckBox checkBoxAttachExternC;
    private System.Windows.Forms.CheckBox checkBoxAttachInlines;
    private System.Windows.Forms.CheckBox checkBoxAttachClasses;
    private System.Windows.Forms.CheckBox checkBoxAttachNamespaces;
    private System.Windows.Forms.CheckBox checkBoxIndentModifiers;
    private System.Windows.Forms.CheckBox checkBoxIndentPreprocDefine;
    private System.Windows.Forms.CheckBox checkBoxRemoveBrackets;
    private System.Windows.Forms.CheckBox checkBoxRemoveCommentPrefix;
    private System.Windows.Forms.CheckBox checkBoxCloseTemplates;
    private System.Windows.Forms.CheckBox checkBoxIndentPreprocBlock;
}
}