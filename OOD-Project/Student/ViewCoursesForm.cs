using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TreeView;

namespace OOD_Project
{
    public partial class ViewCoursesForm : Form
    {
        List<Course> courses = new List<Course>();
        public ViewCoursesForm()
        {
            InitializeComponent();
            courses.Add(new Course("OOD", "IT7006", "Ito", "1", "15"));
            courses.Add(new Course("OOPS", "IT7005", "Jason Bourne", "1", "10"));
            courses.Add(new Course("OOPS", "IT7005", "Jason Bourne", "1", "10"));
            courses.Add(new Course("OOPS", "IT7005", "Jason Bourne", "1", "10"));
            courses.Add(new Course("OOPS", "IT7005", "Jason Bourne", "1", "10"));
            courses.Add(new Course("OOPS", "IT7005", "Jason Bourne", "1", "10"));
            courses.Add(new Course("OOPS", "IT7005", "Jason Bourne", "1", "10"));
            foreach (var course in courses)
            {
                ListViewItem item = new ListViewItem(course.Code + " | " + course.Name);
                item.SubItems.Add(course.Tutor);
                coursesListView.Items.Add(item);
            }
        }
    }


    class Course
    {
        string name;
        string code;
        string tutor;
        string section;
        string credits;

        public Course(string name, string code, string tutor, string section, string credits)
        {
            this.name = name;
            this.Code = code;
            this.tutor = tutor;
            this.section = section;
            this.credits = credits;
        }

        public string Name { get => name; set => name = value; }
        public string Tutor { get => tutor; set => tutor = value; }
        public string Section { get => section; set => section = value; }
        public string Credits { get => credits; set => credits = value; }
        public string Code { get => code; set => code = value; }
    }
}
