using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace KeepMe.ValueConverters
{
    /// <summary>
    /// Converts int to TextDecoration
    /// </summary>
    class CompletedToTextDecorationValueConverter : IValueConverter
    {
        /// <summary>
        /// The instance of the converter
        /// Singleton design pattern
        /// </summary>
        public static CompletedToTextDecorationValueConverter Instance = Instance ?? new CompletedToTextDecorationValueConverter();

        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            if (value == null)
                return "None";
            return (int)value == 1 ? "StrikeThrough" : "None";
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
