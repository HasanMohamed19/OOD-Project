using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOD_Project
{
    public class Announcement
    {
        private static int idCounter = 0;
        private int id;
        private string title;
        private string content;
        private string sender;
        private DateTime dateSent;
        private TimeSpan timeSent;

        public Announcement(string title, string content, string sender, DateTime dateSent, TimeSpan timeSent)
        {
            this.id = ++idCounter;
            this.title = title;
            this.content = content;
            this.sender = sender;
            this.dateSent = dateSent;
            this.timeSent = timeSent;
        }
        public int Id
        {
            get { return id; }
        }

        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        public string Content
        {
            get { return content; }
            set { content = value; }
        }

        public string Sender
        {
            get { return sender; }
            set { sender = value; }
        }

        public DateTime DateSent
        {
            get { return dateSent; }
            set { dateSent = value; }
        }

        public TimeSpan TimeSent
        {
            get { return timeSent; }
            set { timeSent = value; }
        }
    }
}
