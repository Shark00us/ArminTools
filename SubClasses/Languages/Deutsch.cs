using System.Drawing;

namespace ArminTools.SubClasses.Languages
{
    /// <summary>
    ///     Description of Deutsch.
    /// </summary>
    public class Deutsch : ILanguage
    {
         private const string ConstName = "Deutsch";
         private const bool ConstRtl = false;
         private readonly Font _font = new Font("Candara", 12F, FontStyle.Bold);

         //Bilden
         private const string ConstFormName = "Armin Werkzeuge";
         private const string ConstPathPlaceholder = "Bitte wählen Sie den Pfad zu Dateien/Ordnern";
         private const string ConstSelectPath = "Zielpfad auswählen";
         private const string ConstSizeUnit = "Mb";
         private const string ConstStartGrouping = "▶Gruppendateien";
         private const string ConstStartExtracting = "▶Dateien extrahieren";
         private const string ConstExtFrom = "Von:";
         private const string ConstExtTo = "Nach :";
         private const string ConstExtHiddenChange = "Ändern in:";
         private const string ConstStartExtChanging = "▶Dateierweiterung ändern";
         private const string ConstCreator = "Armin Talakoub - 2023";

         //Fehler
         private const string ConstError = "Fehler \n";
         private const string ConstErrorEmptyPath = "Pfad darf nicht leer sein";
         private const string ConstErrorGroupSize = "Gruppengröße darf nicht kleiner als 1 MB sein";
         private const string ConstErrorFileFolderMismatch = "Nichtübereinstimmung in der Anzahl der Dateien und Ordner!";
         private const string ConstErrorFileFolderNull = "Ordner-/Dateisammlungen dürfen nicht null sein";
         private const string ConstErrorNoFolders = "Anzahl der Ordner darf nicht kleiner als 1 sein";

         //MessageBoxes
         private const string ConstContactInfo = "E-Mail: ArminTalakoub@gmail.com \n\nTelegram-ID: @SHARK_US";
         private const string ConstSuccess = "Erfolg!";
         private const string ConstGroupingSuccess = "Dateien wurden erfolgreich gruppiert";
         private const string ConstExtractSuccess = "Dateien wurden erfolgreich extrahiert";
         private const string ConstExtChangeSuccess = "Dateierweiterungen wurden erfolgreich geändert";
         private const string ConstConfirmFirstPart = "Sind Sie sicher, dass Sie den Vorgang ausführen möchten [";
         private const string ConstConfirmSecondPart = "] auf dem folgenden Pfad?";
         private const string ConstOperationGrouping = "Dateigruppierung";
         private const string ConstOperationExtraction = "Dateiextraktion";
         private const string ConstOperationExtChange = "Änderung der Dateierweiterung";


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