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
    public partial class ViewAnnouncementsForm : Form
    {
        private List<int> announcementIds = new List<int>();
        int user_id;
        public ViewAnnouncementsForm(int user_id)
        {
            this.user_id = user_id;
            InitializeComponent();
            if (user_id == 1)
            {
                PopulateAllAnnouncements();
            } else
            {
                PopulateAnnouncements();
            }
            
        }

        private void PopulateAllAnnouncements()
        {
            // show all announcements for admin
            DatabaseManager dbm = DatabaseManager.Instance();
            dbm.Connection.Open();
            dbm.Command = dbm.Connection.CreateCommand();
            dbm.Command.CommandText = "SELECT announcement_id, title, announcement_type_name, date " +
                " FROM [dbo].[announcement] a" +
                " JOIN [dbo].[announcement_type] at ON a.announcement_type_id = at.announcement_type_id ORDER BY date DESC";
            try
            {
                dbm.Reader = dbm.Command.ExecuteReader();
                while (dbm.Reader.Read())
                {
                    int announcementId = Convert.ToInt32(dbm.Reader["announcement_id"].ToString());
                    announcementIds.Add(announcementId);
                    var item = new ListViewItem(dbm.Reader["title"].ToString());
                    item.SubItems.Add(dbm.Reader["announcement_type_name"].ToString());

                    announcementsListView.Items.Add(item);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                dbm.Reader.Close();
                dbm.Connection.Close();
            }
        }

        public void PopulateAnnouncements()
        {
            // show only global announcements or announcements related to this user
            DatabaseManager dbm = DatabaseManager.Instance();
            dbm.Connection.Open();
            dbm.Command = dbm.Connection.CreateCommand();

            dbm.Command.Parameters.AddWithValue("@user_id", user_id);
            dbm.Command.CommandText = "SELECT a.announcement_id, title, announcement_type_name, date " +
                " FROM [dbo].[announcement] a " +
                " JOIN [dbo].[announcement_type] at ON a.announcement_type_id = at.announcement_type_id " +
                " WHERE a.is_global = 'TRUE' " +
                " UNION ALL " +
                " SELECT a.announcement_id, title, announcement_type_name, date " +
                " FROM [dbo].[announcement] a " +
                " JOIN [dbo].[announcement_type] at ON a.announcement_type_id = at.announcement_type_id " +
                " JOIN [dbo].[user_announcement] ua ON ua.announcement_id = a.announcement_id " +
                " WHERE ua.user_id = @user_id " +
                " ORDER BY date DESC ";
            try
            {
                dbm.Reader = dbm.Command.ExecuteReader();
                while (dbm.Reader.Read())
                {
                    int announcementId = Convert.ToInt32(dbm.Reader["announcement_id"].ToString());
                    announcementIds.Add(announcementId);
                    var item = new ListViewItem(dbm.Reader["title"].ToString());
                    item.SubItems.Add(dbm.Reader["announcement_type_name"].ToString());

                    announcementsListView.Items.Add(item);
                }
            }catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            } finally
            {
                dbm.Reader.Close();
                dbm.Connection.Close();
            }
            // select first item if available
            if (announcementsListView.Items.Count <= 0)
            {
                return;
            }
            announcementsListView.Items[0].Selected = true;
        }

        private void UpdateAnnouncementDetails(int announcementId)
        {
            DatabaseManager dbm = DatabaseManager.Instance();
            dbm.Connection.Open();
            dbm.Command = dbm.Connection.CreateCommand();
            dbm.Command.Parameters.AddWithValue("@announcement_id", announcementId);
            dbm.Command.CommandText = "SELECT * FROM [dbo].[announcement] WHERE announcement_id = @announcement_id";
            dbm.Reader = dbm.Command.ExecuteReader();

            while (dbm.Reader.Read())
            {
                announcementTitleLbl.Text = dbm.Reader["title"].ToString();
                announcementBodyLbl.Text = dbm.Reader["body"].ToString();
            }
            dbm.Command.Parameters.Clear();
            dbm.Connection.Close();

        }

        private void announcementsListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (announcementsListView.SelectedItems.Count > 0)
            {
                // starts from zero
                int selectedIndex = announcementsListView.SelectedItems[0].Index;
                UpdateAnnouncementDetails(announcementIds[selectedIndex]);
            }
        }
    }
}
