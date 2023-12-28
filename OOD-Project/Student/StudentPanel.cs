using OOD_Project.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace OOD_Project
{
    public partial class StudentPanel : Form, ProfileBarContainer
    {
        /*
         * // https://www.ietf.org/rfc/rfc6068.txt
            var url = "mailto:someone@somewhere.com";
            Process.Start(url);
         */
        private Student loggedInStudent;
        private User loggedInUser;
        public StudentPanel()
        {
            InitializeComponent();
            loggedInUser = User.GetUser(Global.UserId);
            profileBar.Initialize(loggedInUser, this);
            Helper.OpenChildForm(new ViewCoursesForm(), studentMainContent);
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
                    Helper.OpenChildForm(new ViewEmails(), studentMainContent);
                    break;
            }
        }

        private void viewCoursesBtn_Click(object sender, EventArgs e)
        {
            Helper.OpenChildForm(new ViewCoursesForm(), studentMainContent);
        }

        private void viewEmailBtn_Click(object sender, EventArgs e)
        {
            Helper.OpenChildForm(new ViewEmails(), studentMainContent);
        }

        private void viewAnnouncementBtn_Click(object sender, EventArgs e)
        {
            Helper.OpenChildForm(new ViewAnnouncementsForm(), studentMainContent);
        }

        public void GoToChangePassword()
        {
            Helper.OpenChildForm(new ChangePasswordForm(), studentMainContent);
        }

        public void SignOut()
        {
            LoginForm loginForm = new LoginForm();

            loginForm.Show();
            this.Close();
        }
    }
}
