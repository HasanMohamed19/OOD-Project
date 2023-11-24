using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOD_Project
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }





        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        // store all details into variables and create user object
        private void btnRegister_Click(object sender, EventArgs e)
        {
            string inUsername = txtUsername.Text;
            string inPassword = txtPassword.Text;
            string inConfirm = txtConfirm.Text;
            string inEmail = txtEmail.Text;
            string inStudentID = txtStudentID.Text;
            string inCPR = txtCPR.Text;
            string inFName = txtFName.Text;
            string inLName = txtLName.Text;
            string inPhone = txtPhone.Text;
            // get gender from radio buttons and store as char 'M' or 'F'
            char inGender = 'X';
            if (radioMale.Checked )
            {
                inGender = 'M';
            } else if (radioFemale.Checked) {
                inGender = 'F';
            } else {
                MessageBox.Show("Please select a gender to continue.", "Gender Not Selected");
            }
            DateTime inDOB = dateDOB.Value.Date;

            // create user based on data received
            Student newUser = new Student();
            newUser.RoleId = 3;
            newUser.FirstName = inFName; newUser.LastName = inLName; newUser.Email = inEmail;
            newUser.Password = inPassword; newUser.Cpr = inCPR; newUser.Gender = inGender;
            newUser.Dob = inDOB; newUser.Phone = inPhone; newUser.Username = inUsername;
            newUser.Id = inStudentID;
            Console.WriteLine(newUser.LastName);
            // move to login page with autofill ?
            MessageBox.Show(newUser.ToString(), "New User");
        }

        private void btnRegisterT_Click(object sender, EventArgs e)
        {
            string inUsername = txtUsernameT.Text;
            string inPassword = txtPassT.Text;
            string inConfirm = txtConfirmT.Text;
            string inEmail = txtEmailT.Text;
            string inDept = txtDeptT.Text;
            string inCPR = txtCPRT.Text;
            string inFName = txtFNameT.Text;
            string inLName = txtLNameT.Text;
            string inPhone = txtPhoneT.Text;
            // get gender from radio buttons and store as char 'M' or 'F'
            char inGender = 'X';
            if (radioMaleT.Checked)
            {
                inGender = 'M';
            }
            else if (radioFemaleT.Checked)
            {
                inGender = 'F';
            }
            else
            {
                MessageBox.Show("Please select a gender to continue.", "Gender Not Selected");
            }
            DateTime inDOB = dateDOBT.Value.Date;

            // create user based on data received
            Teacher newUser = new Teacher();
            newUser.RoleId = 2;
            newUser.FirstName = inFName; newUser.LastName = inLName; newUser.Email = inEmail;
            newUser.Password = inPassword; newUser.Cpr = inCPR; newUser.Gender = inGender;
            newUser.Dob = inDOB; newUser.Phone = inPhone; newUser.Username = inUsername;
            newUser.Dept = inDept;
            Console.WriteLine(newUser.LastName);
            // move to login page with autofill ?
            MessageBox.Show(newUser.ToString(), "New User");
        }
    }
    class User
    {
        private string firstName;
        private string lastName;
        private string phone;
        private string cpr;
        private string username;
        private string password;
        private string email;
        private char gender;
        private DateTime dob;
        private int roleId;

        public string FirstName { get { return firstName; } set { firstName = value; } }
        public string LastName { get { return lastName; } set { lastName = value; } }
        public string Email { get { return email; } set { email = value; } }
        public int RoleId { get { return roleId; } set { roleId = value; } }

        public string Phone { get => phone; set => phone = value; }
        public string Password { get => password; set => password = value; }
        public string Username { get => username; set => username = value; }
        public char Gender { get => gender; set => gender = value; }
        public DateTime Dob { get => dob; set => dob = value; }
        public string Cpr { get => cpr; set => cpr = value; }

        public User()
        {

        }

        public User(string firstName, string lastName, string email, int roleId)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.email = email;
            this.roleId = roleId;
        }

        public override string ToString()
        {
            string rolename = "";
            switch (RoleId)
            {
                case 1:
                    rolename = "admin";
                    break;
                case 2:
                    rolename = "teacher";
                    break;
                case 3:
                    rolename = "student";
                    break;
            }
            return rolename + " " + FirstName + " " + LastName + "\n"
                + Email + " " + Cpr + " " + "\n"
                + Username + " " + Password + " " + Phone + "\n"
                + Dob + " " + Gender;
        }
    }

    class Student : User
    {
        private string id;

        public string Id { get => id; set => id = value; }

        public override string ToString()
        {
            string rolename = "";
            switch (RoleId)
            {
                case 1:
                    rolename = "admin";
                    break;
                case 2:
                    rolename = "teacher";
                    break;
                case 3:
                    rolename = "student";
                    break;
            }
            return rolename + " " + FirstName + " " + LastName + "\n"
                + Email + " " + Cpr + " " + id + "\n"
                + Username + " " + Password + " " + Phone + "\n"
                + Dob + " " + Gender;
        }
    }

    class Teacher : User
    {
        private string dept;

        public string Dept { get => dept; set => dept = value; }

        public override string ToString()
        {
            string rolename = "";
            switch (RoleId)
            {
                case 1:
                    rolename = "admin";
                    break;
                case 2:
                    rolename = "teacher";
                    break;
                case 3:
                    rolename = "student";
                    break;
            }
            return rolename + " " + FirstName + " " + LastName + "\n"
                + Email + " " + Cpr + " " + dept + "\n"
                + Username + " " + Password + " " + Phone + "\n"
                + Dob + " " + Gender;
        }
    }
}
