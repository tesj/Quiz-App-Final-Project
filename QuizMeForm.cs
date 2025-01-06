using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Thomas_Speich_CPT_185_Final_Project
{
    public partial class QuizMeForm : Form
    {
        Queue<Question> quizQuestions = new Queue<Question>(); //contains questions for an active quiz
        int currentQuestion = 0;
        int totalQuestions = 0;
        int correctAnswers = 0;
        const string ANSWER_CHARS = "ABCD";
        string incorrectAnswers = "";



        public QuizMeForm()
        {
            InitializeComponent();
        }


        private void startQuizButton_Click(object sender, EventArgs e)
        {
            try
            {
                //check if quiz is selected
                if (quizSelectComboBox.SelectedIndex != -1)
                {
                    //make sure quiz list is empty
                    quizQuestions.Clear();

                    //try to load questions
                    try
                    {
                        foreach (DataRow row in tblQuizQuestionTableAdapter.GetQuestionByQuizID(Convert.ToInt32(quizSelectComboBox.SelectedValue)).Rows)
                        {
                            //quiz id - 0
                            //question id - 1
                            //is multiple choice - 2
                            //quiz name - 3
                            //question - 4
                            //a - 5
                            //b - 6
                            //c - 7
                            //d - 8
                            //correct - 9
                            if (Convert.ToBoolean(row[2]))
                            {
                                quizQuestions.Enqueue(new Question(row[4].ToString(), row[5].ToString(), row[6].ToString(),
                                    row[7].ToString(), row[8].ToString(), Convert.ToInt32(row[9])));
                            }
                            else
                            {
                                quizQuestions.Enqueue(new Question(row[4].ToString(), Convert.ToInt32(row[9])));
                            }

                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        return;
                    }
                    //enable/disable controls
                    answerAButton.Enabled = true;
                    answerBButton.Enabled = true;
                    startQuizButton.Enabled = false;

                    //reset values
                    totalQuestions = quizQuestions.Count;
                    incorrectAnswers = "";

                    //start quiz
                    DisplayNextQuestion();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void answerAButton_Click(object sender, EventArgs e)
        {
            CheckAnswer(0);
        }

        private void answerBButton_Click(object sender, EventArgs e)
        {
            CheckAnswer(1);
        }

        private void answerCButton_Click(object sender, EventArgs e)
        {
            CheckAnswer(2);
        }

        private void answerDButton_Click(object sender, EventArgs e)
        {
            CheckAnswer(3);
        }

        private void DisplayNextQuestion()
        {
            try
            {
                //determine what type of question is next
                if (quizQuestions.Peek().IsMultipleChoice)
                {
                    //set the question label
                    questionLabel.Text = quizQuestions.Peek().QuestionText;

                    //set an answers
                    answerAButton.Text = quizQuestions.Peek().Answers[0];

                    answerBButton.Text = quizQuestions.Peek().Answers[1];

                    //make sure buttons C & D are enabled
                    answerCButton.Text = quizQuestions.Peek().Answers[2];
                    answerCButton.Enabled = true;

                    answerDButton.Text = quizQuestions.Peek().Answers[3];
                    answerDButton.Enabled = true;
                }
                else
                {
                    //set the question label
                    questionLabel.Text = quizQuestions.Peek().QuestionText;

                    //set answers
                    answerAButton.Text = quizQuestions.Peek().Answers[0];

                    answerBButton.Text = quizQuestions.Peek().Answers[1];

                    //Clear and disabled C & B
                    answerCButton.ResetText();
                    answerCButton.Enabled = false;

                    answerDButton.ResetText();
                    answerDButton.Enabled = false;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CheckAnswer(int answer)
        {
            try
            {
                //take the current question out of the queue
                Question question = quizQuestions.Dequeue();

                //check if the answer is matches the correct answer
                if (question.CorrectAnswer == answer)
                {
                    MessageBox.Show("Correct!");
                    correctAnswers++;
                }
                else
                {
                    MessageBox.Show("Incorrect");

                    if (question.IsMultipleChoice)
                    {
                        //Show Correct (A, B, C, D) and user's choice (A, B, C, D)
                        incorrectAnswers += $"{question.QuestionText}\nCorrect answer: {ANSWER_CHARS[question.CorrectAnswer]}\nYou answered: {ANSWER_CHARS[answer]}\n\n";
                    }
                    else
                    {
                        incorrectAnswers += $"{question.QuestionText}\nCorrect answer: {question.CorrectAnswer == 0}\n\n";
                    }
                }
                currentQuestion++;

                //check if there's another question
                if (quizQuestions.Count > 0)
                {
                    DisplayNextQuestion();
                    answerAButton.Focus();
                }
                else
                {
                    //clear all text and disable answer buttons
                    questionLabel.ResetText();

                    answerAButton.ResetText();
                    answerAButton.Enabled = false;

                    answerBButton.ResetText();
                    answerBButton.Enabled = false;

                    answerCButton.ResetText();
                    answerCButton.Enabled = false;

                    answerDButton.ResetText();
                    answerDButton.Enabled = false;


                    //Show the score
                    MessageBox.Show($"Score\n{correctAnswers}/{totalQuestions}\n{(double)correctAnswers / (double)totalQuestions * 100:f2}%");

                    startQuizButton.Enabled = true;

                    correctAnswers = 0;
                    totalQuestions = 0;
                    if (!string.IsNullOrEmpty(incorrectAnswers))
                    {
                        //show incorrect answers if there are any
                        MessageBox.Show("Incorrect answers\n" + incorrectAnswers);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void QuizMeForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //warn user of losing progress
            if (quizQuestions.Count > 0 && MessageBox.Show("Are you sure that you want to close this window? (quiz progress will be lost)", "Close Window", MessageBoxButtons.YesNo) == DialogResult.No) 
            {
                //don't close the form if the user clicks no
                e.Cancel = true;
            }
        }

        private void QuizMeForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quizzesDataSet.tblQuizQuestion' table. You can move, or remove it, as needed.
            this.tblQuizQuestionTableAdapter.Fill(this.quizzesDataSet.tblQuizQuestion);
            // TODO: This line of code loads data into the 'quizzesDataSet.tblQuiz' table. You can move, or remove it, as needed.
            this.tblQuizTableAdapter.Fill(this.quizzesDataSet.tblQuiz);

        }
    }
}
