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

namespace OOD_Project.TeacherGroup.ViewCourses
{
    public partial class ContentView : Form
    {
        int courseId;
        string[] filesList;
        public ContentView(int courseId)
        {
            InitializeComponent();
            this.courseId = courseId;
            filesList = new string[0];
        }

        private void uploadContentBtn_Click(object sender, EventArgs e)
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
                filesList = filePicker.FileNames;
                foreach (string file in filePicker.FileNames)
                {
                    ListViewItem contentFile = new ListViewItem(Path.GetFileName(file));
                    long fileSize = new FileInfo(file).Length;
                    contentFile.SubItems.Add(fileSize.ToString());
                    // rename the view later
                    classesListView.Items.Add(contentFile);
                    Teacher.UploadContent(file, courseId);
                    DocumentHelper.CopyFile(file, Path.Combine(DocumentHelper.parentDirectory, courseId.ToString()));
                }
            }
        }
    }
}
