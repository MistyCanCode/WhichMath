//Misty Tomlin 9-28-18 project 5 Math Class selecter
//This program takes input from two radio buttons and a text box to
//determine whether student can take that class or needs prerequisites

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WhichMathForm
{
    public partial class mathPlacementForm : Form
    {
        public mathPlacementForm()
        {
            InitializeComponent();
        }

        private void calcButton_Click(object sender, EventArgs e)
        {

            //constants for placement tests
            const int Accuplacer = 92;
            const int Act = 19;
            const int Sat = 460;

            //converts string score it an int32 for if statements
            //int score = Convert.ToInt32(scoreTextBox.Text);

            //try catch for validation 
            try
            {
                int score = Convert.ToInt32(scoreTextBox.Text);
                //this if statement checks for the foundations of algebra radio button
                //then it tests for the test taken and the score to see if they are 
                //clear to take foundations of algebra

                //not working
                if (foundationsRadioButton.Checked)
                {
                    if (accuplacerRadioButton.Checked)
                    {
                        if (score >= Accuplacer)
                        {
                            resultTextBox.Text = "Clear to take Foundations of Algebra.";
                        }
                        else
                        {
                            resultTextBox.Text = "Must take Math 1000 and Math 0815.";
                        }
                    }
                }
                else if (foundationsRadioButton.Checked)
                {
                    if (actRadioButton.Checked)
                    {
                        if (score >= Act)
                        {
                            resultTextBox.Text = "Clear to take Foundations of Algebra.";
                        }
                        else
                        {
                            resultTextBox.Text = "Must take Math 1000 and Math 0815.";
                        }
                    }
                }

                else if (foundationsRadioButton.Checked)
                {
                    if (satRadioButton.Checked)
                    {
                        if (score >= Sat)
                        {
                            resultTextBox.Text = "Clear to take Foundations of Algebra.";
                        }

                        else
                        {
                            resultTextBox.Text = "Must take Math 1000 and Math 0815.";
                        }
                    }
                }


                //this section checks for math for liberal arts and then it checks for
                //the test taken and the score in a nested if statement

                //not working
                if (liberalArtsRadioButton.Checked)
                {
                    if (accuplacerRadioButton.Checked)
                    {
                        if (score >= Accuplacer)
                        {
                            resultTextBox.Text = "Clear to take Math for Liberal Arts.";
                        }
                        else
                        {
                            resultTextBox.Text = "Must take Math 1010 and Math 0825.";
                        }
                    }
                }
                else if (liberalArtsRadioButton.Checked)
                {
                    if (actRadioButton.Checked)
                    {
                        if (score >= Act)
                        {
                            resultTextBox.Text = "Clear to take Math for Liberal Arts.";
                        }
                    }
                    else
                    {
                        resultTextBox.Text = "Must take Math 1010 and Math 0825.";
                    }
                }
                else if (liberalArtsRadioButton.Checked)
                {
                    if (satRadioButton.Checked)
                    {
                        if (score >= Sat)
                        {
                            resultTextBox.Text = "Clear to take Math for Liberal Arts.";
                        }
                    }
                    else
                    {
                        resultTextBox.Text = "Must take Math 1010 and Math 0825.";
                    }
                }


                //nested ifs for probability and statistics, and test and score

                //not working
                if (statisticsRadioButton.Checked)
                {
                    if (accuplacerRadioButton.Checked)
                    {
                        if (score >= Accuplacer)
                        {
                            resultTextBox.Text = "Clear to take Probability and Statistics.";
                        }
                    }
                    else
                    {
                        resultTextBox.Text = "Must take Math 1530 & Math 0835.";
                    }
                }
                else if (statisticsRadioButton.Checked)
                {
                    if (actRadioButton.Checked)
                    {
                        if (score >= Act)
                        {
                            resultTextBox.Text = "Clear to take Probability and Statistics.";
                        }
                    }
                    else
                    {
                        resultTextBox.Text = "Must take Math 1530 & Math 0835.";
                    }
                }
                else if (statisticsRadioButton.Checked)
                {
                    if (satRadioButton.Checked)
                    {
                        if (score >= Sat)
                        {
                            resultTextBox.Text = "Clear to take Probability and Stetistics.";
                        }
                    }
                    else
                    {
                        resultTextBox.Text = "Must take Math 1530 & Math 0835.";
                    }
                }


                //nested ifs for finite math, and test and score
                //working
                if (finiteRadioButton.Checked)
                {
                    if (accuplacerRadioButton.Checked)
                    {
                        if (score >= Accuplacer)
                        {
                            resultTextBox.Text = "Clear to take Finite Math.";
                        }
                    }
                    else
                    {
                        resultTextBox.Text = "Must take Math 1630 & Math 0845.";
                    }
                }
                else if (finiteRadioButton.Checked)
                {
                    if (actRadioButton.Checked)
                    {
                        if (score >= Act)
                        {
                            resultTextBox.Text = "Clear to take Finite Math.";
                        }
                    }
                    else
                    {
                        resultTextBox.Text = "Must take Math 1630 & Math 0845.";
                    }
                }
                else if (finiteRadioButton.Checked)
                {
                    if (satRadioButton.Checked)
                    {
                        if (score >= Sat)
                        {
                            resultTextBox.Text = "Clear to take Finite Math.";
                        }
                    }
                    else
                    {
                        resultTextBox.Text = "Must take Math 1630 & Math 0845.";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        

        private void ClearButton_Click(object sender, EventArgs e)
        {
            scoreTextBox.Text = "";
            resultTextBox.Text = "";
            defaultRadioButton1.Checked = true;
            defaultRadioButton2.Checked = true;
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}


        
    

