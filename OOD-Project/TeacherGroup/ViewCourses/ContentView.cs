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
                    long fileSizeInBytes = new FileInfo(file).Length;
                    // rename the view later
                    string fileSize = $"{fileSizeInBytes / 1024} KB";
                    contentFile.SubItems.Add(fileSize);
                    classesListView.Items.Add(contentFile);
                    Teacher.UploadContent(file, courseId);
                    //MessageBox.Show(Path.Combine(DocumentHelper.parentDirectory, courseId.ToString()));
                    DocumentHelper.CopyFile(file, Path.Combine(Path.Combine(DocumentHelper.coursesDirectory, courseId.ToString()), Path.GetFileName(file)));
                }
            }
        }

        private void downloadContentBtn_Click(object sender, EventArgs e)
        {
            if (classesListView.SelectedItems.Count > 0)
            {
                SaveFileDialog savePicker = new SaveFileDialog();
                // set the folderpath when clicking the button to desktop
                string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                string selectedContent = classesListView.SelectedItems[0].Text;
                savePicker.InitialDirectory = desktopPath;
                savePicker.FileName = selectedContent;
                if (savePicker.ShowDialog() == DialogResult.OK)
                {
                    MessageBox.Show(selectedContent);
                    DocumentHelper.CopyFile(Path.Combine(Path.Combine(DocumentHelper.coursesDirectory, courseId.ToString()), selectedContent), savePicker.FileName);

                }
            }
        }
    }
}
