using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Collections.Specialized.BitVector32;

namespace OOD_Project.Admin
{
    public partial class EditCourseForm : Form
    {

        private ManageCourseForm manageCourse;
        private CourseScreens currentScreen = CourseScreens.course;

        private enum CourseScreens
        {
            course,
            students
        }

        private Course course;
        private Section section;
        private List<Student> registeredStudents = new List<Student>();
        public EditCourseForm(int section_id, ManageCourseForm manageCourse)
        {
            this.manageCourse = manageCourse;
            section = Section.GetSection(section_id);
            course = Course.GetCourse(section.AssignedCourse.Id);
            InitializeComponent();
            InitializeComboBoxes();
            PopulateStudentsView();
            UpdateView();
            UpdateScreens();
        }
        List<Teacher> teachers = Teacher.GetTeachers();
        private void InitializeComboBoxes()
        {
            // update combo boxes
            comboProgramme.Items.AddRange(Enum.GetNames(typeof(Programme)));
            foreach (Teacher t in teachers)
            {
                comboTeacher.Items.Add(t.FirstName + " " + t.LastName);
            }
        }

        private void UpdateView()
        {
            comboTeacher.SelectedIndex = comboTeacher.Items.IndexOf(section.AssignedTeacher.FirstName + " " + section.AssignedTeacher.LastName);
            comboProgramme.SelectedIndex = comboProgramme.Items.IndexOf(course.ForProgramme.ToString());
            txtCapacity.Text = section.Capacity.ToString();
            txtCode.Text = course.Code;
            txtDescription.Text = course.Description;
            txtCRN.Text = section.Crn;
            txtCredits.Text = course.Credits.ToString();
            txtCourseName.Text = course.Name;
            // get registered students

            registeredStudents = Registration.GetRegisteredStudents(section.Id);

            // select them in the list view

            foreach (Student student in registeredStudents)
            {
                int index = -1;
                foreach (ListViewItem item in studentsListView.Items)
                {
                    if (item.Text == student.StudentUniversityId)
                    {
                        index = item.Index;
                    }
                }
                studentsListView.Items[index].Checked = true;
            }

        }

        // change displayed screen based on currentScreen
        private void UpdateScreens()
        {
            switch (currentScreen)
            {
                case CourseScreens.course:
                    // create section and course objects
                    headerLbl.Text = "Edit Course";
                    btnLeft.Text = "Cancel";
                    btnRight.Text = "Next";
                    break;
                case CourseScreens.students:
                    UpdateCourse();
                    headerLbl.Text = "Register Students";
                    btnLeft.Text = "Back";
                    btnRight.Text = "Save";
                    break;
            }
            pagesContainer.ColumnStyles[0] = new ColumnStyle(SizeType.Percent, currentScreen == CourseScreens.course ? 100 : 0);
            pagesContainer.ColumnStyles[1] = new ColumnStyle(SizeType.Percent, currentScreen == CourseScreens.students ? 100 : 0);
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

            dbm.Command.Parameters.AddWithValue("@programme_id", (int)course.ForProgramme); // TODO: remove
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
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                dbm.Command.Parameters.Clear();
                dbm.Reader.Close();
                dbm.Connection.Close();
            }
        }

        private void SaveCourse()
        {
            if (course == null || section == null)
            {
                return;
            }

            List<Student> selectedStudents = new List<Student>();
            for (int i = 0; i < studentsListView.CheckedItems.Count; i++)
            {
                string universityId = studentsListView.CheckedItems[i].Text;
                Student student = Student.GetStudentFromUniId(universityId);
                selectedStudents.Add(student);
            }

            Course.EditCourse(course);
            Section.EditSection(section);
            // update students
            foreach (Student student in registeredStudents)
            {
                Student.UnregisterStudentFromSection(student.StudentId, section.Id);
            }
            foreach (Student student in selectedStudents)
            {
                Student.RegisterStudentToSection(student.StudentId, section.Id);
            }
        }

        private void UpdateCourse()
        {
            course.Code = txtCode.Text;
            course.Name = txtCourseName.Text;
            course.Credits = Convert.ToInt32(txtCredits.Text);
            course.Description = txtDescription.Text;
            section.Crn = txtCRN.Text;
            section.Capacity = Convert.ToInt32(txtCapacity.Text);
            course.ForProgramme = (Programme)comboProgramme.SelectedIndex + 1;
            section.AssignedTeacher = teachers[comboTeacher.SelectedIndex];
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            // go to next screen or finish
            if ((int)currentScreen >= 1)
            {
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
            if ((int)currentScreen <= 0)
            {
                this.Close();
                return;
            }
            currentScreen -= 1;
            UpdateScreens();
        }

        private void EditCourseForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            manageCourse.PopulateDGVs();
        }
    }
}
