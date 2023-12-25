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

        public Section()
        {

        }

        ~Section()
        {

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

