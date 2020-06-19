using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using KeepMe.Models;
using KeepMe.ViewModels;
using KeepMe.Repositories;

namespace KeepMe.UserControls
{
    /// <summary>
    /// Interaction logic for TodoUserControl.xaml
    /// </summary>
    public partial class TodoUserControl : UserControl
    {
        public static readonly DependencyProperty IdProperty =
            DependencyProperty.RegisterAttached("Id", typeof(int), typeof(TodoUserControl), new PropertyMetadata(0));

        public static readonly DependencyProperty DescriptionProperty =
            DependencyProperty.RegisterAttached("Description", typeof(string), typeof(TodoUserControl), new PropertyMetadata("Todo Description"));

        public static readonly DependencyProperty CompletedProperty =
            DependencyProperty.RegisterAttached("Completed", typeof(int), typeof(TodoUserControl), new PropertyMetadata(1));

        public int Id
        {
            get
            {
                return (int)GetValue(IdProperty);
            }
            set
            {
                SetValue(IdProperty, value);
                InvalidateVisual();
            }
        }

        public string Description
        {
            get
            {
                return (string)GetValue(DescriptionProperty);
            }
            set
            {
                SetValue(DescriptionProperty, value);
                InvalidateVisual();
            }
        }

        public int Completed
        {
            get
            {
                return (int)GetValue(CompletedProperty);
            }
            set
            {
                SetValue(CompletedProperty, value);
                InvalidateVisual();
            }
        }

        public TodoUserControl()
        {
            InitializeComponent();
        }

        private void root_MouseLeftButtonDown_1(object sender, MouseButtonEventArgs e)
        {
            TodoViewModel.Instance.Trigger(new TodoModel(Id, Description, Completed));
        }
    }
}
