using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace KeepMe.ValueConverters
{
    /// <summary>
    /// Converts int to boolean value
    /// </summary>
    class IntToBooleanValueConverter : IValueConverter
    {
        /// <summary>
        /// The instance of the converter
        /// Singleton design pattern
        /// </summary>
        public static IntToBooleanValueConverter Instance = Instance ?? new IntToBooleanValueConverter();

        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            if (value == null)
                return false;
            return (int)value == 1;
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            return (bool)value ? 1 : 0;
        }
    }
}
