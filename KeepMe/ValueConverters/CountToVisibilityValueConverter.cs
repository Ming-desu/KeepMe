using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;

namespace KeepMe.ValueConverters
{
    /// <summary>
    /// Converts the count of collection into visibility enumerable value
    /// </summary>
    class CountToVisibilityValueConverter : IValueConverter
    {
        /// <summary>
        /// The instance of the converter
        /// Single design pattern
        /// </summary>
        public static CountToVisibilityValueConverter Instance = Instance ?? new CountToVisibilityValueConverter();

        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            var collection = value as IList;
            if (collection != null)
                return collection.Count > 0 ? Visibility.Collapsed : Visibility.Visible;
            return Visibility.Visible;
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
