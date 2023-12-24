﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOD_Project
{
    public enum Programme
    {
        ict,
        business,
        creativeMedia,
        enginerring,
        logistics
    }
    public class Major
    {
        private Programme forProgramme;
        private int majorId;
        private string name;

        public Major(Programme forProgramme, int majorId, string name)
        {
            this.forProgramme = forProgramme;
            this.majorId = majorId;
            this.name = name;
        }
        public Programme ForProgramme {  get { return forProgramme; } set {  forProgramme = value; } }
        public int MajorId { get {  return majorId; } set {  majorId = value; } }
        public string Name { get { return name; } set { name = value; } }

    }
}
