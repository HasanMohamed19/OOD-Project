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

        public ViewEmails()
        {
            
            InitializeComponent();
           
            hideElementsWhenLoadAndNothingSelected();
            populateEmails();
        }

        private void hideElementsWhenLoadAndNothingSelected()
        {
            senderLbl.Hide();
            recipientLbl.Hide();
            emailBodyTxt.Hide();
            attachmentsListView.Hide();
        }

        private void showElements()
        {
            senderLbl.Show();
            recipientLbl.Show();
            emailBodyTxt.Show();
            attachmentsListView.Show();
            label1.Hide();
        }

        private void populateEmails()
        {
            DatabaseManager dbm = DatabaseManager.Instance();
            dbm.Connection.Open();
            dbm.Command = dbm.Connection.CreateCommand();
            dbm.Command.Parameters.AddWithValue("@recipient_user_id", Global.UserId);
            dbm.Command.CommandText = "SELECT * FROM [dbo].[email] WHERE recipient_user_id = @recipient_user_id";
            try
            {
                dbm.Reader = dbm.Command.ExecuteReader();
                while (dbm.Reader.Read())
                {
                    int emailId = Convert.ToInt32(dbm.Reader["email_id"].ToString());
                    emailIds.Add(emailId);
                    string body = dbm.Reader["body"].ToString();
                    string subject = dbm.Reader["subject"].ToString();

                    ListViewItem emailItem = new ListViewItem(dbm.Reader["sender_user_id"].ToString());
                    emailItem.SubItems.Add(dbm.Reader["recipient_user_id"].ToString());
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
            dbm.Command.CommandText = "SELECT * FROM [dbo].[email] WHERE email_id = @email_id";
            dbm.Reader = dbm.Command.ExecuteReader();

            while (dbm.Reader.Read())
            {
                senderLbl.Text = dbm.Reader["sender_user_id"].ToString();
                recipientLbl.Text = dbm.Reader["recipient_user_id"].ToString();
                emailBodyTxt.Text = dbm.Reader["body"].ToString();
            }
            dbm.Command.Parameters.Clear();
            dbm.Connection.Close();

        }

        private void emailsListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            showElements();
            if (emailsListView.SelectedItems.Count > 0)
            {
                // starts from zero
                int selectedIndex = emailsListView.SelectedItems[0].Index;
                updateEmailDetails(emailIds[selectedIndex]);
                loadAttachments(emailIds[selectedIndex]);
                bool hasAttachments = emailHasAttachments(emailIds[selectedIndex]);
                MessageBox.Show(hasAttachments.ToString());
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
                int rows = (int)dbm.Command.ExecuteScalar();
                if (rows > 0)
                {
                    hasAttachments = true;
                }
            } catch (Exception ex)
            {
                MessageBox.Show("here" + ex.Message);
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
            dbm.Reader = dbm.Command.ExecuteReader();
            while (dbm.Reader.Read())
            {
                ListViewItem attachItem = new ListViewItem(dbm.Reader["filename"].ToString());
                attachmentsListView.Items.Add(attachItem);
            }
            dbm.Command.Parameters.Clear();
            dbm.Connection.Close();
            
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
