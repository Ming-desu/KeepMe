using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace KeepMe.ValueConverters
{
    /// <summary>
    /// Converts the width to circle radius
    /// </summary>
    class WidthCircleRadiusValueConverter : IValueConverter
    {
        /// <summary>
        /// The instance of the converter
        /// Singleton design pattern
        /// </summary>
        public static WidthCircleRadiusValueConverter Instance = Instance ?? new WidthCircleRadiusValueConverter();

        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            return (double)value * 4;
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
