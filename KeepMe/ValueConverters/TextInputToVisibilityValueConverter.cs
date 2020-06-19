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
    /// Converts text input into visibility enumerable value
    /// </summary>
    class TextInputToVisibilityValueConverter : IValueConverter 
    {
        /// <summary>
        /// The instance of the converter
        /// Single design pattern
        /// </summary>
        public static TextInputToVisibilityValueConverter Instance = Instance ?? new TextInputToVisibilityValueConverter();

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
