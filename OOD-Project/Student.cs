using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOD_Project
{
    public class Student : User
    {
        private string id;
        private List<Section> registeredSections;

        public Student()
        {
            RoleId = UserRole.student;
            StatusId = UserStatus.pending;
            registeredSections = new List<Section>();
        }

        public string Id { get => id; set => id = value; }
        public List<Section> RegisteredSections { get => registeredSections; set => registeredSections = value; }
        public List<Course> RegisteredCourses
        {
            get
            {
                List<Course> courses = new List<Course>();
                foreach (var section in RegisteredSections)
                {
                    courses.Add(section.AssignedCourse);
                }
                return courses;
            }
        }


        public override string ToString()
        {
            return base.ToString() + " Student ID: " + Id;
            
        }
    }
}
