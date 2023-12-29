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
            Helper.OpenChildForm(new usersListForms(), adminMainContent);

        }


        private void manageBranchesBtn_Click(object sender, EventArgs e)
        {
            Helper.OpenChildForm(new ManageBranchesForm(), adminMainContent);
        }

        private void manageInformationBtn_Click(object sender, EventArgs e)
        {

        }

        private void manageUsersBtn_Click(object sender, EventArgs e)
        {
            Helper.OpenChildForm(new usersListForms(), adminMainContent);
        }

 

        private void manageCoursesBtn_Click_1(object sender, EventArgs e)
        {
            Helper.OpenChildForm(new ManageCourseForm(this), adminMainContent);
        }

        private void btnAddAnouncement_Click(object sender, EventArgs e)
        {
            Helper.OpenChildForm(new AddAnouncementForm(), adminMainContent);
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
                    Helper.OpenChildForm(new ViewEmailForm(), adminMainContent);
                    break;
            }
        }

        public void GoToChangePassword()
        {
            Helper.OpenChildForm(new ChangePasswordForm(), adminMainContent);
        }

        public void SignOut()
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Close();
        }

        private void email_Click(object sender, EventArgs e)
        {
            Helper.OpenChildForm(new ViewEmailForm(), adminMainContent);
        }

        private void sendEmailBtn_Click(object sender, EventArgs e)
        {
            new EmailForm().ShowDialog();
        }
    }
}
