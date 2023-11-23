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
            int userRole = 1;
            // role ids
            // admin = 1
            /* role ids:
                admin = 1 
                teacher = 2
                student = 3
             */

            if (username == givenUsername && password == givenPassword)
            {
                   
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
