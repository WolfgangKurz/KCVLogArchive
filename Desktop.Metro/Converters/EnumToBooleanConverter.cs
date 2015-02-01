﻿using System;
using System.Globalization;
using System.Windows.Data;

namespace Desktop.Metro.Converters
{
	public class EnumToBooleanConverter : IValueConverter
	{
		public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
		{
			return value.ToString() == parameter.ToString();
		}

		public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
		{
			return (bool)value ? Enum.Parse(targetType, parameter.ToString(), true) : null;
		}
	}
}
