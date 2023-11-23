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

            if (username == givenUsername && password == givenPassword)
            {
                RegisterForm registerForm = new RegisterForm();
                registerForm.Show();
                this.Hide();
            }
            else
            {
                
                MessageBox.Show("Invalid Email and/or password", "Invalid Login");
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Hello, World");
        }
    }
}
