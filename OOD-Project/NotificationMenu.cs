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

namespace OOD_Project
{
    public partial class NotificationMenu : Form
    {
        private List<Notification> notificationList;
        private NotificationMenuContainer parentForm;
        public NotificationMenu(List<Notification> notificationList, NotificationMenuContainer parentForm)
        {
            InitializeComponent();
            this.notificationList = notificationList;
            this.parentForm = parentForm;
            AddNotifications();
            SetUnread();
        }

        private void SetUnread()
        {
            // count unread notifications
            int unreadCount = 0;
            foreach (Notification notification in notificationList)
            {
                if (!notification.Read) {
                    unreadCount++;
                }
            }

            lblUnread.Text = unreadCount + " Unread";
        }

        private void AddNotifications()
        {
            foreach (Notification notification in notificationList)
            {
                // create new notification cell and add it
                _ = new NotificationCell(notification, this)
                {
                    Parent = panelNotifications
                };
            }
        }

        public void PerformNotificationAction(NotificationType type)
        {
            parentForm.PerformNotificationAction(type);
        }

        private void NotificationMenu_Deactivate(object sender, EventArgs e)
        {
            this.Close();
        }

        private void NotificationMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            parentForm.NotificationMenuClosed();
        }
    }
}
