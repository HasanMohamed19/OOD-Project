﻿using System;
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
    public partial class EditTeacherForm : Form
    {
        Teacher oldTeacher;
        ManageUsersForm parentForm;
        public EditTeacherForm(Teacher oldTeacher, ManageUsersForm parentForm)
        {
            InitializeComponent();
            InitializeComboBoxes();
            this.oldTeacher = oldTeacher;
            this.parentForm = parentForm;
            UpdateView();
            btnSave.Enabled = false;
        }
        List<Branch> branches = Branch.GetBranches();
        public void CloseAndRefresh()
        {
            parentForm.RefreshView();
            this.Close();
        }


        private int GetIndexOfBranch(Branch branch)
        {
            foreach (Branch b in branches)
            {
                if (branch.BranchId == b.BranchId)
                {
                    return branches.IndexOf(b);
                }
            }
            return -1;
        }
        private void UpdateView()
        {
            txtCPRT.Text = oldTeacher.Cpr;
            txtEmailT.Text = oldTeacher.Email;
            txtFNameT.Text = oldTeacher.FirstName;
            txtLNameT.Text = oldTeacher.LastName;
            txtPhoneT.Text = oldTeacher.PhoneNumber;
            txtTeacherId.Text = oldTeacher.TeacherUniversityId;
            comboBranch.SelectedIndex = GetIndexOfBranch(oldTeacher.ForBranch);
            comboProgramme.SelectedIndex = (int)oldTeacher.InProgramme;
            dateDOBT.Value = oldTeacher.Dob;
            if (oldTeacher.Gender == 'M')
            {
                radioMaleT.Checked = true;
            }
            else if (oldTeacher.Gender == 'F')
            {
                radioFemaleT.Checked = true;
            }
        }
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

        private void btnSave_Click(object sender, EventArgs e)
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
            // validate email
            if (!Regex.Match(inEmail, "^[\\w-\\.]+@([\\w-]+\\.)+[\\w-]{2,4}$").Success)
            {
                MessageBox.Show("Your email is invalid. Please retry.", "Invalid Email");
                return;
            }
            if (oldTeacher.Email != inEmail)
            {
                if (User.GetUserIdByEmail(inEmail) != -1) // if user already exists with this email, dont allow
                {
                    MessageBox.Show("Email already in use. Please try another email.", "Invalid Email");
                    return;
                }
            }
            // create user based on data received
            Teacher teacher = new Teacher(oldTeacher.UserId, inFName + "_" + inLName, inCPR, inEmail, UserRole.teacher, UserStatus.inactive,
                oldTeacher.TeacherId, inFName, inLName, inDOB, inCPR, inGender, inPhone, inBranch, inProgramme, inTeacherId);

            // if there is teacher with universityId already, dont update
            if (Teacher.InactiveTeacherExistsWithId(teacher.TeacherUniversityId, teacher.TeacherId))
            {
                MessageBox.Show("There is already a teacher with the same Teacher ID in the system. Please add a teacher with a different ID or delete the existing one.", "Teacher Already Exists");
                return;
            }

            Teacher.UpdateTeacher(teacher);
            CloseAndRefresh();
        }

        private void setButtonEnabled()
        {
            if ((txtEmailT.Text != String.Empty) && (txtTeacherId.Text != String.Empty) && (txtCPRT.Text != String.Empty)
                && (txtFNameT.Text != String.Empty) && (txtLNameT.Text != String.Empty) && (txtPhoneT.Text != String.Empty) && (txtTeacherId.Text != String.Empty)
                && (!radioMaleT.Checked || !radioFemaleT.Checked) && comboProgramme.SelectedIndex != -1 && comboBranch.SelectedIndex != -1)
            {
                btnSave.Enabled = true;
            }
            else
            {
                btnSave.Enabled = false;
            }
        }

        private void txtTeacherId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtCPRT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtFNameT_TextChanged(object sender, EventArgs e)
        {
            setButtonEnabled();
        }

        private void txtLNameT_TextChanged(object sender, EventArgs e)
        {
            setButtonEnabled();
        }

        private void txtEmailT_TextChanged(object sender, EventArgs e)
        {
            setButtonEnabled();
        }

        private void txtCPRT_TextChanged(object sender, EventArgs e)
        {
            setButtonEnabled();
        }

        private void comboProgramme_SelectedIndexChanged(object sender, EventArgs e)
        {
            setButtonEnabled();
        }

        private void txtTeacherId_TextChanged(object sender, EventArgs e)
        {
            setButtonEnabled();
        }

        private void txtPhoneT_TextChanged(object sender, EventArgs e)
        {
            setButtonEnabled();
        }

        private void comboBranch_SelectedIndexChanged(object sender, EventArgs e)
        {
            setButtonEnabled();
        }

        private void txtFNameT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;  // Prevent non-letter keys
            }
        }

        private void txtLNameT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;  // Prevent non-letter keys
            }
        }
    }
}
