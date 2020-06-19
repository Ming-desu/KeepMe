using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KeepMe.Enumerables;
using System.Windows.Input;
using System.Windows;

namespace KeepMe.ViewModels
{
    /// <summary>
    /// The window view model
    /// The view model for the main window
    /// This is the only view model that binds UI elements
    /// </summary>
    class WindowViewModel : BaseViewModel
    {
        /// <summary>
        /// The current page of the application
        /// </summary>
        private ApplicationPage applicationPage = ApplicationPage.Todo;

        /// <summary>
        /// The window where this model binded to
        /// </summary>
        private Window window;

        /// <summary>
        /// The message that will show to the user as a notification
        /// </summary>
        private string message;

        /// <summary>
        /// The instance of the view model
        /// Singleton design pattern
        /// </summary>
        public static WindowViewModel Instance = Instance ?? new WindowViewModel();

        /// <summary>
        /// The command when the user clicks the minimize button
        /// </summary>
        public RelayCommand MinimizeCommand { get; set; }

        /// <summary>
        /// The command when the user clicks the close button
        /// </summary>
        public RelayCommand CloseCommand { get; set; }

        /// <summary>
        /// The command when the user clicks the dismiss button on the notification
        /// </summary>
        public RelayCommand DismissSnackBarCommand { get; set; }
        
        /// <summary>
        /// The current page of the application
        /// </summary>
        public ApplicationPage CurrentPage
        {
            get { return applicationPage; }
            set 
            { 
                applicationPage = value;
                OnPropertyChanged("CurrentPage");
            }
        }

        /// <summary>
        /// The window this view model binded to
        /// </summary>
        public Window Window
        {
            set { window = value }
        }

        /// <summary>
        /// The message that will show to the user as a notification
        /// </summary>
        public string Message
        {
            get { return message; }
            set { message = value; OnPropertyChanged("Message"); }
        }

        /// <summary>
        /// Default Constructor
        /// </summary>
        public WindowViewModel()
        {
            // Initialize all the commands with their appropriate actions
            MinimizeCommand = new RelayCommand(() => window.WindowState = WindowState.Minimized);
            CloseCommand = new RelayCommand(() => window.Close());
            DismissSnackBarCommand = new RelayCommand(() => Message = "");
        }
    }
}
