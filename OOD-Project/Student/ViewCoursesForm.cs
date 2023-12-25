﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TreeView;

namespace OOD_Project
{
    public partial class ViewCoursesForm : Form
    {
        List<Course> courses = new List<Course>();
        //List<Section> sections = new List<Section>();
        public ViewCoursesForm()
        {
            InitializeComponent();
            //Teacher tempTeacher = Teacher();
            //sections.Add(new Section());
            courses.Add(new Course(1, "Systems Analysis and Design", "IT7005","very fun good course diagrams yese yes", Programme.ict, 15));
            courses.Add(new Course(2, "Systems Analysis and Design", "IT7005","very fun good course diagrams yese yes", Programme.ict, 15));
            courses.Add(new Course(3, "Systems Analysis and Design", "IT7005","very fun good course diagrams yese yes", Programme.ict, 15));
            courses.Add(new Course(4, "Systems Analysis and Design", "IT7005","very fun good course diagrams yese yes", Programme.ict, 15));
            courses.Add(new Course(5, "Systems Analysis and Design", "IT7005","very fun good course diagrams yese yes", Programme.ict, 15));
            courses.Add(new Course(6, "Systems Analysis and Design", "IT7005","very fun good course diagrams yese yes", Programme.ict, 15));
            foreach (var course in courses)
            {
                ListViewItem item = new ListViewItem(course.Code + " | " + course.Name);
                // use sections instead of courses, add teacher from section here
                //item.SubItems.Add();
                coursesListView.Items.Add(item);
            }
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
        }
    }

}
