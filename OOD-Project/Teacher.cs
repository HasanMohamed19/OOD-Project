using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOD_Project
{
    public class Teacher : User
    {
        private string firstName;
        private string lastName;
        private DateTime dob;
        private string cpr;
        private char gender;
        private string phoneNumber;
        private Branch forBranch;
        private Programme inProgramme;
        private string teacherUniversityId;

        

        public Teacher(int userId, string username, string password, string email, UserRole roleId, UserStatus statusId, bool hasNotification, 
            string firstName, string lastName, DateTime dob, string cpr, char gender, string phoneNumber, Branch forBranch, Programme inProgramme, string teacherUniversityId) : 
            base(userId,username,password,email,roleId,statusId,hasNotification)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.dob = dob;
            this.cpr = cpr;
            this.gender = gender;
            this.phoneNumber = phoneNumber;
            this.forBranch = forBranch;
            this.inProgramme = inProgramme;
            this.teacherUniversityId = teacherUniversityId;
        }

        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public DateTime Dob { get => dob; set => dob = value; }
        public string Cpr { get => cpr; set => cpr = value; }
        public char Gender { get => gender; set => gender = value; }
        public string PhoneNumber { get => phoneNumber; set => phoneNumber = value; }
        public Branch ForBranch { get => forBranch; set => forBranch = value; }
        public Programme InProgramme { get => inProgramme; set => inProgramme = value; }
        public string TeacherUniversityId { get => teacherUniversityId; set => teacherUniversityId = value; }

        public override string ToString()
        {
            string rolename = RoleId.ToString();
            string status = StatusId.ToString();
            string baseString = base.ToString();
            baseString += "Status: " + status;
            return baseString;

            //return rolename + " " + FirstName + " " + LastName + "\n"
            //    + Email + " " + Cpr + " " + dept + "\n"
            //    + Username + " " + Password + " " + Phone + "\n"
            //    + Dob + " " + Gender + "Status: " + status;
        }
    }
}
