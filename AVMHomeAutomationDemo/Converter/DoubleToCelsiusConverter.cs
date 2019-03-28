﻿using System;
using System.Windows.Data;

namespace AVMHomeAutomationDemo.Converter
{
    [ValueConversion(typeof(double?), typeof(string))]
    public class DoubleToCelsiusConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            double? val = (double?)value;
            return val.HasValue ? $"{val.Value:N1} °C" : "--.- °C";
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
