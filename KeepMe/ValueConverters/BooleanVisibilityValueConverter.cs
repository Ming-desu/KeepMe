using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;

namespace KeepMe.ValueConverters
{
    /// <summary>
    /// Converts the boolean value into a Visibility Enumerable value
    /// </summary>
    class BooleanVisibilityValueConverter : IValueConverter
    {
        /// <summary>
        /// The instane of the converter
        /// Singleton design pattern
        /// </summary>
        public static BooleanVisibilityValueConverter Instance = Instance ?? new BooleanVisibilityValueConverter();

        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            if ((bool)value)
                return Visibility.Visible;
            return Visibility.Collapsed;
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
