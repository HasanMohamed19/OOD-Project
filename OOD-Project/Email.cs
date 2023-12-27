using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOD_Project.Helpers;

namespace OOD_Project
{
    public class Email: INotificationSubject
    {
        private string body;
        private int emailId;
        private User recipient;
        private User sender;
        private string subject;

        List<INotificationObserver> observers;

        public Email(string body, int emailId, User recipient, User sender, string subject)
        {
            this.observers = new List<INotificationObserver>();
            this.body = body;
            this.emailId = emailId;
            this.recipient = recipient;
            this.sender = sender;
            this.subject = subject;
        }

        public string Body { get { return body; } set => body = value; }
        public int EmailId { get {  return emailId; } set => emailId = value; }
        public User Recipent { get { return recipient; } set => recipient = value; }
        public User Sender { get { return sender; } set { sender = value; } }
        public string Subject { get { return subject; } set => subject = value; }

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
