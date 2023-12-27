using System;
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
    public partial class EditTeacherForm : Form
    {
        Teacher oldTeacher;
        usersListForms parentForm;
        public EditTeacherForm(Teacher oldTeacher, usersListForms parentForm)
        {
            InitializeComponent();
            InitializeComboBoxes();
            this.oldTeacher = oldTeacher;
            this.parentForm = parentForm;
            UpdateView();
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

            // create user based on data received
            Teacher teacher = new Teacher(oldTeacher.UserId, inFName + "_" + inLName, inCPR, inEmail, UserRole.teacher, UserStatus.inactive, false,
                inFName, inLName, inDOB, inCPR, inGender, inPhone, inBranch, inProgramme, inTeacherId);

            // if there is teacher with universityId already, dont update
            if (Teacher.InactiveTeacherExistsWithId(teacher.TeacherUniversityId))
            {
                MessageBox.Show("There is already a teacher with the same Teacher ID in the system. Please add a teacher with a different ID or delete the existing one.", "Teacher Already Exists");
                return;
            }

            Teacher.UpdateTeacher(teacher);
            CloseAndRefresh();
        }
    }
}
