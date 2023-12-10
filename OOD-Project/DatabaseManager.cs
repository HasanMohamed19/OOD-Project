using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOD_Project
{
    public class DatabaseManager
    {
        static DatabaseManager instance;
        private SqlCommand command;
        private SqlConnection connection;
        private SqlDataReader reader;
        private DatabaseManager() 
        { 
            connection = new SqlConnection(Properties.Settings.Default.dbConnectionString);
        }

        public SqlCommand Command { get => command; set => command = value; }
        public SqlConnection Connection { get => connection;}
        public SqlDataReader Reader { get => reader; set => reader = value; }

        public static DatabaseManager Instance()
        {
            
            if (instance == null)
            {
                instance = new DatabaseManager();
            }

            return instance;

        }


    }
}
