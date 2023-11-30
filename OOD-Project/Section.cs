using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Collections.Specialized.BitVector32;

namespace OOD_Project
{
    public class Section
    {

        private int capacity;
        private List<Class> classes;
        private string crn;
        private int id;
        private string name;
        private int number;
        private List<Student> registeredStudents;
        private Teacher teacher;

        public Section()
        {

        }

        ~Section()
        {

        }

        public Teacher assignedTeacher
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
                return id;
            }
            set
            {
                id = value;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public int Number
        {
            get
            {
                return number;
            }
            set
            {
                number = value;
            }
        }

        public List<Student> RegisteredStudents
        {
            get
            {
                return registeredStudents;
            }
            set
            {
                registeredStudents = value;
            }
        }

        public List<Class> Classes { get => classes; set => classes = value; }
    }//end Section

}

