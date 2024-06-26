﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Windows.Forms;
using static System.Collections.Specialized.BitVector32;

namespace OOD_Project
{
    public class Student : User
    {
        private int studentId;
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

        public Student(int userId, string username, string password, string email, UserRole roleId, UserStatus statusId, 
            int studentId, string firstName, string lastName, DateTime dob, string cpr, char gender, string phoneNumber, Major inMajor, string studentUniversityId)
            : base(userId, username, password, email, roleId, statusId)
        {
            this.studentId = studentId;
            this.firstName = firstName;
            this.lastName = lastName;
            this.dob = dob;
            this.cpr = cpr;
            this.gender = gender;
            this.phoneNumber = phoneNumber;
            this.inMajor = inMajor;
            this.studentUniversityId = studentUniversityId;
        }


        public static void UnregisterStudentFromSection(int student_id, int section_id)
        {
            // deletes registration record from db
            DatabaseManager dbm = DatabaseManager.Instance();
            dbm.Connection.Open();
            dbm.Command = dbm.Connection.CreateCommand();

            dbm.Command.Parameters.AddWithValue("@student_id", student_id);
            dbm.Command.Parameters.AddWithValue("@section_id", section_id);

            dbm.Command.CommandText = "DELETE FROM [dbo].[registration] " +
                "WHERE student_id = @student_id AND section_id = @section_id ";

            try
            {
                dbm.Command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                dbm.Command.Parameters.Clear();
                dbm.Connection.Close();
            }
        }
        public static void RegisterStudentToSection(int student_id, int section_id)
        {
            // inserts registration record into db
            DatabaseManager dbm = DatabaseManager.Instance();
            dbm.Connection.Open();
            dbm.Command = dbm.Connection.CreateCommand();

            dbm.Command.Parameters.AddWithValue("@student_id", student_id);
            dbm.Command.Parameters.AddWithValue("@section_id", section_id);

            dbm.Command.CommandText = "INSERT INTO [dbo].[registration] (registration_id, student_id, section_id) " +
                "VALUES (NEXT VALUE FOR [dbo].[registrationIDSequence], @student_id, @section_id)";

            try
            {
                dbm.Command.ExecuteNonQuery();
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            } finally
            {
                dbm.Command.Parameters.Clear();
                dbm.Connection.Close();
            }
        }

        // check if an inactive student account exists with this id
        // used to prevent admin from duplicating universityIds, they must be unique
        public static bool InactiveStudentExistsWithId(string universityId, int existingStudentId)
        {
            List<int> status = new List<int>();

            DatabaseManager dbm = DatabaseManager.Instance();
            dbm.Connection.Open();
            dbm.Command = dbm.Connection.CreateCommand();

            dbm.Command.Parameters.AddWithValue("@student_university_id", universityId);
            dbm.Command.Parameters.AddWithValue("@student_id", existingStudentId);
            dbm.Command.CommandText = "SELECT u.status_id FROM [dbo].[student] s, [dbo].[User] u " +
                "WHERE s.user_id = u.user_id " +
                "AND s.student_university_id = @student_university_id " +
                "AND NOT s.student_id = @student_id";

            dbm.Reader = dbm.Command.ExecuteReader();

            while (dbm.Reader.Read())
            {
                int status_id = dbm.Reader.GetInt32(0);
                status.Add(status_id);
            }
            dbm.Reader.Close();
            dbm.Connection.Close();

            if (status.Count <= 0)
            {
                // nothing found, no inactive user exists
                return false;
            }

            if (status[0] == 3 || status[0] == 2)
            {
                // inactve student exists 
                return true;
            }
            // pending student exists, can consider to not exist
            return false;
        }

        // returns user_id of inactive user with the same universityId
        // used to check if a student can register with this universityId
        // also used to activate student account
        public static int IsStudentIdValid(string universityId)
        {
            // check if this id exists for inactive user
            List<int> ids = new List<int>();
            List<int> status = new List<int>();

            DatabaseManager dbm = DatabaseManager.Instance();
            dbm.Connection.Open();
            dbm.Command = dbm.Connection.CreateCommand();

            dbm.Command.Parameters.AddWithValue("@student_university_id", universityId);
            dbm.Command.CommandText = "SELECT u.user_id, u.status_id FROM [dbo].[student] s, [dbo].[User] u " +
                "WHERE s.user_id = u.user_id " +
                "AND s.student_university_id = @student_university_id " +
                "AND NOT u.status_id = 1 ";

            dbm.Reader = dbm.Command.ExecuteReader();

            while (dbm.Reader.Read())
            {
                int user_id = dbm.Reader.GetInt32(0);
                int status_id = dbm.Reader.GetInt32(1);
                ids.Add(user_id);
                status.Add(status_id);
            }
            dbm.Reader.Close();
            dbm.Connection.Close();

            // if there is more than one row returned or zero, dont continue
            if (ids.Count > 1) {
                throw new Exception("Too many students with id " + universityId);
            } else if (ids.Count < 1)
            {
                throw new Exception("No students with id " + universityId);
            }

            // if status_id is  not 3 (inactive) then a new user cannot be made with this id
            if (status[0] != 3)
            {
                throw new Exception("There is already an active account for id " + universityId);
            }


            return ids[0];
        }

