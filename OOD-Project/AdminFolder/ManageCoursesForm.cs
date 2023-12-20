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
    public partial class ManageCourseForm : Form
    {

        List<Course> courses = new List<Course>();
        public AdminPanel adminPanel;
        public ManageCourseForm(AdminPanel adminPanel)
        {
            InitializeComponent();
            courses.Add(new Course(1, 15, 5, "OOD", "This is a description", "ICT"));
            courses.Add(new Course(1, 15, 5, "OOD", "This is a description", "ICT"));
            courses.Add(new Course(1, 15, 5, "OOD", "This is a description", "ICT"));
            courses.Add(new Course(1, 15, 5, "OOD", "This is a description", "ICT"));
            foreach (var course in courses)
            {
                ListViewItem item = new ListViewItem(course.CourseID.ToString());
                item.Tag = course;
                item.SubItems.Add(course.CourseName);
                item.SubItems.Add(course.Credits.ToString());
                item.SubItems.Add(course.Programme);
                item.SubItems.Add(course.SectionCount.ToString());
                item.SubItems.Add(course.Description);
                courseListView.Items.Add(item);
            }

            this.adminPanel = adminPanel;
        }

        private void ManageCourse_Load(object sender, EventArgs e)
        {

        }

        public class Course
        {
            private int courseID;
            private int credits;
            private int sectionCount;
            private string courseName;
            private string description;
            private string programme;
            

            public int CourseID { get { return courseID; } set { courseID = value; } }
            public int Credits { get { return credits; } set { credits = value; } }
            public int SectionCount { get { return sectionCount; } set { sectionCount = value; } }

            public string CourseName { get { return courseName; } set { courseName = value; } }
            public string Description { get { return description; } set { description = value; } }
            public string Programme { get { return programme; } set { programme = value; } }

            public Course(int courseID, int credits, int sectionCount, string courseName, string description, string programme)
            {
                this.courseID = courseID;
                this.credits = credits;
                this.courseName = courseName;
                this.description = description;
                this.programme = programme;
                this.sectionCount = sectionCount;
            }
        }

        private void deleteCourseBtn_Click(object sender, EventArgs e)
        {
            DialogResult deleteConfirmation = MessageBox.Show("Are you sure you want to delete selected course?", "Delete Confirmation", MessageBoxButtons.YesNo);



            if (deleteConfirmation == DialogResult.Yes)
            {
                while (courseListView.SelectedItems.Count > 0)
                {
                    courseListView.SelectedItems[0].Remove();

                }

            }
        }

        private void editCourseBtn_Click(object sender, EventArgs e)
        {
            if (courseListView.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select a course to edit","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }

            ListViewItem selectedItem = courseListView.SelectedItems[0];
            Course selectedCourse = (Course) selectedItem.Tag;
            EditCourseForm editCourse = new EditCourseForm(this,selectedCourse,selectedItem.Index);
            editCourse.Show();
            adminPanel.Hide();

        }

        private void addCourseBtn_Click(object sender, EventArgs e)
        {
            AddCourseForm addCourseForm = new AddCourseForm(this);
            addCourseForm.Show();
            adminPanel.Hide();
        }

        public ListView GetCourseListView()
        {
            return courseListView;
        }
        public List<Course> getCourses()
        {
            return courses;
        }
    }
}
