using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Thomas_Speich_CPT_185_Final_Project
{
    public partial class QuestionBuilderForm : Form
    {
        Question newQuestion;

        public QuestionBuilderForm(ref Question question)
        {
            InitializeComponent();
            newQuestion = question;

            //select the appropriate tab and fill in the fields with the question's data
            if (newQuestion.IsMultipleChoice)
            {

                questionBuilderTabControl.SelectedIndex = 0;
                builderMCQuestionTextBox.Text = newQuestion.QuestionText;
                answerATextBox.Text = newQuestion.Answers[0];
                answerBTextBox.Text = newQuestion.Answers[1];
                answerCTextBox.Text = newQuestion.Answers[2];
                answerDTextBox.Text = newQuestion.Answers[3];
                correctAnswerDropDownBox.SelectedIndex = newQuestion.CorrectAnswer;
            }
            else
            {

                questionBuilderTabControl.SelectedIndex = 1;
                builderTFQuestionTextBox.Text = newQuestion.QuestionText;
                trueFalseAnswerDropDownBox.SelectedIndex = newQuestion.CorrectAnswer;
            }
        }

        private void clearMCQuestionButton_Click(object sender, EventArgs e)
        {
            builderMCQuestionTextBox.ResetText();
            answerATextBox.ResetText();
            answerBTextBox.ResetText();
            answerCTextBox.ResetText();
            answerDTextBox.ResetText();
            correctAnswerDropDownBox.SelectedIndex = -1;
        }

        private void buildMCQuestionButton_Click(object sender, EventArgs e)
        {
            try
            {
                //declare variables and assign values
                string questionText = builderMCQuestionTextBox.Text;
                string answerA = answerATextBox.Text;
                string answerB = answerBTextBox.Text;
                string answerC = answerCTextBox.Text;
                string answerD = answerDTextBox.Text;
                int correctAnswer = correctAnswerDropDownBox.SelectedIndex;

                //check for empty text
                if (string.IsNullOrEmpty(questionText) || string.IsNullOrEmpty(answerA) || string.IsNullOrEmpty(answerB) ||
                    string.IsNullOrEmpty(answerC) || string.IsNullOrEmpty(answerD))
                {
                    MessageBox.Show("Please ensure that the question and answers are all filled out");
                    return;
                }

                else
                {
                    //check for a valid correct answer
                    if (correctAnswer != -1)
                    {
                        //change the data in the question
                        newQuestion.UpdateQuestion(questionText, answerA, answerB, answerC, answerD, correctAnswer);

                        //close the form with an OK result
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Please pick a correct answer");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buildTFQuestionButton_Click(object sender, EventArgs e)
        {
            try
            {
                //declare variables and assign values
                string question = builderTFQuestionTextBox.Text;
                int correctAnswer = trueFalseAnswerDropDownBox.SelectedIndex;

                //check if question is empty
                if (string.IsNullOrEmpty(question))
                {
                    MessageBox.Show("Please fill in the question textbox");
                    return;
                }
                else
                {
                    //check if a correct answer is selected
                    if (correctAnswer != -1)
                    {
                        //change the data in the question
                        newQuestion.UpdateQuestion(question, correctAnswer);

                        //close the form with an OK result
                        DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Please select an answer");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void clearTFQuestionButton_Click(object sender, EventArgs e)
        {
            builderTFQuestionTextBox.ResetText();
            trueFalseAnswerDropDownBox.SelectedIndex = -1;
        }


        private void closeButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }    
    }
}
