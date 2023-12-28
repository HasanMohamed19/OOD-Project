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
    public partial class ViewEmailForm : Form
    {
        public ViewEmailForm()
        {
            InitializeComponent();
            UpdateView();
        }

        private void UpdateView()
        {
            if (emailTabs.SelectedTab == inboxTab)
            {
                Helper.OpenChildForm(new ViewEmails(true), inboxPanel);
            }
            else
            {
                Helper.OpenChildForm(new ViewEmails(false), sentPanel);
            }
        }

        private void emailTabs_Selecting(object sender, TabControlCancelEventArgs e)
        {
            UpdateView(); 
        }
    }
}
