using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Collections.Specialized.BitVector32;

namespace OOD_Project
{
    public class Section
    {

        private int capacity;
        private string crn;
        private int sectionId;
        private Teacher assignedTeacher;
        private Course forCourse;
        private string reportPath;
        private bool isReportPublished;

        public Section(int capacity, string crn, int sectionId, Teacher assignedTeacher, Course assignedCourse, string reportPath = null, bool isReportPublished = false)
        {
            this.capacity = capacity;
            this.crn = crn;
            this.sectionId = sectionId;
            this.assignedTeacher = assignedTeacher;
            this.forCourse = assignedCourse;
            this.reportPath = reportPath;
            this.isReportPublished = isReportPublished;
        }


        public static bool CanDeleteSection(int section_id)
        {
            // check if section has students registered in it
            // used to check if it can be deleted
            bool canDelete = false;

            DatabaseManager dbm = DatabaseManager.Instance();
            dbm.Connection.Open();
            dbm.Command = dbm.Connection.CreateCommand();

            dbm.Command.Parameters.AddWithValue("@section_id", section_id);
            dbm.Command.CommandText = "SELECT COUNT(registration_id) " +
                " FROM [dbo].[registration] " +
                " WHERE section_id = @section_id ";
            try
            {
                dbm.Reader = dbm.Command.ExecuteReader();
                if (dbm.Reader.Read())
                {
                    int count = dbm.Reader.GetInt32(0);
                    canDelete = count <= 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            } finally
            {
                dbm.Command.Parameters.Clear();
                dbm.Reader.Close();
                dbm.Connection.Close();
            }

            return canDelete;
        }

        public static void DeleteSection(int section_id)
        {
            int course_id = GetSection(section_id).AssignedCourse.Id;

            DatabaseManager dbm = DatabaseManager.Instance();
            dbm.Connection.Open();
            dbm.Command = dbm.Connection.CreateCommand();

            dbm.Command.Parameters.AddWithValue("@section_id", section_id);
            dbm.Command.Parameters.AddWithValue("@course_id", course_id);
            dbm.Command.CommandText = "DELETE FROM [dbo].[class] WHERE section_id = @section_id; " +
                "DELETE FROM [dbo].[section] WHERE section_id = @section_id; " +
                "DELETE FROM [dbo].[course] WHERE course_id = @course_id; ";
            try
            {
                dbm.Command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                dbm.Command.Parameters.Clear();
                dbm.Connection.Close();
            }
        }

        public static int AddSection(Section section)
        {
            DatabaseManager dbm = DatabaseManager.Instance();
            dbm.Connection.Open();
            dbm.Command = dbm.Connection.CreateCommand();

            dbm.Command.Parameters.AddWithValue("@crn", section.Crn);
            dbm.Command.Parameters.AddWithValue("@capacity", section.Capacity);
            dbm.Command.Parameters.AddWithValue("@teacher_id", section.AssignedTeacher.TeacherId);
            dbm.Command.Parameters.AddWithValue("@course_id", section.AssignedCourse.Id);
            dbm.Command.CommandText = "INSERT INTO [dbo].[section] (section_id, crn, capacity, teacher_id, course_id)" +
                "VALUES (NEXT VALUE FOR [dbo].[sectionIDSequence], @crn, @capacity, @teacher_id, @course_id)";

            try
            {
                dbm.Command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                dbm.Command.Parameters.Clear();
                dbm.Connection.Close();
            }
            // get new id
            dbm.Connection.Open();
            dbm.Command = dbm.Connection.CreateCommand();

            dbm.Command.CommandText = "SELECT CAST(CURRENT_VALUE AS INT) FROM SYS.SEQUENCES WHERE NAME='sectionIDSequence'";
            int section_id = -1;
            try
            {
                dbm.Reader = dbm.Command.ExecuteReader();
                if (dbm.Reader.Read())
                {
                    section_id = dbm.Reader.GetInt32(0);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                dbm.Connection.Close();
            }
            // return the new course id
            return section_id;
        }

        public static Section GetSectionFromCourse(int course_id)
        {
            Section section = null;

            DatabaseManager dbm = DatabaseManager.Instance();
            dbm.Connection.Open();
            dbm.Command = dbm.Connection.CreateCommand();

            dbm.Command.Parameters.AddWithValue("@course_id", course_id);
            dbm.Command.CommandText = "SELECT section_id, crn, capacity, teacher_id, report_path, is_report_published " +
                " FROM [dbo].[section] " +
                " WHERE course_id = @course_id ";
            try
            {
                dbm.Reader = dbm.Command.ExecuteReader();

                if (!dbm.Reader.Read())
                {
                    dbm.Reader.Close();
                    dbm.Connection.Close();
                    return null;
                }
                int id = dbm.Reader.GetInt32(0);
                string crn = dbm.Reader.GetString(1);
                int capacity = dbm.Reader.GetInt32(2);
                int teacher_id= dbm.Reader.GetInt32(3);
                string reportPath = dbm.Reader.IsDBNull(4) ? null : dbm.Reader.GetString(4);
                bool isReportPublished = dbm.Reader.GetBoolean(5);
                dbm.Reader.Close();
                dbm.Connection.Close();

                Teacher teacher = Teacher.GetTeacherFromTeacherID(teacher_id);
                Course course = Course.GetCourse(course_id);
                section = new Section(capacity, crn, id, teacher, course, reportPath, isReportPublished);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return section;
        }
        public static Section GetSection(int section_id)
        {
            Section section = null;

            DatabaseManager dbm = DatabaseManager.Instance();
            dbm.Connection.Open();
            dbm.Command = dbm.Connection.CreateCommand();

            dbm.Command.Parameters.AddWithValue("@section_id", section_id);
            dbm.Command.CommandText = "SELECT section_id, crn, capacity, teacher_id, course_id, report_path, is_report_published " +
                " FROM [dbo].[section] " +
                " WHERE section_id = @section_id ";
            try
            {
                dbm.Reader = dbm.Command.ExecuteReader();

                if (!dbm.Reader.Read())
                {
                    dbm.Reader.Close();
                    dbm.Connection.Close();
                    MessageBox.Show("ERROR: Section not found");
                    return null;
                }
                int id = dbm.Reader.GetInt32(0);
                string crn = dbm.Reader.GetString(1);
                int capacity = dbm.Reader.GetInt32(2);
                int teacher_id = dbm.Reader.GetInt32(3);
                int course_id = dbm.Reader.GetInt32(4);
                string reportPath = dbm.Reader.IsDBNull(5) ? null : dbm.Reader.GetString(5); // do not read if column is null
                bool isReportPublished = dbm.Reader.GetBoolean(6);
                dbm.Reader.Close();
                dbm.Connection.Close();

                Teacher teacher = Teacher.GetTeacherFromTeacherID(teacher_id);
                Course course = Course.GetCourse(course_id);
                section = new Section(capacity, crn, id, teacher, course, reportPath, isReportPublished);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return section;
        }

        public static bool EditSection(Section section)
        {
            DatabaseManager dbm = DatabaseManager.Instance();
            dbm.Connection.Open();
            dbm.Command = dbm.Connection.CreateCommand();

            dbm.Command.Parameters.AddWithValue("@section_id", section.Id);
            dbm.Command.Parameters.AddWithValue("@crn", section.Crn);
            dbm.Command.Parameters.AddWithValue("@capacity", section.Capacity);
            dbm.Command.Parameters.AddWithValue("@teacher_id", section.AssignedTeacher.TeacherId);
            dbm.Command.Parameters.AddWithValue("@course_id", section.forCourse.Id);
            dbm.Command.Parameters.AddWithValue("@is_report_published", section.IsReportPublished);
            // if there is no report path, do not add parameter
            if (section.reportPath == null)
            {
                dbm.Command.CommandText = "UPDATE [dbo].[section] " +
                "SET crn = @crn, capacity = @capacity, teacher_id = @teacher_id, course_id = @course_id, is_report_published = @is_report_published " +
                "WHERE section_id = @section_id";
            } else
            {
                dbm.Command.Parameters.AddWithValue("@report_path", section.reportPath); 
                dbm.Command.CommandText = "UPDATE [dbo].[section] " +
                "SET crn = @crn, capacity = @capacity, teacher_id = @teacher_id, course_id = @course_id, report_path = @report_path, is_report_published = @is_report_published " +
                "WHERE section_id = @section_id";
            }

            try
            {
                dbm.Command.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                dbm.Command.Parameters.Clear();
                dbm.Connection.Close();
            }
        }

        public static string GetReport(int sectionId)
        {
            string reportPath = "";
            DatabaseManager dbm = DatabaseManager.Instance();
            dbm.Connection.Open();
            dbm.Command = dbm.Connection.CreateCommand();
            dbm.Command.Parameters.AddWithValue("@section_id", sectionId);
            dbm.Command.CommandText = "SELECT report_path FROM [dbo].[section] WHERE section_id = @section_id";
            dbm.Reader = dbm.Command.ExecuteReader();
            try
            {
                if (dbm.Reader.HasRows)
                {
                    while (dbm.Reader.Read())
                    {
                        reportPath = dbm.Reader.GetString(0);
                    }
                }
            }
            catch (SqlNullValueException)
            {
                MessageBox.Show("No report found for this course.", "No Report", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                dbm.Command.Parameters.Clear();
                dbm.Connection.Close();
            }
            return reportPath;

        }

        public static void PublishReport(string sectionId)
        {
            DatabaseManager dbm = DatabaseManager.Instance();
            dbm.Connection.Open();
            dbm.Command = dbm.Connection.CreateCommand();
            dbm.Command.Parameters.AddWithValue("@section_id", sectionId);
            dbm.Command.CommandText = "UPDATE [dbo].[section] SET is_report_published = 1 WHERE section_id = @section_id";

            try
            {
                int rows = dbm.Command.ExecuteNonQuery();
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            } finally
            {
                dbm.Command.Parameters.Clear();
                dbm.Connection.Close();
            }

        }

        public Teacher AssignedTeacher
        {
            get
            {
                return assignedTeacher;
            }
            set
            {
                assignedTeacher = value;
            }
        }

        public int Capacity
        {
            get
            {
                return capacity;
            }
            set
            {
                capacity = value;
            }
        }

        public string Crn
        {
            get
            {
                return crn;
            }
            set
            {
                crn = value;
            }
        }

        public int Id
        {
            get
            {
                return sectionId;
            }
            set
            {
                sectionId = value;
            }
        }

        public Course AssignedCourse { get => forCourse; set => forCourse = value; }
        public string ReportPath { get => reportPath; set => reportPath = value; }
        public bool IsReportPublished { get => isReportPublished; set => isReportPublished = value; }
    }//end Section

}

