using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OOD_Project.Admin;

namespace OOD_Project
{
    public partial class AdminPanel : Form
    {
        public AdminPanel()
        {
            InitializeComponent();
           
        }

        private void OpenChildForm(Form childForm, object senderBtn)
        {
            
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.adminMainContent.Controls.Add(childForm);
            this.adminMainContent.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void manageBranchesBtn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ManageBranchesForm(), sender);
        }

        private void manageInformationBtn_Click(object sender, EventArgs e)
        {

        }

        private void manageUsersBtn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new usersListForms(), sender);
        }

 

        private void manageCoursesBtn_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new ManageCourseForm(this), sender);
        }
    }
}
