using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OOD_Project.Helpers;

namespace OOD_Project
{
    public partial class ProfileMenu : Form
    {
        private ProfileBar parentContainer;
        public ProfileMenu( ProfileBar parentContainer)
        {
            InitializeComponent();
            this.parentContainer = parentContainer;
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            // open change password form in parent
            parentContainer.GoToChangePassword();
            Close();
        }

        private void btnSignOut_Click(object sender, EventArgs e)
        {
            // go back to login screen
            parentContainer.SignOut();
            Close();
        }

        private void ProfileMenu_Deactivate(object sender, EventArgs e)
        {
            Close();
        }

        private void ProfileMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            parentContainer.ProfileMenuClosed();
        }
    }
}
