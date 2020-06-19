using System;
using System.Windows.Data;
using KeepMe.Enumerables;
using KeepMe.Views;

namespace KeepMe.ValueConverters
{
    /// <summary>
    /// Converts the enumerable application page into an actual page (view)
    /// </summary>
    class ApplicationPageValueConverter : IValueConverter
    {
        /// <summary>
        /// The instance of the converter
        /// Singleton design pattern
        /// </summary>
        public static ApplicationPageValueConverter Instance = Instance ?? new ApplicationPageValueConverter();

        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            switch ((ApplicationPage)value)
            {
                case ApplicationPage.Todo:
                    return new Todo();
                case ApplicationPage.TodoAdd:
                    return new TodoAdd();
                default:
                    return null;
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
