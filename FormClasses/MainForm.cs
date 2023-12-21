/*
 * User: Armin
 * Date: 11/21/2023
 * Time: 08:39 ب.ظ
 */
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
        }

        //Methods

        private void EnableControls()
        {
            textBoxPath.Text = folderBrowserDialog.SelectedPath;
            ///
            buttonStartGrouping.Enabled = true;
            textBoxPath.Enabled = true;
            buttonStratExtracting.Enabled = true;
            buttonStartExtChanger.Enabled = true;
            groupSizeNumericUpDown.Enabled = true;
            checkBoxFromExtEnabler.Enabled = true;
            maskedTextBoxFromExt.Enabled = true;
            maskedTextBoxToExt.Enabled = true;
            /// Color Change
            textBoxPath.ForeColor = Color.LightSkyBlue;
            buttonSelectPath.BackColor = SystemColors.Window;
            buttonStartExtChanger.BackColor = Color.CornflowerBlue;
            buttonStartGrouping.BackColor = Color.Tomato;
            buttonStratExtracting.BackColor = Color.Yellow;
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

        //Events

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
                FolderUtility.CreateSeriesOfFolders(path, groupedFiles.Count(), false, out var directories);
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
                if (checkBoxFromExtEnabler.Checked) fromExt = "*" + maskedTextBoxFromExt.Text;
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

        private void labelCreditMouseEnter(object sender, EventArgs e)
        {
            labelCredit.ForeColor = System.Drawing.Color.Red;
        }

        private void labelCreditMouseLeave(object sender, EventArgs e)
        {
            labelCredit.ForeColor = System.Drawing.SystemColors.ControlText;
        }

        private void CheckBoxFromExtEnablerCheckedChanged(object sender, EventArgs e)
        {
            CheckBox tmp = sender as CheckBox;
            Enable_DisableFromExt(tmp.Checked);
        }
        private void ControlMouseEnter(object sender, EventArgs e)
        {
            var senderControl = sender as Control;
            var oldBackColor = senderControl.BackColor;
            senderControl.BackColor = senderControl.ForeColor;
            senderControl.ForeColor = oldBackColor;
        }
        private void ControlMouseLeave(object sender, EventArgs e)
        {
            var senderControl = sender as Control;
            var oldForeColor = senderControl.ForeColor;
            senderControl.ForeColor = senderControl.BackColor;
            senderControl.BackColor = oldForeColor;
        }
    }
}
