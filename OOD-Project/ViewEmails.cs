using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace OOD_Project
{
    public partial class ViewEmails : Form
    {

        private List<int> emailIds = new List<int>();
        private string selectedAttachmentName;
        static ImageList attachment = new ImageList();
        private bool forInbox;
        public ViewEmails(bool forInbox)
        {

            InitializeComponent();
            //attachment.Images.Add(Bitmap.FromFile("C:\\Users\\Hassan\\source\\repos\\OOD-Project\\attach.png"));
            //emailsListView.LargeImageList = attachment;
            hideElementsWhenLoadAndNothingSelected();
            this.forInbox = forInbox;
            if (forInbox)
            {
                PopulateInbox();
            } else
            {
                populateSentEmails();
            }
            
        }

        private void hideElementsWhenLoadAndNothingSelected()
        {
            emailTableView.Hide();
            //senderLbl.Hide();
            //recipientLbl.Hide();
            //emailBodyTxt.Hide();
            //attachmentsListView.Hide();
        }

        private void showElements()
        {
            emailTableView.Show();
            //senderLbl.Show();
            //recipientLbl.Show();
            //emailBodyTxt.Show();
            //attachmentsListView.Show();
            //nothingLbl.Hide();
        }

        private void populateSentEmails()
        {
            DatabaseManager dbm = DatabaseManager.Instance();
            dbm.Connection.Open();
            dbm.Command = dbm.Connection.CreateCommand();
            dbm.Command.Parameters.AddWithValue("@sender_user_id", Global.UserId);
            dbm.Command.CommandText = "SELECT e.*, sender.username AS SenderUsername " +
                "FROM [dbo].[email] e " +
                "JOIN [dbo].[User] sender ON e.sender_user_id = sender.user_id " +
                "WHERE e.sender_user_id = @sender_user_id ORDER BY email_id DESC";

            try
            {
                dbm.Reader = dbm.Command.ExecuteReader();
                while (dbm.Reader.Read())
                {
                    int emailId = Convert.ToInt32(dbm.Reader["email_id"].ToString());
                    emailIds.Add(emailId);
                    string body = dbm.Reader["body"].ToString();
                    string subject = dbm.Reader["subject"].ToString();

                    ListViewItem emailItem = new ListViewItem(dbm.Reader["SenderUsername"].ToString());
                    emailItem.SubItems.Add(dbm.Reader["subject"].ToString());
                    //if (Convert.ToInt32(dbm.Reader["NumberOfAttachments"].ToString()) > 0)
                    //{
                    //    emailItem.ImageIndex = 0;
                    //}

                    emailsListView.Items.Add(emailItem);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                dbm.Command.Parameters.Clear();
                dbm.Connection.Close();
            }

        }
        private void PopulateInbox()
        {
            
            DatabaseManager dbm = DatabaseManager.Instance();
            dbm.Connection.Open();
            dbm.Command = dbm.Connection.CreateCommand();
            dbm.Command.Parameters.AddWithValue("@recipient_user_id", Global.UserId);
            //dbm.Command.CommandText = "SELECT * FROM [dbo].[email] WHERE recipient_user_id = @recipient_user_id ORDER BY email_id DESC";
            dbm.Command.CommandText = "SELECT e.*, " +
                "recipient.username AS RecUserName, recipient.email AS RecEmail FROM [dbo].[email] e " +
                "JOIN [dbo].[User] recipient ON e.recipient_user_id = recipient.user_id " +
                "WHERE e.recipient_user_id = @recipient_user_id ORDER BY email_id DESC";
            try
            {
                dbm.Reader = dbm.Command.ExecuteReader();
                while (dbm.Reader.Read())
                {
                    int emailId = Convert.ToInt32(dbm.Reader["email_id"].ToString());
                    emailIds.Add(emailId);
                    string body = dbm.Reader["body"].ToString();
                    string subject = dbm.Reader["subject"].ToString();

                    ListViewItem emailItem = new ListViewItem(dbm.Reader["RecUserName"].ToString());
                    emailItem.SubItems.Add(dbm.Reader["subject"].ToString());
                    //if (Convert.ToInt32(dbm.Reader["NumberOfAttachments"].ToString()) > 0)
                    //{
                    //    emailItem.ImageIndex = 0;
                    //}
                    
                    emailsListView.Items.Add(emailItem);

                }
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            } finally
            {
                dbm.Command.Parameters.Clear();
                dbm.Connection.Close();
            }
            

        }

        private void updateEmailDetails(int emailId)
        {
            DatabaseManager dbm = DatabaseManager.Instance();
            dbm.Connection.Open();
            dbm.Command = dbm.Connection.CreateCommand();
            //dbm.Command.Parameters.AddWithValue("@recipient_user_id", Global.User_id);
            dbm.Command.Parameters.AddWithValue("@email_id", emailId);
            dbm.Command.CommandText = "SELECT e.*, sender.email AS senderEmail, rec.email AS recEmail" +
                " FROM [dbo].[email] e" +
                " JOIN [dbo].[User] sender ON e.sender_user_id = sender.user_id" +
                " JOIN [dbo].[User] rec ON e.recipient_user_id = rec.user_id" +
                " WHERE email_id = @email_id";
            try
            {
                dbm.Reader = dbm.Command.ExecuteReader();

                while (dbm.Reader.Read())
                {
                    senderLbl.Text = "From: " + dbm.Reader["senderEmail"].ToString();
                    recipientLbl.Text = "To: " + dbm.Reader["recEmail"].ToString();
                    emailBodyTxt.Text = dbm.Reader["body"].ToString();
                    emailSubjetLbl.Text = dbm.Reader["subject"].ToString();
                }
            } catch (Exception ex)
            {
                MessageBox.Show (ex.Message);
            } finally
            {
                dbm.Command.Parameters.Clear();
                dbm.Connection.Close();
            }
        }

        private void emailsListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            showElements();
            attachmentsListView.Items.Clear();
            if (emailsListView.SelectedItems.Count > 0)
            {
                // starts from zero
                int selectedIndex = emailsListView.SelectedItems[0].Index;
                updateEmailDetails(emailIds[selectedIndex]);
                loadAttachments(emailIds[selectedIndex]);
                bool hasAttachments = emailHasAttachments(emailIds[selectedIndex]);
                //MessageBox.Show(hasAttachments.ToString());
            }
        }

        private bool emailHasAttachments(int emailId)
        {
            bool hasAttachments = false;
            DatabaseManager dbm = DatabaseManager.Instance();
            dbm.Connection.Open();
            dbm.Command = dbm.Connection.CreateCommand();

            dbm.Command.Parameters.AddWithValue("@email_id", emailId);
            dbm.Command.CommandText = "SELECT * FROM [dbo].[email_attachment] WHERE email_id = @email_id";
            try
            {

                object result = dbm.Command.ExecuteScalar();
                if (result != null)
                {
                    hasAttachments = true;
                }

            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            } finally
            {
                dbm.Command.Parameters.Clear();
                dbm.Connection.Close();
            }
            return hasAttachments;
        }

        private void loadAttachments(int emailId)
        {
            DatabaseManager dbm = DatabaseManager.Instance();
            dbm.Connection.Open();
            dbm.Command = dbm.Connection.CreateCommand();

            dbm.Command.Parameters.AddWithValue("@email_id", emailId);
            dbm.Command.CommandText = "SELECT * FROM [dbo].[email_attachment] WHERE email_id = @email_id";
            try
            {
                dbm.Reader = dbm.Command.ExecuteReader();
                while (dbm.Reader.Read())
                {
                    ListViewItem attachItem = new ListViewItem(dbm.Reader["filename"].ToString());
                    attachmentsListView.Items.Add(attachItem);
                }
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            } finally
            {
                dbm.Command.Parameters.Clear();
                dbm.Connection.Close();
            }
        }
        

        private void attachmentsListView_ItemMouseHover(object sender, ListViewItemMouseHoverEventArgs e)
        {

        }

        private void attachmentsListView_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                ListViewItem selected = attachmentsListView.GetItemAt(e.X, e.Y);
                if (selected != null)
                {
                    selectedAttachmentName = selected.Text;
                    downloadMenuStrip.Show(Cursor.Position);
                }
                
            }
        }

        private void downloadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog savePicker = new SaveFileDialog();
            // set the folderpath when clicking the button to desktop
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            savePicker.InitialDirectory = desktopPath;
            savePicker.FileName = selectedAttachmentName;
            if (savePicker.ShowDialog() == DialogResult.OK)
            {   
                MessageBox.Show(selectedAttachmentName);
                DocumentHelper.CopyFile("C:\\Users\\Hassan\\Documents\\OODProject.txt", savePicker.FileName);
                
            }
        }
    }
}
