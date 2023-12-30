using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OOD_Project.Helpers;

namespace OOD_Project
{
    public class Announcement: INotificationSubject
    {
        public enum AnnouncementType
        {
            simple = 1,
            grade = 2
        }

        private int announcementId;
        private string body;
        private DateTime date;
        private List<User> forUsers;
        private bool isGlobal;
        private string title;
        private AnnouncementType type;
        // observer list
        private List<INotificationObserver> observers;


        public Announcement(int announcementId, string body, DateTime date, List<User> forUsers, bool isGlobal, string title, AnnouncementType type)
        {
            observers = new List<INotificationObserver>();
            this.AnnouncementId = announcementId;
            this.Body = body;
            this.Date = date;
            this.ForUsers = forUsers;
            this.IsGlobal = isGlobal;
            this.Title = title;
            this.type = type;
        }

        public Announcement(int announcementId, string body, DateTime date, bool isGlobal, string title, AnnouncementType type)
        {
            observers = new List<INotificationObserver>();
            this.AnnouncementId = announcementId;
            this.Body = body;
            this.Date = date;
            this.IsGlobal = isGlobal;
            this.Title = title;
            this.type = type;
        }

        public int AnnouncementId { get => announcementId; set => announcementId = value; }
        public string Body { get => body; set => body = value; }
        public DateTime Date { get => date; set => date = value; }
        public List<User> ForUsers { get => forUsers; set => forUsers = value; }
        public bool IsGlobal { get => isGlobal; set => isGlobal = value; }
        public string Title { get => title; set => title = value; }
        public AnnouncementType Type { get => type; set => type = value; }
        public List<INotificationObserver> Observers { get => observers; set => observers = value; }

        public void Attach(INotificationObserver observer)
        {
            observers.Add(observer);
        }

        public void Detach(INotificationObserver observer)
        {
            observers.Remove(observer);
        }

        public void Notify()
        {
            foreach (INotificationObserver observer in observers)
            {
                observer.Update(this);
            }
        }

        public static void PublishAnnouncement(Announcement announcement)
        {
            if (announcement.IsGlobal)
            {
                List<User> users = User.GetAllUsers();
                foreach (var user in users)
                {
                    if (user.RoleId != UserRole.admin)
                    {
                        announcement.Attach(user);
                    }
                }
            } else if (announcement.type == AnnouncementType.grade)
            {
                foreach (var student in announcement.forUsers)
                {
                    announcement.Attach(student);
                }
            }
            DatabaseManager dbm = DatabaseManager.Instance();
            dbm.Connection.Open();
            dbm.Command = dbm.Connection.CreateCommand();
            dbm.Command.Parameters.AddWithValue("@body", announcement.Body);
            dbm.Command.Parameters.AddWithValue("@date", announcement.Date);
            dbm.Command.Parameters.AddWithValue("@is_global", announcement.IsGlobal);
            //int type = announcement.IsGlobal ? 1 : 2;
            dbm.Command.Parameters.AddWithValue("@title", announcement.title);
            dbm.Command.Parameters.AddWithValue("@announcement_type_id", ((int)announcement.Type));

            dbm.Command.CommandText = "INSERT INTO [dbo].[announcement] (announcement_id, body, date, is_global, title, announcement_type_id)" +
                " VALUES (NEXT VALUE FOR [dbo].[announcementIDSequence], @body, @date, @is_global, @title, @announcement_type_id)";
            try
            {
                int rows = dbm.Command.ExecuteNonQuery();
                MessageBox.Show($"Announcement published successfully.", "Published");
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
            announcement.Notify();

            if (announcement.Type == AnnouncementType.grade)
            {
                foreach (var student in announcement.forUsers)
                {
                    PublishStudentAnnouncement(student.UserId);
                }
                
            }

        }

        private static void PublishStudentAnnouncement(int user_id)
        {
            DatabaseManager dbm = DatabaseManager.Instance();
            dbm.Connection.Open();
            dbm.Command = dbm.Connection.CreateCommand();
            dbm.Command.Parameters.AddWithValue("@user_id", user_id);
            dbm.Command.CommandText = "INSERT INTO [dbo].[user_announcement] (user_announcement_id, user_id, announcement_id) " +
            "VALUES (NEXT VALUE FOR [dbo].[userAnnouncementIDSequence], @user_id, CONVERT(int, (SELECT current_value FROM sys.sequences WHERE name = 'announcementIDSequence')))";

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

    }
}
