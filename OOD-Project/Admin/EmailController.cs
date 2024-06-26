﻿using System;
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
    /* 
     *  This class is used to send emails over smtp. In our project, we used this functionality to notify the registered user whether his/her request was acceppted or rejcted.
     */
    public class EmailController
    {
        static EmailController instance;
        private readonly SmtpClient smtpClient;

        private EmailController()
        {
            // smtp client setup
            smtpClient = new SmtpClient("smtp.gmail.com", 587)
            {
                EnableSsl = true,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential("elms3dmin@gmail.com", "pixg ebvq lofi nzzk\r\n")
            };
        }
        // to use singleton since we only need one instance
        public static EmailController Instance()
        {
            if (instance == null) 
            {
                instance = new EmailController();
            }
            return instance;
        }

        public void SendAcceptEmail(string email, string first_name, string last_name, string university_id, string cpr)
        {
            string body = $"Hello {first_name} {last_name}. \n Thank you for your registration. \n Your request is accepted, and a default account have been created for you. Please login and change the password.\n" +
                $"Username: {university_id}. \n Password:{cpr}";
            MailMessage msgMail;
            msgMail = new MailMessage();
            msgMail.From = new MailAddress("elms3dmin@gmail.com", "elmsAdmin");
            msgMail.To.Add(email);

            msgMail.Subject = "Request Accepted";
            msgMail.Body = body;
            try
            {
                smtpClient.Send(msgMail);
                MessageBox.Show("Email has been sent to the user. They are now able to log in to the system.", "User Accepted");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            // to relaease the resoruces used by the mail message
            msgMail.Dispose();
        }

        public void SendRejectEmail(string email, string firstName, string lastName)
        {
            string body = $"Hello {firstName} {lastName}. \n Thank you for your registration. \n Your request has been rejected." +
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
                MessageBox.Show("Rejection email has been sent to the user.", "User Rejected");
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
            // to relaease the resoruces used by the mail message
            msgMail.Dispose();
        }

        // this method can be used to have real email notification as well
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
