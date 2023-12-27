using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OOD_Project.Helpers;

namespace OOD_Project.Admin
{
    public partial class AddUserForm : Form
    {
        private usersListForms parentForm;
        public AddUserForm(usersListForms parentForm)
        {
            this.parentForm = parentForm;
            InitializeComponent();
            Helper.OpenChildForm(new AddStudentForm(this), addUserContainer);
        }

        public void CloseAndRefresh()
        {
            parentForm.RefreshView();
            this.Close();
        }

        private void btnRegisterAsStudent_Click(object sender, EventArgs e)
        {
            Helper.OpenChildForm(new AddStudentForm(this), addUserContainer);
        }

        private void btnRegisterAsTeacher_Click(object sender, EventArgs e)
        {
            Helper.OpenChildForm(new AddTeacherForm(this), addUserContainer);
        }
    }
}
