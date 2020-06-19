using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using KeepMe.Enumerables;
using KeepMe.Models;
using KeepMe.Repositories;
using System.Collections.ObjectModel;
using KeepMe.Helpers;

namespace KeepMe.ViewModels
{
    /// <summary>
    /// The todo view model class
    /// This holds all of the business logics and code behinds for the app
    /// </summary>
    class TodoViewModel : BaseViewModel
    {
        #region Private Members
        
        /// <summary>
        /// The todo model object
        /// </summary>
        private TodoModel todo = new TodoModel();

        /// <summary>
        /// The collection of todos
        /// </summary>
        private ObservableCollection<TodoModel> todos;

        /// <summary>
        /// The flag whether the search bar is visible
        /// </summary>
        private bool searchVisible = false; 

        #endregion

        /// <summary>
        /// The instance of the view model
        /// Singleton design pattern
        /// </summary>
        public static TodoViewModel Instance = Instance ?? new TodoViewModel();
        
        /// <summary>
        /// The command when user clicks the add button
        /// </summary>
        public RelayCommand AddCommand { get; set; }

        /// <summary>
        /// The command when user clicks the back button
        /// </summary>
        public RelayCommand BackCommand { get; set; }

        /// <summary>
        /// The command when user clicks the search button
        /// </summary>
        public RelayCommand SearchCommand { get; set; }

        /// <summary>
        /// The command when user submits the add todo form
        /// </summary>
        public RelayCommand AddTodoCommand { get; set; }

        /// <summary>
        /// The command when user types on the search bar
        /// </summary>
        public RelayCommand SearchQueryCommand { get; set; }

        /// <summary>
        /// The flag whether the search bar is visible
        /// </summary>
        public bool SearchVisible
        {
            get { return searchVisible; }
            set { searchVisible = value; OnPropertyChanged("SearchVisible"); }
        }

        /// <summary>
        /// The todo model object
        /// </summary>
        public TodoModel Todo
        {
            get { return todo; }
            set { todo = value; OnPropertyChanged("Todo"); }
        }

        /// <summary>
        /// The collection of todos
        /// </summary>
        public ObservableCollection<TodoModel> Todos
        {
            get { return todos; }
            set { todos = value; OnPropertyChanged("Todos"); }
        }

        /// <summary>
        /// Default Constructor
        /// </summary>
        public TodoViewModel()
        {
            // Initialize all the commands with their appropriate actions
            AddCommand = new RelayCommand(() => WindowViewModel.Instance.CurrentPage = ApplicationPage.TodoAdd);
            BackCommand = new RelayCommand(() => WindowViewModel.Instance.CurrentPage = ApplicationPage.Todo);
            SearchCommand = new RelayCommand(() => SearchVisible = !SearchVisible);
            AddTodoCommand = new RelayCommand(() => Create());
            SearchQueryCommand = new RelayCommand((search) => Read(search));
            
            // Read the todos ...
            Read();
        }

        /// <summary>
        /// The method that handles the creation of todo asynchronously
        /// </summary>
        private async void Create()
        {
            // Since we encapsulate all the UI logics and Database operations in TodoRepository
            // We can just call it here, this is much more organize and more maintainable
            TodoRepository.Instance.Create(Todo);

            // Await for the todos 
            await Task.Run(() => Read());
        }

        /// <summary>
        /// The method that reads the todos from the database asynchronously
        /// </summary>
        private async void Read()
        {
            await Task.Run(() => Todos = new ObservableCollection<TodoModel>(TodoRepository.Instance.Read()));
        }

        /// <summary>
        /// The method that reads the todos based on a string from the database asynchronously
        /// </summary>
        /// <param name="search">The string to be searched</param>
        private async void Read(string search)
        {
            await Task.Run(() => Todos = new ObservableCollection<TodoModel>(TodoRepository.Instance.Read(search)));
        }

        /// <summary>
        /// This method simply toggles the completed state of the todo
        /// </summary>
        /// <param name="todo"></param>
        public void Trigger(TodoModel todo)
        {
            for (int i = 0; i < Todos.Count; i++)
            {
                if (Todos[i].Id == todo.Id)
                {
                    Todos[i].Completed = Todos[i].Completed == 1 ? 0 : 1;
                    TodoRepository.Instance.TriggerTodo(Todos[i]);
                    break;
                }
            }
        }
    }
}
