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
            int roleId = 0;
            if (dbm.Reader.Read())
            {

                int rid = dbm.Reader.GetOrdinal("role_id");
                int uid = dbm.Reader.GetOrdinal("user_id");
                int user_id = dbm.Reader.GetInt32(uid);
                Global.UserId = user_id;
                roleId = dbm.Reader.GetInt32(rid);
            }
            else
            {
                MessageBox.Show("Incorrect username or password. Please try again.");
                dbm.Connection.Close();
                return;
            }
            dbm.Connection.Close();
            switch (roleId)
            {
                case 1:
                    AdminPanel adminPanel = new AdminPanel();
                    adminPanel.Show();
                    this.Hide();
                    break;
                case 2:
                    TeacherPanel teacherPanel = new TeacherPanel();
                    Global.TeacherId = Teacher.GetTeacher(Global.UserId).TeacherId;
                    teacherPanel.Show();
                    this.Hide();
                    break;
                case 3:
                    StudentPanel studentPanel = new StudentPanel();
                    Global.StudentId = Student.GetStudent(Global.UserId).StudentId;
                    studentPanel.Show();
                    this.Hide();
                    break;
                default:
                    MessageBox.Show("Login unsuccessful.", "Login Failed");
                    break;
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            RegisterForm registerForm = new RegisterForm();
            registerForm.Show();
            this.Hide();
        }
    }
}
