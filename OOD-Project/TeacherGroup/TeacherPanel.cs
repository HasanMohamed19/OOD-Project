using OOD_Project.Helpers;
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
    public partial class TeacherPanel : Form, NotificationMenuContainer
    {
        private Teacher loggedInTeacher;
        private User loggedInUser;
        private bool notificationMenuOpened;
        public TeacherPanel()
        {
            InitializeComponent();
            loggedInUser = User.GetUser(Global.UserId);
            loggedInTeacher = Teacher.GetTeacher(loggedInUser.UserId);
            notificationMenuOpened = false;
            CheckUnreadNotifications();
            Helper.OpenChildForm(new TeacherGroup.TeacherViewCoursesForm(loggedInTeacher), teacherMainContent);
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
            }
            else
            {
                btnNotificationBell.BackgroundImage = Properties.Resources.bell_icon;
            }
        }

        private void OpenNotificationMenu(User user, TeacherPanel parentForm)
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
                    break;
            }
        }
        private void btnNotificationBell_Click(object sender, EventArgs e)
        {
            OpenNotificationMenu(loggedInUser, this);
        }

        private void viewCoursesBtn_Click(object sender, EventArgs e)
        {
            Helper.OpenChildForm(new TeacherGroup.TeacherViewCoursesForm(loggedInTeacher), teacherMainContent);
        }
    }
}
