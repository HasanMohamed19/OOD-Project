using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOD_Project
{
    public class Registration
    {
        private Section forSection;
        private Student ofStudent;
        private int registrationId;
        private Dictionary<string, double> studentGrade;

        public Registration(Section forSection, Student ofStudent, int registrationId, Dictionary<string, double> studentGrade)
        {
            this.ForSection = forSection;
            this.OfStudent = ofStudent;
            this.RegistrationId = registrationId;
            this.StudentGrade = studentGrade;
        }

        public Section ForSection { get => forSection; set => forSection = value; }
        public Student OfStudent { get => ofStudent; set => ofStudent = value; }
        public int RegistrationId { get => registrationId; set => registrationId = value; }
        public Dictionary<string, double> StudentGrade { get => studentGrade; set => studentGrade = value; }
    }
}
