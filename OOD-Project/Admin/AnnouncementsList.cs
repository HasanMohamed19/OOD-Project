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
    //Hide add/edit/delete from regular users
    public partial class AnnouncementsList : Form
    {
        private List<Announcement> announcements = new List<Announcement>();
        public AdminPanel adminPanel;
        public AnnouncementsList(AdminPanel adminPanel)
        {
            InitializeComponent();
            this.adminPanel = adminPanel;
            announcements.Add(new Announcement("Announcement Title", "Announcement Content", "Dr. Phil", DateTime.Today, DateTime.Now.TimeOfDay));
            announcements.Add(new Announcement("Announcement Title", "Announcement Content", "Dr. Phil", DateTime.Today, DateTime.Now.TimeOfDay));
            announcements.Add(new Announcement("Announcement Title", "Announcement Content", "Dr. Phil", DateTime.Today, DateTime.Now.TimeOfDay));
            announcements.Add(new Announcement("Announcement Title", "Announcement Content", "Dr. Phil", DateTime.Today, DateTime.Now.TimeOfDay));
            foreach (var announcement in announcements)
            {
                ListViewItem item = new ListViewItem(
                    announcement.Id.ToString());
                item.Tag = announcement;
                item.SubItems.Add(announcement.Title);
                item.SubItems.Add(announcement.Sender);
                item.SubItems.Add(announcement.DateSent.ToString("dd/MM/yyyy"));
                item.SubItems.Add(announcement.TimeSent.ToString(@"hh\:mm\:ss"));
                announcementListView.Items.Add(item);
            }
        }

        private void addAnnouncementBtn_Click(object sender, EventArgs e)
        {
            AnnouncementsForm announcementsForm = new AnnouncementsForm(this);
            announcementsForm.Show();
            adminPanel.Hide();
        }

        public ListView GetAnnouncementListView()
        {
            return announcementListView;
        }

        public List<Announcement> GetAnnouncements()
        {
            return announcements;
        }

        private void editAnnouncementBtn_Click(object sender, EventArgs e)
        {
            if (announcementListView.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select an announcement to edit", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ListViewItem selectedItem = announcementListView.SelectedItems[0];
            Announcement selectedAnnouncement = (Announcement)selectedItem.Tag;
            AnnouncementsForm announcementsForm = new AnnouncementsForm(this,selectedAnnouncement,selectedItem.Index);
            announcementsForm.Show();
            adminPanel.Hide();
            //if (courseListView.SelectedItems.Count == 0)
            //{
            //    MessageBox.Show("Please select a course to edit", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return;
            //}

            //ListViewItem selectedItem = courseListView.SelectedItems[0];
            //Course selectedCourse = (Course)selectedItem.Tag;
            //EditCourseForm editCourse = new EditCourseForm(this, selectedCourse, selectedItem.Index);
            //editCourse.Show();
            //adminPanel.Hide();
        //}
    }

        private void deleteAnnouncementBtn_Click(object sender, EventArgs e)
        {
            DialogResult deleteConfirmation = MessageBox.Show("Are you sure you want to delete selected course?", "Delete Confirmation", MessageBoxButtons.YesNo);

            if (deleteConfirmation == DialogResult.Yes)
            {
                while (announcementListView.SelectedItems.Count > 0)
                {
                    announcementListView.SelectedItems[0].Remove();

                }

            }
        }
    }
}
