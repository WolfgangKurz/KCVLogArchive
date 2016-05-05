using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace LogArchive.Views.Converters
{
	public class StringToIntergerListConverter : IValueConverter
	{
		public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
		{
			if(value == null)
			{
				return "";
			}

			List<int> list = (List<int>)value;

			return string.Join(",", list.Select(x => x.ToString()).ToArray());
		}

		public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
		{
			string text = (string)value;
			string[] parts = text.Split(',');

			List<int> list = new List<int>();

			int integer;
			foreach(var part in parts)
			{
				if (int.TryParse(part, out integer))
					list.Add(integer);
			}

			return list;
		}
	}
}
