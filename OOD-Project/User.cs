﻿using OOD_Project.Helpers;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using OOD_Project.Helpers;
using System.Text.RegularExpressions;

namespace OOD_Project
{
    public enum UserRole
    {
        admin = 1,
        teacher = 2,
        student = 3
    }

    public enum UserStatus
    {
        pending = 1,
        accepted = 2,
        inactive = 3
    }
    public class User: INotificationObserver
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
            Email = email;
            this.roleId = roleId;
            this.statusId = statusId;
            this.hasNotification = hasNotification;
        }


        
        public static void AcceptPendingUser(int user_id, UserRole role)
        {
            int inactive_id;
            string university_id;
            // check if pending user has the same university id as inactive user
            switch (role)
            {
                // get university id and inactive user id
                case UserRole.student:
                    university_id = Student.GetStudent(user_id).StudentUniversityId;
                    try
                    {
                        inactive_id = Student.IsStudentIdValid(university_id);
                    } catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        return;
                    }
                    break;
                case UserRole.teacher:
                    university_id = Teacher.GetTeacher(user_id).TeacherUniversityId;
                    try
                    {
                        inactive_id = Teacher.IsTeacherIdValid(university_id);
                    } catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        return;
                    }
                    break;
                default:
                    return;
            }

            // update status of inactive user
            ActivateUser(inactive_id);

            // delete pending user
            DeleteUser(user_id);
        }


        private static void ActivateUser(int user_id)
        {
            DatabaseManager dbm = DatabaseManager.Instance();
            dbm.Connection.Open();
            dbm.Command = dbm.Connection.CreateCommand();

            dbm.Command.Parameters.AddWithValue("@user_id", user_id);

            dbm.Command.CommandText = "UPDATE [dbo].[User] SET status_id = 2 WHERE user_id = @user_id";
            try
            {
                dbm.Command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            finally
            {
                dbm.Command.Parameters.Clear();
                dbm.Connection.Close();
            }
        }

        public static int UnreadNotificationsForUser(User user)
        {
            int unreadCount = 0;

            DatabaseManager dbm = DatabaseManager.Instance();
            dbm.Connection.Open();
            dbm.Command = dbm.Connection.CreateCommand();

            dbm.Command.Parameters.AddWithValue("@user_id", user.UserId);
            dbm.Command.CommandText = "SELECT COUNT(n.has_read)" +
                " FROM [dbo].[User] u, [dbo].[notification] n " +
                " WHERE n.user_id = u.user_id " +
                " AND u.user_id = @user_id " +
                " AND has_read = 0";
            try
            {
                dbm.Reader = dbm.Command.ExecuteReader();

                if (!dbm.Reader.Read())
                {
                    return 0;
                }
                unreadCount = dbm.Reader.GetInt32(0);

            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            } finally
            {
                dbm.Reader.Close();
                dbm.Connection.Close();
            }

            return unreadCount;
        }

        public static User GetUser(int user_id)
        {
            User user = null;
            DatabaseManager dbm = DatabaseManager.Instance();
            dbm.Connection.Open();
            dbm.Command = dbm.Connection.CreateCommand();

            dbm.Command.Parameters.AddWithValue("@user_id", user_id);
            dbm.Command.CommandText = "SELECT u.user_id, u.username, u.password, u.email, u.role_id, u.status_id, u.has_notification " +
                " FROM  [dbo].[User] u " +
                " WHERE  u.user_id = @user_id";
            try
            {
                dbm.Reader = dbm.Command.ExecuteReader();
                if (!dbm.Reader.Read())
                {
                    return null;
                }
                int id = dbm.Reader.GetInt32(0);
                string username = dbm.Reader.GetString(1);
                string password = dbm.Reader.GetString(2);
                string email = dbm.Reader.GetString(3);
                UserRole roleId = (UserRole)dbm.Reader.GetInt32(4);
                UserStatus statusId = (UserStatus)dbm.Reader.GetInt32(5);
                bool hasNotification = dbm.Reader.GetBoolean(6);

                user = new User(id, username, password, email, roleId, statusId, hasNotification);
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            } finally
            {
                dbm.Reader.Close();
                dbm.Connection.Close();
            }

            
            return user;
        }
        public static void AddUser(User user)
        {
            DatabaseManager dbm = DatabaseManager.Instance();
            dbm.Connection.Open();
            dbm.Command = dbm.Connection.CreateCommand();

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
                MessageBox.Show (ex.Message);
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
            dbm.Command = dbm.Connection.CreateCommand();
            dbm.Command.Parameters.AddWithValue("@user_id", user_id);
            dbm.Command.CommandText = "DELETE FROM [dbo].[User] WHERE user_id = @user_id";
            try
            {
                dbm.Command.ExecuteNonQuery();
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
            return true;

        }

        public static bool EditUser(User user)
        {
            DatabaseManager dbm = DatabaseManager.Instance();
            dbm.Connection.Open();
            dbm.Command = dbm.Connection.CreateCommand();

            dbm.Command.Parameters.AddWithValue("@user_id", user.UserId);
            dbm.Command.Parameters.AddWithValue("@username", user.username);
            dbm.Command.Parameters.AddWithValue("@password", user.password);
            dbm.Command.Parameters.AddWithValue("@email", user.email);
            dbm.Command.Parameters.AddWithValue("@role_id", user.roleId);

            dbm.Command.CommandText = "UPDATE [dbo].[User] SET username = @username, password = @password, email = @email, role_id = @role_id WHERE user_id = @user_id";
            try
            {
                dbm.Command.ExecuteNonQuery();
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
            return true;
        }

        public static int SendEmail(Email email)
        {
            email.Attach(email.Recipent);

            int emailId = 0;
            DatabaseManager dbm = DatabaseManager.Instance();
            dbm.Connection.Open();
            dbm.Command = dbm.Connection.CreateCommand();
            dbm.Command.Parameters.AddWithValue("@subject", email.Subject);
            dbm.Command.Parameters.AddWithValue("@body", email.Body);
            dbm.Command.Parameters.AddWithValue("@recipient_user_id", email.Recipent.UserId);
            dbm.Command.CommandText = "INSERT INTO [dbo].[email] (email_id, body, subject, sender_user_id, recipient_user_id)" +
                " VALUES(NEXT VALUE FOR [dbo].[emailIDSequence], @body, @subject, 2, 3)";

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
            email.Notify();


            dbm.Connection.Open();

            dbm.Command.CommandText = "SELECT CAST(CURRENT_VALUE AS INT) FROM SYS.SEQUENCES WHERE NAME='emailIDSequence'";
            
            try
            {
                dbm.Reader = dbm.Command.ExecuteReader();
                if (dbm.Reader.Read())
                {
                    emailId = dbm.Reader.GetInt32(0);
                }
                
                MessageBox.Show(emailId.ToString());
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            } finally
            {
                dbm.Reader.Close();
                dbm.Command.Parameters.Clear();
                dbm.Connection.Close();
            }
            


            return emailId;

        }

        private static int getRecipientId(int eid)
        {
            int rid = 0;
            DatabaseManager dbm = DatabaseManager.Instance();
            dbm.Connection.Open();
            dbm.Command = dbm.Connection.CreateCommand();
            dbm.Command.Parameters.AddWithValue("@email_id", 20);
            dbm.Command.CommandText = "SELECT recipient_user_id FROM [dbo].[email] WHERE email_id = @email_id";

            try
            {
                dbm.Reader = dbm.Command.ExecuteReader();
                if (dbm.Reader.Read())
                {
                    rid = Convert.ToInt32(dbm.Reader["recipient_user_id"].ToString());
                }
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            } finally
            {
                dbm.Command.Parameters.Clear();
                dbm.Connection.Close();
            }
            
            return rid;
        }

        public static void SendAttachments(string path)
        {
            int recId = getRecipientId(20);
            string fileName = Path.GetFileName(path);
            string folderPath = Path.GetDirectoryName(path);
            DatabaseManager dbm = DatabaseManager.Instance();
            dbm.Connection.Open();
            dbm.Command = dbm.Connection.CreateCommand();
            dbm.Command.Parameters.AddWithValue("@file_name", fileName);
            dbm.Command.Parameters.AddWithValue("@folder_path", folderPath);
            dbm.Command.Parameters.AddWithValue("@email_id", 20);
            dbm.Command.CommandText = "INSERT INTO [dbo].[email_attachment] (email_attachment_id, filename, folder_path, email_id)" +
                " VALUES(NEXT VALUE FOR [dbo].[emaiAttachmentIDSequence], @file_name, @folder_path, @email_id)";
            try
            {
                dbm.Command.ExecuteNonQuery();
                // format: sender_receiver
                string dest = Path.Combine(DocumentHelper.parentDirectory, (Global.UserId.ToString() + "_" + recId.ToString()));
                if (!DocumentHelper.IsDirectoryExists(dest))
                {
                    DocumentHelper.MakeDirectory(Path.Combine(DocumentHelper.parentDirectory, (Global.UserId.ToString() + "_" + recId.ToString())));
                   
                }
                DocumentHelper.CopyFile(path, Path.Combine(dest, fileName));

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

        public void Update(INotificationSubject subject)
        {
            // create new notification based on subject type and save to db
            if (subject is Announcement announcement)
            {
                Notification notif = new Notification(announcement.Body, this, 0, announcement.Title, NotificationType.announcement, false);
                Notification.AddNotification(notif);
            }
            else if (subject is Email email)
            {
                Notification notif = new Notification(email.Body, this, 0, email.Subject, NotificationType.email, false);
                Notification.AddNotification(notif);
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
