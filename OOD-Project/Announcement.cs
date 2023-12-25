using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOD_Project
{
    public class Announcement
    {
        public enum AnnouncementType
        {
            simple,
            grade
        }

        private int announcementId;
        private string body;
        private DateTime date;
        private List<User> forUsers;
        private bool isGlobal;
        private string title;
        private AnnouncementType type;
        // observers later

        public Announcement(int announcementId, string body, DateTime date, List<User> forUsers, bool isGlobal, string title, AnnouncementType type)
        {
            this.AnnouncementId = announcementId;
            this.Body = body;
            this.Date = date;
            this.ForUsers = forUsers;
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
    }
}
