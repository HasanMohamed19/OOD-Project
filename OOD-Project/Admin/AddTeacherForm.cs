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
    public partial class AddTeacherForm : Form
    {
        private AddUserForm parentForm;
        public AddTeacherForm(AddUserForm parentForm)
        {
            this.parentForm = parentForm;
            InitializeComponent();
            InitializeComboBoxes();
            this.parentForm = parentForm;
        }
        List<Branch> branches = Branch.GetBranches();

        private void InitializeComboBoxes()
        {
            foreach (Branch branch in branches)
            {
                comboBranch.Items.Add(branch.BranchName);
            }
            comboProgramme.Items.Add("ICT");
            comboProgramme.Items.Add("Business");
            comboProgramme.Items.Add("Creative Media");
            comboProgramme.Items.Add("Engineering");
            comboProgramme.Items.Add("Logistics");
            comboProgramme.Items.Add("Foundation");
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            string inEmail = txtEmailT.Text;
            Branch inBranch = branches[comboBranch.SelectedIndex];
            Programme inProgramme = (Programme)(comboProgramme.SelectedIndex + 1);
            string inCPR = txtCPRT.Text;
            string inFName = txtFNameT.Text;
            string inLName = txtLNameT.Text;
            string inPhone = txtPhoneT.Text;
            // get gender from radio buttons and store as char 'M' or 'F'
            char inGender;
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
                return;
            }
            DateTime inDOB = dateDOBT.Value.Date;
            string inTeacherId = txtTeacherId.Text;

            // create user based on data received
            Teacher teacher = new Teacher(0, inFName + "_" + inLName, inCPR, inEmail, UserRole.teacher, UserStatus.inactive, false,
                inFName, inLName, inDOB, inCPR, inGender, inPhone, inBranch, inProgramme, inTeacherId);

            // if there is teacher with universityId already, dont add
            if (Teacher.InactiveTeacherExistsWithId(teacher.TeacherUniversityId))
            {
                MessageBox.Show("There is already a teacher with the same Teacher ID in the system. Please add a teacher with a different ID or delete the existing one.", "Teacher Already Exists");
                return;
            }

            Teacher.AddTeacher(teacher);
            parentForm.CloseAndRefresh();
        }
    }
}