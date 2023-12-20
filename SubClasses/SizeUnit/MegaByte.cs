/*
 * User: Armin
 * Date: 12/12/2023
 * Time: 06:07 ب.ظ
 */
using System;

namespace ArminTools
{
	/// <summary>
	/// Description of MegaByte.
	/// </summary>
	public class MegaByte : SizeUnit
	{
		const double uniqueFactor = 1048576;
		const ESizeUnit unittype = ESizeUnit.MegaByte;
		const string abbreviation = "Mb";
		
		public override string Abbreviation
		{	
			get {return abbreviation;}
		}	
		
		public MegaByte(double sizeInByte) : base(sizeInByte,uniqueFactor,unittype,abbreviation) {}
		
	}
}
