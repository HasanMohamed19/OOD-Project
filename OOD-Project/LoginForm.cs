using System;
using System.Windows.Forms;

namespace OOD_Project
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        // fake email andpassword are just set
        string username = "admin";
        string password = "secret";
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string givenUsername = txtUsername.Text;
            string givenPassword = txtPassword.Text;
            int userRole = 3;
            // role ids
            // admin = 1
            /* role ids:
                admin = 1 
                teacher = 2
                student = 3
                it will be an enum
             */

            if (username == givenUsername && password == givenPassword)
            {
                switch (userRole)
                {
                    case 1:
                        AdminPanel adminPanel = new AdminPanel();
                        adminPanel.Show();
                        this.Hide();
                        break;
                    case 2: Console.WriteLine("teacher");
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
                MessageBox.Show("Invalid Email and/or password", "Invalid Login");
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
