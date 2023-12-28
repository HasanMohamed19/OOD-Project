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
using OOD_Project.Helpers;

namespace OOD_Project
{
    public partial class AdminPanel : Form, ProfileBarContainer
    {
        private User loggedInUser;
        public AdminPanel()
        {
            InitializeComponent();
            loggedInUser = User.GetUser(Global.UserId);
            profileBar.Initialize(loggedInUser, this);

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

        private void btnAddAnouncement_Click(object sender, EventArgs e)
        {
            OpenChildForm(new AddAnouncementForm(), sender);
        }

        public void PerformNotificationAction(NotificationType type)
        {
            switch (type)
            {
                case NotificationType.announcement:
                    // go to announcement tab
                    break;
                case NotificationType.email:
                    // go to email tab
                    break;
            }
        }

        public void GoToChangePassword()
        {
            throw new NotImplementedException();
        }

        public void SignOut()
        {
            throw new NotImplementedException();
        }
    }
}
