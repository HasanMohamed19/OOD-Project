using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOD_Project.Admin
{
    public partial class AddStudentForm : Form
    {
        private AddUserForm parentForm;
        private bool activateUser;
        public AddStudentForm(AddUserForm parentForm, bool activateUser)
        {
            
            this.parentForm = parentForm;
            this.activateUser = activateUser;
            InitializeComponent();
            InitializeComboBox();
            btnRegister.Enabled = false;
        }

        List<Major> majors = Major.GetMajors();
        private void InitializeComboBox()
        {
            // update combo box
            foreach (Major major in majors)
            {
                comboMajor.Items.Add(major.Name);
            }
        }

        private void setButtonEnabled()
        {
            if ((txtEmail.Text != String.Empty) && (txtStudentID.Text != String.Empty) && (txtCPR.Text != String.Empty)
                && (txtFName.Text != String.Empty) && (txtLName.Text != String.Empty) && (txtPhone.Text != String.Empty) && (txtStudentID.Text != String.Empty)
                && (!radioMale.Checked || !radioFemale.Checked) && comboMajor.SelectedIndex != -1)
            {
                btnRegister.Enabled = true;
            }
            else
            {
                btnRegister.Enabled = false;
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            UserStatus status = activateUser ? UserStatus.accepted : UserStatus.inactive;

            string inEmail = txtEmail.Text;
            string inStudentID = txtStudentID.Text;
            string inCPR = txtCPR.Text;
            string inFName = txtFName.Text;
            string inLName = txtLName.Text;
            string inPhone = txtPhone.Text;
            Major inMajor = majors[comboMajor.SelectedIndex]; // get major from combo box
            // get gender from radio buttons and store as char 'M' or 'F'
            char inGender;
            if (radioMale.Checked)
            {
                inGender = 'M';
            }
            else if (radioFemale.Checked)
            {
                inGender = 'F';
            }
            else
            {
                MessageBox.Show("Please select a gender to continue.", "Gender Not Selected");
                return;
            }
            DateTime inDOB = dateDOB.Value.Date;

            // validate email
            if (!Regex.Match(inEmail, "^[\\w-\\.]+@([\\w-]+\\.)+[\\w-]{2,4}$").Success)
            {
                MessageBox.Show("Your email is invalid. Please retry.","Invalid Email");
                return;
            }

            // TODO: implement validation
            Student student = new Student(0, inFName + "_" + inLName, inCPR, inEmail, UserRole.student, status
                ,0, inFName, inLName, inDOB, inCPR, inGender, inPhone, inMajor, inStudentID);

            // if there is student with universityId already, dont add
            if (Student.InactiveStudentExistsWithId(student.StudentUniversityId, -1)) // use -1 because this is new student
            {
                MessageBox.Show("There is already a student with the same Student ID in the system. Please add a student with a different ID or delete the existing one.", "Student Already Exists");
                return;
            }

            Student.AddStudent(student);
            parentForm.CloseAndRefresh();
        }

        private void txtStudentID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtCPR_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtFName_TextChanged(object sender, EventArgs e)
        {
            setButtonEnabled();
        }

        private void txtLName_TextChanged(object sender, EventArgs e)
        {
            setButtonEnabled();
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            setButtonEnabled();
        }

        private void txtCPR_TextChanged(object sender, EventArgs e)
        {
            setButtonEnabled();
        }

        private void txtStudentID_TextChanged(object sender, EventArgs e)
        {
            setButtonEnabled();
        }

        private void txtPhone_TextChanged(object sender, EventArgs e)
        {
            setButtonEnabled();
        }

        private void comboMajor_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (comboMajor.SelectedIndex != -1)
            //{
            //    setButtonEnabled();
            //}
            setButtonEnabled();
        }

        private void txtFName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;  // Prevent non-letter keys
            }
        }
    }
}
