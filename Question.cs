using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Thomas_Speich_CPT_185_Final_Project
{
    public class Question
    {

        public bool IsMultipleChoice { get; set; }
        public string QuestionText { get; set; }
        public string[] Answers { get; set; }
        public int CorrectAnswer {  get; set; } // Null = -1, A/True = 0, B/False = 1, C = 3, D = 4


        //true/false constructor
        public Question(string questionText, int correctAnswer)
        {
            UpdateQuestion(questionText, correctAnswer);
        }

        //multiple choice constructor
        public Question(string questionText, string answerA, string answerB, string answerC, string answerD, int correctAnswer)
        {
            UpdateQuestion(questionText, answerA, answerB, answerC, answerD, correctAnswer);
        }

        //update true/false question 
        public void UpdateQuestion(string questionText, int correctAnswer)
        {
            QuestionText = questionText;
            Answers = new string[] { "True", "False" };
            CorrectAnswer = correctAnswer;
            IsMultipleChoice = false;
        }

        //update multiple choice question
        public void UpdateQuestion(string questionText, string answerA, string answerB, string answerC, string answerD, int correctAnswer)
        {
            QuestionText = questionText;
            Answers = new string[] { answerA, answerB, answerC, answerD };
            CorrectAnswer = correctAnswer;
            IsMultipleChoice = true;
        }
    }
}
