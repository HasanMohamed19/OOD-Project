using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
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

        private void PopulateDGVs()
        {
            PopulateCourseDGV();
            PopulateClassDGV();
        }

        private void PopulateCourseDGV()
        {
            string command = "SELECT c.code AS Code, c.name AS Name, t.first_name + ' ' + t.last_name AS Teacher, " +
                "p.programme_name AS Programme, c.credits AS Credits, s.capacity AS Capacity, s.crn AS CRN, c.description AS Description, s.section_id " +
                "FROM [dbo].[course] c " +
                "JOIN [dbo].[section] s ON c.course_id = s.course_id " +
                "JOIN [dbo].[teacher] t ON s.teacher_id = t.teacher_id " +
                "JOIN [dbo].[programme] p on c.programme_id = p.programme_id ";
            PopulateDataGrid(courseDG, command);
        }

        private void PopulateClassDGV()
        {
            // get selected section id
            if (courseDG.SelectedRows.Count < 1)
            {
                return;
            }

            int section_id = Convert.ToInt32(courseDG.SelectedRows[0].Cells[8].Value);

            DatabaseManager dbm = DatabaseManager.Instance();

            dbm.Command.Parameters.AddWithValue("@section_id",section_id);
            dbm.Command.CommandText = "SELECT CONVERT(VARCHAR(5),start_time,108) + ' - ' + CONVERT(VARCHAR(5),end_time,108) AS 'Timing', w.week_day AS Day, building AS Building, room_number AS 'Room Number' " +
                "  " +
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
            DialogResult deleteConfirmation = MessageBox.Show("Are you sure you want to delete selected course?", "Delete Confirmation", MessageBoxButtons.YesNo);



        }

        private void editCourseBtn_Click(object sender, EventArgs e)
        {

        }

        private void addCourseBtn_Click(object sender, EventArgs e)
        {
        }

        private void courseDG_SelectionChanged(object sender, EventArgs e)
        {
            PopulateClassDGV();
        }
    }
}
