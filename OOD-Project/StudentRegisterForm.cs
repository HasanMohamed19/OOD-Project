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
    public partial class StudentRegisterForm : Form
    {
        public StudentRegisterForm()
        {
            InitializeComponent();
            InitializeComboBox();
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

        private void btnRegister_Click(object sender, EventArgs e)
        {
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

            // TODO: implement validation
            Student student = new Student(0, inFName + "_" + inLName, inCPR, inEmail, UserRole.student, UserStatus.pending, false
                , inFName, inLName, inDOB, inCPR, inGender, inPhone, inMajor, inStudentID);

            try
            {
                Student.IsStudentIdValid(student.StudentUniversityId);
            } catch {
                MessageBox.Show("ID could not be found in the system or there is already a user with this id.","Could not register");
                return;
            }

            Student.AddStudent(student);

            //MessageBox.Show(newUser.ToString(), "New User");
        }
    }
}
