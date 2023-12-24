using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOD_Project
{
    public class Teacher : User
    {
        private Department dept;
        private List<Section> assignedSections;

        public Department Dept { get => dept; set => dept = value; }
        public List<Section> AssignedSections { get => assignedSections; set => assignedSections = value; }
        public List<Course> AssignedCourses
        {
            get
            {
                List<Course> courses = new List<Course>();
                foreach (var section in AssignedSections)
                {
                    courses.Add(section.AssignedCourse);
                }
                return courses;
            }
        }


        public override string ToString()
        {
            string rolename = RoleId.ToString();
            string status = StatusId.ToString();
            string baseString = base.ToString();
            baseString += "Status: " + status;
            return baseString;

            //return rolename + " " + FirstName + " " + LastName + "\n"
            //    + Email + " " + Cpr + " " + dept + "\n"
            //    + Username + " " + Password + " " + Phone + "\n"
            //    + Dob + " " + Gender + "Status: " + status;
        }
    }
}
