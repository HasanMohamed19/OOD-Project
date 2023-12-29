using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Collections.Specialized.BitVector32;

namespace OOD_Project
{
    public class Teacher : User
    {
        private int teacherId;
        private string firstName;
        private string lastName;
        private DateTime dob;
        private string cpr;
        private char gender;
        private string phoneNumber;
        private Branch forBranch;
        private Programme inProgramme;
        private string teacherUniversityId;

        

        public Teacher(int userId, string username, string password, string email, UserRole roleId, UserStatus statusId, 
            int teacherId, string firstName, string lastName, DateTime dob, string cpr, char gender, string phoneNumber, Branch forBranch, Programme inProgramme, string teacherUniversityId) : 
            base(userId,username,password,email,roleId,statusId)
        {
            this.teacherId = teacherId;
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

        public static List<Teacher> GetTeachers()
        {
            List<Teacher> teachers = new List<Teacher>();
            DatabaseManager dbm = DatabaseManager.Instance();
            dbm.Connection.Open();
            dbm.Command = dbm.Connection.CreateCommand();
            // get teachers without branch
            dbm.Command.CommandText = "SELECT u.user_id, u.username, u.password, u.email, u.role_id, u.status_id," +
                "t.first_name, t.last_name, t.dob, t.cpr, t.phone_number, t.gender, t.programme_id, t.teacher_university_id, branch_id, teacher_id " +
                " FROM [dbo].[teacher] t, [dbo].[User] u " +
                " WHERE t.user_id = u.user_id " +
                " AND u.status_id = 2";
            try
            {
                dbm.Reader = dbm.Command.ExecuteReader();
                Teacher teacher;
                int branchId;
                while (dbm.Reader.Read())
                {
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
                    Programme programme = (Programme)dbm.Reader.GetInt32(12);
                    string universityId = dbm.Reader.GetString(13);
                    branchId = dbm.Reader.GetInt32(14);
                    int teacherId = dbm.Reader.GetInt32(15);
                    teacher = new Teacher(id, username, password, email, roleId, statusId,
                        teacherId, firstName, lastName, dob, cpr, gender, phoneNumber, null, programme, universityId);
                    teachers.Add(teacher);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            } finally
            {
                dbm.Reader.Close();
                dbm.Connection.Close();
            }

            // get branch for each teacher

            foreach (Teacher t in teachers)
            {
                t.forBranch = Branch.GetBranchForTeacher(t.TeacherId);
            }

            return teachers;
        }

        public static Teacher GetTeacherFromTeacherID(int teacher_id)
        {
            Teacher teacher = null;
            DatabaseManager dbm = DatabaseManager.Instance();
            dbm.Connection.Open();
            dbm.Command = dbm.Connection.CreateCommand();

            dbm.Command.Parameters.AddWithValue("@teacher_id", teacher_id);
            dbm.Command.CommandText = "SELECT u.user_id, u.username, u.password, u.email, u.role_id, u.status_id," +
                "t.first_name, t.last_name, t.dob, t.cpr, t.phone_number, t.gender, t.programme_id, t.teacher_university_id, branch_id, teacher_id " +
                " FROM [dbo].[teacher] t, [dbo].[User] u " +
                " WHERE t.user_id = u.user_id " +
                " AND t.teacher_id = @teacher_id";
            try
            {
                dbm.Reader = dbm.Command.ExecuteReader();

                if (!dbm.Reader.Read())
                {
                    dbm.Reader.Close();
                    dbm.Connection.Close();
                    MessageBox.Show("ERROR: Teacher not found");
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
                Programme programme = (Programme)dbm.Reader.GetInt32(12);
                string universityId = dbm.Reader.GetString(13);
                int branchId = dbm.Reader.GetInt32(14);
                int teacherId = dbm.Reader.GetInt32(15);
                dbm.Reader.Close();
                dbm.Connection.Close();

                Branch branch = Branch.GetBranch(branchId);
                teacher = new Teacher(id, username, password, email, roleId, statusId,
                    teacherId, firstName, lastName, dob, cpr, gender, phoneNumber, branch, programme, universityId);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return teacher;
        }

        public static Teacher GetTeacher(int user_id)
        {
            Teacher teacher = null;
            DatabaseManager dbm = DatabaseManager.Instance();
            dbm.Connection.Open();
            dbm.Command = dbm.Connection.CreateCommand();

            dbm.Command.Parameters.AddWithValue("@user_id", user_id);
            dbm.Command.CommandText = "SELECT u.user_id, u.username, u.password, u.email, u.role_id, u.status_id," +
                "t.first_name, t.last_name, t.dob, t.cpr, t.phone_number, t.gender, t.programme_id, t.teacher_university_id, branch_id, teacher_id " +
                " FROM [dbo].[teacher] t, [dbo].[User] u " +
                " WHERE t.user_id = u.user_id " +
                " AND u.user_id = @user_id";
            try
            {
                dbm.Reader = dbm.Command.ExecuteReader();

                if (!dbm.Reader.Read())
                {
                    dbm.Reader.Close();
                    dbm.Connection.Close();
                    MessageBox.Show("ERROR: Teacher not found");
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
                Programme programme = (Programme)dbm.Reader.GetInt32(12);
                string universityId = dbm.Reader.GetString(13);
                int branchId = dbm.Reader.GetInt32(14);
                int teacherId = dbm.Reader.GetInt32(15);
                dbm.Reader.Close();
                dbm.Connection.Close();

                Branch branch = Branch.GetBranch(branchId);
                teacher = new Teacher(id, username, password, email, roleId, statusId, 
                    teacherId, firstName, lastName, dob, cpr, gender, phoneNumber, branch, programme, universityId);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return teacher;
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
                "AND t.teacher_university_id = @teacher_university_id " +
                "AND NOT u.status_id = 1";

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
            if (ids.Count > 1)
            {
                throw new Exception("Too many teachers with id " + universityId);
            }
            else if (ids.Count < 1)
            {
                throw new Exception("No teachers with id " + universityId);
            }

            // if status_id is  not 3 (inactive) then a new user cannot be made with this id
            if (status[0] != 3)
            {
                throw new Exception("There is already an active account for id " + universityId);
            }


            return ids[0];
        }

        public static void UpdateTeacher(Teacher teacher)
        {
            // update user table for teacher in db
            if (!EditUser(teacher))
            {
                return;
            }

            // update teacher table
            DatabaseManager dbm = DatabaseManager.Instance();
            dbm.Connection.Open();

            // UPDATE TEACHER ROW
            dbm.Command.Parameters.AddWithValue("@user_id", teacher.UserId);
            dbm.Command.Parameters.AddWithValue("@first_name", teacher.firstName);
            dbm.Command.Parameters.AddWithValue("@last_name", teacher.lastName);
            dbm.Command.Parameters.AddWithValue("@phone", teacher.phoneNumber);
            dbm.Command.Parameters.AddWithValue("@cpr", teacher.cpr);
            dbm.Command.Parameters.AddWithValue("@gender", teacher.gender);
            dbm.Command.Parameters.AddWithValue("@dob", teacher.dob);
            dbm.Command.Parameters.AddWithValue("@branch_id", teacher.forBranch.BranchId);
            dbm.Command.Parameters.AddWithValue("@programme_id", (int)teacher.InProgramme);
            dbm.Command.Parameters.AddWithValue("@teacher_university_id", teacher.teacherUniversityId);
            dbm.Command.CommandText = "UPDATE [dbo].[teacher] SET first_name = @first_name, last_name = @last_name, phone_number = @phone" +
                ", cpr = @cpr, gender = @gender, dob = @dob, branch_id = @branch_id, programme_id = @programme_id, teacher_university_id = @teacher_university_id " +
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

        public static void UploadContent(string path, int courseId)
        {
            string fileName = Path.GetFileName(path);
            string folderPath = Path.GetDirectoryName(path);
            DatabaseManager dbm = DatabaseManager.Instance();
            dbm.Connection.Open();
            dbm.Command = dbm.Connection.CreateCommand();
            dbm.Command.Parameters.AddWithValue("@file_name", fileName);
            dbm.Command.Parameters.AddWithValue("@folder_path", folderPath);
            dbm.Command.Parameters.AddWithValue("@course_id", courseId);
            dbm.Command.CommandText = "INSERT INTO [dbo].[Content] (content_id, filename, folder_path, course_id)" +
                " VALUES (NEXT VALUE FOR [dbo].[contentIDSequence], @file_name, @folder_path, @course_id)";

            try
            {
                dbm.Command.ExecuteNonQuery();
                string dest = Path.Combine(DocumentHelper.coursesDirectory, courseId.ToString());
                if (!DocumentHelper.IsDirectoryExists(dest))
                {
                    DocumentHelper.MakeDirectory(dest);
                }
                DocumentHelper.CopyFile(path, dest);
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            } finally
            {
                dbm.Command.Parameters.Clear();
                dbm.Connection.Close();
            }

        }

        public static void UploadReport(string reportPath, int courseId)
        {
            string fileName = Path.GetFileName(reportPath);
            string newDestDirectory = Path.Combine(DocumentHelper.parentRelativePath, "Courses", courseId.ToString(), "Reports");
            string newReportPath = Path.Combine(newDestDirectory, fileName);
            
            DatabaseManager dbm = DatabaseManager.Instance();
            dbm.Connection.Open();
            dbm.Command = dbm.Connection.CreateCommand();
            dbm.Command.Parameters.AddWithValue("@report_path", newReportPath);
            dbm.Command.Parameters.AddWithValue("@course_id", courseId);
            dbm.Command.CommandText = "UPDATE [dbo].[section] SET report_path = @report_path WHERE course_id = @course_id";
            try
            {
                
                if (!DocumentHelper.IsDirectoryExists(Path.Combine(DocumentHelper.coursesDirectory, courseId.ToString(), "Reports")))
                {
                    DocumentHelper.MakeDirectory(Path.Combine(DocumentHelper.coursesDirectory, courseId.ToString(), "Reports"));
                }

                // check if report already exists
                MessageBox.Show(DocumentHelper.IsFileExists(newReportPath).ToString());
                if (DocumentHelper.IsFileExists(newReportPath))
                {

                    DialogResult dialogResult = MessageBox.Show("Report already exists, do you want to overwrite it?", "File exists", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        dbm.Command.ExecuteNonQuery();
                        DocumentHelper.CopyFile(reportPath, newReportPath);
                    } else
                    {
                        MessageBox.Show("Report upload cancelled");
                    }
                } else
                {
                    dbm.Command.ExecuteNonQuery();
                    DocumentHelper.CopyFile(reportPath, Path.Combine(DocumentHelper.coursesDirectory, courseId.ToString(), "Reports", fileName));
                }

                
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            } finally
            {
                dbm.Command.Parameters.Clear();
                dbm.Connection.Close();
            }

        }

        public static void DownloadContent(Content content)
        {
            
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
        public int TeacherId { get => teacherId; set => teacherId = value; }

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
