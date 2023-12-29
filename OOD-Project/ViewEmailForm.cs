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
            Helper.OpenChildForm(new ViewEmails(true), emailContainer);
        }
        private void inboxBtn_Click(object sender, EventArgs e)
        {
            Helper.OpenChildForm(new ViewEmails(true), emailContainer);
        }

        private void outboxBtn_Click(object sender, EventArgs e)
        {
            Helper.OpenChildForm(new ViewEmails(false), emailContainer);
        }

        private void sendEmailBtn_Click(object sender, EventArgs e)
        {
            new EmailForm(null).ShowDialog();
        }
    }
}
