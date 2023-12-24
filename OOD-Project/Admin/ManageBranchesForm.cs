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
    public partial class ManageBranchesForm : Form
    {

        List<Branch> branches= new List<Branch>();
        

        public ManageBranchesForm()
        {
            InitializeComponent();
            //branches.Add(new Branch("10Km^2", 1, "Manama", "BTI", "12345678"));
            //branches.Add(new Branch("30Km^2", 2, "Isa Town", "Polytechnic", "8765432"));
            //foreach (var branch in branches)
            //{
            //    ListViewItem item = new ListViewItem(branch.BranchId.ToString());
            //    item.SubItems.Add(branch.Area);
            //    item.SubItems.Add(branch.City);
            //    item.SubItems.Add(branch.PhoneNumber);
            //    branchesListView.Items.Add(item);
            //}
        }

        private void deleteBranchBtn_Click(object sender, EventArgs e)
        {
            DialogResult deleteConfirmation = MessageBox.Show("Are you sure you want to delete selected branch?", "Delete Confirmation", MessageBoxButtons.YesNo);



            if (deleteConfirmation == DialogResult.Yes)
            {
                while (branchesListView.SelectedItems.Count > 0)
                {
                    branchesListView.SelectedItems[0].Remove();                    
                    
                }

            }
        }

        private void editBranchBtn_Click(object sender, EventArgs e)
        {

        }

 
    }
}
