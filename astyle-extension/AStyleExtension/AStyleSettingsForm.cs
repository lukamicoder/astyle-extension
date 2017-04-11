using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Windows.Forms;

namespace AStyleExtension {
	public enum Language {
		NA,
		Cpp,
		CSharp,
		Java
	}

	public sealed partial class AStyleSettingsForm : Form {
		Dictionary<string, CheckBox> _checkboxDic;
		private Language _language;
		private const string HelpLink = "http://astyle.sourceforge.net/astyle.html";

		Dictionary<string, string> _styleDic = new Dictionary<string, string> {
			{ "", "None" },
			{ "--style=allman", "Allman" },
			{ "--style=java", "Java" },
			{ "--style=kr", "K&R" },
			{ "--style=stroustrup", "Stroustrup" },
			{ "--style=whitesmith", "Whitesmith" },
            { "--style=vtk", "VTK" },
            { "--style=banner", "Banner" },
			{ "--style=gnu", "GNU" },
			{ "--style=linux", "Linux" },
			{ "--style=horstmann", "Horstmann" },
			{ "--style=1tbs", "1TBS" },
			{ "--style=google", "Google" },
			{ "--style=mozilla", "Mozilla" },
			{ "--style=pico", "Pico" },
			{ "--style=lisp", "Lisp" }
		};

