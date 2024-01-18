using ArminTools.CoreClasses;
using ArminTools.SubClasses.Languages;
using ArminTools.SubClasses.SizeUnit;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ArminTools.UtilityClasses
{
    /// <summary>
    /// Description of FolderUtility.
    /// </summary>
    public static class FolderUtility
    {
        private static ILanguage appLang = Program.ApplicationLanguage;

        public static FileInfo[] GetFilesFromFolder(DirectoryInfo folder, bool orderFilesBySizeDecending = true, string pattern = "*.*")
        {
            var files = folder.GetFiles(pattern).ToArray();
            if (orderFilesBySizeDecending) files = files.OrderByDescending(file => files.Length).ToArray();
            return files;
        }

        public static FileInfo[] GetFilesFromFolder(string path, bool orderFilesBySizeDecending = true, string pattern = "*.*")
        {
            FileUtility.CheckPathNullOrEmpty(path);
            var folder = new DirectoryInfo(path);
            var result = GetFilesFromFolder(folder, orderFilesBySizeDecending, pattern);
            return result;
        }


        public static void CreateSeriesOfFolders(string path, int folderCount, bool charInsteadOfNumber, out DirectoryInfo[] createdDirectoires, string preFix = "", string postFix = "")
        {
            FileUtility.CheckPathNullOrEmpty(path);
            if (folderCount < 1) throw new IndexOutOfRangeException();

            char folderName = '1';
            if (charInsteadOfNumber)
            {
                folderName = 'A';
            }

            List<DirectoryInfo> createdFolders = new List<DirectoryInfo>();

            for (int i = 0; i < folderCount; i++)
            {
                var thisFolderName = Path.Combine(path, preFix + folderName + postFix);
                var createdFolder = Directory.CreateDirectory(thisFolderName);
                createdFolders.Add(createdFolder);
                folderName++;
            }
            //out Parameter Assignment
            createdDirectoires = createdFolders.ToArray(); 

        }
        public static DirectoryInfo[] GetSubDirectories(string path)
        {
            FileUtility.CheckPathNullOrEmpty(path);
            DirectoryInfo root = new DirectoryInfo(path);
            return GetSubDirectories(root.GetDirectories());
        }
        
        public static DirectoryInfo[] GetSubDirectories(DirectoryInfo[] directoryInfos)
        {
            var result = directoryInfos.ToList();
            foreach (var directory in directoryInfos)
            {
                result.AddRange(GetSubDirectories(directory.GetDirectories()));
            }
            return result.ToArray();
        }

        public static void DeleteFolders(DirectoryInfo[] folders)
        {
            if (folders == null) throw new NullReferenceException(appLang.ErrorFileFolderNull);
            folders = folders.Reverse().ToArray();
            foreach (var folder in folders)
            {
                folder.Delete();
            }
        }

        public static ByteUnit GetDirectorySizeAsByte(DirectoryInfo folder)
        {
            FileInfo[] files = GetFilesFromFolder(folder);
            long totalSize = 0;
            foreach (var file in files)
            {
                totalSize += file.Length;
            }
            return new ByteUnit(totalSize);
        }

        public static void AddSizeToFoldersName(DirectoryInfo[] folders, ESizeUnit typeOfSizeUnit, int decimals = -1)
        {
            if (folders == null) throw new NullReferenceException(appLang.ErrorFileFolderNull);
            var sizeUnitForAbv = SizeUnit.SizeUnitBuilder(typeOfSizeUnit);
            string postFix = sizeUnitForAbv.Abbreviation;

            foreach (var folder in folders)
            {
                var folderSizeAsByte = GetDirectorySizeAsByte(folder);
                var finalSizeUnit = SizeUnit.SizeUnitBuilder(typeOfSizeUnit, folderSizeAsByte.Size());
                folder.MoveTo(folder.FullName + " ( " + finalSizeUnit.Size(decimals) + " " + postFix + " ) ");
            }
        }



    }
}
