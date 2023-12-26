using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOD_Project
{
    public partial class ViewCoursesForm : Form
    {
        List<Course> courses = new List<Course>();
        List<int> coursesId = new List<int>();
        private string selectedCourseCode = "";
        public ViewCoursesForm()
        {
            InitializeComponent();
            
            PopulateCoursesListView();
        }

        private void feedbackBtn_Click(object sender, EventArgs e)
        {
            Course selectedCourse;
            if (coursesListView.SelectedIndices.Count > 0)
            {
                selectedCourse = courses[coursesListView.SelectedIndices[0]];
                FeedbackForm FeedbackForm = new FeedbackForm(selectedCourse);
                FeedbackForm.Show();
            }
            else
            {
               selectedCourse = (Course)coursesListView.Items[0].Tag;
               FeedbackForm FeedbackForm = new FeedbackForm(selectedCourse);
               FeedbackForm.Show();
            }
        }

        private void coursesListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            feedbackBtn.Enabled = coursesListView.SelectedIndices.Count > 0;
            if (coursesListView.SelectedItems.Count > 0)
            {
                // starts from zero
                int selectedIndex = coursesListView.SelectedItems[0].Index;
                updateDetails(coursesId[selectedIndex]);
            }
        }

        

        private void emailBtn_Click(object sender, EventArgs e)
        {
            EmailForm emailForm = new EmailForm();
            emailForm.Show();
            
        }

        private void PopulateCoursesListView()
        {
            DatabaseManager dbm = DatabaseManager.Instance();
            dbm.Connection.Open();
            dbm.Command = dbm.Connection.CreateCommand();

            dbm.Command.CommandText = "SELECT course.course_id, course.name, course.code, teacher.first_name, teacher.last_name\r\nFROM [dbo].[course]\r\nJOIN [dbo].[section] ON [dbo].[course].course_id = [dbo].[section].course_id\r\nJOIN [dbo].[teacher] ON [dbo].[section].teacher_id = [dbo].[teacher].teacher_id;";
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
            dbm.Command.Parameters.Clear();
            dbm.Connection.Close();


        }

        private void updateDetails(int courseId)
        {
            classesListView.Items.Clear();
            DatabaseManager dbm = DatabaseManager.Instance();
            dbm.Connection.Open();
            dbm.Command = dbm.Connection.CreateCommand();
            dbm.Command.Parameters.AddWithValue("@course_id", courseId);
            dbm.Command.CommandText = "SELECT course.name, course.credits, course.description, programme.programme_name, ClassSection.start_time, ClassSection.end_time, ClassSection.building, ClassSection.room_number, " +
                "section.crn, section.capacity, teacher.first_name, teacher.last_name, " +
                "week_day.week_day FROM [dbo].[course] " +
                "JOIN [dbo].[section] ON [dbo].[course].course_id = [dbo].[section].course_id " +
                " JOIN [dbo].[teacher] ON [dbo].[teacher].teacher_id = [dbo].[section].teacher_id " +
                "JOIN [dbo].[programme] ON [dbo].[programme].programme_id = [dbo].[course].programme_id " +
                "JOIN [dbo].[class] AS ClassSection ON [dbo].[section].section_id = ClassSection.section_id " +
                "JOIN [dbo].[week_day] ON ClassSection.week_day_id = [dbo].[week_day].week_day_id " +
                "WHERE course.course_id = @course_id";
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
                    courseSectionLabel.Text = "Section: " + dbm.Reader["capacity"].ToString();
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
            
            
            


        }
    }

}
