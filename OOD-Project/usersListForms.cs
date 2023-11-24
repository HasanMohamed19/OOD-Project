using System;
using System.Collections;
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
    public partial class usersListForms : Form
    {

        // fake data from db
        User[] currentUsers = { new User("Hasan", "Ali", "student@gmail.com", 3),
        new User("Yousif", "Ali", "student@gmail.com", 2),
        new User("Ahmed", "Ali", "student@gmail.com", 1),
        new User("Mahmood", "Ali", "student@gmail.com", 3),
        new User("Osama", "Ali", "student@gmail.com", 3),
        new User("test1", "Ali", "student@gmail.com", 1),
        new User("test2", "Ali", "student@gmail.com", 2),
        new User("test3", "Ali", "student@gmail.com", 3),
        new User("human4", "Ali", "student@gmail.com", 2),};

        User[] pendingUsers = { new User("pending", "user", "pending@pending.com", 3),
        new User("pending", "user", "pendingUser@pending.com", 2)};

        public usersListForms()
        {
            InitializeComponent();
            foreach (var user in currentUsers)
            {
                user.StatusId = 2;
            }
            currentUsersListBox.Items.AddRange(currentUsers);
            pendingUsersListBox.Items.AddRange(pendingUsers);

        }
         
        private void editUserBtn_Click(object sender, EventArgs e)
        {

        }

        private void deleteUserBtn_Click(object sender, EventArgs e)
        {
            DialogResult deleteConfirmation = MessageBox.Show("Are you sure you want to delete selected user?", "Delete Confirmation", MessageBoxButtons.YesNo);

            if (deleteConfirmation == DialogResult.Yes)
            {
                currentUsersListBox.Items.Remove(currentUsersListBox.SelectedItem);
                currentUsersListBox.Update();
            } else
            {
                Console.WriteLine("user deleted");
            }

        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            User pendingUser = (User) pendingUsersListBox.SelectedItem;
            pendingUser.StatusId = 2;
            currentUsersListBox.Items.Add(pendingUser);
            currentUsersListBox.Update();
            pendingUsersListBox.Items.Remove(pendingUser);
            pendingUsersListBox.Update();
            MessageBox.Show("User Request Accepted Successfully", "User Added");
        }

        private void btnReject_Click(object sender, EventArgs e)
        {
            User pendingUser = (User)pendingUsersListBox.SelectedItem;
            pendingUser.StatusId = 3;
            // just remove the user? or also something else? add list also for rejected user?
            pendingUsersListBox.Items.Remove(pendingUser);
            pendingUsersListBox.Update();
            MessageBox.Show("User Request Rejected Successfully", "User Rejected");
        }
    }

    // temporary to remove later
    // status id:
    // 1 = pending, 2 = accepted, 3 = rejected
    class User
    {
        private string firstName;
        private string lastName;
        private string email;
        private int roleId;
        private int statusId;

        public string FirstName { get { return firstName; } set {  firstName = value; } }
        public string LastName { get { return lastName;} set { lastName = value; } }
        public string Email { get { return email; } set { email = value; } }
        public int RoleId { get {  return roleId; } set {  roleId = value; } }
        public int StatusId { get { return statusId;  } set {  statusId = value; } }

        public User(string firstName, string lastName, string email, int roleId)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.email = email;
            this.roleId = roleId;
            this.statusId = 1;
        }
            public override string ToString()
        {
            string roleName = "";
            string status = "";
            switch (roleId)
            {
                case 1:
                    roleName = "Admin";
                    break;
                case 2:
                    roleName = "Teacher";
                    break;
                case 3:
                    roleName = "Student";
                    break;
            }

            switch (statusId)
            {
                case 1:
                    status = "pending";
                    break;
                case 2:
                    status = "accepted";
                    break;
                case 3:
                    status = "rejected";
                    break;

            }
            // status just for testing now
            return roleName + ": " + firstName + " " + lastName + ". Status:" + status;
        }
    }
    
}
