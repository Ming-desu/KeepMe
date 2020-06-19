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
    /// Converts text count into visibility enumerable value
    /// </summary>
    class TextCountToVisibilityValueConverter : IValueConverter
    {
        /// <summary>
        /// The instance of the converter
        /// Singleton design pattern
        /// </summary>
        public static TextCountToVisibilityValueConverter Instance = Instance ?? new TextCountToVisibilityValueConverter();

        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            if (value == null)
                return Visibility.Collapsed;
            return value.ToString().Length > 0 ? Visibility.Visible : Visibility.Collapsed;
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
