using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOD_Project
{
    public class DatabaseManager
    {
        static DatabaseManager instance;
        private SqlCommand command;
        private SqlConnection connection;
        private SqlDataReader reader;
        //private static string resolvedPath = ResolveDirectory(Directory.GetCurrentDirectory());
        private string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\db.mdf;Integrated Security=True";
        

        //private static string ResolveDirectory(string path)
        //{
        //    for (int i = 0; i < 2; i++)
        //    {
        //        path = Path.GetDirectoryName(path);
        //        if (path == null)
        //        {
        //            return "Invalid Path";
        //        }
        //    }
        //    return path + "\\db.mdf";
        //}
        private DatabaseManager() 
        {
            connection = new SqlConnection(connectionString);
            
            //connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;
            //                    AttachDbFilename=C:\Users\Hassan\source\repos\OOD-Project\OOD-Project\db.mdf;
            //                    Integrated Security=True");
            // not sure why this doesnt work with insert and delete!
            //connection = new SqlConnection(Properties.Settings.Default.dbConnectionString);
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
