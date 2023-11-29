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
            branches.Add(new Branch(1, "10Km", "Manama", "12345678"));
            branches.Add(new Branch(2, "30Km", "Isa Town", "8765432"));
            foreach (var branch in branches)
            {
                ListViewItem item = new ListViewItem(branch.BranchID.ToString());
                item.SubItems.Add(branch.Area);
                item.SubItems.Add(branch.City);
                item.SubItems.Add(branch.PhoneNumber);
                branchesListView.Items.Add(item);
            }
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


    public class Branch
    {
        // name?
        private int branchID;
        private string area;
        private string city;
        private string phoneNumber;

        public int BranchID { get { return branchID; } set { branchID = value; } }
        public string Area { get { return area; } set {  area = value; } }
        public string City { get { return city; } set { city = value; } }
        public string PhoneNumber { get { return phoneNumber; } set { phoneNumber = value; } }


        public Branch(int branchID, string area, string city, string phoneNumber)
        {
            this.branchID = branchID;
            this.area = area;
            this.city = city;
            this.phoneNumber = phoneNumber;
        }


    }

}
