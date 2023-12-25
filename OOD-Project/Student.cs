using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOD_Project
{
    public class Student : User
    {
        private string firstName;
        private string lastName;
        private DateTime dob;
        private string cpr;
        private char gender;
        private string phoneNumber;
        private Major inMajor;
        private string studentUniversityId;

        public Student()
        {
            RoleId = UserRole.student;
            StatusId = UserStatus.pending;
        }

        public Student(int userId, string username, string password, string email, UserRole roleId, UserStatus statusId, bool hasNotification, 
            string firstName, string lastName, DateTime dob, string cpr, char gender, string phoneNumber, Major inMajor, string studentUniversityId)
            : base(userId, username, password, email, roleId, statusId, hasNotification)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.dob = dob;
            this.cpr = cpr;
            this.gender = gender;
            this.phoneNumber = phoneNumber;
            this.inMajor = inMajor;
            this.studentUniversityId = studentUniversityId;
        }

        public string StudentUniversityId { get => studentUniversityId; set => studentUniversityId = value; }
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public DateTime Dob { get => dob; set => dob = value; }
        public string Cpr { get => cpr; set => cpr = value; }
        public char Gender { get => gender; set => gender = value; }
        public string PhoneNumber { get => phoneNumber; set => phoneNumber = value; }
        public Major InMajor { get => inMajor; set => inMajor = value; }

        //public override string ToString()
        //{
        //    return base.ToString() + " Student ID: " + Id;
            
        //}
    }
}
