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

            if (IsFeedbackSubmitted())
            {
                //Loop to initialize radiobuttons in the feedback form
                //int[] ratings = new int[]
                int[] answers = new int[]
                {
                feedback.RatingQuestion1,
                feedback.RatingQuestion2,
                feedback.RatingQuestion3,
                feedback.RatingQuestion4,
                feedback.RatingQuestion5
                };

            //}
            for (int i = 1; i < 6; i++)
                {
                    
                    TableLayoutPanel tlp = this.Controls.Find("tlpQuestion" + (i), true).FirstOrDefault() as TableLayoutPanel;
                    int rating = answers[i-1];
                    RadioButton rb;
                    switch (rating)
                    {
                        case 1:
                            rb = tlp.Controls.Find("RbVeryUnsatisfied" + (i), true).FirstOrDefault() as RadioButton;
                            break;
                        case 2:
                            rb = tlp.Controls.Find("RbUnsatisfied" + (i), true).FirstOrDefault() as RadioButton;
                            break;
                        case 3:
                            rb = tlp.Controls.Find("RbNeutral" + (i), true).FirstOrDefault() as RadioButton;
                            break;
                        case 4:
                            rb = tlp.Controls.Find("RbSatisfied" + (i), true).FirstOrDefault() as RadioButton;
                            break;
                        case 5:
                            rb = tlp.Controls.Find("RbVerySatisfied" + (i), true).FirstOrDefault() as RadioButton;
                            break;
                        default:
                            continue;
                    }
                    if (rb != null)
                    {
                        rb.Checked = true;
                    }
                }
                txtQuestion6.Text = feedback.OpenQuestion;
                // Call the method to disable controls on the form
                DisableControls(this);
                btnSendFeedback.Text = "Form submitted";
                btnSendFeedback.Enabled = false;
            }
        }

        private bool IsFeedbackSubmitted()
        {
            Console.WriteLine(selectedCourse.CourseFeedback != null);
            if (selectedCourse.CourseFeedback.Count > 0) {
                foreach (var feedback in selectedCourse.CourseFeedback)
                {
                    if (feedback.ByStudent.Id == "10")
                    {
                        return true;
                    }
                }
            }
            
            return false;
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
                feedback = new Feedback(q1Result,q2Result,q3Result,q4Result,q5Result);
                feedback.OpenQuestion = txtQuestion6.Text;
                selectedCourse.CourseFeedback.Add(feedback);
                DatabaseManager dbm = DatabaseManager.Instance();
                dbm.Connection.Open();
                dbm.Command = dbm.Connection.CreateCommand();

                dbm.Command.Parameters.AddWithValue("@by_student", Global.user_id);
                dbm.Command.Parameters.AddWithValue("@rating_question_1", q1Result);
                dbm.Command.Parameters.AddWithValue("@rating_question_2", q2Result);
                dbm.Command.Parameters.AddWithValue("@rating_question_3", q3Result);
                dbm.Command.Parameters.AddWithValue("@rating_question_4", q4Result);
                dbm.Command.Parameters.AddWithValue("@rating_question_5", q5Result);
                dbm.Command.Parameters.AddWithValue("@open_question", txtQuestion6.Text);
                dbm.Command.CommandText = "INSERT INTO [dbo].[Feedback] (feedback_id, by_student, rating_question_1, rating_question_2, rating_question_3, rating_question_4, rating_question_5, open_question)" +
                    "VALUES (NEXT VALUE FOR [dbo].[feedbackIDSequence], @by_student, @rating_question_1, @rating_question_2, @rating_question_3, @rating_question_4, @rating_question_5, @open_question)";
                try
                {
                    dbm.Command.ExecuteNonQuery();
                    MessageBox.Show("Course feedback has been sent", "Submitted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                } catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                } finally
                {
                    dbm.Command.Parameters.Clear();
                    dbm.Connection.Close();
                }

                
            }
            else
            {
                MessageBox.Show("Please select an option for each question before submitting", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
