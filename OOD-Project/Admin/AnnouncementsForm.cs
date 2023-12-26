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
    public partial class AnnouncementsForm : Form
    {
        private AnnouncementsList manageAnnouncements;
        private Announcement selectedAnnouncement;
        private int idx;
        public AnnouncementsForm(AnnouncementsList announcementsList)
        {
            InitializeComponent();
            manageAnnouncements = announcementsList;
        }

        public AnnouncementsForm(AnnouncementsList announcementsList,Announcement announcement,int idx)
        {
            this.selectedAnnouncement = announcement;
            this.manageAnnouncements = announcementsList;
            this.idx = idx;
            txtContent.Text = announcement.Content;
            txtTitle.Text = announcement.Title;
        }

        private void btnSendAnnouncement_Click(object sender, EventArgs e)
        {
            try
            {
                string title = txtTitle.Text;
                string content = txtContent.Text;
                //string sentBy = Admin.name
                string sentBy = "admin";
                DateTime currentDate = DateTime.Today;
                TimeSpan currentTime = DateTime.Now.TimeOfDay;
                Announcement announcement = new Announcement(title, content, sentBy, currentDate, currentTime);
                ListViewItem item = new ListViewItem(
                    announcement.Id.ToString());
                item.Tag = announcement;
                item.SubItems.Add(announcement.Title);
                item.SubItems.Add(announcement.Sender);
                item.SubItems.Add(announcement.DateSent.ToString("dd/MM/yyyy"));
                item.SubItems.Add(announcement.TimeSent.ToString(@"hh\:mm\:ss"));
                manageAnnouncements.GetAnnouncementListView().Items.Add(item);
                manageAnnouncements.GetAnnouncements().Add(announcement);
                MessageBox.Show("Announcement sent successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error has occured", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.Close();
            manageAnnouncements.adminPanel.Show();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            manageAnnouncements.adminPanel.Show();
        }
    }
}
