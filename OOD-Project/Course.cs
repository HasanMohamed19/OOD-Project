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
        private string name;
        private string code;
        private string description;
        private string programme;
        private int credits;
        private List<Section> sections;
        private List<Content> content;
        private List<Feedback> courseFeedback;

        public Course()
        {
            sections = new List<Section>();
        }

        public Course(int id, string name, string code, string description, string programme, int credits)
        {
            this.id = id;
            this.name = name;
            this.code = code;
            this.description = description;
            this.programme = programme;
            this.credits = credits;
            sections = new List<Section>();
            content = new List<Content>();
            courseFeedback = new List<Feedback>();
        }

        public string Name { get => name; set => name = value; }
        public string Code { get => code; set => code = value; }
        public int Id { get => id; set => id = value; }
        public string Description { get => description; set => description = value; }
        public string Programme { get => programme; set => programme = value; }
        public List<Section> Sections { get => sections; set => sections = value; }
        public int Credits { get => credits; set => credits = value; }
        public List<Content> Content { get => content; set => content = value; }
        public List<Feedback> CourseFeedback { get => courseFeedback; set => courseFeedback = value; }
    }
}
