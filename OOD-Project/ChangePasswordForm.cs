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
    public partial class ChangePasswordForm : Form
    {
        public ChangePasswordForm()
        {
            InitializeComponent();
        }

        private void ClearForm()
        {
            txtCurrent.Text = string.Empty;
            txtNew.Text = string.Empty;
            txtConfirm.Text = string.Empty;
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            User user = User.GetUser(Global.UserId);

            string currentPassword = txtCurrent.Text;
            string newPassword = txtNew.Text;
            string confirmPassword = txtConfirm.Text;

            // validate current password
            if (!User.IsPasswordValidForUser(user.UserId, currentPassword))
            {
                MessageBox.Show("The password you entered is incorrect.", "Incorrect Password");
                return;
            }

            // validate new password
            if (newPassword != confirmPassword)
            {
                MessageBox.Show("The new passwords you entered do not match.", "Passwords Not Matching");
                return;
            }

            // update user

            user.Password = newPassword;

            User.EditUser(user);

            MessageBox.Show("Password changed successfully.", "Password Changed");

            ClearForm();
        }
    }
}
