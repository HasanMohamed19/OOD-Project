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

namespace OOD_Project.Admin
{
    public partial class ManageAnnouncements : Form
    {
        public ManageAnnouncements()
        {
            InitializeComponent();
            Helper.OpenChildForm(new ViewAnnouncementsForm(Global.UserId), viewPanel);
            Helper.OpenChildForm(new AddAnouncementForm(), sendPanel);
        }

        private void manageAnnouncementsTab_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (manageAnnouncementsTab.SelectedIndex == 0)
            {
                Helper.OpenChildForm(new ViewAnnouncementsForm(Global.UserId), viewPanel);
            } else
            {
                Helper.OpenChildForm(new AddAnouncementForm(), sendPanel);
            }
        }
    }
}
