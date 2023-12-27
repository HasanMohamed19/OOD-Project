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
    public partial class StudentPanel : Form, NotificationMenuContainer
    {
        /*
         * // https://www.ietf.org/rfc/rfc6068.txt
            var url = "mailto:someone@somewhere.com";
            Process.Start(url);
         */
        private Student loggedInStudent;
        private User loggedInUser;
        private bool notificationMenuOpened;
        public StudentPanel()
        {
            InitializeComponent();
            loggedInUser = User.GetUser(Global.User_id);
            notificationMenuOpened = false;
            CheckUnreadNotifications();
        }

        private void CheckUnreadNotifications()
        {
            if (User.UnreadNotificationsForUser(loggedInUser) <= 0)
            {
                // no unread notifications
                UpdateBell(false);
                return;
            }
            UpdateBell(true);
        }

        private void UpdateBell(bool enabled)
        {
            if (enabled)
            {
                btnNotificationBell.BackgroundImage = Properties.Resources.bell_icon_active;
            } else
            {
                btnNotificationBell.BackgroundImage = Properties.Resources.bell_icon;
            }
        }

        private void OpenNotificationMenu(User user, StudentPanel parentForm)
        {
            if (notificationMenuOpened)
            { 
                return;
            }
            List<Notification> notificationList = Notification.GetNotificationsForUser(user);
            NotificationMenu menu = new NotificationMenu(notificationList, parentForm);
            // place under notification bell
            Point menuLocation = btnNotificationBell.PointToScreen(Point.Empty);
            menuLocation.Offset(0, btnNotificationBell.Size.Height);
            menu.Location = menuLocation;
            menu.BringToFront();
            menu.Show();
            notificationMenuOpened = true;
        }

        public void NotificationMenuClosed()
        {
            // TODO: mark all notifications as read and save to db
            Notification.MarkAllReadForUser(loggedInUser);
            CheckUnreadNotifications();
            notificationMenuOpened = false;
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
                    OpenChildForm(new ViewEmails());
                    break;
            }
        }

        private void OpenChildForm(Form childForm)
        {

            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.studentMainContent.Controls.Add(childForm);
            this.studentMainContent.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void viewCoursesBtn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ViewCoursesForm());
        }

        private void btnNotificationBell_Click(object sender, EventArgs e)
        {
            OpenNotificationMenu(loggedInUser, this);
        }

        private void viewEmailBtn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ViewEmails());
        }

        private void viewAnnouncementBtn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ViewAnnouncementsForm());
        }
    }
}
