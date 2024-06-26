﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Collections.Specialized.BitVector32;
using System.Windows.Forms;

namespace OOD_Project
{
    public class Feedback
    {
        private List<int> answers;
        private string suggestions;
        private Course forCourse;
        private int feedbackId;
        private Student byStudent;

        public Feedback() { }

        public Feedback(List<int> answers, string suggestions, Course forCourse, int feedbackId, Student byStudent)
        {
            this.answers = answers;
            this.suggestions = suggestions;
            this.forCourse = forCourse;
            this.feedbackId = feedbackId;
            this.byStudent = byStudent;
        }

        public static void AddFeedback(Feedback feedback)
        {
            // insert feedback
            DatabaseManager dbm = DatabaseManager.Instance();
            dbm.Connection.Open();
            dbm.Command = dbm.Connection.CreateCommand();
            dbm.Command.Parameters.AddWithValue("@student_id", feedback.ByStudent.StudentId);
            dbm.Command.Parameters.AddWithValue("@suggesstions", feedback.Suggestions);
            dbm.Command.Parameters.AddWithValue("@course_id", feedback.ForCourse.Id);
            dbm.Command.CommandText = "INSERT INTO [dbo].[Feedback] (feedback_id, student_id, suggesstions, course_id)" +
                "VALUES (NEXT VALUE FOR [dbo].[feedbackIDSequence], @student_id, @suggesstions, @course_id)";

            try
            {
                dbm.Command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                dbm.Command.Parameters.Clear();
                dbm.Connection.Close();
            }

            // get new feedback id
            int newFeedbackId = -1;
            dbm.Connection.Open();
            dbm.Command.CommandText = "SELECT CAST(CURRENT_VALUE AS INT) FROM SYS.SEQUENCES WHERE NAME='feedbackIDSequence'";
            try
            {
                dbm.Reader = dbm.Command.ExecuteReader();
                if (dbm.Reader.Read())
                {
                    newFeedbackId = dbm.Reader.GetInt32(0);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                dbm.Reader.Close();
                dbm.Command.Parameters.Clear();
                dbm.Connection.Close();
            }

            // insert answers
            for (int i = 1; i<= 5; i++)
            {
                dbm.Connection.Open();
                dbm.Command = dbm.Connection.CreateCommand();
                dbm.Command.Parameters.AddWithValue("@feedback_id", newFeedbackId);
                dbm.Command.Parameters.AddWithValue("@question_number", i);
                dbm.Command.Parameters.AddWithValue("@answer_rating", feedback.Answers[i-1]);
                dbm.Command.CommandText = "INSERT INTO [dbo].[Feedback_Answer] (feedback_answer_id, answer_rating, question_number, feedback_id)" +
                    "VALUES (NEXT VALUE FOR [dbo].[FeedbackAnswerIDSequence], @answer_rating, @question_number, @feedback_id)";

                try
                {
                    dbm.Command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    dbm.Command.Parameters.Clear();
                    dbm.Connection.Close();
                }
            }
        }
        public static Feedback GetFeedback(int course_id, int student_id)
        {
            Feedback feedback = null;

            DatabaseManager dbm = DatabaseManager.Instance();
            dbm.Connection.Open();
            dbm.Command = dbm.Connection.CreateCommand();

            dbm.Command.Parameters.AddWithValue("@course_id", course_id);
            dbm.Command.Parameters.AddWithValue("@student_id", student_id);
            dbm.Command.CommandText = "SELECT feedback_id, student_id, course_id, suggesstions " +
                " FROM [dbo].[feedback] " +
                " WHERE student_id = @student_id " +
                " AND course_id = @course_id";
            try
            {
                dbm.Reader = dbm.Command.ExecuteReader();

                if (!dbm.Reader.Read())
                {
                    return null;
                }
                int feedbackId = dbm.Reader.GetInt32(0);
                string suggestions = dbm.Reader.GetString(3);
                dbm.Reader.Close();
                dbm.Connection.Close();

                feedback = new Feedback(new List<int>(5),suggestions, Course.GetCourse(course_id), feedbackId, Student.GetStudentFromStudentID(student_id));

                // get answers
                dbm.Connection.Open();
                dbm.Command = dbm.Connection.CreateCommand();

                dbm.Command.Parameters.AddWithValue("@feedback_id", feedback.FeedbackId);
                dbm.Command.CommandText = "SELECT answer_rating, question_number " +
                    "FROM [dbo].[Feedback_Answer] " +
                    "WHERE feedback_id = @feedback_id ";

                dbm.Reader = dbm.Command.ExecuteReader();

                while (dbm.Reader.Read())
                {
                    int rating = dbm.Reader.GetInt32(0);
                    feedback.Answers.Insert(dbm.Reader.GetInt32(1)-1,rating);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            } finally
            {
                dbm.Reader.Close();
                dbm.Connection.Close();
            }

            return feedback;
        }

        public string Suggestions { get => suggestions; set => suggestions = value; }
        public Student ByStudent { get => byStudent; set => byStudent = value; }
        public List<int> Answers { get => answers; set => answers = value; }
        public Course ForCourse { get => forCourse; set => forCourse = value; }
        public int FeedbackId { get => feedbackId; set => feedbackId = value; }
    }
}
