using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace OOD_Project.Admin
{
    public partial class AddBranchForm : Form
    {
        ManageBranchesForm parentForm;
        Branch oldBranch;
        public AddBranchForm(ManageBranchesForm parentForm, Branch oldBranch)
        {
            InitializeComponent();
            btnAdd.Enabled = false;
            this.parentForm = parentForm;
            this.oldBranch = oldBranch;
            if (oldBranch != null)
            {
                btnAdd.Text = "Save";
                setOldValues();
            }
        }

        private void setButtonVisibility()
        {
            if ((branchNameTxt.Text != String.Empty) && (phoneNumberTxt.Text != String.Empty))
            {
                btnAdd.Enabled = true;
            }
            else
            {
                btnAdd.Enabled = false;
            }
        }

        private void branchNameTxt_TextChanged(object sender, EventArgs e)
        {
            setButtonVisibility();
        }

        private void phoneNumberTxt_TextChanged(object sender, EventArgs e)
        {
            setButtonVisibility();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string branchName = branchNameTxt.Text;
            string phoneNumber = phoneNumberTxt.Text;
            Branch branch = new Branch(0, branchName, phoneNumber);
            
            if (oldBranch == null)
            {
                bool hasAdded = Branch.AddBranch(branch);
                if (hasAdded)
                {
                    MessageBox.Show("Branch added successfully");
                } else
                {
                    MessageBox.Show("Branch Not added");
                }        
                
            } else if (oldBranch != null)
            {
                branch.BranchId = oldBranch.BranchId;
                bool hasEdited = Branch.EditBranch(branch);
                if (hasEdited)
                {
                    MessageBox.Show("Branch updated successfully" + this.oldBranch.BranchId);
                } else
                {
                    MessageBox.Show("Brnach wasn't updated");
                }
                
            }
            parentForm.UpdateTable();
            this.Close();
        }

        private void setOldValues()
        {
            if (oldBranch != null)
            {
                branchNameTxt.Text = oldBranch.BranchName;
                phoneNumberTxt.Text = oldBranch.PhoneNumber;
            }
        }

        private void phoneNumberTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
