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
    public partial class AddUserForm : Form
    {
        private usersListForms parentForm;
        public AddUserForm(usersListForms parentForm)
        {
            this.parentForm = parentForm;
            InitializeComponent();
            OpenChildForm(new AddStudentForm(this));
        }

        private void OpenChildForm(Form childForm)
        {
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.addUserContainer.Controls.Add(childForm);
            this.addUserContainer.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        public void CloseAndRefresh()
        {
            parentForm.RefreshView();
            this.Close();
        }

        private void btnRegisterAsStudent_Click(object sender, EventArgs e)
        {
            OpenChildForm(new AddStudentForm(this));
        }

        private void btnRegisterAsTeacher_Click(object sender, EventArgs e)
        {
            OpenChildForm(new AddTeacherForm(this));
        }
    }
}
