/*
 * User: Armin
 * Date: 11/30/2023
 * Time: 07:26 ب.ظ
 */
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ArminTools
{
	/// <summary>
	/// Description of FileGrouper.
	/// </summary>
	public class FileGrouper
	{
		private static ILanguage appLang = Program.ApplicationLanguage;
		private string _path;
		private long _groupSize;
		public string Path {get {return this._path;}}
		public long GroupSize {get {return this._groupSize;}}
		
		public FileGrouper(string path,long groupsize)
		{
			FileUtility.CheckPathNullorEmpty(path);
			if (groupsize < 1) throw new InvalidOperationException(appLang.ErrorGroupSize);
			this._path = path;
			this._groupSize = groupsize * 1048576;
		}
		
		public List<List<FileInfo>> GetGroups(bool includeEmptyGroups)
		{
			var files = FolderUtility.GetFilesFromFolder(this.Path);
			List<List<FileInfo>> groups = new List<List<FileInfo>>();
			if(includeEmptyGroups) groups = DoGrouping(files,this.GroupSize,true);
		    else groups = DoGrouping(files,this.GroupSize,false);
			return groups;
		}
		
		private List<List<FileInfo>> DoGrouping(FileInfo[] files,long groupSize,bool includeEmptyGroups)
		{
			var groupedfiles = files.Aggregate(
    											new List<List<FileInfo>>(),
    											(groups, file) => {
      		  														 List<FileInfo> group = groups.FirstOrDefault(g => g.Sum(f => f.Length) + file.Length <= groupSize);
       															 
       																 if (group == null) 
       																 {
           																 group = new List<FileInfo>();
            															 groups.Add(group);
        															 }
       																 if (file.Length <= groupSize)
       																 {
       																 	 group.Add(file);
       																 }

       		return groups;
    										  });
			if(!includeEmptyGroups)
			{
				groupedfiles = groupedfiles.Where(group=> group.Any()).ToList();
			}
			return groupedfiles;
			
		}

	}
}
