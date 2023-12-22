using System.Drawing;

namespace ArminTools.SubClasses.Languages
{
    /// <summary>
    /// Description of ILanguage.
    /// </summary>
    public interface ILanguage
    {
        string Name { get; }
        bool RTL { get; }
        Font Font { get; }
        //Form
        string FormName { get; }
        string PathPlaceholder { get; }
        string SelectPath { get; }
        string SizeUnit { get; }
        string StartGrouping { get; }
        string StartExtracting { get; }
        string ExtFrom { get; }
        string ExtTo { get; }
        string ExtHiddenChange { get; }
        string StartExtChanging { get; }
        string Creator { get; }
        //Errors
        string Error { get; }
        string ErrorEmptyPath { get; }
        string ErrorGroupSize { get; }
        string ErrorFileFolderMismatch { get; }
        string ErrorFileFolderNull { get; }
        string ErrorNoFolders { get; }
        //MessageBoxes
        string ContactInfo { get; }
        string Success { get; }
        string GroupingSuccess { get; }
        string ExtractSuccess { get; }
        string ExtchangeSuccess { get; }
        string ConfirmFirstpart { get; }
        string ConfirmSecondpart { get; }
        string OperationGrouping { get; }
        string OperationExtraction { get; }
        string OperationExtChange { get; }

    }
}
