using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace OOD_Project
{
    public enum UserRole
    {
        admin,
        teacher,
        student
    }

    public enum UserStatus
    {
        pending,
        accepted,
        rejected
    }
    public class User
    {
        private string firstName;
        private string lastName;
        private string phone;
        private string cpr;
        private string username;
        private string password;
        private string email;
        private char gender;
        private DateTime dob;
        private UserRole roleId;
        private UserStatus statusId;

        public string FirstName { get { return firstName; } set { firstName = value; } }
        public string LastName { get { return lastName; } set { lastName = value; } }
        public string Email { get { return email; } set { email = value; } }

        public string Phone { get => phone; set => phone = value; }
        public string Password { get => password; set => password = value; }
        public string Username { get => username; set => username = value; }
        public char Gender { get => gender; set => gender = value; }
        public DateTime Dob { get => dob; set => dob = value; }
        public string Cpr { get => cpr; set => cpr = value; }
        public UserRole RoleId { get => roleId; set => roleId = value; }
        public UserStatus StatusId { get => statusId; set => statusId = value; }

        public User()
        {

        }

        public User(string firstName, string lastName, string email, UserRole roleId)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.email = email;
            this.RoleId = roleId;
            this.StatusId = UserStatus.pending;
        }

        public override string ToString()
        {
            string rolename = RoleId.ToString();
            string status = StatusId.ToString();
            return rolename + " " + FirstName + " " + LastName + "\n"
                + Email + " " + Cpr + " " + "\n"
                + Username + " " + Password + " " + Phone + "\n"
                + Dob + " " + Gender + "Status: " + status;
        }
    }

    public class Student : User
    {
        private string id;

        public string Id { get => id; set => id = value; }

        public override string ToString()
        {
            return base.ToString() + " Student ID: " + Id;
            //return rolename + " " + FirstName + " " + LastName + "\n"
            //    + Email + " " + Cpr + " " + id + "\n"
            //    + Username + " " + Password + " " + Phone + "\n"
            //    + Dob + " " + Gender + "Status: " + status;
        }
    }

    public class Teacher : User
    {
        private string dept;

        public string Dept { get => dept; set => dept = value; }

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
