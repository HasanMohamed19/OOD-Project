﻿using System;
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

        public Feedback(int ratingQuestion1, int ratingQuestion2, int ratingQuestion3, int ratingQuestion4, int ratingQuestion5)
        {
            this.ratingQuestion1 = ratingQuestion1;
            this.ratingQuestion2 = ratingQuestion2;
            this.ratingQuestion3 = ratingQuestion3;
            this.ratingQuestion4 = ratingQuestion4;
            this.ratingQuestion5 = ratingQuestion5;
        }
        public String OpenQuestion { get; set; }
    }
}
