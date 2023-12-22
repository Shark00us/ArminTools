using System;
namespace ArminTools.SubClasses.SizeUnit
{
    /// <summary>
    /// Description of Byte.
    /// </summary>
    public abstract class SizeUnit
    {
        protected readonly double UnitSize;
        protected readonly double Factor;
        protected readonly ESizeUnit ESizeUnit;
        protected readonly string AbbreviationString;

        public abstract string Abbreviation { get; }

        protected SizeUnit(double sizeInByte, double converationFactor, ESizeUnit esize, string abbriv)
        {
            UnitSize = sizeInByte;
            Factor = converationFactor;
            ESizeUnit = esize;
            AbbreviationString = abbriv;
        }

        public static SizeUnit SizeUnitBuilder(ESizeUnit type, double sizeInByte = 1)
        {
            switch (type)
            {
                case ESizeUnit.KiloByte: return new KiloByte(sizeInByte);
                case ESizeUnit.MegaByte: return new MegaByte(sizeInByte);
                case ESizeUnit.GigaByte: return new GigaByte(sizeInByte);
                case ESizeUnit.TeraByte: return new TeraByte(sizeInByte);
                default: return new ByteUnit(sizeInByte);
            }


        }


        public double Size(int decimals = -1)
        {
            if (decimals < 0) return UnitSize / Factor;
            return Math.Round(UnitSize / Factor, decimals);
        }



        public ByteUnit ConvertToByte()
        {
            return new ByteUnit(UnitSize);
        }

        public KiloByte ConvertToKiloByte()
        {
            return new KiloByte(UnitSize);
        }

        public MegaByte ConvertToMegaByte()
        {
            return new MegaByte(UnitSize);
        }

        public GigaByte ConvertToGigaByte()
        {
            return new GigaByte(UnitSize);
        }

        public TeraByte ConvertToTeraByte()
        {
            return new TeraByte(UnitSize);
        }

    }
}
