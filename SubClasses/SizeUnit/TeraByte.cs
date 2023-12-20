/*
 * User: Armin
 * Date: 12/12/2023
 * Time: 06:07 ب.ظ
 */
using System;

namespace ArminTools
{
	/// <summary>
	/// Description of TeraByte.
	/// </summary>
	public class TeraByte : SizeUnit
	{
		const double uniqueFactor = 1099511627776;
		const ESizeUnit unittype = ESizeUnit.TeraByte;
		const string abbreviation = "TB";
		
		public override string Abbreviation
		{	
			get {return abbreviation;}
		}
		
		public TeraByte(double sizeInByte) : base(sizeInByte,uniqueFactor,unittype,abbreviation) {}

	}
}
