namespace ArminTools.SubClasses.SizeUnit
{
    /// <summary>
    /// Description of Byte.
    /// </summary>
    public class ByteUnit : SizeUnit
    {
        const double UniqueFactor = 1;
        const ESizeUnit Unittype = ESizeUnit.Byte;
        const string ByteAbbreviation = "B";

        public override string Abbreviation
        {
            get { return ByteAbbreviation; }
        }

        public ByteUnit(double sizeInByte) : base(sizeInByte, UniqueFactor, Unittype, ByteAbbreviation) { }


    }
}
