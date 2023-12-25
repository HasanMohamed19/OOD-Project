using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOD_Project
{
    public class EmailAttachment
    {
        private int emailAttachmentId;
        private string filename;
        private string folderPath;
        private Email forEmail;

        public EmailAttachment(int emailAttachmentId, string filename, string folderPath, Email forEmail)
        {
            this.emailAttachmentId = emailAttachmentId;
            this.filename = filename;
            this.folderPath = folderPath;
            this.forEmail = forEmail;
        }

        public int EmailAttachmentId { get => emailAttachmentId; set => emailAttachmentId = value; }
        public string Filename { get => filename; set => filename = value; }
        public string FolderPath { get => folderPath; set => folderPath = value; }
        public Email ForEmail { get => forEmail; set => forEmail = value; }
    }
}
