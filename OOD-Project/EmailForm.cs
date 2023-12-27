using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOD_Project
{
    public partial class EmailForm : Form
    {
        private string[] files = {};
        public EmailForm()
        {
            InitializeComponent();
        }

        private void btnSendEmail_Click(object sender, EventArgs e)
        {
            string subject = subjectTxt.Text;
            string content = bodyText.Text;
            User.SendEmail(subject, content, 3);
            if (files.Length > 0)
            {
                foreach (var file in files)
                {
                    User.SendAttachments(file);
                }
            }
            // after sending clear attachments
            files = new string[0];
            recipientTxt.Text = "To";
            attachmentsTxt.Text = "";
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
                files = filePicker.FileNames;
                foreach (string file in filePicker.FileNames)
                {
                    attachmentsTxt.Text += file + Environment.NewLine;
                }
            }

        }
    }
}
