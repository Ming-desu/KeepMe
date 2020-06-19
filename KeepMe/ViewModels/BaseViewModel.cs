using System.ComponentModel;

namespace KeepMe.ViewModels
{
    /// <summary>
    /// The base view model class that inherits
    /// the interface INotifyPropertyChanged
    /// </summary>
    public class BaseViewModel : INotifyPropertyChanged
    {
        /// <summary>
        /// The event PropertyChangedEventHandler
        /// This must be raise whenever a property value changes
        /// so that the UI can be refreshed immediately
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(string name)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(name));
            }
        }
    }
}
