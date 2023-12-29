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
            
            PopulateCurrentDGV();
            PopulatePendingDGV();
            PopulateInactiveDGV();
            // currentUsersListBox.Items.AddRange(currentUsers);
            //pendingUsersListBox.Items.AddRange(pendingUsers);

        }
         
        private void EditUserFromDGV(DataGridView dgv)
        {
            if (dgv.SelectedRows.Count > 0)
            {
                int selectedID = Convert.ToInt32(dgv.SelectedRows[0].Cells[8].Value);
                string roleName = Convert.ToString(dgv.SelectedRows[0].Cells[0].Value);
                switch (roleName)
                {
                    case "student":
                        EditStudentForm studentForm = new EditStudentForm(Student.GetStudent(selectedID), this);
                        studentForm.Show();
                        break;
                    case "teacher":
                        EditTeacherForm teacherForm = new EditTeacherForm(Teacher.GetTeacher(selectedID), this);
                        teacherForm.Show();
                        break;
                }
            }
        }

        private void DeleteUserFromDGV(DataGridView dgv)
        {
            DialogResult deleteConfirmation = MessageBox.Show("Are you sure you want to delete selected user?", "Delete Confirmation", MessageBoxButtons.YesNo);

            if (deleteConfirmation == DialogResult.Yes)
            {
                if (dgv.SelectedRows.Count > 0)
                {
                    int selectedID = Convert.ToInt32(dgv.SelectedRows[0].Cells[8].Value);

                    User.DeleteUser(selectedID);
                }
            }
            PopulateGrids();
        }

        private void PopulateDataGrid(DataGridView dgv, string sqlCommand)
        {
            DatabaseManager dbm = DatabaseManager.Instance();
            // get all active students and teachers
            dbm.Command.CommandText = sqlCommand;

            try
            {
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(dbm.Command);
                BindingSource bs = new BindingSource();

                da.Fill(dt);
                bs.DataSource = dt;
                dgv.DataSource = bs;
                dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
                dgv.RowTemplate.MinimumHeight = 30;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private UserRole GetUserRoleFromDGV(DataGridView dgv)
        {
            string roleName = Convert.ToString(dgv.SelectedRows[0].Cells[0].Value);
            switch (roleName)
            {
                case "student":
                    return UserRole.student;
                case "teacher":
                    return UserRole.teacher;
                default:
                    throw new Exception("Invalid user role. Is the spelling correct?");
            }
        }

        private void editUserBtn_Click(object sender, EventArgs e)
        {
            EditUserFromDGV(currentUsersDG);
        }

        // called from child views to update after editing fields
        public void RefreshView()
        {
            PopulateGrids();

        }

        private void PopulateGrids()
        {
            PopulateCurrentDGV();
            PopulatePendingDGV();
            PopulateInactiveDGV();
        }

        private void PopulateCurrentDGV()
        {
            string sqlCommand = "SELECT  r.role_name AS Role, s.student_university_id AS 'University ID', s.first_name +' '+ s.last_name AS Name, s.phone_number AS Phone, s.cpr AS CPR, u.email AS Email, s.dob AS Birthdate, s.gender AS Gender, u.user_id AS ID " +
                "FROM [dbo].[User] u " +
                "JOIN [dbo].[student] s ON u.user_id = s.user_id " +
                "JOIN [dbo].[role] r ON u.role_id = r.role_id " +
                "WHERE status_id = 2 " +
                "UNION ALL " +
                "SELECT r.role_name, t.teacher_university_id, t.first_name +' '+ t.last_name, t.phone_number, t.cpr, u.email, t.dob, t.gender, u.user_id AS ID " +
                "FROM [dbo].[User] u " +
                "JOIN [dbo].[teacher] t ON u.user_id = t.user_id " +
                "JOIN [dbo].[role] r ON u.role_id = r.role_id " +
                "WHERE status_id = 2 ";
            PopulateDataGrid(currentUsersDG, sqlCommand);
        }
        private void PopulatePendingDGV()
        {
            // get all pending students and teachers
            string sqlCommand = "SELECT  r.role_name AS Role, s.student_university_id AS 'University ID', s.first_name +' '+ s.last_name AS Name, s.phone_number AS Phone, s.cpr AS CPR, u.email AS Email, s.dob AS Birthdate, s.gender AS Gender, u.user_id AS ID " +
                "FROM [dbo].[User] u " +
                "JOIN [dbo].[student] s ON u.user_id = s.user_id " +
                "JOIN [dbo].[role] r ON u.role_id = r.role_id " +
                "WHERE status_id = 1 " +
                "UNION ALL " +
                "SELECT r.role_name, t.teacher_university_id, t.first_name +' '+ t.last_name, t.phone_number, t.cpr, u.email, t.dob, t.gender, u.user_id AS ID " +
                "FROM [dbo].[User] u " +
                "JOIN [dbo].[teacher] t ON u.user_id = t.user_id " +
                "JOIN [dbo].[role] r ON u.role_id = r.role_id " +
                "WHERE status_id = 1 ";

            PopulateDataGrid(pendingDGV, sqlCommand);
        }
        private void PopulateInactiveDGV()
        {
            // get all inactive students and teachers
            string sqlCommand = "SELECT  r.role_name AS Role, s.student_university_id AS 'University ID', s.first_name +' '+ s.last_name AS Name, s.phone_number AS Phone, s.cpr AS CPR, u.email AS Email, s.dob AS Birthdate, s.gender AS Gender, u.user_id AS ID " +
                "FROM [dbo].[User] u " +
                "JOIN [dbo].[student] s ON u.user_id = s.user_id " +
                "JOIN [dbo].[role] r ON u.role_id = r.role_id " +
                "WHERE status_id = 3 " +
                "UNION ALL " +
                "SELECT r.role_name, t.teacher_university_id, t.first_name +' '+ t.last_name, t.phone_number, t.cpr, u.email, t.dob, t.gender, u.user_id AS ID " +
                "FROM [dbo].[User] u " +
                "JOIN [dbo].[teacher] t ON u.user_id = t.user_id " +
                "JOIN [dbo].[role] r ON u.role_id = r.role_id " +
                "WHERE status_id = 3 ";
            PopulateDataGrid(inactiveDGV, sqlCommand);
        }


        private void deleteUserBtn_Click(object sender, EventArgs e)
        {
            DeleteUserFromDGV(currentUsersDG);
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            if (pendingDGV.SelectedRows.Count < 1)
            {
                MessageBox.Show("Please select a user first.", "No user selected");
                return;
            }
            int selectedId = Convert.ToInt32(pendingDGV.SelectedRows[0].Cells[8].Value);
            UserRole role = GetUserRoleFromDGV(pendingDGV);

            // send accept email
            EmailController ec = EmailController.Instance();
            switch (role)
            {
                case UserRole.student:
                    Student student = Student.GetStudent(selectedId);
                    ec.SendAcceptEmail(student.Email, student.FirstName, student.LastName, student.StudentUniversityId, student.Cpr);
                    break;
                case UserRole.teacher:
                    Teacher teacher = Teacher.GetTeacher(selectedId);
                    ec.SendAcceptEmail(teacher.Email, teacher.FirstName, teacher.LastName, teacher.TeacherUniversityId, teacher.Cpr);
                    break;
                default:
                    return;
            }
            User.AcceptPendingUser(selectedId, role);
            PopulateGrids();
        }

        private void btnReject_Click(object sender, EventArgs e)
        {
            DialogResult deleteConfirmation = MessageBox.Show("Are you sure you want to reject selected user?\nTheir request will be deleted.", "Delete Confirmation", MessageBoxButtons.YesNo);

            if (deleteConfirmation != DialogResult.Yes)
            {
                return;
            }
            if (pendingDGV.SelectedRows.Count < 1)
            {
                MessageBox.Show("Please select a user first.", "No user selected");
                return;
            }
            int selectedId = Convert.ToInt32(pendingDGV.SelectedRows[0].Cells[8].Value);
            UserRole role = GetUserRoleFromDGV(pendingDGV);

            // send rejection email
            EmailController ec = EmailController.Instance();
            switch (role)
            {
                case UserRole.student:
                    Student student = Student.GetStudent(selectedId);
                    ec.SendRejectEmail(student.Email, student.FirstName, student.LastName);
                    break;
                case UserRole.teacher:
                    Teacher teacher = Teacher.GetTeacher(selectedId);
                    ec.SendRejectEmail(teacher.Email, teacher.FirstName, teacher.LastName);
                    break;
                default:
                    return;
            }
            User.DeleteUser(selectedId);

            PopulateGrids();

        }

        private void addUserBtn_Click(object sender, EventArgs e)
        {
            // add active user
            AddUserForm form = new AddUserForm(this, true);
            form.Show();
        }

        private void addInactive_Click(object sender, EventArgs e)
        {
            // add inactive user
            AddUserForm form = new AddUserForm(this, false);
            form.Show();
        }

        private void editInactive_Click(object sender, EventArgs e)
        {
            EditUserFromDGV(inactiveDGV);
        }

        private void deleteInactive_Click(object sender, EventArgs e)
        {
            DeleteUserFromDGV(inactiveDGV);
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
