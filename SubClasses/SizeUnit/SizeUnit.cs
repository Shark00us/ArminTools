/*
 * User: Armin
 * Date: 12/12/2023
 * Time: 06:04 ب.ظ
 */
using System;
namespace ArminTools
{
	/// <summary>
	/// Description of Byte.
	/// </summary>
	public abstract class SizeUnit
	{
		protected readonly double size;
		protected readonly double factor;
		protected readonly ESizeUnit eSizeUnit;
		protected readonly string abbreviationString;
		
		public abstract string Abbreviation {get;}
   		
   		protected SizeUnit(double sizeInByte,double converationFactor,ESizeUnit esize,string abbriv)
    	{
        	size = sizeInByte;
        	factor = converationFactor;
        	eSizeUnit = esize;
        	abbreviationString = abbriv;
    	}
   		
   		public static SizeUnit SizeUnitBuilder (ESizeUnit type,double sizeInByte = 1)
    	{
   			switch (type)
   			{
   				case ESizeUnit.KiloByte:return new KiloByte(sizeInByte);
   				case ESizeUnit.MegaByte:return new MegaByte(sizeInByte);
   				case ESizeUnit.GigaByte:return new GigaByte(sizeInByte);
   				case ESizeUnit.TeraByte:return new TeraByte(sizeInByte);
   			default: return new ByteUnit(sizeInByte);
   			}


    	}
   		
   		
   		public double Size(int decimals=-1)
   		{
   			if(decimals < 0) return size/factor;
   			return Math.Round(size/factor,decimals);
   		}
   		

   		
   		public ByteUnit ConvertToByte ()
   		{
   			return new ByteUnit(size);
   		}
   		   		
		public KiloByte ConvertToKiloByte ()
		{
			return new KiloByte(size);
		}
		
		public MegaByte ConvertToMegaByte ()
		{
			return new MegaByte(size);
		}
		
		public GigaByte ConvertToGigaByte ()
		{
			return new GigaByte(size);
		}
		
		public TeraByte ConvertToTeraByte ()
		{
			return new TeraByte(size);
		}
		
	}
}
	