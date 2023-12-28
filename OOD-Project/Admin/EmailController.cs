using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Runtime.ConstrainedExecution;

namespace OOD_Project.Admin
{
    public class EmailController
    {
        static EmailController instance;
        private readonly SmtpClient smtpClient;

        private EmailController()
        {
            smtpClient = new SmtpClient("smtp.gmail.com", 587)
            {
                EnableSsl = true,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential("elms3dmin@gmail.com", "zalf dpnb abwl hepa\r\n")
            };
        }

        public static EmailController Instance()
        {
            if (instance == null) 
            {
                instance = new EmailController();
            }
            return instance;
        }

        public void SendAcceptEmail(string email, string firstName, string lastName, string cpr)
        {
            string body = $"Hello {firstName} {lastName}. \n Thank you for your registration. \n Your request is accepted, and a default account have been created for you. Please login and change the password.\n" +
                $"Username: {firstName}.{lastName}. \n Password:{cpr}";
            MailMessage msgMail;
            msgMail = new MailMessage();
            msgMail.From = new MailAddress("elms3dmin@gmail.com", "elmsAdmin");
            msgMail.To.Add(email);

            msgMail.Subject = "Request Accepted";
            msgMail.Body = body;
            try
            {
                smtpClient.Send(msgMail);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            // to relaease the resoruces used by the mail message
            msgMail.Dispose();
        }

        public void SendRejectEmail(string firstName, string lastName, string email)
        {
            string body = $"Hello {firstName} {lastName}. \n Thank you for your registration. \n Your request is rejected." +
                $"No account with such details is found.";
            MailMessage msgMail;
            msgMail = new MailMessage();
            msgMail.From = new MailAddress("elms3dmin@gmail.com", "elmsAdmin");
            msgMail.To.Add(email);

            msgMail.Subject = "Request Accepted";
            msgMail.Body = body;
            try
            {
                smtpClient.Send(msgMail);
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
            // to relaease the resoruces used by the mail message
            msgMail.Dispose();
        }

        public void SendNotificationEmail(string recipientEmail)
        {
            string body = "You have a new Notification. Please check the system";
            MailMessage msgMail;
            msgMail = new MailMessage();
            // email can be changed later
            msgMail.From = new MailAddress("elms3dmin@gmail.com", "elmsAdmin");
            msgMail.To.Add(recipientEmail);

            msgMail.Subject = "New Notification";
            msgMail.Body = body;
            try
            {
                smtpClient.Send(msgMail);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            } finally
            {
                msgMail.Dispose();
            }

        }

    }
}
