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
        private string recipientEmail;

        public EmailForm(string recipientEmail)
        {
            InitializeComponent();
            GetEmails();
            if (!string.IsNullOrWhiteSpace(recipientEmail))
            {
                this.recipientEmail = recipientEmail;
                recipientTxt.Text = recipientEmail;
                recipientTxt.ReadOnly = true;
            }
            else
            {
                this.recipientEmail = null;
                btnSendEmail.Enabled = false;
            }
        }

        private void btnSendEmail_Click(object sender, EventArgs e)
        {

            string subject = subjectTxt.Text;
            string content = bodyText.Text;
            string recipientEmail = recipientTxt.Text;
            User recipient = User.GetUser(User.GetUserIdByEmail(recipientEmail));
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
            //files.Clear();
            //recipientTxt.Text = "To";
            //attachmentsListView.Items.Clear();
            //subjectTxt.Text = "Subject";
            //bodyText.Text = "";

            // close the form after sending email
            this.Close();

        }

        private void btnAttach_Click(object sender, EventArgs e)
        {
            OpenFileDialog filePicker = new OpenFileDialog();
            // set the folderpath when clicking the button to desktop
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            filePicker.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            filePicker.FilterIndex = 2;
            filePicker.InitialDirectory = desktopPath;
            filePicker.Multiselect = true;
            if (filePicker.ShowDialog() == DialogResult.OK)
            {
                //string fileName = filePicker.FileName;
                //files.Add(fileName);
                //ListViewItem item = new ListViewItem(Path.GetFileName(fileName));
                //attachmentsListView.Items.Add(item);
                foreach (string file in filePicker.FileNames)
                {
                    string fileName = Path.GetFileName(file);
                    if (files.Contains(file))
                    {
                        MessageBox.Show($"This email has already a file with this name. {fileName} can't be uploaded again.", "Duplicate File", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    } else
                    {
                        files.Add(file);
                        ListViewItem item = new ListViewItem(fileName);
                        attachmentsListView.Items.Add(item);
                    }
                    
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
            files.RemoveAt(selectedItemIndex);
        }

        private void recipientTxt_TextChanged(object sender, EventArgs e)
        {
            // since gmail and outlook allow an email to have empty body and no attachments we'll do the same
            // the only thing required is the recipient email
            bool allEmpty = recipientTxt.Text.Length == 0 || recipientTxt.Text.Length < 10;
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
            
        }

    }
}
