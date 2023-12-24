using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOD_Project
{
    public class Feedback
    {
        private int feedbackId;
        private Student byStudent;
        private Course forCourse;
        private List<int> answers;
        private string suggestion;

        public Feedback(int feedbackId, Student byStudent, Course forCourse, List<int> answers, string suggestion)
        {
            this.FeedbackId = feedbackId;
            this.ByStudent = byStudent;
            this.ForCourse = forCourse;
            this.Answers = answers;
            this.Suggestion = suggestion;
        }
        public int FeedbackId { get => feedbackId; set => feedbackId = value; }
        public Student ByStudent { get => byStudent; set => byStudent = value; }
        public Course ForCourse { get => forCourse; set => forCourse = value; }
        public List<int> Answers { get => answers; set => answers = value; }
        public string Suggestion { get => suggestion; set => suggestion = value; }
    }
}
