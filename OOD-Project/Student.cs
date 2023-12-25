using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Windows.Forms;

namespace OOD_Project
{
    public class Student : User
    {
        private string firstName;
        private string lastName;
        private DateTime dob;
        private string cpr;
        private char gender;
        private string phoneNumber;
        private Major inMajor;
        private string studentUniversityId;

        public Student()
        {
            RoleId = UserRole.student;
            StatusId = UserStatus.pending;
        }

        public Student(int userId, string username, string password, string email, UserRole roleId, UserStatus statusId, bool hasNotification, 
            string firstName, string lastName, DateTime dob, string cpr, char gender, string phoneNumber, Major inMajor, string studentUniversityId)
            : base(userId, username, password, email, roleId, statusId, hasNotification)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.dob = dob;
            this.cpr = cpr;
            this.gender = gender;
            this.phoneNumber = phoneNumber;
            this.inMajor = inMajor;
            this.studentUniversityId = studentUniversityId;
        }


        public static void AddStudent(Student student)
        {
            // ADD USER ROW
            DatabaseManager dbm = DatabaseManager.Instance();
            dbm.Connection.Open();
            dbm.Command = dbm.Connection.CreateCommand();
            // default username and password until accepted by admin
            dbm.Command.Parameters.AddWithValue("@username", student.firstName + "_" + student.lastName);
            dbm.Command.Parameters.AddWithValue("@password", student.cpr);
            dbm.Command.Parameters.AddWithValue("@email", student.Email);
            dbm.Command.Parameters.AddWithValue("@role_id", (int)student.RoleId);
            dbm.Command.Parameters.AddWithValue("@status_id", (int)student.StatusId);

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
                    student.UserId = dbm.Reader.GetInt32(0);
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
            dbm.Command.Parameters.AddWithValue("@user_id", student.UserId);
            dbm.Command.Parameters.AddWithValue("@first_name", student.firstName);
            dbm.Command.Parameters.AddWithValue("@last_name", student.lastName);
            dbm.Command.Parameters.AddWithValue("@phone", student.phoneNumber);
            dbm.Command.Parameters.AddWithValue("@cpr", student.cpr);
            dbm.Command.Parameters.AddWithValue("@gender", student.gender);
            dbm.Command.Parameters.AddWithValue("@dob", student.dob);
            dbm.Command.Parameters.AddWithValue("@major_id", student.InMajor.MajorId);
            dbm.Command.Parameters.AddWithValue("@student_university_id", student.studentUniversityId);
            dbm.Command.CommandText = "INSERT INTO [dbo].[student] (student_id, user_id, first_name, last_name, phone_number, cpr, gender, dob, major_id, student_university_id)" +
                " VALUES(NEXT VALUE FOR [dbo].[studentIDSequence],@user_id, @first_name, @last_name, @phone, @cpr, @gender, @dob, @major_id, @student_university_id)";

            try
            {
                int rows = dbm.Command.ExecuteNonQuery();
                MessageBox.Show($"Student added successfully {rows}");
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

        public string StudentUniversityId { get => studentUniversityId; set => studentUniversityId = value; }
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public DateTime Dob { get => dob; set => dob = value; }
        public string Cpr { get => cpr; set => cpr = value; }
        public char Gender { get => gender; set => gender = value; }
        public string PhoneNumber { get => phoneNumber; set => phoneNumber = value; }
        public Major InMajor { get => inMajor; set => inMajor = value; }

        //public override string ToString()
        //{
        //    return base.ToString() + " Student ID: " + Id;
            
        //}
    }
}
