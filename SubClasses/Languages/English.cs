/*
 * User: Armin
 * Date: 12/17/2023
 * Time: 07:39 ب.ظ
 */

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

        //Form
        private const string formName = "Armin Tools";
        private const string pathPlaceholder = "Please Select the Path to Files/Folders";
        private const string selectPath = "Select Files/Folders Path";
        private const string sizeUnit = "Mb";
        private const string startGrouping = "Start Grouping Files";
        private const string startExtracting = "Start Extraction from Folders";
        private const string extFrom = "From";
        private const string extTo = "To";
        private const string extHiddenChange = "Change To";
        private const string startExtChanging = "Change Files Extensions";
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
        private const string confirmSecondpart = "] on the Path Mentioned Below?";
        private const string operationGrouping = "File Grouping";
        private const string operationExtraction = "Folder Extraction";
        private const string operationExtChange = "File Extension Change";


        public string Name => name;
        public bool RTL => rTL;

        public Font Font { get; } = new Font("Adobe Arabic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 178);

        //Form
        public string FormName => formName;
        public string PathPlaceholder => pathPlaceholder;
        public string SelectPath => selectPath;
        public string SizeUnit => sizeUnit;
        public string StartGrouping => startGrouping;
        public string StartExtracting => startExtracting;
        public string ExtFrom => extFrom;
        public string ExtTo => extTo;
        public string ExtHiddenChange => extHiddenChange;
        public string StartExtChanging => startExtChanging;

        public string Creator => creator;

        //Errors
        public string Error => error;
        public string ErrorEmptyPath => errorEmptyPath;
        public string ErrorGroupSize => errorGroupSize;
        public string ErrorFileFolderMismatch => errorFileFolderMismatch;
        public string ErrorFileFolderNull => errorFileFolderNull;

        public string ErrorNoFolders => errorNoFolders;

        //MessageBoxes
        public string ContactInfo => contactInfo;
        public string GroupingSuccess => groupingSuccess;
        public string ExtractSuccess => extractSuccess;
        public string ExtchangeSuccess => extchangeSuccess;
        public string ConfirmFirstpart => confirmFirstpart;
        public string ConfirmSecondpart => confirmSecondpart;
        public string OperationGrouping => operationGrouping;
        public string OperationExtraction => operationExtraction;
        public string OperationExtChange => operationExtChange;


        //		string selectPath = "انتخاب پوشه فایل ها";
        //		string sizeUnit = "Mb";
        //		string creator = "Armin Talakoub - 2023";
        //		string startGrouping = "شروع گروهبندی فایل ها";
        //		string startExtracting = "شروع استخراج فایل ها از پوشه ها";
        //		string startExtChanging = "تغییر گروهی پسوند فایلها";
        //		string extFrom = "از";
        //		string extTo = "به";
        //		string extHiddenChange = "تغییر";
        //		string errorEmptyPath = "Path can not be Empty";
        //		string errorGroupSize = "Group Size can not be Smaller than 1Mb";
        //		string errorFileFolderMismatch = "Mismatch in Files and Folders count!";
        //		string errorFileFolderNull = "Folders/Files Collections can not be null";
        //		string errorNoFolders = "Number of Folders can not be less than 1";
        //		string contactInfo = "Email : ArminTalakoub@gmail.com \n\nTelegram Id : @SHARK_US";
        //		string groupingSuccess = "گروهبندی با موفقیت انجام شد";
        //		string extractSuccess = "استخراج فایل ها با موفقیت انجام شد";
        //		string extchangeSuccess = "تغییر پسوند فایل ها با موفقیت انجام شد";
        //		string confirmFirstpart = " آیا از انجام عملیات ";
        //		string confirmSecondpart = " برروی مسیر زیر مطمن هستید؟ ";
        //		string operationGrouping = "گروهبندی فایل ها";
        //		string operationExtraction = "استخراج فایل ها";
        //		string operationExtChange = "تغییر پسوند فایل ها";
        //		string error = "خطا \n";	
        //		string pathPlaceholder = "لطفا مسیر فایل ها را انتخاب کنید";
    }
}