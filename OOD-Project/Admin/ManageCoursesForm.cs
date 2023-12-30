using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOD_Project.Admin
{
    public partial class ManageCourseForm : Form
    {

        public ManageCourseForm()
        {
            InitializeComponent();
            PopulateDGVs();
        }

        public void PopulateDGVs()
        {
            PopulateCourseDGV();
            PopulateClassDGV();
        }

        private void PopulateCourseDGV()
        {
            string command = "SELECT s.section_id, c.code AS Code, c.name AS Name, t.first_name + ' ' + t.last_name AS Teacher, " +
                "s.is_report_published AS 'Report Published', CASE WHEN (s.report_path IS NOT NULL) THEN 'Available' ELSE " +
                "'Not Available' END AS Report, p.programme_name AS Programme, c.credits AS Credits, s.capacity AS Capacity, s.crn AS CRN," +
                " c.description AS Description " +
                "FROM [dbo].[course] c " +
                "JOIN [dbo].[section] s ON c.course_id = s.course_id " +
                "JOIN [dbo].[teacher] t ON s.teacher_id = t.teacher_id " +
                "JOIN [dbo].[programme] p on c.programme_id = p.programme_id ";
            PopulateDataGrid(courseDG, command);
            courseDG.Columns[0].Visible = false;
        }

        private int GetSectionId()
        {
            return Convert.ToInt32(courseDG.SelectedRows[0].Cells[0].Value);
        }

        private void PopulateClassDGV()
        {
            // get selected section id
            if (courseDG.SelectedRows.Count < 1)
            {
                return;
            }

            int section_id = GetSectionId();

            DatabaseManager dbm = DatabaseManager.Instance();

            dbm.Command.Parameters.AddWithValue("@section_id",section_id);
            dbm.Command.CommandText = "SELECT c.class_id AS ID, CONVERT(VARCHAR(5),start_time,108) + ' - ' + CONVERT(VARCHAR(5)" +
                ",end_time,108) AS 'Timing', w.week_day AS Day, building AS Building, room_number AS 'Room Number' " +
                "FROM [dbo].[class] c " +
                "JOIN [dbo].[week_day] w ON c.week_day_id = w.week_day_id " +
                "WHERE section_id = @section_id ";

            try
            {
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(dbm.Command);
                BindingSource bs = new BindingSource();

                da.Fill(dt);
                bs.DataSource = dt;
                classDG.DataSource = bs;
                classDG.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
                classDG.RowTemplate.MinimumHeight = 30;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            } finally
            {
                dbm.Command.Parameters.Clear();
            }
        }

        private void PopulateDataGrid(DataGridView dgv, string sqlCommand)
        {
            DatabaseManager dbm = DatabaseManager.Instance();
            dbm.Command.CommandText = sqlCommand;

            try
            {
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(dbm.Command);
                BindingSource bs = new BindingSource();

                da.Fill(dt);
                bs.DataSource = dt;
                dgv.DataSource = bs;
                dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
                dgv.RowTemplate.MinimumHeight = 30;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void deleteCourseBtn_Click(object sender, EventArgs e)
        {
            // get selected course
            if (courseDG.SelectedRows.Count < 1)
            {
                return;
            }
            int section_id = GetSectionId();

            // check if there are registered students in the course
            if (!Section.CanDeleteSection(section_id))
            {
                MessageBox.Show("This course has students registered for it already. If you would like to delete it, please unregister the students first.","Cannot delete");
                return;
            }

            DialogResult deleteConfirmation = MessageBox.Show("Are you sure you want to delete selected course?", "Delete Confirmation", MessageBoxButtons.YesNo);
            
            if (deleteConfirmation != DialogResult.Yes)
            {
                return;
            }

            // delete course and section and classes
            Section.DeleteSection(section_id);
            // refresh view
            PopulateDGVs();
        }

        private void editCourseBtn_Click(object sender, EventArgs e)
        {
            // get selected course
            if (courseDG.SelectedRows.Count < 1)
            {
                return;
            }
            int section_id = GetSectionId();

            EditCourseForm editCourseForm = new EditCourseForm(section_id, this);
            editCourseForm.Show();
        }

        private void addCourseBtn_Click(object sender, EventArgs e)
        {
            AddCourseForm form = new AddCourseForm(this);
            form.Show();
        }

        private void courseDG_SelectionChanged(object sender, EventArgs e)
        {
            bool courseSelected = courseDG.SelectedRows.Count > 0;
            btnPublishReport.Enabled = courseSelected;
            feedbackBtn.Enabled = courseSelected;
            reportBtn.Enabled = courseSelected;
            PopulateClassDGV();
        }

        private void addClass_Click(object sender, EventArgs e)
        {
            // get selected course
            if (courseDG.SelectedRows.Count < 1)
            {
                return;
            }
            int section_id = GetSectionId();

            AddClassForm form = new AddClassForm(section_id, this);
            form.Show();
        }

        private void editClass_Click(object sender, EventArgs e)
        {
            // get selected class
            if (classDG.SelectedRows.Count < 1)
            {
                return;
            }
            int class_id = Convert.ToInt32(classDG.SelectedRows[0].Cells[0].Value);

            EditClassForm form = new EditClassForm(class_id, this);
            form.Show();
        }

        private void deleteClass_Click(object sender, EventArgs e)
        {
            // get selected class
            if (classDG.SelectedRows.Count < 1)
            {
                return;
            }
            int class_id = Convert.ToInt32(classDG.SelectedRows[0].Cells[0].Value);

            DialogResult deleteConfirmation = MessageBox.Show("Are you sure you want to delete selected class?", "Delete Confirmation", MessageBoxButtons.YesNo);

            if (deleteConfirmation != DialogResult.Yes)
            {
                return;
            }

            Class.DeleteClass(class_id);
            PopulateDGVs();

        }

        private void feedbackBtn_Click(object sender, EventArgs e)
        {
            // get selected section
            if (courseDG.SelectedRows.Count < 1)
            {
                return;
            }
            int section_id = GetSectionId();

        }

        private void reportBtn_Click(object sender, EventArgs e)
        {
            // get selected section
            if (courseDG.SelectedRows.Count < 1)
            {
                return;
            }

            int section_id = GetSectionId();
            string reportPath = Section.GetReport(section_id);

            if (!string.IsNullOrWhiteSpace(reportPath))
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                string reportName = Path.GetFileName(reportPath);
                saveFileDialog.FileName = reportName;

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string selectedFileName = saveFileDialog.FileName;
                    string selectedDirectoryPath = Path.GetDirectoryName(selectedFileName);
                    
                    string courseID = Course.getCourseIdByCourseCode(courseDG.SelectedRows[0].Cells[1].Value.ToString());
                    MessageBox.Show(Path.Combine(DocumentHelper.coursesDirectory, courseID, "Reports", reportName));
                    DocumentHelper.CopyFile(Path.Combine(DocumentHelper.coursesDirectory, courseID, "Reports", reportName), Path.Combine(selectedDirectoryPath, selectedFileName));
                }

            }

        }

        private void btnPublishReport_Click(object sender, EventArgs e)
        {
            bool isReportPublished = Convert.ToBoolean(courseDG.SelectedRows[0].Cells[4].Value);
            if (isReportPublished)
            {
                MessageBox.Show("Report has already been published.", "Cannot Publish");
                return;
            }
            List<User> students = Student.GetStudentsOfCourse(GetSectionId());
            string courseCode = courseDG.SelectedRows[0].Cells[1].Value.ToString();
            string courseName = courseDG.SelectedRows[0].Cells[2].Value.ToString();
            string sectionId = GetSectionId().ToString();
            Announcement announcement = new Announcement(0, $"{courseCode}-{courseName} grade has been published.", DateTime.Now, students, false, "Grade Published", Announcement.AnnouncementType.grade);
            Announcement.PublishAnnouncement(announcement);
            Section.PublishReport(sectionId);
            // need to check path before? and how to update the view
            PopulateDGVs();
        }
    }
}
