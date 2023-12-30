using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOD_Project.Admin
{
    public partial class ViewFeedbackForm : Form
    {
        List<int> courseIds = new List<int>();
        List<int> studentIds = new List<int>();
        Feedback feedback;

        private string[] answers =
        {
            "Very unsatisfied",
            "Unsatisfied",
            "Neutral",
            "Satisfied",
            "Very satisfied",
        };

        public ViewFeedbackForm()
        {
            InitializeComponent();
            PopulateListViews();
        }

        private void UpdateView()
        {
            feedback = GetFeedback();
            if (feedback == null
                || feedback.Answers.Count < 5)
            {
                return;
            }
            lblCourse.Text = $"Course: {feedback.ForCourse.Name}";
            lblStudent.Text = $"Student: {feedback.ByStudent.FirstName} {feedback.ByStudent.LastName}";
            lblA1.Text = $"Answer:\n{feedback.Answers[0]}";
            lblA2.Text = $"Answer:\n{feedback.Answers[1]}";
            lblA3.Text = $"Answer:\n{feedback.Answers[2]}";
            lblA4.Text = $"Answer:\n{feedback.Answers[3]}";
            lblA5.Text = $"Answer:\n{feedback.Answers[4]}";
            lblSuggestions.Text = $"Suggestions:\n{feedback.Suggestions}";
        }

        private Feedback GetFeedback()
        {
            if (courseListView.SelectedItems.Count <= 0
                || studentListView.SelectedItems.Count <= 0)
            {
                // display no courses
                return null;
            }
            // get section_id from selected course
            int course_id = courseIds[courseListView.SelectedItems[0].Index];
            int student_id = studentIds[studentListView.SelectedItems[0].Index];
            // get feedback based on course id and student id
            return Feedback.GetFeedback(course_id, student_id);
        }

        private void PopulateListViews()
        {
            PopulateCourses();
            PopulateStudents();
        }

        private void PopulateStudents()
        {
            if (courseListView.Items.Count <= 0
                || courseListView.SelectedItems.Count <= 0)
            {
                return;
            }
            studentListView.Items.Clear();
            // get section_id from selected course
            int section_id = Section.GetSectionFromCourse(courseIds[courseListView.SelectedItems[0].Index]).Id;
            // get all students that are registered in selected course, display in the sidebar
            DatabaseManager dbm = DatabaseManager.Instance();
            dbm.Connection.Open();
            dbm.Command = dbm.Connection.CreateCommand();

            dbm.Command.Parameters.AddWithValue("@section_id", section_id);
            dbm.Command.CommandText = "SELECT s.student_id, s.first_name, s.last_name\r\n" +
                "FROM [dbo].[student] s\r\n" +
                "JOIN [dbo].[registration] r ON r.student_id = s.student_id\r\n" +
                "JOIN [dbo].[section] sc ON r.section_id = sc.section_id\r\n" +
                "JOIN [dbo].[course] c ON sc.course_id = c.course_id\r\n" +
                "JOIN [dbo].[feedback] f ON f.course_id = c.course_id\r\n" +
                "WHERE f.student_id = s.student_id\r\n" +
                "AND sc.section_id = @section_id";
            try
            {
                dbm.Reader = dbm.Command.ExecuteReader();

                while (dbm.Reader.Read())
                {
                    studentIds.Add(dbm.Reader.GetInt32(0));
                    string firstName = dbm.Reader.GetString(1);
                    string lastName = dbm.Reader.GetString(2);

                    string fullName = firstName + " " + lastName;

                    ListViewItem item = new ListViewItem(fullName);
                    studentListView.Items.Add(item);
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
            if (studentListView.Items.Count <= 0)
            {
                // display no students
                return;
            }
            studentListView.Items[0].Selected = true;
        }

        private void PopulateCourses()
        {
            courseListView.Items.Clear();
            // get all courses, display in the sidebar
            DatabaseManager dbm = DatabaseManager.Instance();
            dbm.Connection.Open();
            dbm.Command = dbm.Connection.CreateCommand();

            dbm.Command.CommandText = "SELECT c.course_id, c.name, c.code, t.first_name, t.last_name\r\n" +
                "FROM [dbo].[course] c\r\n" +
                "JOIN [dbo].[section] s ON c.course_id = s.course_id\r\n" +
                "JOIN [dbo].[teacher] t ON s.teacher_id = t.teacher_id\r\n";
            try
            {
                dbm.Reader = dbm.Command.ExecuteReader();

                while (dbm.Reader.Read())
                {
                    courseIds.Add(Convert.ToInt32(dbm.Reader["course_id"].ToString()));
                    string name = dbm.Reader["name"].ToString();
                    string code = dbm.Reader["code"].ToString();
                    string fullName = dbm.Reader["first_name"].ToString() + " " + dbm.Reader["last_name"].ToString();

                    ListViewItem item = new ListViewItem(code + " | " + name);
                    item.SubItems.Add(fullName);
                    courseListView.Items.Add(item);
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
            if (courseListView.Items.Count <= 0)
            {
                // display no courses
                return;
            }
            courseListView.Items[0].Selected = true;
        }

        private void studentListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateView();
        }

        private void courseListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            PopulateStudents();
            UpdateView();
        }
    }
}
