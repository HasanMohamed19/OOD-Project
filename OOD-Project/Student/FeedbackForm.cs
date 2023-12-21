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
        public FeedbackForm()
        {
         //if (selectedCourse.CourseFeedback != null) {}
            InitializeComponent();
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
                if (control is RadioButton radioButton && radioButton.Checked)
                {
                    string radioButtonName = radioButton.Name.Substring(0, radioButton.Name.Length - 1);
                    switch (radioButtonName)
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
                break;
            }
            return result;
        }

        private void btnSendFeedback_Click_1(object sender, EventArgs e)
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
                Feedback feedback = new Feedback(q1Result,q2Result,q3Result,q4Result,q5Result);
                feedback.OpenQuestion = txtQuestion6.Text;
                MessageBox.Show("Course feedback has been sent", "Submitted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
            }
            else
            {
                MessageBox.Show("Please select an option for each question before submitting", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
