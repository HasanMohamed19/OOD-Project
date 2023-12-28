using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OOD_Project.Helpers;

namespace OOD_Project.TeacherGroup
{
    public partial class TeacherViewCoursesForm : Form
    {
        private enum SelectedMenu
        {
            course, content, students
        }

        Teacher loggedInTeacher;
        List<Course> courses = new List<Course>();
        List<int> courseIds = new List<int>();
        SelectedMenu selectedMenu = SelectedMenu.course; // this will keep track of which menu is currently open
        int selectedIndex = 0;
        public TeacherViewCoursesForm(Teacher loggedInTeacher)
        {
            this.loggedInTeacher = loggedInTeacher;
            InitializeComponent();
            PopulateCoursesListView();
            // set the first item to be selected
            
            if (courseIds.Count > 0 )
            {
                
                Helper.OpenChildForm(new ViewCourses.ViewCourseForm(courseIds[selectedIndex]), detailContainer);
                coursesListView.Items[0].Selected = true;
            }
        }

        private void PopulateCoursesListView()
        {
            DatabaseManager dbm = DatabaseManager.Instance();
            dbm.Connection.Open();
            dbm.Command = dbm.Connection.CreateCommand();

            dbm.Command.Parameters.AddWithValue("@user_id", loggedInTeacher.UserId);
            dbm.Command.CommandText = "SELECT course.course_id, course.name, course.code\r\n" +
                "FROM [dbo].[course]\r\n" +
                "JOIN [dbo].[section] ON [dbo].[course].course_id = [dbo].[section].course_id\r\n" +
                "JOIN [dbo].[teacher] ON [dbo].[section].teacher_id = [dbo].[teacher].teacher_id\r\n" +
                "WHERE teacher.user_id = @user_id";
            
            try
            {
                dbm.Reader = dbm.Command.ExecuteReader();
                while (dbm.Reader.Read())
                {
                    courseIds.Add(Convert.ToInt32(dbm.Reader["course_id"].ToString()));
                    Course course = new Course();
                    course.Name = dbm.Reader["name"].ToString();
                    course.Code = dbm.Reader["code"].ToString();

                    ListViewItem item = new ListViewItem(course.Code + " | " + course.Name);
                    coursesListView.Items.Add(item);
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


        private void UpdateChildView()
        {
            switch (selectedMenu)
            {
                case SelectedMenu.course:
                    if (courseIds.Count > 0)
                    {
                        Helper.OpenChildForm(new ViewCourses.ViewCourseForm(courseIds[selectedIndex]), detailContainer);
                    }
                    break;
                case SelectedMenu.content:
                    if (courseIds.Count > 0)
                    {
                        Helper.OpenChildForm(new ViewCourses.ContentView(courseIds[selectedIndex]), detailContainer);
                    }
                    break;
                case SelectedMenu.students:
                    if (courseIds.Count > 0)
                    {
                        Helper.OpenChildForm(new ViewCourses.ViewStudentsForm(courseIds[selectedIndex]), detailContainer);
                    }
                    break;
                default:
                    break;
            }
        }

        private void courseBtn_Click(object sender, EventArgs e)
        {
            if (courseIds.Count > 0)
            {
                selectedMenu = SelectedMenu.course;
                Helper.OpenChildForm(new ViewCourses.ViewCourseForm(courseIds[selectedIndex]), detailContainer);
            }
        }

        private void contentBtn_Click(object sender, EventArgs e)
        {
            if (courseIds.Count > 0)
            {
                selectedMenu = SelectedMenu.content;
                Helper.OpenChildForm(new ViewCourses.ContentView(courseIds[selectedIndex]), detailContainer);
            }
        }

        private void studentsBtn_Click(object sender, EventArgs e)
        {
            if (courseIds.Count > 0)
            {
                selectedMenu = SelectedMenu.students;
                Helper.OpenChildForm(new ViewCourses.ViewStudentsForm(courseIds[selectedIndex]), detailContainer);
            }
        }

        private void coursesListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (coursesListView.SelectedItems.Count > 0)
            {
                // change selected index
                selectedIndex = coursesListView.SelectedItems[0].Index;
                UpdateChildView();
            }
        }
    }
}
