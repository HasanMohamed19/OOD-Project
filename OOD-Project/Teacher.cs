﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        public static void AddTeacher(Teacher teacher)
        {
            // ADD USER ROW
            DatabaseManager dbm = DatabaseManager.Instance();
            dbm.Connection.Open();
            dbm.Command = dbm.Connection.CreateCommand();
            // default username and password until accepted by admin
            dbm.Command.Parameters.AddWithValue("@username", teacher.firstName + "_" + teacher.lastName);
            dbm.Command.Parameters.AddWithValue("@password", teacher.cpr);
            dbm.Command.Parameters.AddWithValue("@email", teacher.Email);
            dbm.Command.Parameters.AddWithValue("@role_id", (int)teacher.RoleId);
            dbm.Command.Parameters.AddWithValue("@status_id", (int)teacher.StatusId);

            dbm.Command.CommandText = "INSERT INTO [dbo].[User] (user_id, username, password, email, role_id, status_id)" +
                " VALUES(NEXT VALUE FOR [dbo].[userIDSequence], @username, @password, @email, @role_id, @status_id)";
            try
            {
                int rows = dbm.Command.ExecuteNonQuery();
                MessageBox.Show($"User added successfully {rows}");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            finally
            {
                dbm.Command.Parameters.Clear();
            }
            // GET CURRENT SEQUENCE ID
            dbm.Command.CommandText = "SELECT CAST(current_value AS int) FROM sys.sequences WHERE name = 'userIDSequence'";
            try
            {
                dbm.Reader = dbm.Command.ExecuteReader();
                if (dbm.Reader.Read())
                {
                    teacher.UserId = dbm.Reader.GetInt32(0);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            finally
            {
                dbm.Reader.Close();
            }

            // ADD STUDENT ROW
            dbm.Command.Parameters.AddWithValue("@branch_id", teacher.forBranch.BranchId);
            dbm.Command.Parameters.AddWithValue("@user_id", teacher.UserId);
            dbm.Command.Parameters.AddWithValue("@first_name", teacher.firstName);
            dbm.Command.Parameters.AddWithValue("@last_name", teacher.lastName);
            dbm.Command.Parameters.AddWithValue("@phone", teacher.phoneNumber);
            dbm.Command.Parameters.AddWithValue("@cpr", teacher.cpr);
            dbm.Command.Parameters.AddWithValue("@gender", teacher.gender);
            dbm.Command.Parameters.AddWithValue("@dob", teacher.dob);
            dbm.Command.Parameters.AddWithValue("@programme_id", (int)teacher.inProgramme);
            dbm.Command.Parameters.AddWithValue("@teacher_university_id", teacher.teacherUniversityId);
            dbm.Command.CommandText = "INSERT INTO [dbo].[teacher] (teacher_id, branch_id, user_id, first_name, last_name, phone_number, dob, cpr, gender, programme_id, teacher_university_id)" +
                " VALUES(NEXT VALUE FOR [dbo].[teacherIDSequence], @branch_id, @user_id, @first_name, @last_name, @phone, @dob, @cpr, @gender, @programme_id, @teacher_university_id)";

            try
            {
                int rows = dbm.Command.ExecuteNonQuery();
                MessageBox.Show($"Teacher added successfully {rows}");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            finally
            {
                dbm.Command.Parameters.Clear();
                dbm.Connection.Close();
            }
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
