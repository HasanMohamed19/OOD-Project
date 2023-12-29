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
    public partial class ProfileBar : UserControl
    {
        private bool notificationMenuOpened = false;
        private bool profileMenuOpened = false;
        public ProfileBar()
        {
            InitializeComponent();
        }

        public void Initialize(User loggedInUser, ProfileBarContainer parentContainer)
        {
            LoggedInUser = loggedInUser;
            ParentContainer = parentContainer;
            CheckUnreadNotifications();
            SetUsername();
        }

        public ProfileBarContainer ParentContainer { get; set; }
        public List<Notification> NotificationList {  get; set; }
        public User LoggedInUser { get; set; }

        private void SetUsername()
        {
            string usertype = "Admin";
            if (LoggedInUser.RoleId == UserRole.student)
            {
                usertype = "Student";
            } else if (LoggedInUser.RoleId == UserRole.teacher) {
                usertype = "Teacher";
            }
            usernameLbl.Text = usertype + "\n" + LoggedInUser.Username;
        }
        public void PerformNotificationAction(NotificationType type)
        {
            ParentContainer.PerformNotificationAction(type);
        }
        public void GoToChangePassword()
        {
            ParentContainer.GoToChangePassword();
        }
        public void SignOut()
        {
            ParentContainer.SignOut();
        }
        public void NotificationMenuClosed()
        {
            // TODO: mark all notifications as read and save to db
            Notification.MarkAllReadForUser(LoggedInUser);
            CheckUnreadNotifications();
            notificationMenuOpened = false;
        }
        public void ProfileMenuClosed()
        {
            // TODO: mark all notifications as read and save to db
            profileMenuOpened = false;
        }
        private void OpenNotificationMenu(User user, ProfileBarContainer parentForm)
        {
            if (notificationMenuOpened)
            {
                return;
            }
            List<Notification> notificationList = Notification.GetNotificationsForUser(user);
            NotificationMenu menu = new NotificationMenu(notificationList, this);
            // place under notification bell
            Point menuLocation = btnNotificationBell.PointToScreen(Point.Empty);
            menuLocation.Offset(0, btnNotificationBell.Size.Height);
            menu.Location = menuLocation;
            menu.BringToFront();
            menu.Show();
            notificationMenuOpened = true;
        }

        private void OpenProfileMenu()
        {
            if (profileMenuOpened)
            {
                return;
            }
            ProfileMenu menu = new ProfileMenu(this);
            // place under notification bell
            Point menuLocation = btnProfile.PointToScreen(Point.Empty);
            menuLocation.Offset(0, btnProfile.Size.Height);
            menu.Location = menuLocation;
            menu.BringToFront();
            menu.Show();
            profileMenuOpened = true;
        }

        private void CheckUnreadNotifications()
        {
            if (User.UnreadNotificationsForUser(LoggedInUser) <= 0)
            {
                // no unread notifications
                UpdateBell(false);
                return;
            }
            UpdateBell(true);
        }

        // update bell color
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

        private void btnProfile_Click(object sender, EventArgs e)
        {
            OpenProfileMenu();
        }

        private void btnNotificationBell_Click(object sender, EventArgs e)
        {
            OpenNotificationMenu(LoggedInUser, ParentContainer);
        }
    }
}
