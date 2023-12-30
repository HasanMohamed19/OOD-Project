using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OOD_Project.Helpers;

namespace OOD_Project.TeacherGroup.ViewCourses
{
    public partial class ViewStudentsForm : Form
    {
        private int courseId;
        public ViewStudentsForm(int courseId)
        {
            this.courseId = courseId;
            InitializeComponent();
            PopulateStudents();
        }


        private void PopulateStudents()
        {
            DatabaseManager dbm = DatabaseManager.Instance();
            // get all students for selected course
            dbm.Command.Parameters.AddWithValue("@course_id", courseId);
            dbm.Command.CommandText = "SELECT s.student_university_id AS 'Student ID', s.first_name + ' ' + s.last_name AS Name" +
                ", r.student_grade AS Grade, s.user_id " +
                "FROM [dbo].[student] s " +
                "JOIN [dbo].[registration] r ON s.student_id = r.student_id " +
                "JOIN [dbo].[section] sc ON r.section_id = sc.section_id " +
                "JOIN [dbo].[course] c ON sc.course_id = c.course_id " +
                "WHERE c.course_id = @course_id ";

            try
            {
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(dbm.Command);
                BindingSource bs = new BindingSource();

                da.Fill(dt);
                bs.DataSource = dt;
                studentsDG.DataSource = bs;
                studentsDG.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
                studentsDG.RowTemplate.MinimumHeight = 30;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            } finally
            {
                dbm.Command.Parameters.Clear();
            }
        }

        private void studentsDG_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            //  make sure only editing grade cell
            if (studentsDG.CurrentCell.ColumnIndex != 2)
            {
                return;
            }

            // get id of current cell
            string universityId = Convert.ToString(studentsDG.CurrentRow.Cells[0].Value);
            // get student_id using universityId
            int studentId = Student.GetStudentFromUniId(universityId).StudentId;

            // get section_id from course
            int sectionId = Section.GetSectionFromCourse(courseId).Id;

            // get value of current cell
            double newGrade = Convert.ToDouble(studentsDG.CurrentCell.Value);

            // update db
            DatabaseManager dbm = DatabaseManager.Instance();
            dbm.Connection.Open();
            dbm.Command = dbm.Connection.CreateCommand();

            dbm.Command.Parameters.AddWithValue("@student_id", studentId);
            dbm.Command.Parameters.AddWithValue("@section_id", sectionId);
            dbm.Command.Parameters.AddWithValue("@student_grade", newGrade);
            dbm.Command.CommandText = "UPDATE [dbo].[registration] " +
                "SET student_grade = @student_grade " +
                "WHERE section_id = @section_id " +
                "AND student_id = @student_id ";

            try
            {
                dbm.Command.ExecuteNonQuery();
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            } finally { 
                dbm.Command.Parameters.Clear();
                dbm.Connection.Close(); 
            }
            PopulateStudents();

        }

        private void generateBtn_Click(object sender, EventArgs e)
        {
            // show save dialog to choose where to save report
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Application.StartupPath;
            saveFileDialog.CheckPathExists = true;
            saveFileDialog.DefaultExt = "csv";
            saveFileDialog.Title = "Choose save location";
            saveFileDialog.Filter = "csv Files (*.csv)|*.csv";
            DialogResult = saveFileDialog.ShowDialog();

            if (DialogResult != DialogResult.OK)
            {
                return;
            }

            string path = saveFileDialog.FileName;
            // save report as .csv file
            Helper.GenerateGradeReport(courseId, path, studentsDG);
        }

        private void publishBtn_Click(object sender, EventArgs e)
        {
            // send report to admin
            OpenFileDialog filePicker = new OpenFileDialog();
            filePicker.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            filePicker.CheckPathExists  = true;
            filePicker.CheckFileExists = true;
            filePicker.Title = "Upload report";
            filePicker.Multiselect = false;
            DialogResult = filePicker.ShowDialog();

            if (DialogResult == DialogResult.OK)
            {
                string path = filePicker.FileName;
                MessageBox.Show(path);
                Teacher.UploadReport(path, courseId);
            }

        }

        private void emailBtn_Click(object sender, EventArgs e)
        {
            if (studentsDG.SelectedCells.Count < 1)
            {
                return;
            }

            int userId = Convert.ToInt32(studentsDG.CurrentRow.Cells[3].Value);
            User recipient = User.GetUser(userId);
            // open email form and sent to user
            EmailForm emailForm = new EmailForm(recipient.Email);
            emailForm.ShowDialog();
        }
    }
}
