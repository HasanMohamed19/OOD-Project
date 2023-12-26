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
    public partial class EditCourseForm : Form
    {
        private ManageCourseForm manageCourse;
        private ManageCourseForm.Course selectedCourse;
        private ListView courseListView;
        private int itemIdx;
        public EditCourseForm(ManageCourseForm manageCourseForm, ManageCourseForm.Course course,int itemIdx)
        {
            InitializeComponent();
            this.selectedCourse = course;
            this.manageCourse = manageCourseForm;
            this.courseListView = manageCourse.GetCourseListView();
            this.manageCourse = manageCourseForm;
            this.itemIdx = itemIdx;
            txtCourseID.Text = course.CourseID.ToString();
            txtCourseName.Text = course.CourseName;
            txtCredits.Text = course.Credits.ToString();
            txtDescription.Text = course.Description;
            txtProgramme.Text = course.Programme;
            txtSectionCount.Text = course.SectionCount.ToString();
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Are you sure you want to save changes?", "Save changes?", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if(result == DialogResult.Yes) 
                { 
                    ListViewItem selectedItem = courseListView.Items[itemIdx];
                    selectedCourse.CourseID = int.Parse(txtCourseID.Text);
                    selectedCourse.Credits = int.Parse(txtCredits.Text);
                    selectedCourse.SectionCount = int.Parse(txtSectionCount.Text);
                    selectedCourse.CourseName = txtCourseName.Text;
                    selectedCourse.Programme = txtProgramme.Text;
                    selectedCourse.Description = txtDescription.Text;
                    selectedItem.SubItems[0].Text = txtCourseID.Text;
                    selectedItem.SubItems[1].Text = txtCourseName.Text;
                    selectedItem.SubItems[2].Text = txtCredits.Text;
                    selectedItem.SubItems[3].Text = txtProgramme.Text;
                    selectedItem.SubItems[4].Text = txtSectionCount.Text;
                    selectedItem.SubItems[5].Text = txtDescription.Text;
                    this.Close();
                    manageCourse.adminPanel.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error has occured", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
         
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            manageCourse.adminPanel.Show();
        }
    }
}