		public AStyleSettingsForm(Language language) {
			InitializeComponent();
			_language = language;

			switch (_language) {
				case Language.CSharp:
					Text = "AStyle C# Settings";
					break;
				case Language.Cpp:
					Text = "AStyle C/C++ Settings";
					break;
			}

			_checkboxDic = new Dictionary<string, CheckBox> {
				{ "--attach-namespaces", checkBoxAttachNamespaces },
				{ "--attach-classes", checkBoxAttachClasses },
				{ "--attach-inlines", checkBoxAttachInlines },
				{ "--attach-extern-c", checkBoxAttachExternC },
                { "--attach-closing-while", checkBoxAttachClosingWhile },
                { "--indent-classes", checkBoxIndentClasses },
				{ "--indent-modifiers", checkBoxIndentModifiers },
				{ "--indent-switches", checkBoxIndentSwitches },
				{ "--indent-cases", checkBoxIndentCases },
				{ "--indent-namespaces", checkBoxIndentNamesp },
                { "--indent-after-parens", checkBoxIndentAfterParens },
                { "--indent-labels", checkBoxIndentLabels },
				{ "--indent-preproc-block", checkBoxIndentPreprocBlock },
				{ "--indent-preproc-define", checkBoxIndentPreprocDefine },
				{ "--indent-preproc-cond", checkBoxIndentPreprocCond },
				{ "--indent-col1-comments", checkBoxIndentCol1Com },
				{ "--break-blocks", checkBoxBreakBlocks },
				{ "--break-blocks=all", checkBoxBreakBlocksAll },
				{ "--pad-oper", checkBoxPadOper },
				{ "--pad-comma", checkBoxPadComma },
				{ "--pad-paren", checkBoxPadParen },
				{ "--pad-paren-out", checkBoxPadParenOut },
				{ "--pad-paren-in", checkBoxPadParenIn },
				{ "--pad-first-paren-out", checkBoxPadFirstParenOut },
				{ "--pad-header", checkBoxPadHeader },
				{ "--unpad-paren", checkBoxUnpadParen },
				{ "--delete-empty-lines", checkBoxDelEmptyLines },
				{ "--fill-empty-lines", checkBoxFillEmptyLines },
				{ "--close-templates", checkBoxCloseTemplates },
				{ "--break-closing-braces", checkBoxBreakClosingBraces },
				{ "--break-elseifs", checkBoxBreakElseIfs },
				{ "--break-one-line-headers", checkBoxBreakOneLineHeaders },
				{ "--add-brackets", checkBoxAddBrackets },
				{ "--remove-brackets", checkBoxRemoveBrackets },
				{ "--add-one-line-brackets", checkBoxAddOneLineBrackets },
				{ "--keep-one-line-blocks", checkBoxKeepOneLineBlocks },
				{ "--keep-one-line-statements", checkBoxKeepOneLineStat },
				{ "--convert-tabs", checkBoxConvertTabs },
				{ "--break-after-logical", checkBoxBreakAfterLogical },
				{ "--remove-comment-prefix", checkBoxRemoveCommentPrefix }
			};

			toolTip.SetToolTip(checkBoxAttachNamespaces, "Attach brackets to a namespace statement.");
			toolTip.SetToolTip(checkBoxAttachClasses, "Attach brackets to a class statement.");
			toolTip.SetToolTip(checkBoxAttachInlines, "Attach brackets to class and struct inline function definition.");
            toolTip.SetToolTip(checkBoxAttachExternC, "Attach brackets to a bracketed extern \"C\" statement.");
            toolTip.SetToolTip(checkBoxAttachClosingWhile, "Attach the closing 'while' of a 'do-while' statement to the closing brace.");
            toolTip.SetToolTip(checkBoxIndent, "Indent using spaces or tab characters.");
			toolTip.SetToolTip(checkBoxIndentForceTabX, "Set tab length to a length that is different than the indent length.");
			toolTip.SetToolTip(checkBoxIndentClasses, "Indent 'class' and 'struct' blocks.");
			toolTip.SetToolTip(checkBoxIndentModifiers, "Indent 'class' and 'struct' access modifiers one half indent.");
			toolTip.SetToolTip(checkBoxIndentSwitches, "Indent 'switch' blocks.");
			toolTip.SetToolTip(checkBoxIndentCases, "Indent 'case X:' blocks from the 'case X:' headers.");
            toolTip.SetToolTip(checkBoxIndentNamesp, "Add extra indentation to namespace blocks.");
            toolTip.SetToolTip(checkBoxIndentAfterParens, "Indent, instead of align, continuation lines following lines that contain an opening paren '(' or an assignment '='.");
            toolTip.SetToolTip(checkBoxIndentLabels, "Add extra indentation to labels so they appear 1 indent less than the current indentation.");
			toolTip.SetToolTip(checkBoxIndentContinuation, "Set the continuation indent for a line that ends with an opening paren '(' or an assignment '='.");
			toolTip.SetToolTip(checkBoxIndentPreprocBlock, "Indent preprocessor blocks at bracket level zero, and immediately within a namespace.");
			toolTip.SetToolTip(checkBoxIndentPreprocDefine, "Indent multi-line preprocessor definitions ending with a backslash.");
			toolTip.SetToolTip(checkBoxIndentPreprocCond, "Indent preprocessor conditional statements to the same level as the source code.");
			toolTip.SetToolTip(checkBoxIndentCol1Com, "Indent C++ comments beginning in column one.");
			toolTip.SetToolTip(checkBoxMinCondIndent, "Set the minimal indent that is added when a header is built of multiple lines.");
			toolTip.SetToolTip(checkBoxMaxInstateIndent, "Set the maximum number of spaces to indent a continuation line.");
			toolTip.SetToolTip(checkBoxBreakBlocks, "Pad empty lines around header blocks (e.g. 'if', 'for', 'while').");
			toolTip.SetToolTip(checkBoxBreakBlocksAll, "Pad empty lines around header blocks (e.g. 'if', 'for', 'while'). Treat closing header blocks (e.g. 'else', 'catch') as stand-alone blocks.");
			toolTip.SetToolTip(checkBoxPadOper, "Insert space padding around operators.");
			toolTip.SetToolTip(checkBoxPadComma, "Insert space padding after commas.");
			toolTip.SetToolTip(checkBoxPadParen, "Insert space padding around parenthesis on both the outside and the inside.");
			toolTip.SetToolTip(checkBoxPadParenOut, "Insert space padding around parenthesis on the outside only.");
			toolTip.SetToolTip(checkBoxPadFirstParenOut, "Insert space padding around the first parenthesis in a series on the outside only.");
			toolTip.SetToolTip(checkBoxPadParenIn, "Insert space padding around parenthesis on the inside only.");
			toolTip.SetToolTip(checkBoxPadHeader, "Insert space padding after paren headers only (e.g. 'if', 'for', 'while').");
			toolTip.SetToolTip(checkBoxUnpadParen, "Remove extra space padding around parenthesis on the inside and outside.");
			toolTip.SetToolTip(checkBoxDelEmptyLines, "Delete empty lines within a function or method. Empty lines outside of functions or methods are not deleted.");
			toolTip.SetToolTip(checkBoxFillEmptyLines, "Fill empty lines with the white space of the previous line.");
			toolTip.SetToolTip(checkBoxCloseTemplates, "Close whitespace in the angle brackets of template definitions.");
			toolTip.SetToolTip(checkBoxBreakClosingBraces, "Break closing headers (e.g. 'else', 'catch') from their immediately preceding closing brackets.");
			toolTip.SetToolTip(checkBoxBreakElseIfs, "Break 'else if' header combinations into separate lines.");
			toolTip.SetToolTip(checkBoxBreakOneLineHeaders, "Break one line headers (e.g. 'if', 'while', 'else', ...) from a statement residing on the same line.");
			toolTip.SetToolTip(checkBoxAddBrackets, "Add brackets to unbracketed one line conditional statements (e.g. 'if', 'for', 'while').");
			toolTip.SetToolTip(checkBoxRemoveBrackets, "Remove brackets from one line conditional statements (e.g. 'if', 'for', 'while').");
			toolTip.SetToolTip(checkBoxAddOneLineBrackets, "Add one line brackets to unbracketed one line conditional statements  (e.g. 'if', 'for', 'while').");
			toolTip.SetToolTip(checkBoxKeepOneLineBlocks, "Don't break blocks residing completely on one line.");
			toolTip.SetToolTip(checkBoxKeepOneLineStat, "Don't break complex statements and multiple statements residing on a single line.");
			toolTip.SetToolTip(checkBoxConvertTabs, "Convert tabs into spaces in the non-indentation part of the line.");
			toolTip.SetToolTip(checkBoxAlignPointer, "Attach a pointer or reference operator (* or &) to either the variable type or variable name, or in between.");
			toolTip.SetToolTip(checkBoxAlignReference, "Attach a reference operator (&) to either the variable type or variable name, or in between.");
			toolTip.SetToolTip(checkBoxMaxCodeLength, "Break a line if the code exceeds maximum characters.");
			toolTip.SetToolTip(checkBoxBreakAfterLogical, "Break a line at a semicolon if the line goes over the maximum length. Used with max-code-length.");
			toolTip.SetToolTip(checkBoxRemoveCommentPrefix, "Remove the preceding '*' in a multi-line comment that begins a line.");

			comboBoxStyle.SelectedIndex = 0;

			OnCheckBoxIndentCheckedChanged(checkBoxIndent, null);
			OnCheckBoxMinCondIndentCheckedChanged(checkBoxMinCondIndent, null);
			OnCheckBoxMaxInstateIndentCheckedChanged(checkBoxMaxInstateIndent, null);
			OnCheckBoxAlignPointerCheckedChanged(checkBoxAlignPointer, null);
			OnCheckBoxAlignReferenceCheckedChanged(checkBoxAlignReference, null);
			OncheckBoxIndentForceTabXCheckedChanged(checkBoxIndentForceTabX, null);
			OncheckBoxMaxCodeLengthCheckedChanged(checkBoxMaxCodeLength, null);
		}

