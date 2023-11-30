using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOD_Project
{
    public class Course
    {
        int id;
        string name;
        string code;
        string description;
        string programme;
        int credits;
        List<Section> sections;

        public Course(int id, string name, string code, string description, string programme, int credits)
        {
            this.id = id;
            this.name = name;
            this.code = code;
            this.description = description;
            this.programme = programme;
            this.credits = credits;
        }

        public string Name { get => name; set => name = value; }
        public string Code { get => code; set => code = value; }
        public int Id { get => id; set => id = value; }
        public string Description { get => description; set => description = value; }
        public string Programme { get => programme; set => programme = value; }
        public List<Section> Sections { get => sections; set => sections = value; }
    }
}
