﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace LogArchive.Views.Converters
{
	public class StringToStringListConverter : IValueConverter
	{
		public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
		{
			if (value == null)
			{
				return "";
			}

			List<string> list = (List<string>)value;

			return string.Join(",", list.ToArray());
		}

		public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
		{
			string text = (string)value;
			string[] parts = text.Split(',');

			return parts.ToList();
		}
	}
}
