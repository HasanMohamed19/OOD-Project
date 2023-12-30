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
            PopulateCourseContent(courseId);
        }

        // this method will get the files from the db and display their names 
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
                    string fileName = Path.GetFileName(file);
                    
                    string newFullPath = Path.Combine(DocumentHelper.coursesDirectory, courseId.ToString(), fileName);
                    if (DocumentHelper.IsFileExists(newFullPath))
                    {
                        MessageBox.Show($"This course has already a file with this name. {fileName} can't be uploaded again.", "Duplicate File", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    } else
                    {
                        ListViewItem contentFile = new ListViewItem(fileName);
                        long fileSizeInBytes = new FileInfo(file).Length;
                        // rename the view later
                        string fileSize = $"{fileSizeInBytes / 1024} KB";
                        contentFile.SubItems.Add(fileSize);
                        classesListView.Items.Add(contentFile);
                        string newRelativePath = Path.Combine(DocumentHelper.coursesRelativePath, courseId.ToString(), fileName);
                        Teacher.UploadContent(newRelativePath, courseId);
                        DocumentHelper.CopyFile(file, newFullPath);
                    }
                    
                }
            }
        }

        // method for downloading content
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
                    DocumentHelper.CopyFile(Path.Combine(Path.Combine(DocumentHelper.coursesDirectory, courseId.ToString()), selectedContent), savePicker.FileName);
                }
            }
        }

        
        // mthod for populating course content
        private void PopulateCourseContent(int courseId)
        {
            DatabaseManager dbm = DatabaseManager.Instance();
            dbm.Connection.Open();
            dbm.Command = dbm.Connection.CreateCommand();
            dbm.Command.Parameters.AddWithValue("@course_id", courseId);
            dbm.Command.CommandText = "SELECT * FROM [dbo].[content] WHERE course_id = @course_id";
            dbm.Reader = dbm.Command.ExecuteReader();
            while (dbm.Reader.Read())
            {
                string folderPath = dbm.Reader["folder_path"].ToString();
                string fileName = dbm.Reader["filename"].ToString();
                string relativePath = Path.Combine(folderPath, fileName);
                string fullPath = Path.Combine(DocumentHelper.coursesDirectory, courseId.ToString(), fileName);
                ListViewItem courseContent = new ListViewItem(dbm.Reader["filename"].ToString());
                long fileSizeInBytes = new FileInfo(fullPath).Length;
                string fileSize = $"{fileSizeInBytes / 1024} KB";
                courseContent.SubItems.Add(fileSize);
                classesListView.Items.Add(courseContent);
            }
            dbm.Command.Parameters.Clear();
            dbm.Reader.Close();
            dbm.Connection.Close();
        }

        private void ContentView_Load(object sender, EventArgs e)
        {
            //PopulateCourseContent(courseId);
        }

        // method for downloading the content
        private void deleteContentBtn_Click(object sender, EventArgs e)
        {
            ListViewItem selectedItem = classesListView.SelectedItems[0];
            DatabaseManager dbm = DatabaseManager.Instance();
            dbm.Connection.Open();
            dbm.Command = dbm.Connection.CreateCommand();
            dbm.Command.Parameters.AddWithValue("@course_id", courseId);
            dbm.Command.Parameters.AddWithValue("@filename", selectedItem.Text);
            dbm.Command.CommandText = "DELETE FROM [dbo].[content] WHERE course_id = @course_id AND filename = @filename";
            try
            {
                int numberOfFileDeleted = dbm.Command.ExecuteNonQuery();
                classesListView.Items.Remove(selectedItem);
                DocumentHelper.DeleteFile(Path.Combine(DocumentHelper.coursesDirectory, courseId.ToString(), selectedItem.Text));
                MessageBox.Show($"{numberOfFileDeleted} file has been deleted.");
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
    }
}
