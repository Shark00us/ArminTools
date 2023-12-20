/*
 * User: Armin
 * Date: 12/05/2023
 * Time: 09:06 ب.ظ
 */
using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace ArminTools
{
	/// <summary>
	/// Description of FolderUtility.
	/// </summary>
	public static class FolderUtility
	{
		private static ILanguage appLang = Program.ApplicationLanguage;
		
		public static FileInfo[] GetFilesFromFolder(DirectoryInfo folder,bool orderFilesBySizeDecending = true,string pattern = "*.*")
		{
			var files = folder.GetFiles(pattern).ToArray();
			if (orderFilesBySizeDecending) files = files.OrderByDescending(file=>files.Length).ToArray();
			return files;
		}
		
		public static FileInfo[] GetFilesFromFolder(string path,bool orderFilesBySizeDecending = true,string pattern = "*.*")
		{
			FileUtility.CheckPathNullorEmpty(path);
			var folder = new DirectoryInfo(path);
			var result = GetFilesFromFolder(folder,orderFilesBySizeDecending,pattern);
			return result;
		}
		

		public static void CreateSeriesOfFolders(string path,int folderCount,bool charInsteadOfNumber,out DirectoryInfo[] createdDirectoires,string preFix = "",string postFix = "")
		{
			FileUtility.CheckPathNullorEmpty(path);
			if(folderCount<1) throw new IndexOutOfRangeException();
			
			char folderName = '1';
			if (charInsteadOfNumber)
			{
				folderName = 'A';
			}
			
			List<DirectoryInfo> createdFolders = new List<DirectoryInfo>();
			
			for (int i=0;i<folderCount;i++)
			{
				var thisFolderName = Path.Combine(path,preFix+folderName.ToString()+postFix);
        		var createdFolder = Directory.CreateDirectory(thisFolderName);
        		createdFolders.Add(createdFolder);
        		folderName++;
			}
			
			createdDirectoires = createdFolders.ToArray(); //out Parameter Assignment
			
		}
		public static DirectoryInfo[] GetSubDirectories (string path)
		{
			FileUtility.CheckPathNullorEmpty(path);
			DirectoryInfo root = new DirectoryInfo(path);
			string[] subDirectories = Directory.GetDirectories(root.FullName);
			List<DirectoryInfo> result = new List<DirectoryInfo>();
			foreach (var dir in subDirectories)
        	{
				var tempDirectory = new DirectoryInfo(dir);
				result.Add(tempDirectory);
			}
			return result.ToArray();
		}
		
		public static void DeleteFolders (DirectoryInfo[] folders)
		{
			if (folders == null) throw new NullReferenceException(appLang.ErrorFileFolderNull);
			foreach(var folder in folders)
			{
				folder.Delete();
			}
		}
		
    	public static ByteUnit GetDirectorySizeAsByte(DirectoryInfo folder)
    	{
    		FileInfo[] files = FolderUtility.GetFilesFromFolder(folder);
        	long totalSize = 0;
        	foreach (var file in files)
        	{
          		  totalSize += file.Length;
      		}
        	return new ByteUnit(totalSize);
    	}
		
		public static void AddSizeToFoldersName (DirectoryInfo[] folders,ESizeUnit typeOfSizeUnit,int decimals = -1)
		{
			if (folders == null) throw new NullReferenceException(appLang.ErrorFileFolderNull);
			var sizeUnitForAbv = SizeUnit.SizeUnitBuilder(typeOfSizeUnit);
			string postFix = sizeUnitForAbv.Abbreviation;

			foreach(var folder in folders)
			{
				var folderSizeAsByte = GetDirectorySizeAsByte(folder);
				var finalSizeUnit = SizeUnit.SizeUnitBuilder(typeOfSizeUnit,folderSizeAsByte.Size());
				folder.MoveTo(folder.FullName+" ( "+finalSizeUnit.Size(decimals)+" "+postFix+" ) ");
			}
		}
		
	
		
	}
}
