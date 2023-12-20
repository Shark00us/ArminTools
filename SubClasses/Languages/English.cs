/*
 * User: Armin
 * Date: 12/17/2023
 * Time: 07:39 ب.ظ
 */
using System;
using System.Drawing;

namespace ArminTools
{
	/// <summary>
	/// Description of English.
	/// </summary>
	public class English : ILanguage
	{
		
		const string name = "English";
		const bool rTL = false;
		Font font = new Font("Adobe Arabic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(178)));
		//Form
		const string formName = "Armin Tools";
		const string pathPlaceholder = "Please Select the Path to Files/Folders";
		const string selectPath = "Select Files/Folders Path";
		const string sizeUnit = "Mb";
		const string startGrouping = "Start Grouping Files";
		const string startExtracting = "Start Extraction from Folders";
		const string extFrom = "From";
		const string extTo = "To";
		const string extHiddenChange = "Change";
		const string startExtChanging = "Change Files Extensions";
		const string creator = "Armin Talakoub - 2023";
		//Errors
		const string error = "Error \n";
		const string errorEmptyPath = "Path can not be Empty";
		const string errorGroupSize = "Group Size can not be Smaller than 1 Mb";
		const string errorFileFolderMismatch = "Mismatch in Files and Folders count!";
		const string errorFileFolderNull = "Folders/Files Collections can not be null";
		const string errorNoFolders = "Number of Folders can not be less than 1";
		//MessageBoxes
		const string contactInfo = "Email : ArminTalakoub@gmail.com \n\nTelegram Id : @SHARK_US";
		const string groupingSuccess = "Files were Grouped Successfully";
		const string extractSuccess = "Files were Extracted Successfully";
		const string extchangeSuccess = "Files Extensions were Changed Successfully";
		const string confirmFirstpart = "Are you sure you want to Run the Operation [";
		const string confirmSecondpart = "] on the Path Mentioned Below?";
		const string operationGrouping = "File Grouping";
		const string operationExtraction = "Folder Extraction";
		const string operationExtChange = "File Extension Change";
		
		
		public string Name {get{return name;}}
		public bool RTL {get{return rTL;}}
		public Font Font {get{return font;}}
		//Form
		public string FormName {get{return formName;}}
		public string PathPlaceholder {get{return pathPlaceholder;}}
		public string SelectPath {get{return selectPath;}}
		public string SizeUnit {get{return sizeUnit;}}
		public string StartGrouping {get{return startGrouping;}}
		public string StartExtracting {get{return startExtracting;}}
		public string ExtFrom {get{return extFrom;}}
		public string ExtTo {get{return extTo;}}
		public string ExtHiddenChange {get{return extHiddenChange;}}
		public string StartExtChanging {get{return startExtChanging;}}
		public string Creator {get{return creator;}}
		//Errors
		public string Error {get{return error;}}
		public string ErrorEmptyPath {get{return errorEmptyPath;}}
		public string ErrorGroupSize {get{return errorGroupSize;}}
		public string ErrorFileFolderMismatch {get{return errorFileFolderMismatch;}}
		public string ErrorFileFolderNull {get{return errorFileFolderNull;}}
		public string ErrorNoFolders {get{return errorNoFolders;}}
		//MessageBoxes
		public string ContactInfo {get{return contactInfo;}}
		public string GroupingSuccess {get{return groupingSuccess;}}
		public string ExtractSuccess {get{return extractSuccess;}}
		public string ExtchangeSuccess {get{return extchangeSuccess;}}
		public string ConfirmFirstpart {get{return confirmFirstpart;}}
		public string ConfirmSecondpart {get{return confirmSecondpart;}}
		public string OperationGrouping {get{return operationGrouping;}}
		public string OperationExtraction {get{return operationExtraction;}}
		public string OperationExtChange {get{return operationExtChange;}}
		
		
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
