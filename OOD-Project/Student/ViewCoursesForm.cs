using System;
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
        public ViewCoursesForm()
        {
            InitializeComponent();
            courses.Add(new Course(1, "Systems Analysis and Design", "IT7005","very fun good course diagrams yese yes", "ICT", 15));
            courses.Add(new Course(2, "Systems Analysis and Design", "IT7005","very fun good course diagrams yese yes", "ICT", 15));
            courses.Add(new Course(3, "Systems Analysis and Design", "IT7005","very fun good course diagrams yese yes", "ICT", 15));
            courses.Add(new Course(4, "Systems Analysis and Design", "IT7005","very fun good course diagrams yese yes", "ICT", 15));
            courses.Add(new Course(5, "Systems Analysis and Design", "IT7005","very fun good course diagrams yese yes", "ICT", 15));
            courses.Add(new Course(6, "Systems Analysis and Design", "IT7005","very fun good course diagrams yese yes", "ICT", 15));
            foreach (var course in courses)
            {
                ListViewItem item = new ListViewItem(course.Code + " | " + course.Name);
                // use sections instead of courses, add teacher from section here
                //item.SubItems.Add();
                coursesListView.Items.Add(item);
            }
        }

        private void coursesListView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void emailBtn_Click(object sender, EventArgs e)
        {
            //Get teacher from selected section to send email
            Teacher selectedTeacher = new Teacher();
            selectedTeacher.Email = "202102145@student.polytechnic.bh"; //Appears in JunkEmail if you try.
            EmailTutorForm emailTutorForm = new EmailTutorForm(selectedTeacher);
            emailTutorForm.Show();
        }
    }

}
