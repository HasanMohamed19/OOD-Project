using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOD_Project
{
    public class Course
    {
        private int id;
        private string courseName;
        private string code;
        private string description;
        private Programme forProgramme;
        private int credits;

        public Course()
        {

        }

        public Course(int id, string name, string code, string description, Programme programme, int credits)
        {
            this.id = id;
            this.courseName = name;
            this.code = code;
            this.description = description;
            this.forProgramme = programme;
            this.credits = credits;
        }

        public string Name { get => courseName; set => courseName = value; }
        public string Code { get => code; set => code = value; }
        public int Id { get => id; set => id = value; }
        public string Description { get => description; set => description = value; }
        public Programme ForProgramme { get => forProgramme; set => forProgramme = value; }
        public int Credits { get => credits; set => credits = value; }

        public static Course GetCourse(int course_id)
        {
            Course course = null;

            DatabaseManager dbm = DatabaseManager.Instance();
            dbm.Connection.Open();
            dbm.Command = dbm.Connection.CreateCommand();

            dbm.Command.Parameters.AddWithValue("@course_id", course_id);
            dbm.Command.CommandText = "SELECT name, code, description, programme_id, credits FROM [dbo].[course] " +
                "WHERE course_id = @course_id";
            try
            {
                dbm.Reader = dbm.Command.ExecuteReader();
                if (!dbm.Reader.Read())
                {
                    throw new Exception("Course not found with id " + course_id);
                }
                string name = dbm.Reader.GetString(0);
                string code = dbm.Reader.GetString(1);
                string description = dbm.Reader.GetString(2);
                Programme programme = (Programme)dbm.Reader.GetInt32(3);
                int credits= dbm.Reader.GetInt32(4);
                course = new Course(course_id, name, code, description, programme, credits);
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            } finally
            {
                dbm.Reader.Close();
                dbm.Connection.Close();
            }

            return course;
        }
        public static int AddCourse(Course course)
        {
            DatabaseManager dbm = DatabaseManager.Instance();
            dbm.Connection.Open();
            dbm.Command = dbm.Connection.CreateCommand();
            dbm.Command.Parameters.AddWithValue("@name", course.Name);
            dbm.Command.Parameters.AddWithValue("@code", course.Code);
            dbm.Command.Parameters.AddWithValue("@description", course.Description);
            dbm.Command.Parameters.AddWithValue("@credits", course.Credits);
            dbm.Command.Parameters.AddWithValue("@programme_id", (int)course.forProgramme);
            dbm.Command.CommandText = "INSERT INTO [dbo].[course] (course_id, name, code, description, programme_id, credits)" +
                "VALUES (NEXT VALUE FOR [dbo].[courseIDSequence], @name, @code, @description, @programme_id, @credits)";

            try
            {
                dbm.Command.ExecuteNonQuery();
            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message );
            } finally
            {
                dbm.Command.Parameters.Clear();
                dbm.Connection.Close();
            }
            // get new id
            dbm.Connection.Open();
            dbm.Command = dbm.Connection.CreateCommand();

            dbm.Command.CommandText = "SELECT CAST(CURRENT_VALUE AS INT) FROM SYS.SEQUENCES WHERE NAME='courseIDSequence'";
            int course_id = -1;
            try
            {
                dbm.Reader = dbm.Command.ExecuteReader();
                if (dbm.Reader.Read())
                {
                    course_id = dbm.Reader.GetInt32(0);
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
            return course_id;
        }

        public static bool DeleteCourse(int course_id)
        {
            DatabaseManager dbm = DatabaseManager.Instance();
            dbm.Connection.Open();
            dbm.Command.Parameters.AddWithValue("@course_id", course_id);
            dbm.Command.CommandText = "DELETE FROM [dbo].[course] WHERE course_id = @course_id";
            try
            {
                dbm.Command.ExecuteNonQuery();
                return true;
            } catch (Exception ex)
            {
                return false;
            } finally
            {
                dbm.Command.Parameters.Clear();
                dbm.Connection.Close();
            }

        }

        public static bool EditCourse(Course course)
        {
            DatabaseManager dbm = DatabaseManager.Instance();
            dbm.Connection.Open();

            dbm.Command.Parameters.AddWithValue("@course_id", course.Id);
            dbm.Command.Parameters.AddWithValue("@name", course.courseName);
            dbm.Command.Parameters.AddWithValue("@code", course.code);
            dbm.Command.Parameters.AddWithValue("@description", course.description);
            dbm.Command.Parameters.AddWithValue("@programme_id", course.forProgramme);
            dbm.Command.Parameters.AddWithValue("@credits", course.credits);

            dbm.Command.CommandText = "UPDATE [dbo].[course] SET name = @name, code = @code, description = @description, programme_id = @programme_id, credits = @credits WHERE course_id = @course_id";
            try
            {
                dbm.Command.ExecuteNonQuery();
                return true;
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            } finally
            {
                dbm.Command.Parameters.Clear();
                dbm.Connection.Close();
            }
        }

        public static string getCourseIdByCourseCode(string courseCode)
        {
            DatabaseManager dbm = DatabaseManager.Instance();
            dbm.Connection.Open();
            dbm.Command = dbm.Connection.CreateCommand();
            dbm.Command.Parameters.AddWithValue("@course_code", courseCode);
            dbm.Command.CommandText = "SELECT course.course_id FROM [dbo].[course] WHERE code = @course_code";

            try
            {
                dbm.Reader = dbm.Command.ExecuteReader();

                if (dbm.Reader.Read())
                {
                    
                    return dbm.Reader["course_id"].ToString();
                }
                
                return "";
            } catch (Exception ex)
            {
                return "";
            } finally
            {
                dbm.Command.Parameters.Clear();
                dbm.Connection.Close();
            }
           

        }

    }
}
