/*
 * User: Armin
 * Date: 12/12/2023
 * Time: 06:06 ب.ظ
 */
using System;

namespace ArminTools
{
	/// <summary>
	/// Description of KiloByte.
	/// </summary>
	public class KiloByte : SizeUnit
	{
		const double uniqueFactor = 1024;
		const ESizeUnit unittype = ESizeUnit.KiloByte;
		const string abbreviation = "Kb";
		
		public override string Abbreviation
		{	
			get {return abbreviation;}
		}
		
		public KiloByte(double sizeInByte) : base(sizeInByte,uniqueFactor,unittype,abbreviation) {}
		
	}
}
