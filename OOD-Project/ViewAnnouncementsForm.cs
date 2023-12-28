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
        public ViewAnnouncementsForm()
        {
            InitializeComponent();
            PopulateAnnouncements();
        }

        public void PopulateAnnouncements()
        {
            DatabaseManager dbm = DatabaseManager.Instance();
            dbm.Connection.Open();
            dbm.Command.CommandText = "SELECT * FROM [dbo].[announcement] a" +
                " JOIN [dbo].[announcement_type] at ON a.announcement_type_id = at.announcement_type_id ORDER BY announcement_id DESC";
            dbm.Reader = dbm.Command.ExecuteReader();
            while (dbm.Reader.Read())
            {
                int announcementId = Convert.ToInt32(dbm.Reader["announcement_id"].ToString());
                announcementIds.Add(announcementId);
                var item = new ListViewItem(dbm.Reader["title"].ToString());
                item.SubItems.Add(dbm.Reader["announcement_type_name"].ToString());

                announcementsListView.Items.Add(item);
            }
            dbm.Connection.Close();
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
