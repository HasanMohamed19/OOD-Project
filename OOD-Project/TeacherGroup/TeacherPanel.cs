﻿using OOD_Project.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace OOD_Project
{
    public partial class TeacherPanel : Form, ProfileBarContainer
    {
        private Teacher loggedInTeacher;
        private User loggedInUser;
        public TeacherPanel()
        {
            InitializeComponent();
            loggedInUser = User.GetUser(Global.UserId);
            loggedInTeacher = Teacher.GetTeacher(loggedInUser.UserId);
            profileBar.Initialize(loggedInUser, this);
            Helper.OpenChildForm(new TeacherGroup.TeacherViewCoursesForm(loggedInTeacher), teacherMainContent);
        }

        public void GoToChangePassword()
        {
            Helper.OpenChildForm(new ChangePasswordForm(), teacherMainContent);
        }

        public void PerformNotificationAction(NotificationType type)
        {
            switch (type)
            {
                case NotificationType.announcement:
                    // go to announcement tab
                    Helper.OpenChildForm(new ViewAnnouncementsForm(loggedInUser.UserId), teacherMainContent);
                    break;
                case NotificationType.email:
                    // go to email tab
                    Helper.OpenChildForm(new ViewEmailForm(), teacherMainContent);
                    break;
            }
        }

        public void SignOut()
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Close();
        }

        private void viewCoursesBtn_Click(object sender, EventArgs e)
        {
            Helper.OpenChildForm(new TeacherGroup.TeacherViewCoursesForm(loggedInTeacher), teacherMainContent);
        }

        private void viewEmailsBtn_Click(object sender, EventArgs e)
        {
            Helper.OpenChildForm(new ViewEmailForm(), teacherMainContent);
        }

        private void sendEmailBtn_Click(object sender, EventArgs e)
        {
            new EmailForm(null).ShowDialog();
        }

        private void announcementsBtn_Click(object sender, EventArgs e)
        {
            Helper.OpenChildForm(new ViewAnnouncementsForm(loggedInUser.UserId), teacherMainContent);
        }
    }
}
