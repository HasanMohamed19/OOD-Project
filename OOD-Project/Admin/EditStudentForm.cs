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
    public partial class EditStudentForm : Form
    {
        private ManageUsersForm parentForm;
        private Student oldStudent;
        List<Major> majors;
        public EditStudentForm(Student oldStudent, ManageUsersForm parentForm)
        {
            majors = Major.GetMajors();
            InitializeComponent();
            InitializeComboBox();
            this.parentForm = parentForm;
            this.oldStudent = oldStudent;
            UpdateView();
        }

        public void CloseAndRefresh()
        {
            parentForm.RefreshView();
            this.Close();
        }

        private void InitializeComboBox()
        {
            // update combo box
            foreach (Major major in majors)
            {
                comboMajor.Items.Add(major.Name);
            }
        }

        private int GetIndexOfMajor(Major major)
        {
            foreach (Major m in majors)
            {
                if (major.MajorId == m.MajorId)
                {
                    return majors.IndexOf(m);
                }
            }
            return -1;
        }

        private void UpdateView()
        {
            txtCPR.Text = oldStudent.Cpr;
            txtEmail.Text = oldStudent.Email;
            txtFName.Text = oldStudent.FirstName;
            txtLName.Text = oldStudent.LastName;
            txtPhone.Text = oldStudent.PhoneNumber;
            txtStudentID.Text = oldStudent.StudentUniversityId;
            comboMajor.SelectedIndex = GetIndexOfMajor(oldStudent.InMajor);
            dateDOB.Value = oldStudent.Dob;
            if (oldStudent.Gender == 'M')
            {
                radioMale.Checked = true;
            } else if (oldStudent.Gender == 'F')
            {
                radioFemale.Checked = true;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
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
            Student student = new Student(oldStudent.UserId, inFName + "_" + inLName, inCPR, inEmail, UserRole.student, UserStatus.pending
                ,oldStudent.StudentId, inFName, inLName, inDOB, inCPR, inGender, inPhone, inMajor, inStudentID);

            // if there is student with universityId already, dont update
            if (Student.InactiveStudentExistsWithId(student.StudentUniversityId))
            {
                MessageBox.Show("There is already a student with the same Student ID in the system. Please add a student with a different ID or delete the existing one.", "Student Already Exists");
                return;
            }

            Student.UpdateStudent(student);
            CloseAndRefresh();
        }
    }
}
