using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOD_Project
{
    public class Registration
    {
        private Section forSection;
        private Student ofStudent;
        private int registrationId;
        private double studentGrade;

        public Registration(Section forSection, Student ofStudent, int registrationId, double studentGrade)
        {
            this.ForSection = forSection;
            this.OfStudent = ofStudent;
            this.RegistrationId = registrationId;
            this.StudentGrade = studentGrade;
        }

        public static List<Student> GetRegisteredStudents(int section_id)
        {
            List<Student> registeredStudents = new List<Student>();
            List<int> studentIds = new List<int>();

            DatabaseManager dbm = DatabaseManager.Instance();
            dbm.Connection.Open();
            dbm.Command = dbm.Connection.CreateCommand();
            dbm.Command.Parameters.AddWithValue("@section_id", section_id);
            dbm.Command.CommandText = "SELECT st.student_id " +
                " FROM [dbo].[registration] r " +
                " JOIN [dbo].[section] s ON r.section_id = s.section_id " +
                "JOIN [dbo].[student] st ON st.student_id = r.student_id " +
                " WHERE s.section_id = @section_id";
            try
            {
                dbm.Reader = dbm.Command.ExecuteReader();
                while (dbm.Reader.Read())
                {
                    studentIds.Add(dbm.Reader.GetInt32(0));
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

            // get students from their ids
            foreach (int id in studentIds)
            {
                registeredStudents.Add(Student.GetStudentFromStudentID(id));
            }

            return registeredStudents;
        }


        public Section ForSection { get => forSection; set => forSection = value; }
        public Student OfStudent { get => ofStudent; set => ofStudent = value; }
        public int RegistrationId { get => registrationId; set => registrationId = value; }
        public double StudentGrade { get => studentGrade; set => studentGrade = value; }
    }
}
