using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOD_Project
{
    public class Email
    {
        private string body;
        private int emailId;
        private User recipient;
        private User sender;
        private string subject;

        public Email(string body, int emailId, User recipient, User sender, string subject)
        {
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

    }
}
