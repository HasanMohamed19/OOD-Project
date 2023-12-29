using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOD_Project.Admin
{
    public partial class AddCourseForm : Form
    {
        private ManageCourseForm manageCourse;

        private CourseScreens currentScreen = CourseScreens.course;

        private enum CourseScreens
        {
            course,
            classes,
            students
        }

        private Course course;
        private Section section;
        private List<Class> classes = new List<Class>();
        int classIdCounter = 0;

        public AddCourseForm(ManageCourseForm manageCourse)
        {
            this.manageCourse = manageCourse;
            InitializeComponent();
            currentScreen = CourseScreens.course;
            InitializeComboBoxes();
            UpdateScreens();
        }
        List<Teacher> teachers = Teacher.GetTeachers();
        private void InitializeComboBoxes()
        {
            // update combo boxes
            comboDay.Items.AddRange(Enum.GetNames(typeof(WeekDays)));
            comboProgramme.Items.AddRange(Enum.GetNames(typeof(Programme)));
            foreach (Teacher t in teachers)
            {
                comboTeacher.Items.Add(t.FirstName +" "+ t.LastName);
            }
        }

        // change displayed screen based on currentScreen
        private void UpdateScreens()
        {
            switch (currentScreen)
            {
                case CourseScreens.course:
                    // create section and course objects
                    headerLbl.Text = "Add Course";
                    btnLeft.Text = "Cancel";
                    break;
                case CourseScreens.classes:
                    CreateCourse();
                    headerLbl.Text = "Add Classes";
                    btnLeft.Text = "Back";
                    btnRight.Text = "Next";
                    break;
                case CourseScreens.students:
                    PopulateStudentsView();
                    headerLbl.Text = "Register Students";
                    btnRight.Text = "Save";
                    break;
            }
            pagesContainer.ColumnStyles[0] = new ColumnStyle(SizeType.Percent, currentScreen == CourseScreens.course ? 100 : 0);
            pagesContainer.ColumnStyles[1] = new ColumnStyle(SizeType.Percent, currentScreen == CourseScreens.classes ? 100 : 0);
            pagesContainer.ColumnStyles[2] = new ColumnStyle(SizeType.Percent, currentScreen == CourseScreens.students ? 100 : 0);
        }

        private void PopulateClassView()
        {
            classesListView.Items.Clear();
            foreach (Class c in classes)
            {
                ListViewItem item = new ListViewItem(c.ClassId.ToString());
                item.SubItems.Add(c.StartTime.ToString("hh:mm tt"));
                item.SubItems.Add(c.EndTime.ToString("hh:mm tt"));
                item.SubItems.Add(c.DayOfTheWeek.ToString());
                item.SubItems.Add(c.Building);
                item.SubItems.Add(c.RoomNumber);

                classesListView.Items.Add(item);
            }
        }

        private void PopulateStudentsView()
        {
            if (course == null)
            {
                return;
            }

            studentsListView.Items.Clear();
            DatabaseManager dbm = DatabaseManager.Instance();
            dbm.Connection.Open();
            dbm.Command = dbm.Connection.CreateCommand();

            dbm.Command.Parameters.AddWithValue("@programme_id", (int)course.ForProgramme);
            dbm.Command.CommandText = "SELECT s.student_university_id, s.first_name + ' ' + s.last_name, s.cpr, m.major_name, p.programme_name " +
                "FROM [dbo].[student] s " +
                "JOIN [dbo].[User] u ON s.user_id = u.user_id " +
                "JOIN [dbo].[major] m ON s.major_id = m.major_id " +
                "JOIN [dbo].[programme] p ON m.programme_id = p.programme_id " +
                "AND u.status_id = 2 ";
            try
            {
                dbm.Reader = dbm.Command.ExecuteReader();
                // populate list view
                while (dbm.Reader.Read())
                {
                    ListViewItem item = new ListViewItem(dbm.Reader.GetString(0));
                    item.SubItems.Add(dbm.Reader.GetString(1));
                    item.SubItems.Add(dbm.Reader.GetString(2));
                    item.SubItems.Add(dbm.Reader.GetString(3));
                    item.SubItems.Add(dbm.Reader.GetString(4));
                    studentsListView.Items.Add(item);
                }
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            } finally
            {
                dbm.Command.Parameters.Clear();
                dbm.Reader.Close();
                dbm.Connection.Close();
            }
        }

        private void SaveCourse()
        {
            if (course == null || section == null || classes.Count == 0) {
                return;
            }

            List<Student> selectedStudents = new List<Student>();
            for (int i = 0; i < studentsListView.CheckedItems.Count; i++)
            {
                string universityId = studentsListView.CheckedItems[i].Text;
                Student student = Student.GetStudentFromUniId(universityId);
                selectedStudents.Add(student);
            }

            int newCourseId = Course.AddCourse(course);
            section.AssignedCourse.Id = newCourseId;
            int newSectionId = Section.AddSection(section);
            // add classes
            foreach (Class c in classes)
            {
                c.Section.Id = newSectionId;
                Class.AddClass(c);
            }
            // update students
            foreach (Student student in selectedStudents)
            {
                Student.RegisterStudentToSection(student.StudentId, newSectionId);
            }
        }

        private void CreateCourse()
        {
            string code = txtCode.Text;
            string name = txtCourseName.Text;
            int credits = Convert.ToInt32(txtCredits.Text);
            string description = txtDescription.Text;
            string crn = txtCRN.Text;
            int capacity = Convert.ToInt32(txtCapacity.Text);
            Programme programme = (Programme)comboProgramme.SelectedIndex+1;
            Teacher teacher = teachers[comboTeacher.SelectedIndex];

            course = new Course(0, name, code, description, programme, credits);
            section = new Section(capacity, crn, 0, teacher, course);

        }

        private void btnAddClass_Click(object sender, EventArgs e)
        {
            DateTime start = timeStart.Value;
            DateTime end = timeEnd.Value;
            WeekDays day = (WeekDays)comboDay.SelectedIndex;
            string building = txtBuilding.Text;
            string room = txtRoom.Text;

            Class newClass = new Class(classIdCounter++, building, room, day, end, start, section);
            classes.Add(newClass);
            PopulateClassView();
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            // go to next screen or finish
            if ((int)currentScreen >= 2) {
                SaveCourse();
                Close(); 
                return;
            }
            currentScreen += 1;
            UpdateScreens();
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            // go to previous screen or cancel
            if ((int)currentScreen <= 0) {
                this.Close();
                return; 
            }
            currentScreen -= 1;
            UpdateScreens();
        }

        // delete class
        private void btnDeleteClass_Click(object sender, EventArgs e)
        {
            if (classesListView.SelectedItems.Count <= 0)
            {
                return;
            }
            // get selected class
            int classId = Convert.ToInt32(classesListView.SelectedItems[0].Text);
            // find in list and remove
            foreach (Class c in classes)
            {
                if (c.ClassId == classId)
                {
                    classes.Remove(c);
                    break;
                }
            }
            PopulateClassView();
        }

        private void AddCourseForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            manageCourse.PopulateDGVs();
        }
    }
}
