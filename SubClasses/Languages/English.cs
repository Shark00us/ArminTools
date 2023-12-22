using System.Drawing;

namespace ArminTools
{
    /// <summary>
    ///     Description of English.
    /// </summary>
    public class English : ILanguage
    {
        private const string name = "English";
        private const bool rTL = false;
        private readonly Font font = new Font("Candara", 12F, FontStyle.Bold);

        //Form
        private const string formName = "Armin Tools";
        private const string pathPlaceholder = "Please Select the Path to Files/Folders";
        private const string selectPath = "Select Target Path";
        private const string sizeUnit = "Mb";
        private const string startGrouping = "▶Group Files";
        private const string startExtracting = "▶Extract Files";
        private const string extFrom = "From :";
        private const string extTo = "To :";
        private const string extHiddenChange = "Change To :";
        private const string startExtChanging = "▶Change Files Extension";
        private const string creator = "Armin Talakoub - 2023";

        //Errors
        private const string error = "Error \n";
        private const string errorEmptyPath = "Path can not be Empty";
        private const string errorGroupSize = "Group Size can not be Smaller than 1 Mb";
        private const string errorFileFolderMismatch = "Mismatch in Files and Folders count!";
        private const string errorFileFolderNull = "Folders/Files Collections can not be null";
        private const string errorNoFolders = "Number of Folders can not be less than 1";

        //MessageBoxes
        private const string contactInfo = "Email : ArminTalakoub@gmail.com \n\nTelegram Id : @SHARK_US";
        private const string groupingSuccess = "Files were Grouped Successfully";
        private const string extractSuccess = "Files were Extracted Successfully";
        private const string extchangeSuccess = "Files Extensions were Changed Successfully";
        private const string confirmFirstpart = "Are you sure you want to Run the Operation [";
        private const string confirmSecondpart = "] on the Following Path?";
        private const string operationGrouping = "File Grouping";
        private const string operationExtraction = "File Extraction";
        private const string operationExtChange = "File Extension Change";


        public string Name { get { return name; } }
        public bool RTL { get { return rTL; } }
        public Font Font { get { return font; } }

        //Form
        public string FormName { get { return formName; } }
        public string PathPlaceholder { get { return pathPlaceholder; } }
        public string SelectPath { get { return selectPath; } }
        public string SizeUnit { get { return sizeUnit; } }
        public string StartGrouping { get { return startGrouping; } }
        public string StartExtracting { get { return startExtracting; } }
        public string ExtFrom { get { return extFrom; } }
        public string ExtTo { get { return extTo; } }
        public string ExtHiddenChange { get { return extHiddenChange; } }
        public string StartExtChanging { get { return startExtChanging; } }
        public string Creator { get { return creator; } }

        //Errors
        public string Error { get { return error; } }
        public string ErrorEmptyPath { get { return errorEmptyPath; } }
        public string ErrorGroupSize { get { return errorGroupSize; } }
        public string ErrorFileFolderMismatch { get { return errorFileFolderMismatch; } }
        public string ErrorFileFolderNull { get { return errorFileFolderNull; } }
        public string ErrorNoFolders { get { return errorNoFolders; } }

        //MessageBoxes
        public string ContactInfo { get { return contactInfo; } }
        public string GroupingSuccess { get { return groupingSuccess; } }
        public string ExtractSuccess { get { return extractSuccess; } }
        public string ExtchangeSuccess { get { return extchangeSuccess; } }
        public string ConfirmFirstpart { get { return confirmFirstpart; } }
        public string ConfirmSecondpart { get { return confirmSecondpart; } }
        public string OperationGrouping { get { return operationGrouping; } }
        public string OperationExtraction { get { return operationExtraction; } }
        public string OperationExtChange { get { return operationExtChange; } }

    }
}