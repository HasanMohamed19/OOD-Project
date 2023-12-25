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
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
            OpenChildForm(new StudentRegisterForm());
        }
        private void OpenChildForm(Form childForm)
        {
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.RegisterContainer.Controls.Add(childForm);
            this.RegisterContainer.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void btnRegisterAsStudent_Click(object sender, EventArgs e)
        {
            OpenChildForm(new StudentRegisterForm());
        }

        private void btnRegisterAsTeacher_Click(object sender, EventArgs e)
        {
            OpenChildForm(new TeacherRegisterForm());
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }
    }

}