		public void SetControls(string command) {
			switch (_language) {
				case Language.CSharp:
					comboBoxMode.SelectedIndex = 1;
					checkBoxAttachExternC.Visible = false;
					checkBoxAttachInlines.Visible = false;
					break;
				case Language.Cpp:
					comboBoxMode.SelectedIndex = 0;
					checkBoxAttachExternC.Visible = true;
					checkBoxAttachInlines.Visible = true;
					break;
			}

			if (string.IsNullOrEmpty(command)) {
				return;
			}

			var optionsList = new List<string>();
			optionsList.AddRange(command.Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries));

			foreach (string option in optionsList) {
				int pos;
				int no;
				if (option.StartsWith("--style=")) {
					string val;
					if (_styleDic.TryGetValue(option, out val)) {
						comboBoxStyle.SelectedItem = val;
					}
				} else if (option.StartsWith("--indent=spaces=") || option.StartsWith("--indent=tab=") || option.StartsWith("--indent=force-tab=")) {
					pos = option.LastIndexOf("=", StringComparison.Ordinal);

					if (int.TryParse(option.Substring(pos + 1), out no)) {
						if (no < 2) {
							no = 2;
						}
						if (no > 20) {
							no = 20;
						}

						numericUpDownIndent.Value = no;
						string[] parts = option.Split('=');
						comboBoxIndent.SelectedItem = parts[1];
						checkBoxIndent.Checked = true;
					}
				} else if (option.StartsWith("--indent=force-tab-x=")) {
					pos = option.LastIndexOf("=", StringComparison.Ordinal);

					if (int.TryParse(option.Substring(pos + 1), out no)) {
						if (no < 2) {
							no = 2;
						}
						if (no > 20) {
							no = 20;
						}

						numericUpDownIndentForceTabX.Value = no;
						checkBoxIndentForceTabX.Checked = true;
					}
				} else if (option.StartsWith("--min-conditional-indent=")) {
					pos = option.LastIndexOf("=", StringComparison.Ordinal);

					if (int.TryParse(option.Substring(pos + 1), out no)) {
						if (no < 0) {
							no = 0;
						}
						if (no > 4) {
							no = 4;
						}

						numericUpDownMinCondIndent.Value = no;
						checkBoxMinCondIndent.Checked = true;
					}
				} else if (option.StartsWith("--max-instatement-indent=")) {
					pos = option.LastIndexOf("=", StringComparison.Ordinal);

					if (int.TryParse(option.Substring(pos + 1), out no)) {
						if (no < 10) {
							no = 10;
						}
						if (no > 120) {
							no = 120;
						}

						numericUpDownMaxInstateIndent.Value = no;
						checkBoxMaxInstateIndent.Checked = true;
					}
				} else if (option.StartsWith("--indent-continuation=")) {
					pos = option.LastIndexOf("=", StringComparison.Ordinal);

					if (int.TryParse(option.Substring(pos + 1), out no)) {
						if (no < 0) {
							no = 0;
						}
						if (no > 4) {
							no = 4;
						}

						numericUpDownIndentContinuation.Value = no;
						checkBoxIndentContinuation.Checked = true;
					}
				} else if (option.StartsWith("--align-pointer=")) {
					pos = option.LastIndexOf("=", StringComparison.Ordinal);
					comboBoxAlignPointer.SelectedItem = option.Substring(pos + 1);
					checkBoxAlignPointer.Checked = true;
				} else if (option.StartsWith("--align-reference=")) {
					pos = option.LastIndexOf("=", StringComparison.Ordinal);
					comboBoxAlignReference.SelectedItem = option.Substring(pos + 1);
					checkBoxAlignReference.Checked = true;
				} else if (option.StartsWith("--max-code-length=")) {
					pos = option.LastIndexOf("=", StringComparison.Ordinal);

					if (int.TryParse(option.Substring(pos + 1), out no)) {
						if (no < 50) {
							no = 50;
						}
						if (no > 200) {
							no = 200;
						}

						numericUpDownMaxCodeLength.Value = no;
						checkBoxMaxCodeLength.Checked = true;
						checkBoxBreakAfterLogical.Enabled = true;
					}
				} else {
					CheckBox cb;
					if (_checkboxDic.TryGetValue(option, out cb)) {
						cb.Checked = true;
					}
				}
			}
		}

