using ArminTools.CoreClasses;
using ArminTools.SubClasses.Languages;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ArminTools.UtilityClasses
{
    /// <summary>
    /// Description of FileUtility.
    /// </summary>
    public static class FileUtility
    {
        private static readonly ILanguage appLang = Program.ApplicationLanguage;

        public static void CheckPathNullOrEmpty(string path)
        {
            if (string.IsNullOrWhiteSpace(path)) throw new ArgumentNullException(appLang.ErrorEmptyPath);
        }
        private static string ModifyFileNameForDuplicateFiles(string path,FileInfo file,int loopCount)
        {
            CheckPathNullOrEmpty(Path.GetDirectoryName(file.FullName));
            string newFileName = string.Format(" Copy({0})",loopCount);
            return Path.Combine(path,
                Path.GetFileNameWithoutExtension(file.Name) + newFileName + file.Extension);
        }
        private static void MoveFiles(string path, List<FileInfo> files)
        {
            CheckPathNullOrEmpty(path);
            foreach (var fle in files)
            {
                int loopCount = 1;
                var destinationFilePath = Path.Combine(path,fle.Name);
                while (File.Exists(destinationFilePath))
                {
                    destinationFilePath = ModifyFileNameForDuplicateFiles(path,fle, loopCount);
                    loopCount++;
                }
                fle.MoveTo(destinationFilePath);
            }
        }

        public static void MoveFiles(string path, DirectoryInfo[] folders)
        {
            List<FileInfo> allFiles = new List<FileInfo>();
            foreach (var dir in folders)
            {
                var files = dir.GetFiles();
                allFiles.AddRange(files);
            }
            MoveFiles(path, allFiles);
        }

        public static void MoveFiles(DirectoryInfo[] folders, List<List<FileInfo>> files)
        {
            if (folders == null || files == null) throw new IndexOutOfRangeException(appLang.ErrorFileFolderNull);
            if (folders.Count() != files.Count()) throw new IndexOutOfRangeException(appLang.ErrorFileFolderMismatch);
            var filesAsArray = files.ToArray();
            for (int i = 0; i < files.Count(); i++)
            {
                MoveFiles(folders[i].FullName, filesAsArray[i]);
            }
        }

        public static void ChangeFilesExtension(FileInfo[] files, string extension)
        {
            foreach (var file in files)
            {
                File.Move(file.FullName, Path.ChangeExtension(file.FullName, extension));
            }
        }


    }
}
