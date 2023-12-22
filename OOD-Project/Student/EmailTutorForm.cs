using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;

namespace OOD_Project
{
    public partial class EmailTutorForm : Form
    {
        string teacherEmail;
        public EmailTutorForm(Teacher selectedTeacher)
        {   
            InitializeComponent();
            teacherEmail = selectedTeacher.Email;
            txtTo.Text = teacherEmail;
            txtTo.Enabled = false;
        }

        private void btnSendEmail_Click(object sender, EventArgs e)
        {
            string smtpHost = "smtp.gmail.com";
            int smtpPort = 587;
            string username = "sample.student.acc1@gmail.com"; //Dummy email for sending emails
            string password = "jnnx pmdp yuwq fxfe";

            MailMessage message = new MailMessage(username, teacherEmail, txtSubject.Text, txtContent.Text);
            SmtpClient smtpClient = new SmtpClient(smtpHost, smtpPort);
            smtpClient.UseDefaultCredentials = false;
            smtpClient.Credentials = new NetworkCredential(username, password);
            smtpClient.EnableSsl = true;
            try
            {
                smtpClient.Send(message);
                MessageBox.Show("Email sent successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while sending the email: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
