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
    public partial class AddCourseForm : Form
    {
        private ManageCourseForm manageCourse;
        public AddCourseForm(ManageCourseForm manageCourseForm)
        {
            InitializeComponent();
            this.manageCourse = manageCourseForm;
        }


        private void btnAddCourse_Click(object sender, EventArgs e)
        {
            try
            {
                ListView courseListView = manageCourse.GetCourseListView();
                //validation later
                int courseID = int.Parse(txtCourseID.Text);
                int credits = int.Parse(txtCredits.Text);
                int sectionCount = int.Parse(txtSectionCount.Text);
                string courseCode = txtCode.Text;
                string courseName = txtCourseName.Text;
                //string programme = txtProgramme.Text;
                string description = txtDescription.Text;
                Course course = new Course(courseID, courseName,courseCode, description, Programme.ict, credits);
                ListViewItem item = new ListViewItem(new string[]
                {course.Id.ToString(),
                 course.Name,
                 course.Code,
                 course.Credits.ToString(),
                 Programme.ict.ToString(),
                 "12",
                 course.Description });
                item.Tag = course;
                courseListView.Items.Add(item);
                manageCourse.getCourses().Add(course);
                MessageBox.Show("New Course Added\nCourse ID:" + course.Id + "\nCourse Name: " + course.Name, "Course Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }catch (Exception ex)
            {
                MessageBox.Show("An error has occured", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.Close();
            manageCourse.adminPanel.Show();

        }
    }
}
