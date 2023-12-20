/*
 * User: Armin
 * Date: 11/21/2023
 * Time: 08:39 ب.ظ
 */
using System;
using System.Windows.Forms;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using System.Diagnostics;

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
		
		void EnableControls()
		{
			textBoxPath.Text = folderBrowserDialog1.SelectedPath;
			textBoxPath.ForeColor = System.Drawing.Color.LightSkyBlue;
			buttonStartGrouping.Enabled = true;
			textBoxPath.Enabled = true;
			buttonStratExtracting.Enabled = true;
			buttonStartExtChanger.Enabled = true;
			groupSizeNumericUpDown.Enabled = true;
			checkBoxFromExtEnabler.Enabled = true;
			maskedTextBoxFromExt.Enabled = true;
			maskedTextBoxToExt.Enabled = true;
		}
		
		void Enable_DisableFromExt(bool enable_or_disable)
		{
			maskedTextBoxFromExt.Enabled = enable_or_disable;
			maskedTextBoxFromExt.Visible = enable_or_disable;
			labelExtFrom.Visible = enable_or_disable;
		}
		
		void Success(string type,string path)
		{
			MessageBox.Show(type);
			Process.Start(path);
		}
		
		bool Conformation (string path,string operation)
		{
			var dialogResult = MessageBox.Show(appLang.ConfirmFirstpart+operation+appLang.ConfirmSecondpart+"\n\n"+path,operation,MessageBoxButtons.YesNo,MessageBoxIcon.Question);
			return dialogResult==DialogResult.Yes;
		}
		
		long RemoveThousendSeprator (string number)
		{
			string newNumber = number.Replace(",","");
			long result = Convert.ToInt64(newNumber);
			return result;
		}
		
		//Events
		
		void selectPathButtonClick(object sender, EventArgs e)
		{
			folderBrowserDialog1.ShowDialog();
			var selectedPath = folderBrowserDialog1.SelectedPath;
			if (!String.IsNullOrWhiteSpace(selectedPath))
			{
				EnableControls();
			}
		}

		
		void buttonStartGroupingClick(object sender, EventArgs e)
		{
			var path = folderBrowserDialog1.SelectedPath;
			if(!Conformation(path,appLang.OperationGrouping)) return;
			try
			{
				long groupSize = RemoveThousendSeprator(groupSizeNumericUpDown.Text);
				var groupedFiles = new FileGrouper(path,groupSize).GetGroups(false);
				DirectoryInfo[] directories;
				FolderUtility.CreateSeriesOfFolders(path,groupedFiles.Count(),false,out directories);
				FileUtility.MoveFiles(directories,groupedFiles);
				FolderUtility.AddSizeToFoldersName(directories,ESizeUnit.MegaByte,2);
				Success(appLang.GroupingSuccess,path);
			}
			catch(Exception exc)
			{
				MessageBox.Show(appLang.Error+exc.Message);
			}
		}
		
		void buttonStratExtractingClick(object sender, EventArgs e)
		{
			var path = folderBrowserDialog1.SelectedPath;
			if(!Conformation(path,appLang.OperationExtraction)) return;
			try
			{
				var dirs = FolderUtility.GetSubDirectories(path);
				FileUtility.MoveFiles(path,dirs);
				FolderUtility.DeleteFolders(dirs);
				Success(appLang.ExtractSuccess,path);
			}
			catch(Exception exc)
			{
				MessageBox.Show(appLang.Error+exc.Message);
			}
		}
		
		void buttonStartExtChangerClick(object sender, EventArgs e)
		{
			var path = folderBrowserDialog1.SelectedPath;
			if(!Conformation(path,appLang.OperationExtChange)) return;
			try
			{
				var toExt = maskedTextBoxToExt.Text;
				var fromExt = "*.*";
				if (checkBoxFromExtEnabler.Checked) fromExt = "*"+maskedTextBoxFromExt.Text;
				FileInfo[] files = FolderUtility.GetFilesFromFolder(path,true,fromExt);
				FileUtility.ChangeFilesExtension(files,toExt);
				Success(appLang.ExtchangeSuccess,path);
			}
			catch(Exception exc)
			{
				MessageBox.Show(appLang.Error+exc.Message);
			}
		}
		
		void labelCreditClick(object sender, EventArgs e)
		{
			MessageBox.Show(appLang.ContactInfo);
		}
		
		void TextBoxPathClick(object sender, EventArgs e)
		{
            try
            {
				Process.Start(textBoxPath.Text);
            }
			catch(Exception exc)
			{
				MessageBox.Show(appLang.Error+exc.Message);
			}
			
		}
		void labelCreditMouseEnter(object sender, EventArgs e)
		{
			labelCredit.ForeColor = System.Drawing.Color.Red;
		}
		void labelCreditMouseLeave(object sender, EventArgs e)
		{
			labelCredit.ForeColor = System.Drawing.SystemColors.ControlText;
		}
		void CheckBoxFromExtEnablerCheckedChanged(object sender, EventArgs e)
		{
			CheckBox tmp = sender as CheckBox;
			Enable_DisableFromExt(tmp.Checked);
		}
}
}
