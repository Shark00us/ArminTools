using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace ArminTools
{

    /// <summary>
    /// Description of MainForm.
    /// </summary>

    public partial class MainForm : Form
    {

        private ILanguage appLang = Program.ApplicationLanguage;

        public MainForm()
        {
            InitializeComponent();
            SetControlTexts();
            SetFont();
            IsRTL(appLang.RTL);
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
            Text = appLang.FormName;
            buttonSelectPath.Text = appLang.SelectPath;
            labelUnitSize.Text = appLang.SizeUnit;
            labelCredit.Text = appLang.Creator;
            buttonStartGrouping.Text = appLang.StartGrouping;
            buttonStratExtracting.Text = appLang.StartExtracting;
            buttonStartExtChanger.Text = appLang.StartExtChanging;
            labelExtFrom.Text = appLang.ExtFrom;
            labelExtTo.Text = appLang.ExtTo;
            textBoxPath.Text = appLang.PathPlaceholder;
            labelHiddenChange.Text = appLang.ExtHiddenChange;
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
            MessageBox.Show(type);
            Process.Start(path);
        }

        private bool Conformation(string path, string operation)
        {
            var dialogResult = MessageBox.Show(string.Format("{0}{1}{2}\n\n{3}", appLang.ConfirmFirstpart, operation, appLang.ConfirmSecondpart, path), operation, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            return dialogResult == DialogResult.Yes;
        }

        private long RemoveThousandSeparator(string number)
        {
            string newNumber = number.Replace(",", "");
            long result = Convert.ToInt64(newNumber);
            return result;
        }

        private void IsRTL(bool isRTL)
        {
            if (!isRTL) return;
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
                cntrl.Font = appLang.Font;
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
            Enable_DisableFromExt(tmp.Checked);
        }
        private void ControlMouseEnterorLeave(object sender, EventArgs e)
        {
            var senderControl = sender as Control;
            var oldBackColor = senderControl.BackColor;
            senderControl.BackColor = senderControl.ForeColor;
            senderControl.ForeColor = oldBackColor;
        }

        private void selectPathButtonClick(object sender, EventArgs e)
        {
            folderBrowserDialog.ShowDialog();
            var selectedPath = folderBrowserDialog.SelectedPath;
            if (!string.IsNullOrWhiteSpace(selectedPath))
            {
                EnableControls();
            }
        }


        private void buttonStartGroupingClick(object sender, EventArgs e)
        {
            var path = folderBrowserDialog.SelectedPath;
            if (!Conformation(path, appLang.OperationGrouping)) return;
            try
            {
                long groupSize = RemoveThousandSeparator(groupSizeNumericUpDown.Text);
                var groupedFiles = new FileGrouper(path, groupSize).GetGroups(false);
                DirectoryInfo[] directories;
                FolderUtility.CreateSeriesOfFolders(path, groupedFiles.Count(), false, out directories);
                FileUtility.MoveFiles(directories, groupedFiles);
                FolderUtility.AddSizeToFoldersName(directories, ESizeUnit.MegaByte, 2);
                Success(appLang.GroupingSuccess, path);
            }
            catch (Exception exc)
            {
                MessageBox.Show(appLang.Error + exc.Message);
            }
        }

        private void buttonStratExtractingClick(object sender, EventArgs e)
        {
            var path = folderBrowserDialog.SelectedPath;
            if (!Conformation(path, appLang.OperationExtraction)) return;
            try
            {
                var dirs = FolderUtility.GetSubDirectories(path);
                FileUtility.MoveFiles(path, dirs);
                FolderUtility.DeleteFolders(dirs);
                Success(appLang.ExtractSuccess, path);
            }
            catch (Exception exc)
            {
                MessageBox.Show(appLang.Error + exc.Message);
            }
        }

        private void buttonStartExtChangerClick(object sender, EventArgs e)
        {
            var path = folderBrowserDialog.SelectedPath;
            if (!Conformation(path, appLang.OperationExtChange)) return;
            try
            {
                var toExt = maskedTextBoxToExt.Text;
                var fromExt = "*.*";
                if (checkBoxFromExtEnabler.Checked) fromExt = string.Format("*{0}", maskedTextBoxFromExt.Text);
                FileInfo[] files = FolderUtility.GetFilesFromFolder(path, true, fromExt);
                FileUtility.ChangeFilesExtension(files, toExt);
                Success(appLang.ExtchangeSuccess, path);
            }
            catch (Exception exc)
            {
                MessageBox.Show(appLang.Error + exc.Message);
            }
        }

        private void labelCreditClick(object sender, EventArgs e)
        {
            MessageBox.Show(appLang.ContactInfo, appLang.Creator, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void TextBoxPathClick(object sender, EventArgs e)
        {
            try
            {
                Process.Start(textBoxPath.Text);
            }
            catch (Exception exc)
            {
                MessageBox.Show(appLang.Error + exc.Message);
            }

        }


    }
}
