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


        public static void AddCourse(Course course)
        {
            DatabaseManager dbm = DatabaseManager.Instance();
            dbm.Connection.Open();

            dbm.Command.Parameters.AddWithValue("@course_id", course.id);
            dbm.Command.Parameters.AddWithValue("@name", course.courseName);
            dbm.Command.Parameters.AddWithValue("@description", course.description);
            dbm.Command.Parameters.AddWithValue("@credits", course.credits);
            dbm.Command.Parameters.AddWithValue("@programme_id", 1); // later get programme id here

            try
            {
                dbm.Command.ExecuteNonQuery();
            } catch(Exception ex)
            {

            } finally
            {
                dbm.Command.Parameters.Clear();
                dbm.Connection.Close();
            }
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

    }
}
