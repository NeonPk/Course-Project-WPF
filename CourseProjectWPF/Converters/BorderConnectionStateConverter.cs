﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Media;

namespace CourseProjectWPF.Converters
{
    class BorderConnectionStateConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {


            if ( ((bool)value) )
            {
                return (SolidColorBrush)(new BrushConverter().ConvertFrom("#50C878"));
            }
            else
            {
                return new SolidColorBrush(Colors.Red);
            }



        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
