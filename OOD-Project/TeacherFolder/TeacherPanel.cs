using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OOD_Project.TeacherFolder;

namespace OOD_Project
{
    public partial class TeacherPanel : Form
    {
        public TeacherPanel()
        {
            InitializeComponent();
        }

        private void OpenChildForm(Form childForm, object senderBtn)
        {

            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.teacherMainContent.Controls.Add(childForm);
            this.teacherMainContent.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void manageBranchesBtn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ManageContentForm(), sender);
        }
    }
}
