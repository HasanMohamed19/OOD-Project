using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOD_Project
{
    public partial class FeedbackForm : Form
    {
        Course selectedCourse;
        Feedback feedback = new Feedback();
        public FeedbackForm(Course course)
        {
            selectedCourse = course;
            InitializeComponent();

            if (!IsFeedbackSubmitted())
            {
                MessageBox.Show("Feedback added");
                AddFeedback();
            } else
            {
                MessageBox.Show("Feedback already submitted");
                this.Hide();
            }

            
        }

        private void AddFeedback()
        {
            if (IsFeedbackSubmitted() == false)
            {
                DatabaseManager dbm = DatabaseManager.Instance();
                dbm.Connection.Open();
                dbm.Command.Parameters.AddWithValue("@student_id", Global.StudentId);
                dbm.Command.Parameters.AddWithValue("@course_id", selectedCourse.Id);
                dbm.Command.CommandText = "INSERT INTO [dbo].[Feedback] (feedback_id, student_id, course_id)" +
                    "VALUES (NEXT VALUE FOR [dbo].[feedbackIDSequence], @student_id, @course_id";

                try
                {
                    dbm.Command.ExecuteNonQuery();
                    MessageBox.Show("added");
                } catch (Exception ex) {

                
                } finally
                {
                    dbm.Command.Parameters.Clear();
                    dbm.Connection.Close();
                }

            } else
            {
                MessageBox.Show("not added");
            }
            
        }

        // returns false nothing found, true otherwise
        private bool IsFeedbackSubmitted()
        {

            DatabaseManager dbm = DatabaseManager.Instance();
            dbm.Connection.Open();
            dbm.Command.Parameters.AddWithValue("@student_id", Global.StudentId);
            dbm.Command.Parameters.AddWithValue("@coursee_id", selectedCourse.Id);
            dbm.Command.CommandText = "SELECT * FROM [dbo].[Feedback] WHERE student_id = @student_id AND course_id = @coursee_id";
            dbm.Reader = dbm.Command.ExecuteReader();

            if (!dbm.Reader.HasRows)
            {
                dbm.Command.Parameters.Clear();
                dbm.Connection.Close();
                return false;
            } else
            {
                dbm.Command.Parameters.Clear();
                dbm.Connection.Close();
                return true;
            }


            
        }

        //Method to check and disable radio buttons and textboxes inside the form
        public void DisableControls(Control control)
        {
            foreach (Control childControl in control.Controls)
            {
                if (childControl is RadioButton || childControl is TextBox)
                {
                    childControl.Enabled = false;
                }
                else
                {
                    DisableControls(childControl); 
                }
            }
        }

        //Method to check if a radio button is selected within a layout panel.
        private bool RadioButtonSelected(TableLayoutPanel tableLayoutPanel)
        {
            foreach (Control control in tableLayoutPanel.Controls)
            {
                if (control is RadioButton radioButton && radioButton.Checked)
                {
                    return true;
                }
            }

            return false;
        }

        //Gets result from the questions and converts it to an int (1-5)
        private int GetRadioButtonResult(TableLayoutPanel tableLayoutPanel)
        {
            int result = 0;

            foreach (Control control in tableLayoutPanel.Controls)
            {
                if (control is RadioButton radioButton&&radioButton.Checked)
                {   
                    string radioButtonName = radioButton.Name.Substring(0, radioButton.Name.Length-1); //Get radiobutton name without last digit
                    switch (radioButtonName) //Return result based on name
                    {
                        case "RbVeryUnsatisfied":
                            result = 1;
                            break;
                        case "RbUnsatisfied":
                            result = 2;
                            break;
                        case "RbNeutral":
                            result = 3;
                            break;
                        case "RbSatisfied":
                            result = 4;
                            break;
                        case "RbVerySatisfied":
                            result = 5;
                            break;
                        default:
                            break;
                    }
     
                }

            }
            return result;
        }

        private int getNewFeedbackId()
        {
            DatabaseManager dbm = DatabaseManager.Instance();
            //dbm.Connection.Open();
            dbm.Connection.CreateCommand();
            dbm.Command.Parameters.AddWithValue("@student_id", Global.StudentId);
            dbm.Command.Parameters.AddWithValue("@course_id", selectedCourse.Id);
            dbm.Command.CommandText = "SELECT feedback_id FROM [dbo].[Feedback] WHERE student_id = @student_id AND course_id = @course_id";
            dbm.Reader = dbm.Command.ExecuteReader();
            int id = 0;
            if (dbm.Reader.Read())
            {
                int fid = dbm.Reader.GetOrdinal("feedback_id");
                id = dbm.Reader.GetInt32(fid);
                MessageBox.Show(id.ToString());
            }
            
            dbm.Command.Parameters.Clear();
            dbm.Connection.Close();
            return id;
        }

        private void btnSendFeedback_Click(object sender, EventArgs e)
        {
            //Check if a button is selected in each question
            bool question1Checked = RadioButtonSelected(tlpQuestion1);
            bool question2Checked = RadioButtonSelected(tlpQuestion2);
            bool question3Checked = RadioButtonSelected(tlpQuestion3);
            bool question4Checked = RadioButtonSelected(tlpQuestion4);
            bool question5Checked = RadioButtonSelected(tlpQuestion5);

            if (question1Checked && question2Checked && question3Checked && question4Checked && question5Checked)
            {
                //Store feedback here
                int q1Result = GetRadioButtonResult(tlpQuestion1);
                int q2Result = GetRadioButtonResult(tlpQuestion2);
                int q3Result = GetRadioButtonResult(tlpQuestion3);
                int q4Result = GetRadioButtonResult(tlpQuestion4);
                int q5Result = GetRadioButtonResult(tlpQuestion5);
                List<int> answers = new List<int> {q1Result, q2Result, q3Result, q4Result, q5Result};
                feedback.Answers = answers;
                feedback.Suggestions = txtQuestion6.Text;
                DatabaseManager dbm = DatabaseManager.Instance();
                dbm.Connection.Open();
                int id = getNewFeedbackId();
                MessageBox.Show("here" + id.ToString());
                dbm.Connection.Open();
                dbm.Command = dbm.Connection.CreateCommand();
                

                for (int i = 1; i < 6; i++)
                {
                    dbm.Command.Parameters.AddWithValue("@feedback_id", id);
                    dbm.Command.Parameters.AddWithValue("@question_number", i);
                    dbm.Command.Parameters.AddWithValue("@answer_rating", answers[i - 1]);
                    dbm.Command.CommandText = "INSERT INTO [dbo].[Feedback_Answer] (feedback_answer_id, answer_rating, question_number, feedback_id)" +
                        "VALUES (NEXT VALUE FOR [dbo].[FeedbackAnswerIDSequence], @answer_rating, @question_number, @feedback_id)";
                    
                    try
                    {
                        dbm.Command.ExecuteNonQuery();
                        MessageBox.Show("Course feedback has been sent", "Submitted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Hide();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("here " + ex.Message);
                    }
                    finally
                    {
                        dbm.Command.Parameters.Clear();
                    }


                }

                

                
            }
            else
            {
                MessageBox.Show("Please select an option for each question before submitting", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
