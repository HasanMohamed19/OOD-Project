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
    public partial class AddTeacherForm : Form
    {
        private AddUserForm parentForm;
        private bool activateUser;
        public AddTeacherForm(AddUserForm parentForm, bool activateUser)
        {
            this.parentForm = parentForm;
            InitializeComponent();
            InitializeComboBoxes();
            btnAdd.Enabled = false;
            this.parentForm = parentForm;
            this.activateUser = activateUser;
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
            UserStatus status = activateUser ? UserStatus.accepted : UserStatus.inactive;

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
            // create user based on data received
            Teacher teacher = new Teacher(0, inFName + "_" + inLName, inCPR, inEmail, UserRole.teacher, status,
                0, inFName, inLName, inDOB, inCPR, inGender, inPhone, inBranch, inProgramme, inTeacherId);

            // if there is teacher with universityId already, dont add
            if (Teacher.InactiveTeacherExistsWithId(teacher.TeacherUniversityId, -1)) // use -1 because this is new teacher
            {
                MessageBox.Show("There is already a teacher with the same Teacher ID in the system. Please add a teacher with a different ID or delete the existing one.", "Teacher Already Exists");
                return;
            }

            Teacher.AddTeacher(teacher);
            parentForm.CloseAndRefresh();
        }

        private void setButtonEnabled()
        {
            if ((txtEmailT.Text != String.Empty) && (txtTeacherId.Text != String.Empty) && (txtCPRT.Text != String.Empty)
                && (txtFNameT.Text != String.Empty) && (txtLNameT.Text != String.Empty) && (txtPhoneT.Text != String.Empty) && (txtTeacherId.Text != String.Empty)
                && (!radioMaleT.Checked || !radioFemaleT.Checked) && comboProgramme.SelectedIndex != -1 && comboBranch.SelectedIndex != -1)
            {                
                btnAdd.Enabled = true;
            }
            else
            {
                btnAdd.Enabled = false;
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

        private void txtPhoneT_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtTeacherId_TextChanged(object sender, EventArgs e)
        {
            setButtonEnabled();
        }

        private void txtPhoneT_TextChanged(object sender, EventArgs e)
        {
            setButtonEnabled();
        }

        private void comboProgramme_SelectedIndexChanged(object sender, EventArgs e)
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
