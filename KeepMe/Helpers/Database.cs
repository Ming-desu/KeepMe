using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using KeepMe.ViewModels;

namespace KeepMe.Helpers
{
    /// <summary>
    /// The helper class to connect and perform operations to MySql Database
    /// </summary>
    class Database
    {
        #region Private Members
        
        /// <summary>
        /// The connection established between the client and the server
        /// </summary>
        private static MySqlConnection connection;

        /// <summary>
        /// The connection string to be used in order to connect to the server
        /// </summary>
        private static string connectionString = "Server=localhost; Database=db_keepme; Uid=root";

        // This members where encapsulated in order to restrict the access of the user to it

        #endregion

        /// <summary>
        /// The method that handles and performs all the database operations related
        /// </summary>
        /// <param name="action">The action to be done after establishing the connection</param>
        public static void Execute(Action<MySqlConnection> action)
        {
            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                try
                {
                    con.Open();

                    if (con.State == System.Data.ConnectionState.Open)
                    {
                        action(con);
                    }

                    con.Close();
                }
                catch (MySqlException err) 
                {
                    // Show the error message on the screen
                    WindowViewModel.Instance.Message = err.Message;    
                }
            }
        }
    }
}
