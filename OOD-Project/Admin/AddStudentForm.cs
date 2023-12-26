﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOD_Project.Admin
{
    public partial class AddStudentForm : Form
    {
        private AddUserForm parentForm;
        public AddStudentForm(AddUserForm parentForm)
        {
            this.parentForm = parentForm;
            InitializeComponent();
            InitializeComboBox();
            this.parentForm = parentForm;
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

            // if there is student with universityId already, dont add
            if (Student.InactiveStudentExistsWithId(student.StudentUniversityId))
            {
                MessageBox.Show("There is already a student with the same Student ID in the system. Please add a student with a different ID or delete the existing one.", "Student Already Exists");
                return;
            }

            Student.AddStudent(student);
            parentForm.CloseAndRefresh();
        }
    }
}