		public string GetCommandLine() {
			StringBuilder sb = new StringBuilder();

			foreach (KeyValuePair<string, string> pair in _styleDic) {
				if ((string)comboBoxStyle.SelectedItem == pair.Value) {
					sb.Append(pair.Key).Append(" ");
					break;
				}
			}

			if (checkBoxIndent.Checked) {
				sb.Append("--indent=").Append(comboBoxIndent.SelectedItem).Append("=").Append(numericUpDownIndent.Value).Append(" ");
			}

			if (checkBoxIndentForceTabX.Checked) {
				sb.Append("--indent=force-tab-x=").Append(numericUpDownIndentForceTabX.Value).Append(" ");
			}

			if (checkBoxMinCondIndent.Checked) {
				sb.Append("--min-conditional-indent=").Append(numericUpDownMinCondIndent.Value).Append(" ");
			}

			if (checkBoxMaxInstateIndent.Checked) {
				sb.Append("--max-instatement-indent=").Append(numericUpDownMaxInstateIndent.Value).Append(" ");
			}

			if (checkBoxIndentContinuation.Checked) {
				sb.Append("--indent-continuation=").Append(numericUpDownIndentContinuation.Value).Append(" ");
			}

			if (checkBoxAlignPointer.Checked) {
				sb.Append("--align-pointer=").Append(comboBoxAlignPointer.SelectedItem).Append(" ");
			}

			if (checkBoxAlignReference.Checked) {
				sb.Append("--align-reference=").Append(comboBoxAlignReference.SelectedItem).Append(" ");
			}

			if (checkBoxMaxCodeLength.Checked) {
				sb.Append("--max-code-length=").Append(numericUpDownMaxCodeLength.Value).Append(" ");
			}

			foreach (KeyValuePair<string, CheckBox> pair in _checkboxDic) {
				if (pair.Value.Checked) {
					sb.Append(pair.Key).Append(" ");
				}
			}

			if (sb.Length > 1) {
				if (_language == Language.CSharp) {
					sb.Append("--mode=cs");
				} else if (_language == Language.Cpp) {
					sb.Append("--mode=c");
				}
			}

			return sb.ToString().Trim();
		}

