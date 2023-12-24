using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOD_Project
{
    public class Feedback
    {
        private int ratingQuestion1;
        private int ratingQuestion2;
        private int ratingQuestion3;
        private int ratingQuestion4;
        private int ratingQuestion5;
        private string openQuestion;
        private Student byStudent;

        public Feedback() { }
        public Feedback(int ratingQuestion1, int ratingQuestion2, int ratingQuestion3, int ratingQuestion4, int ratingQuestion5)
        {
            this.ratingQuestion1 = ratingQuestion1;
            this.ratingQuestion2 = ratingQuestion2;
            this.ratingQuestion3 = ratingQuestion3;
            this.ratingQuestion4 = ratingQuestion4;
            this.ratingQuestion5 = ratingQuestion5;
        }
        public int RatingQuestion1
        {
            get { return ratingQuestion1; }
            set { ratingQuestion1 = value; }
        }

        public int RatingQuestion2
        {
            get { return ratingQuestion2; }
            set { ratingQuestion2 = value; }
        }

        public int RatingQuestion3
        {
            get { return ratingQuestion3; }
            set { ratingQuestion3 = value; }
        }

        public int RatingQuestion4
        {
            get { return ratingQuestion4; }
            set { ratingQuestion4 = value; }
        }

        public int RatingQuestion5
        {
            get { return ratingQuestion5; }
            set { ratingQuestion5 = value; }
        }

        public string OpenQuestion { get => openQuestion; set => openQuestion = value; }
        public Student ByStudent { get => byStudent; set => byStudent = value; }
    }
}
