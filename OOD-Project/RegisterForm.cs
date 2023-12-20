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
        // for STUDENT
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
            newUser.RoleId = UserRole.student;
            newUser.FirstName = inFName; newUser.LastName = inLName; newUser.Email = inEmail;
            newUser.Password = inPassword; newUser.Cpr = inCPR; newUser.Gender = inGender;
            newUser.Dob = inDOB; newUser.Phone = inPhone; newUser.Username = inUsername;
            newUser.Id = inStudentID; newUser.StatusId = UserStatus.pending;
            Console.WriteLine(newUser.LastName);
            // move to login page with autofill ?
            MessageBox.Show(newUser.ToString(), "New User");
        }

        // For TEACHER
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
            newUser.RoleId = UserRole.teacher;
            newUser.FirstName = inFName; newUser.LastName = inLName; newUser.Email = inEmail;
            newUser.Password = inPassword; newUser.Cpr = inCPR; newUser.Gender = inGender;
            newUser.Dob = inDOB; newUser.Phone = inPhone; newUser.Username = inUsername;
            newUser.Dept = inDept; newUser.StatusId = UserStatus.pending;
            Console.WriteLine(newUser.LastName);
            // move to login page with autofill ?
            MessageBox.Show(newUser.ToString(), "New User");
        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }

}
