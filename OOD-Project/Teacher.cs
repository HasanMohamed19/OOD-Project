using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOD_Project
{
    public class Teacher : User
    {
        private string firstName;
        private string lastName;
        private DateTime dob;
        private string cpr;
        private char gender;
        private string phoneNumber;
        private Branch forBranch;
        private Programme inProgramme;
        private string teacherUniversityId;

        

        public Teacher(int userId, string username, string password, string email, UserRole roleId, UserStatus statusId, bool hasNotification, 
            string firstName, string lastName, DateTime dob, string cpr, char gender, string phoneNumber, Branch forBranch, Programme inProgramme, string teacherUniversityId) : 
            base(userId,username,password,email,roleId,statusId,hasNotification)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.dob = dob;
            this.cpr = cpr;
            this.gender = gender;
            this.phoneNumber = phoneNumber;
            this.forBranch = forBranch;
            this.inProgramme = inProgramme;
            this.teacherUniversityId = teacherUniversityId;
        }

        // check if an inactive teacher account exists with this id
        // used to prevent admin from duplicating universityIds, they must be unique
        public static bool InactiveTeacherExistsWithId(string universityId)
        {
            List<int> status = new List<int>();

            DatabaseManager dbm = DatabaseManager.Instance();
            dbm.Connection.Open();
            dbm.Command = dbm.Connection.CreateCommand();

            dbm.Command.Parameters.AddWithValue("@teacher_university_id", universityId);
            dbm.Command.CommandText = "SELECT u.status_id FROM [dbo].[teacher] t, [dbo].[User] u " +
                "WHERE t.user_id = u.user_id " +
                "AND t.teacher_university_id = @teacher_university_id";

            dbm.Reader = dbm.Command.ExecuteReader();

            while (dbm.Reader.Read())
            {
                int status_id = dbm.Reader.GetInt32(0);
                status.Add(status_id);
            }
            dbm.Connection.Close();

            if (status.Count <= 0)
            {
                // nothing found, no inactive user exists
                return false;
            }

            if (status[0] == 3 || status[0] == 2)
            {
                // inactive teacher exists 
                return true;
            }
            // pending teacher exists, can consider it to not exist
            return false;
        }

        // returns user_id of inactive user with the same universityId
        // used to check if a teacher can register with this universityId
        // also used to activate teacher account
        public static int IsTeacherIdValid(string universityId)
        {
            // check if this id exists for inactive user
            List<int> ids = new List<int>();
            List<int> status = new List<int>();

            DatabaseManager dbm = DatabaseManager.Instance();
            dbm.Connection.Open();
            dbm.Command = dbm.Connection.CreateCommand();

            dbm.Command.Parameters.AddWithValue("@teacher_university_id", universityId);
            dbm.Command.CommandText = "SELECT u.user_id, u.status_id FROM [dbo].[teacher] t, [dbo].[User] u " +
                "WHERE t.user_id = u.user_id " +
                "AND t.teacher_university_id = @teacher_university_id";

            dbm.Reader = dbm.Command.ExecuteReader();

            while (dbm.Reader.Read())
            {
                int user_id = dbm.Reader.GetInt32(0);
                int status_id = dbm.Reader.GetInt32(1);
                ids.Add(user_id);
                status.Add(status_id);
            }
            dbm.Connection.Close();

            // if there is more than one row returned or zero, dont continue
            if (ids.Count != 1)
            {
                throw new Exception("Too many or zero records found for teachers with id " + universityId);
            }

            // if status_id is  not 3 (inactive) then a new user cannot be made with this id
            if (status[0] != 3)
            {
                throw new Exception("There is already an active account for id " + universityId);
            }


            return ids[0];
        }
        public static void AddTeacher(Teacher teacher)
        {
            // ADD USER ROW
            DatabaseManager dbm = DatabaseManager.Instance();
            dbm.Connection.Open();
            dbm.Command = dbm.Connection.CreateCommand();
            // default username and password until accepted by admin
            dbm.Command.Parameters.AddWithValue("@username", teacher.firstName + "_" + teacher.lastName);
            dbm.Command.Parameters.AddWithValue("@password", teacher.cpr);
            dbm.Command.Parameters.AddWithValue("@email", teacher.Email);
            dbm.Command.Parameters.AddWithValue("@role_id", (int)teacher.RoleId);
            dbm.Command.Parameters.AddWithValue("@status_id", (int)teacher.StatusId);

            dbm.Command.CommandText = "INSERT INTO [dbo].[User] (user_id, username, password, email, role_id, status_id)" +
                " VALUES(NEXT VALUE FOR [dbo].[userIDSequence], @username, @password, @email, @role_id, @status_id)";
            try
            {
                int rows = dbm.Command.ExecuteNonQuery();
                MessageBox.Show($"User added successfully {rows}");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            finally
            {
                dbm.Command.Parameters.Clear();
            }
            // GET CURRENT SEQUENCE ID
            dbm.Command.CommandText = "SELECT CAST(current_value AS int) FROM sys.sequences WHERE name = 'userIDSequence'";
            try
            {
                dbm.Reader = dbm.Command.ExecuteReader();
                if (dbm.Reader.Read())
                {
                    teacher.UserId = dbm.Reader.GetInt32(0);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            finally
            {
                dbm.Reader.Close();
            }

            // ADD STUDENT ROW
            dbm.Command.Parameters.AddWithValue("@branch_id", teacher.forBranch.BranchId);
            dbm.Command.Parameters.AddWithValue("@user_id", teacher.UserId);
            dbm.Command.Parameters.AddWithValue("@first_name", teacher.firstName);
            dbm.Command.Parameters.AddWithValue("@last_name", teacher.lastName);
            dbm.Command.Parameters.AddWithValue("@phone", teacher.phoneNumber);
            dbm.Command.Parameters.AddWithValue("@cpr", teacher.cpr);
            dbm.Command.Parameters.AddWithValue("@gender", teacher.gender);
            dbm.Command.Parameters.AddWithValue("@dob", teacher.dob);
            dbm.Command.Parameters.AddWithValue("@programme_id", (int)teacher.inProgramme);
            dbm.Command.Parameters.AddWithValue("@teacher_university_id", teacher.teacherUniversityId);
            dbm.Command.CommandText = "INSERT INTO [dbo].[teacher] (teacher_id, branch_id, user_id, first_name, last_name, phone_number, dob, cpr, gender, programme_id, teacher_university_id)" +
                " VALUES(NEXT VALUE FOR [dbo].[teacherIDSequence], @branch_id, @user_id, @first_name, @last_name, @phone, @dob, @cpr, @gender, @programme_id, @teacher_university_id)";

            try
            {
                int rows = dbm.Command.ExecuteNonQuery();
                MessageBox.Show($"Teacher added successfully {rows}");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            finally
            {
                dbm.Command.Parameters.Clear();
                dbm.Connection.Close();
            }
        }

        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public DateTime Dob { get => dob; set => dob = value; }
        public string Cpr { get => cpr; set => cpr = value; }
        public char Gender { get => gender; set => gender = value; }
        public string PhoneNumber { get => phoneNumber; set => phoneNumber = value; }
        public Branch ForBranch { get => forBranch; set => forBranch = value; }
        public Programme InProgramme { get => inProgramme; set => inProgramme = value; }
        public string TeacherUniversityId { get => teacherUniversityId; set => teacherUniversityId = value; }

        public override string ToString()
        {
            string rolename = RoleId.ToString();
            string status = StatusId.ToString();
            string baseString = base.ToString();
            baseString += "Status: " + status;
            return baseString;

            //return rolename + " " + FirstName + " " + LastName + "\n"
            //    + Email + " " + Cpr + " " + dept + "\n"
            //    + Username + " " + Password + " " + Phone + "\n"
            //    + Dob + " " + Gender + "Status: " + status;
        }
    }
}
