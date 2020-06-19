using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KeepMe.ViewModels;

namespace KeepMe.Models
{
    /// <summary>
    /// The model representation of a todo
    /// Inherits the BaseViewModel to allow this model
    /// To have some of the base methods from it
    /// </summary>
    public class TodoModel : BaseViewModel
    {
        #region Private Members
        
        /// <summary>
        /// The primary key of the Todo
        /// </summary>
        private int id;

        /// <summary>
        /// The description of the todo
        /// </summary>
        private string description;

        /// <summary>
        /// Is the todo is marked as completed or not
        /// </summary>
        private int completed; 

        // This encapsulates these data and allowing to manipulate it before returning 
        // to the accessor of these property data

        #endregion

        public int Id
        {
            get { return id; }
            set { id = value; OnPropertyChanged("Id"); }
        }

        public string Description
        {
            get { return description; }
            set { description = value; OnPropertyChanged("Description"); }
        }

        public int Completed
        {
            get { return completed; }
            set { completed = value; OnPropertyChanged("Completed"); }
        }

        /// <summary>
        /// Default Constructor
        /// </summary>
        public TodoModel() { }

        /// <summary>
        /// Parameterized Constructor
        /// </summary>
        /// <param name="id">The id of the todo</param>
        /// <param name="description">The description of the todo</param>
        /// <param name="completed">The flag for completed of the todo</param>
        public TodoModel(int id, string description, int completed)
        {
            Id = id;
            Description = description;
            Completed = completed;
        }
    }
}
