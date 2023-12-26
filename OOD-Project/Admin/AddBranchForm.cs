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
    public partial class AddBranchForm : Form
    {
        private ManageBranchesForm manageBranches;
        public AddBranchForm(ManageBranchesForm manageBranchesForm)
        {
            InitializeComponent();
            this.manageBranches = manageBranchesForm;
            this.btnAddBranch.Visible = true;
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            manageBranches.adminPanel.Show();
            this.Close();
        }

        private void BtnAddBranch_Click(object sender, EventArgs e)
        {
            try
            {
                ListView branchListView = manageBranches.GetBranchListView();
                int branchID = int.Parse(txtBranchID.Text);
                string phoneNumber = txtPhone.Text;
                string branchName = txtBranchName.Text;
                string area = txtBranchName.Text;
                string city = txtCity.Text;
                Branch branch = new Branch(area, branchID, city, branchName, phoneNumber);
                ListViewItem item = new ListViewItem(new string[]
                {
                    branch.BranchId.ToString(),
                    branch.Name,
                    branch.Area,
                    branch.City,
                    branch.PhoneNumber
                });
                item.Tag = branch;
                manageBranches.GetBranchListView().Items.Add(item);
                manageBranches.getBranches().Add(branch);
                MessageBox.Show("New Course Added\nCourse ID:" + branch.BranchId + "\nCourse Name: " + branch.Name, "Branch Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error has occured", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            manageBranches.adminPanel.Show();
            this.Close();
        }
    }
}
