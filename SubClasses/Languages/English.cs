using System.Drawing;

namespace ArminTools.SubClasses.Languages
{
    /// <summary>
    ///     Description of English.
    /// </summary>
    public class English : ILanguage
    {
        private const string ConstName = "English";
        private const bool ConstRtl = false;
        private readonly Font _font = new Font("Candara", 12F, FontStyle.Bold);

        //Form
        private const string ConstFormName = "Armin Tools";
        private const string ConstPathPlaceholder = "Please Select the Path to Files/Folders";
        private const string ConstSelectPath = "Select Target Path";
        private const string ConstSizeUnit = "Mb";
        private const string ConstStartGrouping = "▶Group Files";
        private const string ConstStartExtracting = "▶Extract Files";
        private const string ConstExtFrom = "From :";
        private const string ConstExtTo = "To :";
        private const string ConstExtHiddenChange = "Change To :";
        private const string ConstStartExtChanging = "▶Change Files Extension";
        private const string ConstCreator = "Armin Talakoub - 2023";

        //Errors
        private const string ConstError = "Error \n";
        private const string ConstErrorEmptyPath = "Path can not be Empty";
        private const string ConstErrorGroupSize = "Group Size can not be Smaller than 1 Mb";
        private const string ConstErrorFileFolderMismatch = "Mismatch in Files and Folders count!";
        private const string ConstErrorFileFolderNull = "Folders/Files Collections can not be null";
        private const string ConstErrorNoFolders = "Number of Folders can not be less than 1";

        //MessageBoxes
        private const string ConstContactInfo = "Email : ArminTalakoub@gmail.com \n\nTelegram Id : @SHARK_US";
        private const string ConstSuccess = "Success!";
        private const string ConstGroupingSuccess = "Files were Grouped Successfully";
        private const string ConstExtractSuccess = "Files were Extracted Successfully";
        private const string ConstExtChangeSuccess = "Files Extensions were Changed Successfully";
        private const string ConstConfirmFirstPart = "Are you sure you want to Run the Operation [";
        private const string ConstConfirmSecondPart = "] on the Following Path?";
        private const string ConstOperationGrouping = "File Grouping";
        private const string ConstOperationExtraction = "File Extraction";
        private const string ConstOperationExtChange = "File Extension Change";


        public string Name { get { return ConstName; } }
        public bool RTL { get { return ConstRtl; } }
        public Font Font { get { return _font; } }

        //Form
        public string FormName { get { return ConstFormName; } }
        public string PathPlaceholder { get { return ConstPathPlaceholder; } }
        public string SelectPath { get { return ConstSelectPath; } }
        public string SizeUnit { get { return ConstSizeUnit; } }
        public string StartGrouping { get { return ConstStartGrouping; } }
        public string StartExtracting { get { return ConstStartExtracting; } }
        public string ExtFrom { get { return ConstExtFrom; } }
        public string ExtTo { get { return ConstExtTo; } }
        public string ExtHiddenChange { get { return ConstExtHiddenChange; } }
        public string StartExtChanging { get { return ConstStartExtChanging; } }
        public string Creator { get { return ConstCreator; } }

        //Errors
        public string Error { get { return ConstError; } }
        public string ErrorEmptyPath { get { return ConstErrorEmptyPath; } }
        public string ErrorGroupSize { get { return ConstErrorGroupSize; } }
        public string ErrorFileFolderMismatch { get { return ConstErrorFileFolderMismatch; } }
        public string ErrorFileFolderNull { get { return ConstErrorFileFolderNull; } }
        public string ErrorNoFolders { get { return ConstErrorNoFolders; } }

        //MessageBoxes
        public string ContactInfo { get { return ConstContactInfo; } }
        public string Success { get { return ConstSuccess; } }
        public string GroupingSuccess { get { return ConstGroupingSuccess; } }
        public string ExtractSuccess { get { return ConstExtractSuccess; } }
        public string ExtchangeSuccess { get { return ConstExtChangeSuccess; } }
        public string ConfirmFirstpart { get { return ConstConfirmFirstPart; } }
        public string ConfirmSecondpart { get { return ConstConfirmSecondPart; } }
        public string OperationGrouping { get { return ConstOperationGrouping; } }
        public string OperationExtraction { get { return ConstOperationExtraction; } }
        public string OperationExtChange { get { return ConstOperationExtChange; } }

    }
}