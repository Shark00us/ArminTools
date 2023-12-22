namespace ArminTools.SubClasses.SizeUnit
{
    /// <summary>
    /// Description of MegaByte.
    /// </summary>
    public class MegaByte : SizeUnit
    {
        const double UniqueFactor = 1048576;
        const ESizeUnit Unittype = ESizeUnit.MegaByte;
        const string MbAbbreviation = "Mb";

        public override string Abbreviation
        {
            get { return MbAbbreviation; }
        }

        public MegaByte(double sizeInByte) : base(sizeInByte, UniqueFactor, Unittype, MbAbbreviation) { }

    }
}
