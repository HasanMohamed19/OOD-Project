using OOD_Project.Admin;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOD_Project
{
    public partial class usersListForms : Form
    {

        // fake data from db
        //User[] currentUsers = { new User("Hasan", "Ali", "student@gmail.com", UserRole.student),
        //new User("Yousif", "Ali", "student@gmail.com", UserRole.teacher),
        //new User("Ahmed", "Ali", "student@gmail.com", UserRole.admin),
        //new User("Mahmood", "Ali", "student@gmail.com", UserRole.student),
        //new User("Osama", "Ali", "student@gmail.com", UserRole.student),
        //new User("test1", "Ali", "student@gmail.com", UserRole.admin),
        //new User("test2", "Ali", "student@gmail.com", UserRole.teacher),
        //new User("test3", "Ali", "student@gmail.com", UserRole.student),
        //new User("human4", "Ali", "student@gmail.com", UserRole.teacher),
        //new User("Yousif", "Ali", "student@gmail.com", UserRole.teacher),
        //new User("Ahmed", "Ali", "student@gmail.com", UserRole.teacher),
        //new User("Mahmood", "Ali", "student@gmail.com", UserRole.student),
        //new User("Osama", "Ali", "student@gmail.com", UserRole.student),
        //new User("test1", "Ali", "student@gmail.com", UserRole.admin),
        //new User("test2", "Ali", "student@gmail.com", UserRole.teacher),
        //new User("test3", "Ali", "student@gmail.com", UserRole.student),
        //new User("human4", "Ali", "student@gmail.com", UserRole.teacher)};

        //User[] pendingUsers = { new User("pending", "user", "elms3dmin@gmail.com", UserRole.student),
        //new User("pending", "user", "elms3dmin@gmail.com", UserRole.teacher)};

        public usersListForms()
        {
            InitializeComponent();
            //foreach (var user in currentUsers)
            //{
            //    user.StatusId = UserStatus.accepted;
            //    ListViewItem item = new ListViewItem(user.FirstName);
            //    item.SubItems.Add(user.LastName);
            //    item.SubItems.Add(user.Email);
            //    item.SubItems.Add(user.RoleId.ToString());
            //    item.SubItems.Add(user.StatusId.ToString());
            //    //currentUsersListView.Items.Add(item);
            //}
            
            populateDGV();
            // currentUsersListBox.Items.AddRange(currentUsers);
            //pendingUsersListBox.Items.AddRange(pendingUsers);

        }
         
        private void editUserBtn_Click(object sender, EventArgs e)
        {

        }

        // called from child views to update after editing fields
        public void RefreshView()
        {
            populateDGV();
        }

        private void populateDGV()
        {
            DatabaseManager dbm = DatabaseManager.Instance();
            dbm.Command.CommandText = "SELECT * FROM [dbo].[User]";

            try
            {
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(dbm.Command);
                BindingSource bs = new BindingSource();

                da.Fill(dt);
                bs.DataSource = dt;
                currentUsersDG.DataSource = bs;
                currentUsersDG.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
                currentUsersDG.RowTemplate.MinimumHeight = 30;
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void deleteUserBtn_Click(object sender, EventArgs e)
        {
            DialogResult deleteConfirmation = MessageBox.Show("Are you sure you want to delete selected user?", "Delete Confirmation", MessageBoxButtons.YesNo);

            

            if (deleteConfirmation == DialogResult.Yes)
            {
                if (currentUsersDG.SelectedRows.Count > 0)
                {
                    int selectedID = Convert.ToInt32(currentUsersDG.SelectedRows[0].Cells[0].Value);
                    MessageBox.Show(selectedID.ToString());
                    // this should be in a method
                    DatabaseManager dbm = DatabaseManager.Instance();
                    dbm.Connection.Open();
                    dbm.Command.Parameters.AddWithValue("@user_id", selectedID);
                    dbm.Command.CommandText = "DELETE FROM [dbo].[user] WHERE user_id = @user_id";
                    
                    try
                    {
                        dbm.Command.ExecuteNonQuery();
                        currentUsersDG.Update();
                        populateDGV();
                    } catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    } finally
                    {
                        dbm.Connection.Close();
                    }
                    
                    
                }

            }

        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            User pendingUser = (User) pendingUsersListBox.SelectedItem;
            pendingUser.StatusId = UserStatus.accepted;
            //currentUsersListBox.Items.Add(pendingUser);
            //currentUsersListBox.Update();
            pendingUsersListBox.Items.Remove(pendingUser);
            pendingUsersListBox.Update();
            //EmailController.Instance().SendAcceptEmail(pendingUser.Email, pendingUser.FirstName, pendingUser.LastName, pendingUser.Cpr);
            MessageBox.Show("User Request Accepted Successfully", "User Added");
        }

        private void btnReject_Click(object sender, EventArgs e)
        {
            User pendingUser = (User)pendingUsersListBox.SelectedItem;
            pendingUser.StatusId = UserStatus.inactive;
            // just remove the user? or also something else? add list also for rejected user?
            pendingUsersListBox.Items.Remove(pendingUser);
            pendingUsersListBox.Update();
            //EmailController.Instance().SendRejectEmail(pendingUser.FirstName, pendingUser.LastName, pendingUser.Email);
            MessageBox.Show("User Request Rejected Successfully", "User Rejected");
        }

        private void addUserBtn_Click(object sender, EventArgs e)
        {
            AddUserForm form = new AddUserForm(this);
            form.Show();
        }
    }

    // temporary to remove later
    // status id:
    // 1 = pending, 2 = accepted, 3 = rejected
    //class User
    //{
    //    private string firstName;
    //    private string lastName;
    //    private string email;
    //    private int roleId;
    //    private int statusId;

    //    public string FirstName { get { return firstName; } set {  firstName = value; } }
    //    public string LastName { get { return lastName;} set { lastName = value; } }
    //    public string Email { get { return email; } set { email = value; } }
    //    public int RoleId { get {  return roleId; } set {  roleId = value; } }
    //    public int StatusId { get { return statusId;  } set {  statusId = value; } }

    //    public User(string firstName, string lastName, string email, int roleId)
    //    {
    //        this.firstName = firstName;
    //        this.lastName = lastName;
    //        this.email = email;
    //        this.roleId = roleId;
    //        this.statusId = 1;
    //    }
    //        public override string ToString()
    //    {
    //        string roleName = "";
    //        string status = "";
    //        switch (roleId)
    //        {
    //            case 1:
    //                roleName = "Admin";
    //                break;
    //            case 2:
    //                roleName = "Teacher";
    //                break;
    //            case 3:
    //                roleName = "Student";
    //                break;
    //        }

    //        switch (statusId)
    //        {
    //            case 1:
    //                status = "pending";
    //                break;
    //            case 2:
    //                status = "accepted";
    //                break;
    //            case 3:
    //                status = "rejected";
    //                break;

    //        }
    //        // status just for testing now
    //        return roleName + ": " + firstName + " " + lastName + ". Status:" + status;
    //    }
    //}
    
}
