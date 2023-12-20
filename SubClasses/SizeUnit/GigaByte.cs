/*
 * User: Armin
 * Date: 12/12/2023
 * Time: 06:07 ب.ظ
 */
using System;

namespace ArminTools
{
	/// <summary>
	/// Description of GigaByte.
	/// </summary>
	public class GigaByte : SizeUnit
	{
		const double uniqueFactor = 1073741824;
		const ESizeUnit unittype = ESizeUnit.GigaByte;
		const string abbreviation = "GB";
		
		public override string Abbreviation
		{	
			get {return abbreviation;}
		}
		
		public GigaByte(double sizeInByte) : base(sizeInByte,uniqueFactor,unittype,abbreviation) {}
		
	}
}
