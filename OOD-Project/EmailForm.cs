using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOD_Project
{
    public partial class EmailForm : Form
    {
        private Dictionary<int, string> emails = new Dictionary<int, string>();
        private List<string> files = new List<string>();
        private string selectedAttachmentName = "";
        public EmailForm()
        {
            InitializeComponent();
            GetEmails();
        }

        private void btnSendEmail_Click(object sender, EventArgs e)
        {

            string subject = subjectTxt.Text;
            string content = bodyText.Text;
            
            User recipient = User.GetUser(3);
            User emailSender = User.GetUser(Global.UserId);
            Email email = new Email(content,0, recipient, emailSender, subject);
            int newEmailId = User.SendEmail(email);
            if (files.Count > 0)
            {
                foreach (var file in files)
                {
                    User.SendAttachments(file, newEmailId);
                }
            }
            // after sending clear attachments
            files.Clear();
            recipientTxt.Text = "To";
            attachmentsListView.Items.Clear();
            subjectTxt.Text = "Subject";
            bodyText.Text = "";

        }

        private void btnAttach_Click(object sender, EventArgs e)
        {
            OpenFileDialog filePicker = new OpenFileDialog();
            // set the folderpath when clicking the button to desktop
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            filePicker.Multiselect = true;
            filePicker.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            filePicker.FilterIndex = 2;
            filePicker.InitialDirectory = desktopPath;
            
            if (filePicker.ShowDialog() == DialogResult.OK)
            {
                files.AddRange(filePicker.FileNames);
                foreach (string file in filePicker.FileNames)
                {
                    ListViewItem item = new ListViewItem(Path.GetFileName(file));
                    attachmentsListView.Items.Add(item);
                }
            }

        }

        private void attachmentsListView_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                ListViewItem selected = attachmentsListView.GetItemAt(e.X, e.Y);
                if (selected != null)
                {
                    selectedAttachmentName = selected.Text;
                    deleteMenuStrip.Show(Cursor.Position);
                }

            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int selectedItemIndex = attachmentsListView.SelectedItems[0].Index;
            attachmentsListView.Items.Remove(attachmentsListView.SelectedItems[0]);
        }

        private void recipientTxt_TextChanged(object sender, EventArgs e)
        {
            // since gmail and outlook allow an email to have empty body and no attachments we'll do the same
            // the only thing required is the recipient email
            bool allEmpty = recipientTxt.Text.Length == 0;
            btnSendEmail.Enabled = !allEmpty;
            
        }

        // later where to put this code?
        public void GetEmails()
        {
            DatabaseManager dbm = DatabaseManager.Instance();
            dbm.Connection.Open();
            dbm.Command.CommandText = "SELECT user_id, email FROM [dbo].[User]";
            try
            {
                dbm.Reader = dbm.Command.ExecuteReader();

                while (dbm.Reader.Read())
                {
                    emails.Add(dbm.Reader.GetInt32(0), dbm.Reader.GetString(1));
                }
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            } finally
            {
                dbm.Reader.Close();
                dbm.Connection.Close();
            }
            
            MessageBox.Show(emails.Count.ToString());

        }

    }
}
