using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOD_Project
{
    public partial class StudentPanel : Form
    {
        /*
         * // https://www.ietf.org/rfc/rfc6068.txt
            var url = "mailto:someone@somewhere.com";
            Process.Start(url);
         */
        public StudentPanel()
        {
            InitializeComponent();
        }

        private void OpenChildForm(Form childForm, object senderBtn)
        {

            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.studentMainContent.Controls.Add(childForm);
            this.studentMainContent.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void viewCoursesBtn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ViewCoursesForm(), sender);
        }

        private void editProfileBtn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new StudentEditProfileForm(), sender);
        }
    }
}
