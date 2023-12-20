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
	public class ByteUnit : SizeUnit
	{	
		const double uniqueFactor = 1;
		const ESizeUnit unittype = ESizeUnit.Byte;
		const string abbreviation = "B";
		
		public override string Abbreviation
		{	
			get {return abbreviation;}
		}	
		
		public ByteUnit(double sizeInByte) : base(sizeInByte,uniqueFactor,unittype,abbreviation) {}
		

	}
}
