namespace ArminTools.SubClasses.SizeUnit
{
    /// <summary>
    /// Description of KiloByte.
    /// </summary>
    public class KiloByte : SizeUnit
    {
        const double UniqueFactor = 1024;
        const ESizeUnit Unittype = ESizeUnit.KiloByte;
        const string KbAbbreviation = "Kb";

        public override string Abbreviation
        {
            get { return KbAbbreviation; }
        }

        public KiloByte(double sizeInByte) : base(sizeInByte, UniqueFactor, Unittype, KbAbbreviation) { }

    }
}
