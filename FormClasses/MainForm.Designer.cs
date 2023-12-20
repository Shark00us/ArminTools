/*
 * User: Armin
 * Date: 11/21/2023
 * Time: 08:39 ب.ظ
 */
using System.Windows.Forms;
namespace ArminTools
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private Button selectPathButton;
		private Label labelUnitSize;
		private Label labelCredit;
		private FolderBrowserDialog folderBrowserDialog1;
		private Button buttonStartGrouping;
		private Button buttonStratExtracting;
		private Label labelline1;
		private Label labelline2;
		private Label labelline3;
		private Button buttonStartExtChanger;
		private Label labelExtFrom;
		private Label labelExtTo;
		private NumericUpDown groupSizeNumericUpDown;
		private Label labelline4;
		private RichTextBox textBoxPath;
		private CheckBox checkBoxFromExtEnabler;
		private MaskedTextBox maskedTextBoxFromExt;
		private MaskedTextBox maskedTextBoxToExt;
		private Label labelHiddenChange;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.selectPathButton = new System.Windows.Forms.Button();
			this.labelUnitSize = new System.Windows.Forms.Label();
			this.labelCredit = new System.Windows.Forms.Label();
			this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
			this.buttonStartGrouping = new System.Windows.Forms.Button();
			this.buttonStratExtracting = new System.Windows.Forms.Button();
			this.labelline1 = new System.Windows.Forms.Label();
			this.labelline2 = new System.Windows.Forms.Label();
			this.labelline3 = new System.Windows.Forms.Label();
			this.buttonStartExtChanger = new System.Windows.Forms.Button();
			this.labelExtFrom = new System.Windows.Forms.Label();
			this.labelExtTo = new System.Windows.Forms.Label();
			this.groupSizeNumericUpDown = new System.Windows.Forms.NumericUpDown();
			this.labelline4 = new System.Windows.Forms.Label();
			this.textBoxPath = new System.Windows.Forms.RichTextBox();
			this.checkBoxFromExtEnabler = new System.Windows.Forms.CheckBox();
			this.maskedTextBoxFromExt = new System.Windows.Forms.MaskedTextBox();
			this.maskedTextBoxToExt = new System.Windows.Forms.MaskedTextBox();
			this.labelHiddenChange = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.groupSizeNumericUpDown)).BeginInit();
			this.SuspendLayout();
			// 
			// selectPathButton
			// 
			this.selectPathButton.BackColor = System.Drawing.Color.Lime;
			this.selectPathButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
			this.selectPathButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.HotTrack;
			this.selectPathButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.selectPathButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.selectPathButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.selectPathButton.Location = new System.Drawing.Point(7, 58);
			this.selectPathButton.Margin = new System.Windows.Forms.Padding(2);
			this.selectPathButton.Name = "selectPathButton";
			this.selectPathButton.Size = new System.Drawing.Size(180, 31);
			this.selectPathButton.TabIndex = 0;
			this.selectPathButton.UseVisualStyleBackColor = false;
			this.selectPathButton.Click += new System.EventHandler(this.selectPathButtonClick);
			// 
			// labelUnitSize
			// 
			this.labelUnitSize.Font = new System.Drawing.Font("ISOCPEUR", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelUnitSize.Location = new System.Drawing.Point(148, 103);
			this.labelUnitSize.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.labelUnitSize.Name = "labelUnitSize";
			this.labelUnitSize.Size = new System.Drawing.Size(39, 31);
			this.labelUnitSize.TabIndex = 2;
			this.labelUnitSize.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// labelCredit
			// 
			this.labelCredit.Cursor = System.Windows.Forms.Cursors.Hand;
			this.labelCredit.Font = new System.Drawing.Font("ISOCPEUR", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelCredit.Location = new System.Drawing.Point(4, 321);
			this.labelCredit.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.labelCredit.Name = "labelCredit";
			this.labelCredit.Size = new System.Drawing.Size(191, 23);
			this.labelCredit.TabIndex = 3;
			this.labelCredit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.labelCredit.Click += new System.EventHandler(this.labelCreditClick);
			this.labelCredit.MouseEnter += new System.EventHandler(this.labelCreditMouseEnter);
			this.labelCredit.MouseLeave += new System.EventHandler(this.labelCreditMouseLeave);
			// 
			// buttonStartGrouping
			// 
			this.buttonStartGrouping.Enabled = false;
			this.buttonStartGrouping.Font = new System.Drawing.Font("Adobe Arabic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.buttonStartGrouping.Location = new System.Drawing.Point(7, 139);
			this.buttonStartGrouping.Margin = new System.Windows.Forms.Padding(2);
			this.buttonStartGrouping.Name = "buttonStartGrouping";
			this.buttonStartGrouping.Size = new System.Drawing.Size(180, 31);
			this.buttonStartGrouping.TabIndex = 2;
			this.buttonStartGrouping.UseVisualStyleBackColor = true;
			this.buttonStartGrouping.Click += new System.EventHandler(this.buttonStartGroupingClick);
			// 
			// buttonStratExtracting
			// 
			this.buttonStratExtracting.Enabled = false;
			this.buttonStratExtracting.Font = new System.Drawing.Font("Adobe Arabic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.buttonStratExtracting.Location = new System.Drawing.Point(7, 183);
			this.buttonStratExtracting.Margin = new System.Windows.Forms.Padding(2);
			this.buttonStratExtracting.Name = "buttonStratExtracting";
			this.buttonStratExtracting.Size = new System.Drawing.Size(180, 31);
			this.buttonStratExtracting.TabIndex = 3;
			this.buttonStratExtracting.UseVisualStyleBackColor = true;
			this.buttonStratExtracting.Click += new System.EventHandler(this.buttonStratExtractingClick);
			// 
			// labelline1
			// 
			this.labelline1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.labelline1.Location = new System.Drawing.Point(0, 176);
			this.labelline1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.labelline1.Name = "labelline1";
			this.labelline1.Size = new System.Drawing.Size(197, 2);
			this.labelline1.TabIndex = 8;
			// 
			// labelline2
			// 
			this.labelline2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.labelline2.Location = new System.Drawing.Point(0, 220);
			this.labelline2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.labelline2.Name = "labelline2";
			this.labelline2.Size = new System.Drawing.Size(197, 2);
			this.labelline2.TabIndex = 9;
			// 
			// labelline3
			// 
			this.labelline3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.labelline3.Location = new System.Drawing.Point(0, 314);
			this.labelline3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.labelline3.Name = "labelline3";
			this.labelline3.Size = new System.Drawing.Size(197, 2);
			this.labelline3.TabIndex = 10;
			// 
			// buttonStartExtChanger
			// 
			this.buttonStartExtChanger.Enabled = false;
			this.buttonStartExtChanger.Font = new System.Drawing.Font("Adobe Arabic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.buttonStartExtChanger.Location = new System.Drawing.Point(6, 280);
			this.buttonStartExtChanger.Margin = new System.Windows.Forms.Padding(2);
			this.buttonStartExtChanger.Name = "buttonStartExtChanger";
			this.buttonStartExtChanger.Size = new System.Drawing.Size(181, 31);
			this.buttonStartExtChanger.TabIndex = 7;
			this.buttonStartExtChanger.UseVisualStyleBackColor = true;
			this.buttonStartExtChanger.Click += new System.EventHandler(this.buttonStartExtChangerClick);
			// 
			// labelExtFrom
			// 
			this.labelExtFrom.Font = new System.Drawing.Font("Adobe Arabic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.labelExtFrom.ForeColor = System.Drawing.SystemColors.ControlText;
			this.labelExtFrom.Location = new System.Drawing.Point(110, 223);
			this.labelExtFrom.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.labelExtFrom.Name = "labelExtFrom";
			this.labelExtFrom.Size = new System.Drawing.Size(73, 21);
			this.labelExtFrom.TabIndex = 13;
			this.labelExtFrom.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// labelExtTo
			// 
			this.labelExtTo.Font = new System.Drawing.Font("Adobe Arabic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.labelExtTo.Location = new System.Drawing.Point(9, 223);
			this.labelExtTo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.labelExtTo.Name = "labelExtTo";
			this.labelExtTo.Size = new System.Drawing.Size(73, 19);
			this.labelExtTo.TabIndex = 14;
			this.labelExtTo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// groupSizeNumericUpDown
			// 
			this.groupSizeNumericUpDown.BackColor = System.Drawing.SystemColors.ActiveBorder;
			this.groupSizeNumericUpDown.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.groupSizeNumericUpDown.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.groupSizeNumericUpDown.Enabled = false;
			this.groupSizeNumericUpDown.Font = new System.Drawing.Font("ISOCPEUR", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupSizeNumericUpDown.InterceptArrowKeys = false;
			this.groupSizeNumericUpDown.Location = new System.Drawing.Point(9, 102);
			this.groupSizeNumericUpDown.Margin = new System.Windows.Forms.Padding(2);
			this.groupSizeNumericUpDown.Maximum = new decimal(new int[] {
			100000000,
			0,
			0,
			0});
			this.groupSizeNumericUpDown.Minimum = new decimal(new int[] {
			1,
			0,
			0,
			0});
			this.groupSizeNumericUpDown.Name = "groupSizeNumericUpDown";
			this.groupSizeNumericUpDown.Size = new System.Drawing.Size(135, 31);
			this.groupSizeNumericUpDown.TabIndex = 1;
			this.groupSizeNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.groupSizeNumericUpDown.ThousandsSeparator = true;
			this.groupSizeNumericUpDown.Value = new decimal(new int[] {
			650,
			0,
			0,
			0});
			// 
			// labelline4
			// 
			this.labelline4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.labelline4.Location = new System.Drawing.Point(0, 94);
			this.labelline4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.labelline4.Name = "labelline4";
			this.labelline4.Size = new System.Drawing.Size(197, 2);
			this.labelline4.TabIndex = 17;
			// 
			// textBoxPath
			// 
			this.textBoxPath.BackColor = System.Drawing.SystemColors.InfoText;
			this.textBoxPath.Cursor = System.Windows.Forms.Cursors.Hand;
			this.textBoxPath.DetectUrls = false;
			this.textBoxPath.Enabled = false;
			this.textBoxPath.Font = new System.Drawing.Font("ISOCPEUR", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxPath.ForeColor = System.Drawing.Color.Red;
			this.textBoxPath.Location = new System.Drawing.Point(7, 13);
			this.textBoxPath.Name = "textBoxPath";
			this.textBoxPath.ReadOnly = true;
			this.textBoxPath.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
			this.textBoxPath.Size = new System.Drawing.Size(180, 40);
			this.textBoxPath.TabIndex = 18;
			this.textBoxPath.TabStop = false;
			this.textBoxPath.ZoomFactor = 1.1F;
			this.textBoxPath.Click += new System.EventHandler(this.TextBoxPathClick);
			// 
			// checkBoxFromExtEnabler
			// 
			this.checkBoxFromExtEnabler.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
			| System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.checkBoxFromExtEnabler.BackColor = System.Drawing.SystemColors.ActiveBorder;
			this.checkBoxFromExtEnabler.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.checkBoxFromExtEnabler.Checked = true;
			this.checkBoxFromExtEnabler.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBoxFromExtEnabler.Cursor = System.Windows.Forms.Cursors.Hand;
			this.checkBoxFromExtEnabler.Enabled = false;
			this.checkBoxFromExtEnabler.Font = new System.Drawing.Font("Adobe Arabic", 1.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.checkBoxFromExtEnabler.ForeColor = System.Drawing.SystemColors.ButtonShadow;
			this.checkBoxFromExtEnabler.Location = new System.Drawing.Point(110, 225);
			this.checkBoxFromExtEnabler.Name = "checkBoxFromExtEnabler";
			this.checkBoxFromExtEnabler.Size = new System.Drawing.Size(18, 19);
			this.checkBoxFromExtEnabler.TabIndex = 4;
			this.checkBoxFromExtEnabler.UseVisualStyleBackColor = false;
			this.checkBoxFromExtEnabler.CheckedChanged += new System.EventHandler(this.CheckBoxFromExtEnablerCheckedChanged);
			// 
			// maskedTextBoxFromExt
			// 
			this.maskedTextBoxFromExt.BeepOnError = true;
			this.maskedTextBoxFromExt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.maskedTextBoxFromExt.Culture = new System.Globalization.CultureInfo("en-US");
			this.maskedTextBoxFromExt.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludePrompt;
			this.maskedTextBoxFromExt.Enabled = false;
			this.maskedTextBoxFromExt.Font = new System.Drawing.Font("ISOCPEUR", 14F);
			this.maskedTextBoxFromExt.HidePromptOnLeave = true;
			this.maskedTextBoxFromExt.Location = new System.Drawing.Point(110, 244);
			this.maskedTextBoxFromExt.Mask = ".AAAAAA";
			this.maskedTextBoxFromExt.Name = "maskedTextBoxFromExt";
			this.maskedTextBoxFromExt.PromptChar = ' ';
			this.maskedTextBoxFromExt.ShortcutsEnabled = false;
			this.maskedTextBoxFromExt.Size = new System.Drawing.Size(73, 30);
			this.maskedTextBoxFromExt.TabIndex = 5;
			this.maskedTextBoxFromExt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// maskedTextBoxToExt
			// 
			this.maskedTextBoxToExt.BeepOnError = true;
			this.maskedTextBoxToExt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.maskedTextBoxToExt.Culture = new System.Globalization.CultureInfo("en-US");
			this.maskedTextBoxToExt.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludePrompt;
			this.maskedTextBoxToExt.Enabled = false;
			this.maskedTextBoxToExt.Font = new System.Drawing.Font("ISOCPEUR", 14F);
			this.maskedTextBoxToExt.HidePromptOnLeave = true;
			this.maskedTextBoxToExt.Location = new System.Drawing.Point(9, 244);
			this.maskedTextBoxToExt.Mask = ".AAAAAA";
			this.maskedTextBoxToExt.Name = "maskedTextBoxToExt";
			this.maskedTextBoxToExt.PromptChar = ' ';
			this.maskedTextBoxToExt.ShortcutsEnabled = false;
			this.maskedTextBoxToExt.Size = new System.Drawing.Size(73, 30);
			this.maskedTextBoxToExt.TabIndex = 19;
			this.maskedTextBoxToExt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// labelHiddenChange
			// 
			this.labelHiddenChange.Font = new System.Drawing.Font("Adobe Arabic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.labelHiddenChange.Location = new System.Drawing.Point(9, 245);
			this.labelHiddenChange.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.labelHiddenChange.Name = "labelHiddenChange";
			this.labelHiddenChange.Size = new System.Drawing.Size(96, 27);
			this.labelHiddenChange.TabIndex = 20;
			this.labelHiddenChange.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.labelHiddenChange.Visible = false;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(5F, 14F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveBorder;
			this.ClientSize = new System.Drawing.Size(195, 351);
			this.Controls.Add(this.maskedTextBoxToExt);
			this.Controls.Add(this.maskedTextBoxFromExt);
			this.Controls.Add(this.checkBoxFromExtEnabler);
			this.Controls.Add(this.textBoxPath);
			this.Controls.Add(this.labelline4);
			this.Controls.Add(this.groupSizeNumericUpDown);
			this.Controls.Add(this.labelExtTo);
			this.Controls.Add(this.labelExtFrom);
			this.Controls.Add(this.buttonStartExtChanger);
			this.Controls.Add(this.labelline3);
			this.Controls.Add(this.labelline2);
			this.Controls.Add(this.labelline1);
			this.Controls.Add(this.buttonStratExtracting);
			this.Controls.Add(this.buttonStartGrouping);
			this.Controls.Add(this.labelCredit);
			this.Controls.Add(this.labelUnitSize);
			this.Controls.Add(this.selectPathButton);
			this.Controls.Add(this.labelHiddenChange);
			this.Cursor = System.Windows.Forms.Cursors.Arrow;
			this.Font = new System.Drawing.Font("Adobe Arabic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(2);
			this.MaximizeBox = false;
			this.Name = "MainForm";
			((System.ComponentModel.ISupportInitialize)(this.groupSizeNumericUpDown)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
		

	}
}

