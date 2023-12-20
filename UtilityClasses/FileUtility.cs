/*
 * User: Armin
 * Date: 11/30/2023
 * Time: 07:50 ب.ظ
 */
using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;

namespace ArminTools
{
	/// <summary>
	/// Description of FileUtility.
	/// </summary>
	public static class FileUtility
	{
		private static ILanguage appLang = Program.ApplicationLanguage;
		
		public static void CheckPathNullorEmpty(string path)
		{
			if (String.IsNullOrWhiteSpace(path)) throw new NullReferenceException(appLang.ErrorEmptyPath);
		}
		
		public static void MoveFiles (string path,List<FileInfo> files)
		{
			CheckPathNullorEmpty(path);
        	foreach(var fle in files)
        	{
        		fle.MoveTo(path+@"\"+fle.Name);
        	}
		}
		
		public static void MoveFiles (string path,DirectoryInfo[] folders)
		{
			List<FileInfo> allFiles = new List<FileInfo>();
        	foreach(var dir in folders)
        	{
        		var files = dir.GetFiles();
        		allFiles.AddRange(files);
        	}
        	MoveFiles(path,allFiles);
		}
		
		public static void MoveFiles (DirectoryInfo [] folders,List<List<FileInfo>> files)
		{
			if (folders == null || files == null) throw new IndexOutOfRangeException(appLang.ErrorFileFolderNull);
			if (folders.Count() != files.Count()) throw new IndexOutOfRangeException(appLang.ErrorFileFolderMismatch);
			var filesAsArray = files.ToArray();
			for(int i = 0 ; i < files.Count() ; i++)
			{
				MoveFiles(folders[i].FullName,filesAsArray[i]);
			}
		}
		
		public static void ChangeFilesExtension (FileInfo[] files,string extension)
		{
			foreach (var file in files)
        		{
					File.Move(file.FullName, Path.ChangeExtension(file.FullName, extension));
     	    	}	
		}
		

	}
}
