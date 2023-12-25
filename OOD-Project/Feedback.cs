using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOD_Project
{
    public class Feedback
    {
        private List<int> answers;
        private string suggestions;
        private Course forCourse;
        private int feedbackId;
        private Student byStudent;

        public Feedback() { }

        public Feedback(List<int> answers, string suggestions, Course forCourse, int feedbackId, Student byStudent)
        {
            this.answers = answers;
            this.suggestions = suggestions;
            this.forCourse = forCourse;
            this.feedbackId = feedbackId;
            this.byStudent = byStudent;
        }

        public string Suggestions { get => suggestions; set => suggestions = value; }
        public Student ByStudent { get => byStudent; set => byStudent = value; }
        public List<int> Answers { get => answers; set => answers = value; }
        public Course ForCourse { get => forCourse; set => forCourse = value; }
        public int FeedbackId { get => feedbackId; set => feedbackId = value; }
    }
}