		private void OnLinkLabelHelpClicked(object sender, LinkLabelLinkClickedEventArgs e) {
			var sInfo = new ProcessStartInfo(HelpLink);
			Process.Start(sInfo);
		}

		private void OnCheckBoxIndentCheckedChanged(object sender, EventArgs e) {
			if (((CheckBox)sender).Checked) {
				comboBoxIndent.Enabled = true;
				numericUpDownIndent.Enabled = true;
			} else {
				comboBoxIndent.SelectedIndex = 0;
				comboBoxIndent.Enabled = false;
				numericUpDownIndent.Value = 4;
				numericUpDownIndent.Enabled = false;
			}
		}

		private void OncheckBoxIndentForceTabXCheckedChanged(object sender, EventArgs e) {
			if (((CheckBox)sender).Checked) {
				numericUpDownIndentForceTabX.Enabled = true;
			} else {
				numericUpDownIndentForceTabX.Value = 8;
				numericUpDownIndentForceTabX.Enabled = false;
			}
		}

		private void OnCheckBoxMinCondIndentCheckedChanged(object sender, EventArgs e) {
			if (((CheckBox)sender).Checked) {
				numericUpDownMinCondIndent.Enabled = true;
			} else {
				numericUpDownMinCondIndent.Value = 2;
				numericUpDownMinCondIndent.Enabled = false;
			}
		}

		private void OnCheckBoxMaxInstateIndentCheckedChanged(object sender, EventArgs e) {
			if (((CheckBox)sender).Checked) {
				numericUpDownMaxInstateIndent.Enabled = true;
			} else {
				numericUpDownMaxInstateIndent.Value = 40;
				numericUpDownMaxInstateIndent.Enabled = false;
			}
		}

		private void OnCheckBoxAlignPointerCheckedChanged(object sender, EventArgs e) {
			if (((CheckBox)sender).Checked) {
				comboBoxAlignPointer.Enabled = true;
			} else {
				comboBoxAlignPointer.SelectedIndex = 0;
				comboBoxAlignPointer.Enabled = false;
			}
		}

		private void OnCheckBoxAlignReferenceCheckedChanged(object sender, EventArgs e) {
			if (((CheckBox)sender).Checked) {
				comboBoxAlignReference.Enabled = true;
			} else {
				comboBoxAlignReference.SelectedIndex = 0;
				comboBoxAlignReference.Enabled = false;
			}
		}

		private void OnCheckBoxIndentContinuationCheckedChanged(object sender, EventArgs e) {
			if (((CheckBox)sender).Checked) {
				numericUpDownIndentContinuation.Enabled = true;
			} else {
				numericUpDownIndentContinuation.Value = 1;
				numericUpDownIndentContinuation.Enabled = false;
			}
		}

		private void OncheckBoxMaxCodeLengthCheckedChanged(object sender, EventArgs e) {
			if (((CheckBox)sender).Checked) {
				numericUpDownMaxCodeLength.Enabled = true;
				checkBoxBreakAfterLogical.Enabled = true;
			} else {
				numericUpDownMaxCodeLength.Value = 50;
				numericUpDownMaxCodeLength.Enabled = false;
				checkBoxBreakAfterLogical.Checked = false;
				checkBoxBreakAfterLogical.Enabled = false;
			}
		}

		private void OnComboBoxIndentSelectedIndexChanged(object sender, EventArgs e) {
			var combo = (ComboBox)sender;

			if ((string)combo.SelectedItem == "force-tab") {
				checkBoxIndentForceTabX.Enabled = true;
				numericUpDownIndentForceTabX.Enabled = true;
			} else {
				checkBoxIndentForceTabX.Checked = false;
				checkBoxIndentForceTabX.Enabled = false;
				numericUpDownIndentForceTabX.Value = 8;
				numericUpDownIndentForceTabX.Enabled = false;
			}
		}
	}
}