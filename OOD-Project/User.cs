using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace OOD_Project
{
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
        private int roleId;
        private int statusId;

        public string FirstName { get { return firstName; } set { firstName = value; } }
        public string LastName { get { return lastName; } set { lastName = value; } }
        public string Email { get { return email; } set { email = value; } }
        public int RoleId { get { return roleId; } set { roleId = value; } }

        public string Phone { get => phone; set => phone = value; }
        public string Password { get => password; set => password = value; }
        public string Username { get => username; set => username = value; }
        public char Gender { get => gender; set => gender = value; }
        public DateTime Dob { get => dob; set => dob = value; }
        public string Cpr { get => cpr; set => cpr = value; }
        public int StatusId { get => statusId; set => statusId = value; }

        public User()
        {

        }

        public User(string firstName, string lastName, string email, int roleId)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.email = email;
            this.roleId = roleId;
            this.StatusId = 1;
        }

        public override string ToString()
        {
            string rolename = "";
            switch (RoleId)
            {
                case 1:
                    rolename = "admin";
                    break;
                case 2:
                    rolename = "teacher";
                    break;
                case 3:
                    rolename = "student";
                    break;
            }
            string status = "";
            switch (StatusId)
            {
                case 1:
                    status = "pending";
                    break;
                case 2:
                    status = "accepted";
                    break;
                case 3:
                    status = "rejected";
                    break;

            }
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
            string rolename = "";
            switch (RoleId)
            {
                case 1:
                    rolename = "admin";
                    break;
                case 2:
                    rolename = "teacher";
                    break;
                case 3:
                    rolename = "student";
                    break;
            }
            string status = "";
            switch (base.StatusId)
            {
                case 1:
                    status = "pending";
                    break;
                case 2:
                    status = "accepted";
                    break;
                case 3:
                    status = "rejected";
                    break;

            }
            return rolename + " " + FirstName + " " + LastName + "\n"
                + Email + " " + Cpr + " " + id + "\n"
                + Username + " " + Password + " " + Phone + "\n"
                + Dob + " " + Gender + "Status: " + status;
        }
    }

    public class Teacher : User
    {
        private string dept;

        public string Dept { get => dept; set => dept = value; }

        public override string ToString()
        {
            string rolename = "";
            switch (RoleId)
            {
                case 1:
                    rolename = "admin";
                    break;
                case 2:
                    rolename = "teacher";
                    break;
                case 3:
                    rolename = "student";
                    break;
            }
            string status = "";
            switch (base.StatusId)
            {
                case 1:
                    status = "pending";
                    break;
                case 2:
                    status = "accepted";
                    break;
                case 3:
                    status = "rejected";
                    break;

            }
            return rolename + " " + FirstName + " " + LastName + "\n"
                + Email + " " + Cpr + " " + dept + "\n"
                + Username + " " + Password + " " + Phone + "\n"
                + Dob + " " + Gender + "Status: " + status;
        }
    }
}
