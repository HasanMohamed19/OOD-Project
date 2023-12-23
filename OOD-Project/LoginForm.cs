using System;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace OOD_Project
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        // fake email andpassword are just set
        //string username = "admin";
        //string password = "secret";
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string givenUsername = txtUsername.Text;
            string givenPassword = txtPassword.Text;

            DatabaseManager dbm = DatabaseManager.Instance();

            dbm.Connection.Open();

            
            //MessageBox.Show("Connection Open ! ");
            dbm.Command = dbm.Connection.CreateCommand();

            dbm.Command.Parameters.AddWithValue("@username", givenUsername);
            dbm.Command.Parameters.AddWithValue("@password", givenPassword);

            dbm.Command.CommandText = "SELECT * FROM [dbo].[User] WHERE username = @username AND password = @password";
            dbm.Reader = dbm.Command.ExecuteReader();
            if (dbm.Reader.Read())
            {

                int rid = dbm.Reader.GetOrdinal("role_id");
                int roleId = dbm.Reader.GetInt32(rid);
                switch (roleId)
                {
                    case 1:
                        AdminPanel adminPanel = new AdminPanel();
                        adminPanel.Show();
                        this.Hide();
                        break;
                    case 2:
                        TeacherPanel teacherPanel = new TeacherPanel();
                        teacherPanel.Show();
                        this.Hide();
                        break;
                    case 3:
                        StudentPanel studentPanel = new StudentPanel();
                        studentPanel.Show();
                        this.Hide();
                        break;
                }

            }
            else
            {
                MessageBox.Show(dbm.Reader.Read().ToString());

            }
            dbm.Connection.Close();

            // role ids
            // admin = 1
            /* role ids:
                admin = 1 
                teacher = 2
                student = 3
                it will be an enum
             */

            //if (username == givenUsername && password == givenPassword)
            //{
            //    switch (userRole)
            //    {
            //        case 1:
            //            //AdminPanel adminPanel = new AdminPanel();
            //            //adminPanel.Show();
            //            //this.Hide();
            //            MessageBox.Show("FAILEDDDDD!");
            //            break;
            //        case 2: Console.WriteLine("teacher");
            //            break;
            //        case 3:
            //            StudentPanel studentPanel = new StudentPanel();
            //            studentPanel.Show();
            //            this.Hide();
            //            break;
            //    }
            //}
            //else
            //{
            //    MessageBox.Show("Invalid Email and/or password", "Invalid Login");
            //    Console.WriteLine("Wrong email and password");
            //    Console.WriteLine("Why working now?");
            //}

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            //////    Console.WriteLine("Working Now?? Why??");
            //////    RegisterForm registerForm = new RegisterForm();
            //////    registerForm.Show();
            //////    this.Hide();
        }
    }
}
