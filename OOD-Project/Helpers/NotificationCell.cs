using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOD_Project.Helpers
{
    public partial class NotificationCell : UserControl
    {
        private Notification notification;
        private NotificationMenu parentMenu;

        public NotificationCell(Notification notification, NotificationMenu parentMenu)
        {
            InitializeComponent();
            this.parentMenu = parentMenu;
            this.notification = notification;
            SetLabels();
        }

        private void SetLabels()
        {
            lblBody.Text = notification.Body;
            lblTitle.Text = notification.Title;

            if (!notification.Read)
            {
                lblTitle.ForeColor = Color.Red;
            }
        }


        private void lblBody_Click(object sender, EventArgs e)
        {
            parentMenu.PerformNotificationAction(notification.Type);

        }
    }
}
