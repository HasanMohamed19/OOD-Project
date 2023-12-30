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
        public FeedbackForm(Course course)
        {
            selectedCourse = course;

            

            InitializeComponent();

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
            // save feedback
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
                string suggestions = txtQuestion6.Text;

                Feedback feedback = new Feedback(answers, suggestions, selectedCourse, 0, Student.GetStudentFromStudentID(Global.StudentId));

                Feedback.AddFeedback(feedback);
                Close();
            }
            else
            {
                MessageBox.Show("Please select an option for each question before submitting", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
