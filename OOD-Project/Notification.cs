using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOD_Project
{

    public enum NotificationType
    {
        email,
        announcement
    }

    public class Notification
    {
        private string body;
        private User forUser;
        private int notificationId;
        private string title;
        private NotificationType type;
        private bool read;

        public Notification(string body, User forUser, int notificationId, string title, NotificationType type, bool read = false)
        {
            this.body = body;
            this.forUser = forUser;
            this.notificationId = notificationId;
            this.title = title;
            this.type = type;
            this.read = read;
        }


        public static void AddNotification(Notification notification)
        {
            DatabaseManager dbm = DatabaseManager.Instance();
            dbm.Connection.Open();

            dbm.Command.Parameters.AddWithValue("@title", notification.title);
            dbm.Command.Parameters.AddWithValue("@body", notification.body);
            dbm.Command.Parameters.AddWithValue("@notification_type_id", (int)notification.type);
            dbm.Command.Parameters.AddWithValue("@user_id", notification.forUser.UserId);
            dbm.Command.Parameters.AddWithValue("@has_read", notification.read);
            dbm.Command.CommandText = "INSERT INTO [dbo].[notification] (notification_id, title, body, notification_type_id, user_id, has_read)" +
                " VALUES ([(NEXT VALUE FOR [dbo].[notificationIDSequence], @title, @body, @notification_type_id, @user_id, @has_read)";

            try
            {
                dbm.Command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                dbm.Command.Parameters.Clear();
                dbm.Connection.Close();
            }
        }

        public static void MarkAllReadForUser(User user)
        {
            DatabaseManager dbm = DatabaseManager.Instance();
            dbm.Connection.Open();
            dbm.Command = dbm.Connection.CreateCommand();
            // mark all notifications as read for this user
            dbm.Command.Parameters.AddWithValue("@user_id", user.UserId);
            dbm.Command.CommandText = "UPDATE [dbo].[notification] " +
                " SET has_read = 1 " +
                " WHERE user_id = @user_id";
            try
            {
                dbm.Command.ExecuteNonQuery();
            } catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally { dbm.Connection.Close(); }
        }

        public static List<Notification> GetNotificationsForUser(User user)
        {
            List<Notification> notifications = new List<Notification>();

            DatabaseManager dbm = DatabaseManager.Instance();
            dbm.Connection.Open();
            dbm.Command = dbm.Connection.CreateCommand();
            // get notifications from db sorted by most recently added
            dbm.Command.Parameters.AddWithValue("@user_id", user.UserId);
            dbm.Command.CommandText = "SELECT notification_id, title, body, notification_type_id, has_read FROM [dbo].[notification] " +
                "WHERE user_id = @user_id " +
                "ORDER BY notification_id DESC";

            dbm.Reader = dbm.Command.ExecuteReader();
            while (dbm.Reader.Read())
            {
                int notificationId = dbm.Reader.GetInt32(0);
                string title = dbm.Reader.GetString(1);
                string body = dbm.Reader.GetString(2);
                NotificationType type = (NotificationType)dbm.Reader.GetInt32(3);
                bool read = dbm.Reader.GetBoolean(4);
                notifications.Add(new Notification(body, user, notificationId, title, type, read));
            }
            dbm.Reader.Close();
            dbm.Connection.Close();

            return notifications;
        }

        public String Body { get { return body; } set { body = value; } }
        public User ForUser { get {  return forUser; } set {  forUser = value; } }
        public int NotificationId { get {  return notificationId; } set {  notificationId = value; } }
        public string Title { get { return title; } set { title = value; } }
        public NotificationType Type { get { return type; } set { type = value; } }
        public bool Read { get => read; set => read = value; }
    }
}