        public static Student GetStudentFromUniId(string university_id)
        {
            Student student = null;
            DatabaseManager dbm = DatabaseManager.Instance();
            dbm.Connection.Open();
            dbm.Command = dbm.Connection.CreateCommand();

            dbm.Command.Parameters.AddWithValue("@student_university_id", university_id);
            dbm.Command.CommandText = "SELECT u.user_id, u.username, u.password, u.email, u.role_id, u.status_id," +
                "s.first_name, s.last_name, s.dob, s.cpr, s.phone_number, s.gender, s.major_id, s.student_university_id, s.student_id " +
                " FROM [dbo].[student] s, [dbo].[User] u " +
                " WHERE s.user_id = u.user_id " +
                " AND s.student_university_id = @student_university_id " +
                " AND u.status_id = 2 ";
            try
            {
                dbm.Reader = dbm.Command.ExecuteReader();

                if (!dbm.Reader.Read())
                {
                    dbm.Reader.Close();
                    dbm.Connection.Close();
                    return null;
                }
                int id = dbm.Reader.GetInt32(0);
                string username = dbm.Reader.GetString(1);
                string password = dbm.Reader.GetString(2);
                string email = dbm.Reader.GetString(3);
                UserRole roleId = (UserRole)dbm.Reader.GetInt32(4);
                UserStatus statusId = (UserStatus)dbm.Reader.GetInt32(5);
                string firstName = dbm.Reader.GetString(6);
                string lastName = dbm.Reader.GetString(7);
                DateTime dob = dbm.Reader.GetDateTime(8);
                string cpr = dbm.Reader.GetString(9);
                string phoneNumber = dbm.Reader.GetString(10);
                char gender = dbm.Reader.GetString(11)[0];
                int major_id = dbm.Reader.GetInt32(12);
                string universityId = dbm.Reader.GetString(13);
                int studentId = dbm.Reader.GetInt32(14);
                dbm.Reader.Close();
                dbm.Connection.Close();

                Major major = Major.GetMajor(major_id);
                student = new Student(id, username, password, email, roleId, statusId,
                    studentId, firstName, lastName, dob, cpr, gender, phoneNumber, major, universityId);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return student;
        }

        public static Student GetStudentFromStudentID(int student_id)
        {
            Student student = null;
            DatabaseManager dbm = DatabaseManager.Instance();
            dbm.Connection.Open();
            dbm.Command = dbm.Connection.CreateCommand();

            dbm.Command.Parameters.AddWithValue("@student_id", student_id);
            dbm.Command.CommandText = "SELECT u.user_id, u.username, u.password, u.email, u.role_id, u.status_id," +
                "s.first_name, s.last_name, s.dob, s.cpr, s.phone_number, s.gender, s.major_id, s.student_university_id, s.student_id " +
                " FROM [dbo].[student] s, [dbo].[User] u " +
                " WHERE s.user_id = u.user_id " +
                " AND s.student_id = @student_id";
            try
            {
                dbm.Reader = dbm.Command.ExecuteReader();

                if (!dbm.Reader.Read())
                {
                    dbm.Reader.Close();
                    dbm.Connection.Close();
                    return null;
                }
                int id = dbm.Reader.GetInt32(0);
                string username = dbm.Reader.GetString(1);
                string password = dbm.Reader.GetString(2);
                string email = dbm.Reader.GetString(3);
                UserRole roleId = (UserRole)dbm.Reader.GetInt32(4);
                UserStatus statusId = (UserStatus)dbm.Reader.GetInt32(5);
                string firstName = dbm.Reader.GetString(6);
                string lastName = dbm.Reader.GetString(7);
                DateTime dob = dbm.Reader.GetDateTime(8);
                string cpr = dbm.Reader.GetString(9);
                string phoneNumber = dbm.Reader.GetString(10);
                char gender = dbm.Reader.GetString(11)[0];
                int major_id = dbm.Reader.GetInt32(12);
                string universityId = dbm.Reader.GetString(13);
                int studentId = dbm.Reader.GetInt32(14);
                dbm.Reader.Close();
                dbm.Connection.Close();

                Major major = Major.GetMajor(major_id);
                student = new Student(id, username, password, email, roleId, statusId,
                    studentId, firstName, lastName, dob, cpr, gender, phoneNumber, major, universityId);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return student;
        }
        public static Student GetStudent(int user_id)
        {
            Student student = null;
            DatabaseManager dbm = DatabaseManager.Instance();
            dbm.Connection.Open();
            dbm.Command = dbm.Connection.CreateCommand();
            
            dbm.Command.Parameters.AddWithValue("@user_id", user_id);
            dbm.Command.CommandText = "SELECT u.user_id, u.username, u.password, u.email, u.role_id, u.status_id," +
                "s.first_name, s.last_name, s.dob, s.cpr, s.phone_number, s.gender, s.major_id, s.student_university_id, s.student_id " +
                " FROM [dbo].[student] s, [dbo].[User] u " +
                " WHERE s.user_id = u.user_id " +
                " AND u.user_id = @user_id";
            try
            {
                dbm.Reader = dbm.Command.ExecuteReader();

                if (!dbm.Reader.Read())
                {
                    dbm.Reader.Close();
                    dbm.Connection.Close();
                    return null;
                }
                int id = dbm.Reader.GetInt32(0);
                string username = dbm.Reader.GetString(1);
                string password = dbm.Reader.GetString(2);
                string email = dbm.Reader.GetString(3);
                UserRole roleId = (UserRole)dbm.Reader.GetInt32(4);
                UserStatus statusId = (UserStatus)dbm.Reader.GetInt32(5);
                string firstName = dbm.Reader.GetString(6);
                string lastName = dbm.Reader.GetString(7);
                DateTime dob = dbm.Reader.GetDateTime(8);
                string cpr = dbm.Reader.GetString(9);
                string phoneNumber = dbm.Reader.GetString(10);
                char gender = dbm.Reader.GetString(11)[0];
                int major_id = dbm.Reader.GetInt32(12);
                string universityId = dbm.Reader.GetString(13);
                int studentId = dbm.Reader.GetInt32(14);
                dbm.Reader.Close();
                dbm.Connection.Close();

                Major major = Major.GetMajor(major_id);
                student = new Student(id, username, password, email, roleId, statusId, 
                    studentId, firstName, lastName, dob, cpr, gender, phoneNumber, major, universityId);

            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
            return student;
        }


        public static void UpdateStudent(Student student)
        {
            // update user table for student in db
            if (!EditUser(student))
            {
                return;
            }

            // update student table
            DatabaseManager dbm = DatabaseManager.Instance();
            dbm.Connection.Open();

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
            dbm.Command.CommandText = "UPDATE [dbo].[student] SET first_name = @first_name, last_name = @last_name, phone_number = @phone" +
                ", cpr = @cpr, gender = @gender, dob = @dob, major_id = @major_id, student_university_id = @student_university_id " +
                " WHERE user_id = @user_id";

            try
            {
                int rows = dbm.Command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                dbm.Command.Parameters.Clear();
                dbm.Connection.Close();
            }
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
                //MessageBox.Show($"User added successfully {rows}");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            finally
            {
                dbm.Command.Parameters.Clear();
                dbm.Reader.Close();
                dbm.Connection.Close();
            }

            dbm.Connection.Open();
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
                dbm.Command.Parameters.Clear();
                dbm.Connection.Close();
            }

            dbm.Connection.Open();
            
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
                // if pending user, tell them to wait for admin approval
                if (student.StatusId == UserStatus.inactive)
                {
                    MessageBox.Show("Registration request sent. Please wait for approval from the admin. Check your email to be notified.", "Request Sent");
                }
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

        public static List<User> GetStudentsOfCourse(int sectionId)
        {
            List<User> students = new List<User>();
            DatabaseManager dbm = DatabaseManager.Instance();
            dbm.Connection.Open();
            dbm.Command.Parameters.AddWithValue("@section_id", sectionId);

            dbm.Command.CommandText = "SELECT * FROM [dbo].[registration] r" +
                " JOIN [dbo].[student] s ON s.student_id = r.student_id WHERE section_id = @section_id";
            dbm.Reader = dbm.Command.ExecuteReader();
            try
            {
                while (dbm.Reader.Read())
                {
                    User student = new Student();
                    //student.studentId = Convert.ToInt32(dbm.Reader["student_id"].ToString());
                    student.UserId = Convert.ToInt32(dbm.Reader["user_id"].ToString());
                    students.Add(student);
                }
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            } finally
            {
                dbm.Command.Parameters.Clear();
                dbm.Connection.Close();
            }
            return students;

        }

        public string StudentUniversityId { get => studentUniversityId; set => studentUniversityId = value; }
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public DateTime Dob { get => dob; set => dob = value; }
        public string Cpr { get => cpr; set => cpr = value; }
        public char Gender { get => gender; set => gender = value; }
        public string PhoneNumber { get => phoneNumber; set => phoneNumber = value; }
        public Major InMajor { get => inMajor; set => inMajor = value; }
        public int StudentId { get => studentId; set => studentId = value; }

        //public override string ToString()
        //{
        //    return base.ToString() + " Student ID: " + Id;

        //}
    }
}
