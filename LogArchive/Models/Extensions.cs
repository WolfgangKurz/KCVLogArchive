using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogArchive.Models
{
	internal class Extensions
	{
		public static DateTime CSVStringToTime(string str)
		{
			string[] elem = str.Split("- :".ToCharArray());

			// Excel様が *うっかり* データを破損させることがあるので対応
			return new DateTime(
				elem.Length > 0 ? int.Parse(elem[0]) : 1970,
				elem.Length > 1 ? int.Parse(elem[1]) : 1,
				elem.Length > 2 ? int.Parse(elem[2]) : 1,
				elem.Length > 3 ? int.Parse(elem[3]) : 0,
				elem.Length > 4 ? int.Parse(elem[4]) : 0,
				elem.Length > 5 ? int.Parse(elem[5]) : 0
			);
		}
	}
}
