using ArminTools.CoreClasses;
using ArminTools.SubClasses.Languages;
using ArminTools.SubClasses.SizeUnit;
using ArminTools.UtilityClasses;
using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace ArminTools.FormClasses
{

    /// <summary>
    /// Description of MainForm.
    /// </summary>

    public partial class MainForm : Form
    {

        private readonly ILanguage _appLang = Program.ApplicationLanguage;

        public MainForm()
        {
            InitializeComponent();
            SetControlTexts();
            SetFont();
            IsRtl(_appLang.RTL);
        }

        //Methods

        private void EnableControls()
        {
            textBoxPath.Text = folderBrowserDialog.SelectedPath;

            buttonStartGrouping.Enabled = true;
            textBoxPath.Enabled = true;
            buttonStratExtracting.Enabled = true;
            buttonStartExtChanger.Enabled = true;
            groupSizeNumericUpDown.Enabled = true;
            checkBoxFromExtEnabler.Enabled = true;
            maskedTextBoxFromExt.Enabled = true;
            maskedTextBoxToExt.Enabled = true;

            textBoxPath.ForeColor = Color.LightSkyBlue;
            buttonSelectPath.BackColor = SystemColors.Window;
            var buttonGreen = Color.MediumSpringGreen;
            buttonStartExtChanger.BackColor = buttonGreen;
            buttonStartGrouping.BackColor = buttonGreen;
            buttonStratExtracting.BackColor = buttonGreen;
        }

        private void SetControlTexts()
        {
            Text = _appLang.FormName;
            buttonSelectPath.Text = _appLang.SelectPath;
            labelUnitSize.Text = _appLang.SizeUnit;
            labelCredit.Text = _appLang.Creator;
            buttonStartGrouping.Text = _appLang.StartGrouping;
            buttonStratExtracting.Text = _appLang.StartExtracting;
            buttonStartExtChanger.Text = _appLang.StartExtChanging;
            labelExtFrom.Text = _appLang.ExtFrom;
            labelExtTo.Text = _appLang.ExtTo;
            textBoxPath.Text = _appLang.PathPlaceholder;
            labelHiddenChange.Text = _appLang.ExtHiddenChange;
            folderBrowserDialog.Description = _appLang.SelectPath;
        }

        private void Enable_DisableFromExt(bool enableOrDisable)
        {
            maskedTextBoxFromExt.Enabled = enableOrDisable;
            labelExtTo.Visible = enableOrDisable;
            labelHiddenChange.Visible = !enableOrDisable;
            maskedTextBoxFromExt.Clear();
            if (enableOrDisable) labelExtFrom.ForeColor = SystemColors.ControlText;
            else labelExtFrom.ForeColor = SystemColors.ControlDark;
        }

        private void Success(string type, string path)
        {
            MessageBox.Show(type, _appLang.Success, MessageBoxButtons.OK, MessageBoxIcon.Information);
            Process.Start(path);
        }

        private bool Conformation(string path, string operation)
        {
            var dialogResult = MessageBox.Show(string.Format("{0}{1}{2}\n\n{3}", _appLang.ConfirmFirstpart, operation, _appLang.ConfirmSecondpart, path), operation, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            return dialogResult == DialogResult.Yes;
        }

        private long RemoveThousandSeparator(string number)
        {
            string newNumber = number.Replace(",", "");
            long result = Convert.ToInt64(newNumber);
            return result;
        }

        private void IsRtl(bool isRtl)
        {
            if (!isRtl) return;
            Control[] controls =
            {
                checkBoxFromExtEnabler,
                maskedTextBoxFromExt,
                maskedTextBoxToExt,
                labelExtFrom,
                labelExtTo,
                labelHiddenChange
            };
            foreach (Control cntrl in controls)
            {
                cntrl.Left = 200 - (cntrl.Left + cntrl.Size.Width);
            }
        }

        private void SetFont()
        {
            Control[] controls =
            {
                labelExtFrom,
                labelExtTo,
                labelHiddenChange,
                buttonStratExtracting,
                buttonSelectPath,
                buttonStartGrouping,
                buttonStartExtChanger,
                labelCredit
            };
            foreach (Control cntrl in controls)
            {
                cntrl.Font = _appLang.Font;
                AdjustControlFontSize(cntrl);
            }
        }

        private int ControlTextLengthInPx(Control cntrl)
        {
            return TextRenderer.MeasureText(cntrl.Text, cntrl.Font).Width;
        }

        private void AdjustControlFontSize(Control cntrl, int pad = 10, float step = 1.5f)
        {
            while (cntrl.Width - pad < ControlTextLengthInPx(cntrl))
            {
                cntrl.Font = new Font(cntrl.Font.FontFamily, cntrl.Font.Size - step, cntrl.Font.Style);
            }
        }
        //Events

        private void CheckBoxFromExtEnablerCheckedChanged(object sender, EventArgs e)
        {
            CheckBox tmp = sender as CheckBox;
            Enable_DisableFromExt(tmp != null && tmp.Checked);
        }
        private void ControlMouseEnterorLeave(object sender, EventArgs e)
        {
            var senderControl = sender as Control;
            if (senderControl != null)
            {
                var oldBackColor = senderControl.BackColor;
                senderControl.BackColor = senderControl.ForeColor;
                senderControl.ForeColor = oldBackColor;
            }
        }

        private void SelectPathButtonClick(object sender, EventArgs e)
        {
            folderBrowserDialog.ShowDialog();
            var selectedPath = folderBrowserDialog.SelectedPath;
            if (!string.IsNullOrWhiteSpace(selectedPath))
            {
                EnableControls();
            }
        }


        private void ButtonStartGroupingClick(object sender, EventArgs e)
        {
            var path = folderBrowserDialog.SelectedPath;
            if (!Conformation(path, _appLang.OperationGrouping)) return;
            try
            {
                long groupSize = RemoveThousandSeparator(groupSizeNumericUpDown.Text);
                var groupedFiles = new FileGrouper(path, groupSize).GetGroups(false);
                DirectoryInfo[] directories;
                FolderUtility.CreateSeriesOfFolders(path, groupedFiles.Count(), false, out directories);
                FileUtility.MoveFiles(directories, groupedFiles);
                FolderUtility.AddSizeToFoldersName(directories, ESizeUnit.MegaByte, 2);
                Success(_appLang.GroupingSuccess, path);
            }
            catch (Exception exc)
            {
                MessageBox.Show(_appLang.Error + exc.Message);
            }
        }

        private void ButtonStratExtractingClick(object sender, EventArgs e)
        {
            var path = folderBrowserDialog.SelectedPath;
            if (!Conformation(path, _appLang.OperationExtraction)) return;
            try
            {
                var dirs = FolderUtility.GetSubDirectories(path);
                FileUtility.MoveFiles(path, dirs);
                FolderUtility.DeleteFolders(dirs);
                Success(_appLang.ExtractSuccess, path);
            }
            catch (Exception exc)
            {
                MessageBox.Show(_appLang.Error + exc.Message);
            }
        }

        private void ButtonStartExtChangerClick(object sender, EventArgs e)
        {
            var path = folderBrowserDialog.SelectedPath;
            if (!Conformation(path, _appLang.OperationExtChange)) return;
            try
            {
                var toExt = maskedTextBoxToExt.Text;
                var fromExt = "*.*";
                if (checkBoxFromExtEnabler.Checked) fromExt = string.Format("*{0}", maskedTextBoxFromExt.Text);
                FileInfo[] files = FolderUtility.GetFilesFromFolder(path, true, fromExt);
                FileUtility.ChangeFilesExtension(files, toExt);
                Success(_appLang.ExtchangeSuccess, path);
            }
            catch (Exception exc)
            {
                MessageBox.Show(_appLang.Error + exc.Message);
            }
        }

        private void LabelCreditClick(object sender, EventArgs e)
        {
            MessageBox.Show(_appLang.ContactInfo, _appLang.Creator, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void TextBoxPathClick(object sender, EventArgs e)
        {
            try
            {
                Process.Start(textBoxPath.Text);
            }
            catch (Exception exc)
            {
                MessageBox.Show(_appLang.Error + exc.Message);
            }

        }


    }
}
