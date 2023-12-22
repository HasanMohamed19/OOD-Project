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
            courses.Add(new Course(1, "OOD", "IT7006", "This is a description", "ICT", 15));
            courses.Add(new Course(1, "OOD", "IT7006", "This is a description", "ICT", 15));
            courses.Add(new Course(1, "OOD", "IT7006", "This is a description", "ICT", 15));
            courses.Add(new Course(1, "OOD", "IT7006", "This is a description", "ICT", 15));
            foreach (var course in courses)
            {
                ListViewItem item = new ListViewItem(course.Id.ToString());
                item.Tag = course;
                item.SubItems.Add(course.Name);
                item.SubItems.Add(course.Code);
                item.SubItems.Add(course.Credits.ToString());
                item.SubItems.Add(course.Programme);
                item.SubItems.Add(course.Sections.Count.ToString());
                item.SubItems.Add(course.Description);
                courseListView.Items.Add(item);
            }

            this.adminPanel = adminPanel;
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

        private void courseListView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
