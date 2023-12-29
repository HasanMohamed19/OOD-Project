using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Collections.Specialized.BitVector32;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace OOD_Project
{
    public partial class ViewCoursesForm : Form
    {
        List<Course> courses = new List<Course>();
        List<int> coursesId = new List<int>();
        private string selectedCourseCode = "";
        private int selectedIndex = -1;
        private int student_id;

        private bool showingContentView = false;

        public ViewCoursesForm(int student_id)
        {
            this.student_id = student_id;
            InitializeComponent();
            
            PopulateCoursesListView();
            PopulateContentView();
            UpdateContentView();
        }

        private void UpdateContentView()
        {
            contentListView.Visible = showingContentView;
            downloadBtn.Visible = showingContentView;
            contentClassBtn.Text = showingContentView ? "View Classes" : "View Content";

        }

        private void feedbackBtn_Click(object sender, EventArgs e)
        {
            Course selectedCourse;
            if (selectedIndex != -1)
            {
                selectedCourse = Course.GetCourse(coursesId[selectedIndex]);
                
                FeedbackForm FeedbackForm = new FeedbackForm(selectedCourse);
                FeedbackForm.ShowDialog();
            }
            else
            {
               //selectedCourse = (Course)coursesListView.Items[0].Tag;
               //FeedbackForm FeedbackForm = new FeedbackForm(selectedCourse);
               //FeedbackForm.Show();
            }
        }

        private void coursesListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool courseSelected = coursesListView.SelectedIndices.Count > 0;
            emailBtn.Enabled = courseSelected;
            feedbackBtn.Enabled = courseSelected;
            contentClassBtn.Enabled = courseSelected;

            if (coursesListView.SelectedItems.Count > 0)
            {
                // starts from zero
                selectedIndex = coursesListView.SelectedItems[0].Index;
                updateDetails(coursesId[selectedIndex]);
            }
        }

        

        private void emailBtn_Click(object sender, EventArgs e)
        {
            EmailForm emailForm = new EmailForm(GetCourseTutorEmail(coursesId[coursesListView.SelectedItems[0].Index]));
            emailForm.ShowDialog();
            
        }

        private void PopulateCoursesListView()
        {
            DatabaseManager dbm = DatabaseManager.Instance();
            dbm.Connection.Open();
            dbm.Command = dbm.Connection.CreateCommand();

            dbm.Command.Parameters.AddWithValue("@student_id", student_id);
            dbm.Command.CommandText = "SELECT c.course_id, c.name, c.code, t.first_name, t.last_name\r\n" +
                "FROM [dbo].[course] c\r\n" +
                "JOIN [dbo].[section] s ON c.course_id = s.course_id\r\n" +
                "JOIN [dbo].[teacher] t ON s.teacher_id = t.teacher_id\r\n" +
                "JOIN [dbo].[registration] r ON r.section_id = s.section_id\r\n" +
                "WHERE r.student_id = @student_id";
            try
            {
                dbm.Reader = dbm.Command.ExecuteReader();

                while (dbm.Reader.Read())
                {
                    coursesId.Add(Convert.ToInt32(dbm.Reader["course_id"].ToString()));
                    Course course = new Course();
                    course.Name = dbm.Reader["name"].ToString();
                    course.Code = dbm.Reader["code"].ToString();
                    selectedCourseCode = course.Code;
                    string fullName = dbm.Reader["first_name"].ToString() + " " + dbm.Reader["last_name"].ToString();

                    ListViewItem item = new ListViewItem(course.Code + " | " + course.Name);
                    item.SubItems.Add(fullName);
                    coursesListView.Items.Add(item);
                }
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            } finally
            {
                dbm.Command.Parameters.Clear();
                dbm.Connection.Close();
            }
            if (coursesListView.Items.Count <=0)
            {
                // display no courses
                return;
            }
            coursesListView.Items[0].Selected = true;

        }

        private void PopulateContentView()
        {
            if (coursesListView.SelectedItems.Count <= 0)
            {
                return;
            }
            // get selected course id
            selectedIndex = coursesListView.SelectedItems[0].Index;
            int course_id = coursesId[selectedIndex];
            // retreive content
            contentListView.Items.Clear();
            DatabaseManager dbm = DatabaseManager.Instance();
            dbm.Connection.Open();
            dbm.Command = dbm.Connection.CreateCommand();

            dbm.Command.Parameters.AddWithValue("@course_id", course_id);
            dbm.Command.CommandText = "SELECT content_id, filename, folder_path\r\n" +
                "FROM [dbo].[content]\r\n" +
                "WHERE course_id = @course_id";
            try
            {
                dbm.Reader = dbm.Command.ExecuteReader();

                while (dbm.Reader.Read())
                {
                    int content_id = dbm.Reader.GetInt32(0);
                    string filename = dbm.Reader.GetString(1);
                    string folder_path = dbm.Reader.GetString(2);
                    ListViewItem item = new ListViewItem(content_id.ToString());
                    item.SubItems.Add(filename);
                    try
                    {
                        string size = ((new FileInfo(folder_path + "\\" + filename).Length) / 1024).ToString() + " KB";
                        item.SubItems.Add(size);
                    } catch (Exception ex)
                    {
                        
                    }
                    
                    contentListView.Items.Add(item);
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

        private void updateDetails(int courseId)
        {
            classesListView.Items.Clear();
            DatabaseManager dbm = DatabaseManager.Instance();
            dbm.Connection.Open();
            dbm.Command = dbm.Connection.CreateCommand();
            dbm.Command.Parameters.AddWithValue("@course_id", courseId);
            dbm.Command.Parameters.AddWithValue("@student_id", student_id);
            dbm.Command.CommandText = "SELECT c.name, c.credits, c.description, p.programme_name, cl.start_time, cl.end_time, cl.building, cl.room_number, " +
                "s.crn, r.student_grade, t.first_name, t.last_name, " +
                "w.week_day FROM [dbo].[course] c " +
                "JOIN [dbo].[section] s ON c.course_id = s.course_id " +
                " JOIN [dbo].[teacher] t ON t.teacher_id = s.teacher_id " +
                "JOIN [dbo].[programme] p ON p.programme_id = c.programme_id " +
                "JOIN [dbo].[class] cl ON s.section_id = cl.section_id " +
                "JOIN [dbo].[week_day] w ON cl.week_day_id = w.week_day_id " +
                "JOIN [dbo].[registration] r ON r.section_id = s.section_id " +
                "WHERE c.course_id = @course_id " +
                "AND r.student_id = @student_id ";
            try
            {
                dbm.Reader = dbm.Command.ExecuteReader();
                while (dbm.Reader.Read())
                {
                    courseTitleLabel.Text = dbm.Reader["name"].ToString();
                    courseCodeLabel.Text = selectedCourseCode;
                    courseCRNLabel.Text = "CRN: " + dbm.Reader["crn"].ToString();
                    courseTutorLabel.Text = "Tutor: " + dbm.Reader["first_name"].ToString() + " " + dbm.Reader["last_name"].ToString();
                    courseCreditsLabel.Text = "Credits: " + dbm.Reader["credits"].ToString();
                    courseProgrammeLabel.Text = "Programme: " + dbm.Reader["programme_name"].ToString();
                    courseDescription.Text = "Description: " + dbm.Reader["description"].ToString();
                    courseSectionLabel.Text = "Grade: " + (dbm.Reader.IsDBNull(9) ? "N/A" : dbm.Reader["student_grade"].ToString());
                    ListViewItem classDetails = new ListViewItem(dbm.Reader["week_day"].ToString());
                    classDetails.SubItems.Add(dbm.Reader["start_time"] + " - " + dbm.Reader["end_time"]);
                    classDetails.SubItems.Add(dbm.Reader["building"] + "." + dbm.Reader["room_number"]);
                    classesListView.Items.Add(classDetails);

                }
                
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            } finally
            {
                dbm.Command.Parameters.Clear();
                dbm.Connection.Close();
            }
            PopulateContentView();
        }

        // where to put this
        public string GetCourseTutorEmail(int course_id)
        {
            string email = "";
            DatabaseManager dbm = DatabaseManager.Instance();
            dbm.Connection.Open();
            dbm.Command = dbm.Connection.CreateCommand();
            dbm.Command.Parameters.AddWithValue("@course_id", course_id);
            //dbm.Command.Parameters.AddWithValue("@teacher_id", teacher_id);
            dbm.Command.CommandText = "SELECT u.email from [dbo].[User] u " +
                "JOIN[dbo].[teacher] t ON t.user_id = u.user_id " + 
                "JOIN[dbo].[section] s ON s.teacher_id = t.teacher_id " +
                "JOIN[dbo].[course] c ON c.course_id = s.course_id " + 
                "WHERE t.user_id = u.user_id AND s.course_id = @course_id";
            dbm.Reader = dbm.Command.ExecuteReader();
            try
            {
                while (dbm.Reader.Read())
                {
                    email = dbm.Reader["email"].ToString();
                }
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            } finally
            {
                dbm.Command.Parameters.Clear();
                dbm.Connection.Close();
            }
            return email;

        }

        private void contentClassBtn_Click(object sender, EventArgs e)
        {
            showingContentView = !showingContentView;
            UpdateContentView();
        }

        private void downloadBtn_Click(object sender, EventArgs e)
        {
            if (coursesListView.SelectedItems.Count <= 0)
            {
                return;
            }
            // get selected course id
            selectedIndex = coursesListView.SelectedItems[0].Index;
            int course_id = coursesId[selectedIndex];
            // get selected content
            if (contentListView.SelectedItems.Count <= 0)
            {
                return;
            }
            SaveFileDialog savePicker = new SaveFileDialog();
            // set the folderpath when clicking the button to desktop
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string selectedContent = contentListView.SelectedItems[0].SubItems[1].Text;
            savePicker.InitialDirectory = desktopPath;
            savePicker.FileName = selectedContent;
            if (savePicker.ShowDialog() == DialogResult.OK)
            {
                DocumentHelper.CopyFile(Path.Combine(Path.Combine(DocumentHelper.coursesDirectory, course_id.ToString()), selectedContent), savePicker.FileName);
            }
        }
    }

}
