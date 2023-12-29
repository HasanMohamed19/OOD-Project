using OOD_Project.Admin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TreeView;

namespace OOD_Project
{
    public partial class ManageBranchesForm : Form
    {
        public ManageBranchesForm()
        {
            InitializeComponent();
            
        }

        public void UpdateTable()
        {
            branchesListView.Items.Clear();
            populateBranches();
        }

        private void populateBranches()
        {
            DatabaseManager dbm = DatabaseManager.Instance();
            dbm.Connection.Open();
            dbm.Command.CommandText = "SELECT * FROM [dbo].[Branch]";
            try
            {
                dbm.Reader = dbm.Command.ExecuteReader();
                while (dbm.Reader.Read())
                {
                    var item = new ListViewItem(dbm.Reader["branch_id"].ToString());
                    item.SubItems.Add(dbm.Reader["name"].ToString());
                    item.SubItems.Add(dbm.Reader["phone_number"].ToString());

                    branchesListView.Items.Add(item);
                }
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            } finally
            {
                dbm.Reader.Close();
                dbm.Connection.Close();
            }
            

        }

        private void deleteBranchBtn_Click(object sender, EventArgs e)
        {   
            if (branchesListView.SelectedItems.Count <= 0)
            {
                MessageBox.Show("Please select a branch to delete first");
            }

            DialogResult deleteConfirmation = MessageBox.Show("Are you sure you want to delete selected branch?", "Delete Confirmation", MessageBoxButtons.YesNo);
            if (deleteConfirmation == DialogResult.Yes)
            {
                int branch_id = Convert.ToInt32(branchesListView.SelectedItems[0].Text);
                Branch.DeleteBranch(branch_id);
                UpdateTable();
            }

        }

        private void editBranchBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (branchesListView.SelectedItems[0] != null)
                {
                    ListViewItem selctedItem = branchesListView.SelectedItems[0];
                    int id = Convert.ToInt32(selctedItem.Text);
                    Branch branch = Branch.GetBranch(id);
                    AddBranchForm editForm = new AddBranchForm(this, branch);
                    editForm.ShowDialog();
                }
            } catch 
            {
                MessageBox.Show("Please choose a branch to edit first");
            }
        }

        private void addBranchBtn_Click(object sender, EventArgs e)
        {
            AddBranchForm form = new AddBranchForm(this, null);
            form.Show();
        }

        private void ManageBranchesForm_Load(object sender, EventArgs e)
        {
            UpdateTable();
        }
    }
}
