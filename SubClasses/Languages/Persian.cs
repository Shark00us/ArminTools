using System.Drawing;

namespace ArminTools.SubClasses.Languages
{
    /// <summary>
    /// Description of Persian.
    /// </summary>
    public class Persian : ILanguage
    {

        private const string ConstName = "فارسی";
        private const bool ConstRtl = true;
        private readonly Font _font = new Font("Courier New", 13F, FontStyle.Bold);

        //Form
        private const string ConstFormName = "ابزار های آرمین";
        private const string ConstPathPlaceholder = "لطفا مسیر فایل ها /فولدر ها را انتخاب کنید";
        private const string ConstSelectPath = "انتخاب مسیر";
        private const string ConstSizeUnit = "Mb";
        private const string ConstStartGrouping = "▶ گروهبندی فایلها";
        private const string ConstStartExtracting = "▶ استخراج فایلها";
        private const string ConstExtFrom = ": از";
        private const string ConstExtTo = ": به";
        private const string ConstExtHiddenChange = ": تغییر به";
        private const string ConstStartExtChanging = "▶ تغییر پسوند فایلها";
        private const string ConstCreator = "آرمین طلاکوب - 1402";

        //Errors
        private const string ConstError = "خطا \n";
        private const string ConstErrorEmptyPath = "مسیر نمی تواند خالی باشد";
        private const string ConstErrorGroupSize = "اندازه گروه نمی تواند کمتر از 1 مگابایت باشد";
        private const string ConstErrorFileFolderMismatch = "عدم تطابق تعداد فولدر ها و گروه ها";
        private const string ConstErrorFileFolderNull = "فایل/فولدر ورودی نمی تواند نال باشد";
        private const string ConstErrorNoFolders = "تعداد فولدر ها نمی بایست کمتر از 1 باشد";

        //MessageBoxes
        private const string ConstContactInfo = "ArminTalakoub@gmail.com :ایمیل\n\n @SHARK_US :آی دی تلگرام";
        private const string ConstSuccess = "!موفقیت";
        private const string ConstGroupingSuccess = "فایلها با موفقیت گروهبندی شدند";
        private const string ConstExtractSuccess = "فایلها با موفقیت استخراج شدند";
        private const string ConstExtChangeSuccess = "پسوند فایلها با موفقیت تغییر یافت";
        private const string ConstConfirmFirstPart = " آیا از انجام عملیات ";
        private const string ConstConfirmSecondPart = " بر روی مسیر زیر مطمن هستید؟ ";
        private const string ConstOperationGrouping = "گروهبندی فایلها";
        private const string ConstOperationExtraction = "استخراج فایل ها";
        private const string ConstOperationExtChange = "تغییر پسوند فایلها";


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
