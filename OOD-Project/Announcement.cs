using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOD_Project.Helpers;

namespace OOD_Project
{
    public class Announcement: INotificationSubject
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
    }
}
