using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public Notification(string body, User forUser, int notificationId, string title, NotificationType type)
        {
            this.body = body;
            this.forUser = forUser;
            this.notificationId = notificationId;
            this.title = title;
            this.type = type;
        }
        public String Body { get { return body; } set { body = value; } }
        public User ForUser { get {  return forUser; } set {  forUser = value; } }
        public int NotificationId { get {  return notificationId; } set {  notificationId = value; } }
        public string Title { get { return title; } set { title = value; } }
        public NotificationType Type { get { return type; } set { type = value; } }
    }
}
