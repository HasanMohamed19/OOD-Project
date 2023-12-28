using System;
using System.Collections.Generic;
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

        public Section(int capacity, string crn, int sectionId, Teacher assignedTeacher, Course assignedCourse)
        {
            this.capacity = capacity;
            this.crn = crn;
            this.sectionId = sectionId;
            this.assignedTeacher = assignedTeacher;
            this.forCourse = assignedCourse;
        }


        public static Section GetSectionFromCourse(int course_id)
        {
            Section section = null;

            DatabaseManager dbm = DatabaseManager.Instance();
            dbm.Connection.Open();
            dbm.Command = dbm.Connection.CreateCommand();

            dbm.Command.Parameters.AddWithValue("@course_id", course_id);
            dbm.Command.CommandText = "SELECT section_id, crn, capacity, teacher_id " +
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
                dbm.Reader.Close();
                dbm.Connection.Close();

                Teacher teacher = Teacher.GetTeacher(teacher_id);
                Course course = Course.GetCourse(course_id);
                section = new Section(capacity, crn, id, teacher, course);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return section;
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
    }//end Section

}

