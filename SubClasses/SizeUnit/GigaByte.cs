namespace ArminTools.SubClasses.SizeUnit
{
    /// <summary>
    /// Description of GigaByte.
    /// </summary>
    public class GigaByte : SizeUnit
    {
        const double UniqueFactor = 1073741824;
        const ESizeUnit Unittype = ESizeUnit.GigaByte;
        const string GbAbbreviation = "GB";

        public override string Abbreviation
        {
            get { return GbAbbreviation; }
        }

        public GigaByte(double sizeInByte) : base(sizeInByte, UniqueFactor, Unittype, GbAbbreviation) { }

    }
}
