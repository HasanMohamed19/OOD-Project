using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace OOD_Project
{
    public enum UserRole
    {
        admin,
        teacher,
        student
    }

    public enum UserStatus
    {
        pending,
        accepted,
        rejected
    }
    public class User
    {
        private int userId;
        private string username;
        private string password;
        private string email;
        private UserRole roleId;
        private UserStatus statusId;
        private bool hasNotification;

        public string Email { get { return email; } set { email = value; } }

        public string Password { get => password; set => password = value; }
        public string Username { get => username; set => username = value; }
        public UserRole RoleId { get => roleId; set => roleId = value; }
        public UserStatus StatusId { get => statusId; set => statusId = value; }
        public bool HasNotification { get => hasNotification; set => hasNotification = value; }
        public int UserId { get => userId; set => userId = value; }

        public User()
        {

        }

        public User(int userId, string username, string password, string email, UserRole roleId, UserStatus statusId, bool hasNotification)
        {
            this.userId = userId;
            this.username = username;
            this.password = password;
            this.email = email;
            this.roleId = roleId;
            this.statusId = statusId;
            this.hasNotification = hasNotification;
        }

        public static void AddUser(User user)
        {
            DatabaseManager dbm = DatabaseManager.Instance();
            dbm.Connection.Open();
            
            dbm.Command.Parameters.AddWithValue("@username", user.username);
            dbm.Command.Parameters.AddWithValue("@password", user.password);
            dbm.Command.Parameters.AddWithValue("@email", user.email);
            dbm.Command.Parameters.AddWithValue("@role_id", user.roleId);
            dbm.Command.Parameters.AddWithValue("@status_id", 1);
            dbm.Command.CommandText = "INSERT INTO [dbo].[User] (user_id, username, password, email, role_id, status_id)" +
                " VALUES ([(NEXT VALUE FOR [dbo].[userIDSequence], @username, @password, @email, @role_id, @status_id)";

            try
            {
                dbm.Command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

            }
            finally
            {
                dbm.Command.Parameters.Clear();
                dbm.Connection.Close();
            }
        }

        public static bool DeleteUser(int user_id)
        {
            DatabaseManager dbm = DatabaseManager.Instance();
            dbm.Connection.Open();
            dbm.Command.Parameters.AddWithValue("@user_id", user_id);
            dbm.Command.CommandText = "DELETE FROM [dbo].[User] WHERE user_id = @user_id";
            try
            {
                dbm.Command.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
            finally
            {
                dbm.Command.Parameters.Clear();
                dbm.Connection.Close();
            }

        }

        public static bool EditUser(User user)
        {
            DatabaseManager dbm = DatabaseManager.Instance();
            dbm.Connection.Open();

            dbm.Command.Parameters.AddWithValue("@username", user.username);
            dbm.Command.Parameters.AddWithValue("@password", user.password);
            dbm.Command.Parameters.AddWithValue("@email", user.email);
            dbm.Command.Parameters.AddWithValue("@role_id", user.roleId);

            dbm.Command.CommandText = "UPDATE [dbo].[User] SET username = @username, password = @password, email = @email, role_id = @role_id, WHERE user_id = @user_id";
            try
            {
                dbm.Command.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                dbm.Command.Parameters.Clear();
                dbm.Connection.Close();
            }
        }

        public static void SendEmail(string subject, string content, int recipient_id)
        {
            DatabaseManager dbm = DatabaseManager.Instance();
            dbm.Connection.Open();
            dbm.Command = dbm.Connection.CreateCommand();
            dbm.Command.Parameters.AddWithValue("@subject", subject);
            dbm.Command.Parameters.AddWithValue("@body", content);
            dbm.Command.Parameters.AddWithValue("@recipient_user_id", recipient_id);
            dbm.Command.CommandText = "INSERT INTO [dbo].[email] (email_id, body, subject, sender_user_id, recipient_user_id)" +
                " VALUES(NEXT VALUE FOR [dbo].[userIDSequence], @body, @subject, 2, 3)";

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

        public static void SendAttachments(string path)
        {
            string fileName = Path.GetFileName(path);
            string folderPath = Path.GetDirectoryName(path);
            DatabaseManager dbm = DatabaseManager.Instance();
            dbm.Connection.Open();
            dbm.Command = dbm.Connection.CreateCommand();
            dbm.Command.Parameters.AddWithValue("@file_name", fileName);
            dbm.Command.Parameters.AddWithValue("@folder_path", folderPath);
            dbm.Command.Parameters.AddWithValue("@email_id", 32);
            dbm.Command.CommandText = "INSERT INTO [dbo].[email_attachment] (email_attachment_id, filename, folder_path, email_id)" +
                " VALUES(NEXT VALUE FOR [dbo].[emaiAttachmentIDSequence], @file_name, @folder_path, @email_id)";
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


        //public override string ToString()
        //{
        //    string rolename = RoleId.ToString();
        //    string status = StatusId.ToString();
        //    return rolename + " " + FirstName + " " + LastName + "\n"
        //        + Email + " " + Cpr + " " + "\n"
        //        + Username + " " + Password + " " + Phone + "\n"
        //        + Dob + " " + Gender + "Status: " + status;
        //}
    }

    

    

    //public class Admin : User
    //{
    //    private int adminId;

    //    public int AdminId { get => adminId; set => adminId = value; }
        
    //    public Admin() 
    //    {
    //        this.AdminId = 0;
    //        RoleId = UserRole.admin;
    //        StatusId = UserStatus.accepted;

    //        FirstName = "Admin";
    //        LastName = string.Empty;
    //        Gender = 'M';
    //        Dob = DateTime.Now;
    //        Phone = string.Empty;
    //        Cpr = string.Empty;
    //        Email = string.Empty;
    //    }
    //}
}
