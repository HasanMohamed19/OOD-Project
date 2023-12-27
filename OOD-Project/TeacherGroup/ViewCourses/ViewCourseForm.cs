using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOD_Project.TeacherGroup.ViewCourses
{
    public partial class ViewCourseForm : Form
    {
        public ViewCourseForm(int courseId)
        {
            InitializeComponent();

            updateDetails(courseId);
        }
        
        private void updateDetails(int courseId)
        {
            classesListView.Items.Clear();
            DatabaseManager dbm = DatabaseManager.Instance();
            dbm.Connection.Open();
            dbm.Command = dbm.Connection.CreateCommand();
            dbm.Command.Parameters.AddWithValue("@course_id", courseId);
            dbm.Command.CommandText = "SELECT course.name, course.code, course.credits, course.description, programme.programme_name, ClassSection.start_time, ClassSection.end_time, ClassSection.building, ClassSection.room_number, " +
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
                    courseCodeLabel.Text = dbm.Reader["code"].ToString();
                    courseCRNLabel.Text = "CRN: " + dbm.Reader["crn"].ToString();
                    courseTutorLabel.Text = "Tutor: " + dbm.Reader["first_name"].ToString() + " " + dbm.Reader["last_name"].ToString();
                    courseCreditsLabel.Text = "Credits: " + dbm.Reader["credits"].ToString();
                    courseProgrammeLabel.Text = "Programme: " + dbm.Reader["programme_name"].ToString();
                    courseDescription.Text = "Description: " + dbm.Reader["description"].ToString();
                    courseSectionLabel.Text = "Capacity: " + dbm.Reader["capacity"].ToString();
                    ListViewItem classDetails = new ListViewItem(dbm.Reader["week_day"].ToString());
                    classDetails.SubItems.Add(dbm.Reader["start_time"] + " - " + dbm.Reader["end_time"]);
                    classDetails.SubItems.Add(dbm.Reader["building"] + "." + dbm.Reader["room_number"]);
                    classesListView.Items.Add(classDetails);

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

    }
}
