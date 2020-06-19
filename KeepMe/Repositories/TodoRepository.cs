using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KeepMe.Models;
using KeepMe.Helpers;
using KeepMe.ViewModels;
using MySql.Data.MySqlClient;

namespace KeepMe.Repositories
{
    /// <summary>
    /// The todo repository
    /// This class contains all the database operation needed in todo
    /// </summary>
    class TodoRepository
    {
        /// <summary>
        /// The instance of the todo repository
        /// Singleton design pattern
        /// </summary>
        public static TodoRepository Instance = Instance ?? new TodoRepository();

        /// <summary>
        /// The method that will create a todo
        /// </summary>
        /// <param name="todo">The todo model of the todo to be created</param>
        public void Create(TodoModel todo) 
        {
            // Get the instance of the view model for the window
            // So that we may interfere with the UI logics
            WindowViewModel vm = WindowViewModel.Instance;

            // We validate for the required field
            if (string.IsNullOrWhiteSpace(todo.Description))
            {
                vm.Message = "Todo description cannot be empty.";
                return;
            }

            // Calls the database operation CreateTodo
            CreateTodo(todo);

            // This encapsulates the database logic to the business logic of the creation of todo
            // The above code mainly focuses on the UI state of the app
            // While the other one mainly for the database communication purpose
        }

        /// <summary>
        /// The database operation of adding a todo
        /// </summary>
        /// <param name="todo">The todo model of the todo to be created</param>
        private void CreateTodo(TodoModel todo)
        {
            WindowViewModel vm = WindowViewModel.Instance;

            Database.Execute((con) =>
            {
                MySqlCommand cmd = new MySqlCommand("INSERT INTO todos VALUES(NULL, @description, 0)", con);
                cmd.Parameters.AddWithValue("description", todo.Description);
                cmd.ExecuteNonQuery();

                // If there aren't any errors occured
                // Notify that the action was successful
                vm.Message = "Successfully added a todo.";
                vm.CurrentPage = Enumerables.ApplicationPage.Todo;
            });
        }

        /// <summary>
        /// The method that gets all the data of todo from the database
        /// </summary>
        /// <returns></returns>
        public List<TodoModel> Read()
        {
            return ReadTodo();
        }

        /// <summary>
        /// The method that gets all the data of todo from the database based on a string to be search
        /// </summary>
        /// <param name="search">The string to be searched</param>
        /// <returns></returns>
        public List<TodoModel> Read(string search)
        {
            return ReadTodo(search);
        }

        // These two Read Method depicts Method Overloading 
        // wherein we pass different parameter to the same method
        // with the same return type.
        // This help programmers to be much more organize in their methods

        /// <summary>
        /// The database operation for reading the todo from the database
        /// </summary>
        /// <param name="search">The string to be searched</param>
        /// <returns></returns>
        private List<TodoModel> ReadTodo(string search = "")
        {
            List<TodoModel> todos = new List<TodoModel>();

            Database.Execute((con) =>
            {
                string query = "SELECT * FROM todos";

                // Add the query for the search if it is not empty
                if (!string.IsNullOrWhiteSpace(search))
                    query += " WHERE description LIKE @search";
                
                query += " ORDER BY id DESC";

                MySqlCommand cmd = new MySqlCommand(query, con);
                
                // Add the query parameter for the search if it is not empty
                if (!string.IsNullOrWhiteSpace(search))
                    cmd.Parameters.AddWithValue("search", search + "%");

                MySqlDataReader dr = cmd.ExecuteReader();

                // Read the data and add it to the container above
                while (dr.Read())
                    todos.Add(new TodoModel(Convert.ToInt32(dr["id"]), dr["description"].ToString(), Convert.ToInt32(dr["completed"])));
                
                dr.Close();
            });

            return todos;
        }

        /// <summary>
        /// This method simply toggle the completed state of the todo in the database
        /// </summary>
        /// <param name="todo"></param>
        public async void TriggerTodo(TodoModel todo)
        {
            await Task.Run(() =>
            {
                Database.Execute((con) =>
                {
                    MySqlCommand cmd = new MySqlCommand("UPDATE todos SET completed = @completed WHERE id = @id", con);
                    cmd.Parameters.AddWithValue("completed", todo.Completed);
                    cmd.Parameters.AddWithValue("id", todo.Id);
                    cmd.ExecuteNonQuery();
                });
            });
        }
    }
}
