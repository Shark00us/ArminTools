using System.Drawing;

namespace ArminTools
{
    /// <summary>
    /// Description of Persian.
    /// </summary>
    public class Persian : ILanguage
    {

        private const string name = "فارسی";
        private const bool rTL = true;
        private readonly Font font = new Font("Sakkal Majalla", 12F, FontStyle.Bold);

        //Form
        private const string formName = "ابزار های آرمین";
        private const string pathPlaceholder = "لطفا مسیر فایل ها /فولدر ها را انتخاب کنید";
        private const string selectPath = "انتخاب مسیر پوشه ها/فایلها";
        private const string sizeUnit = "Mb";
        private const string startGrouping = "▶ گروهبندی فایلها";
        private const string startExtracting = "▶ استخراج فایلها";
        private const string extFrom = ": از";
        private const string extTo = ": به";
        private const string extHiddenChange = ": تغییر به";
        private const string startExtChanging = "▶ تغییر پسوند فایلها";
        private const string creator = "آرمین طلاکوب - 1402";

        //Errors
        private const string error = "خطا \n";
        private const string errorEmptyPath = "مسیر نمی تواند خالی باشد";
        private const string errorGroupSize = "اندازه گروه نمی تواند کمتر از 1 مگابایت باشد";
        private const string errorFileFolderMismatch = "عدم تطابق تعداد فولدر ها و گروه ها";
        private const string errorFileFolderNull = "فایل/فولدر ورودی نمی تواند نال باشد";
        private const string errorNoFolders = "تعداد فولدر ها نمی بایست کمتر از 1 باشد";

        //MessageBoxes
        private const string contactInfo = "ArminTalakoub@gmail.com :ایمیل\n\n @SHARK_US :آی دی تلگرام";
        private const string groupingSuccess = "فایلها به موفقیت گروهبندی شدند";
        private const string extractSuccess = "فایلها با موفقیت استخراج شدند";
        private const string extchangeSuccess = "پسوند فایلها با موفقیت تغییر یافت";
        private const string confirmFirstpart = " آیا از انجام عملیات ";
        private const string confirmSecondpart = " بر روی مسیر زیر مطمن هستید؟ ";
        private const string operationGrouping = "گروهبندی فایلها";
        private const string operationExtraction = "استخراج فایل ها";
        private const string operationExtChange = "تغییر پسوند فایلها";


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
