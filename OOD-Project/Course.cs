using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
