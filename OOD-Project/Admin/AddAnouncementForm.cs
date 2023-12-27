using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOD_Project.Admin
{
    public partial class AddAnouncementForm : Form
    {
        public AddAnouncementForm()
        {
            InitializeComponent();
        }

        private void btnPublishAnouncement_Click(object sender, EventArgs e)
        {
            string body = txtBody.Text;
            string title = txtTitle.Text;
            Announcement announcement = new Announcement(0, body, DateTime.Now, true, title, Announcement.AnnouncementType.simple);
            Announcement.PublishAnnouncement(announcement);
            // clear the textboxes for new announcement
            txtBody.Text = "";
            txtTitle.Text = "";
        }
    }
}
