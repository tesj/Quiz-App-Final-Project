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
    public partial class QuizBuildForm : Form
    {
        const string ANSWER_CHARS = "ABCD";
        public QuizBuildForm()
        {
            InitializeComponent();
        }


        /*
         *
         * Events
         *
         */
        private void QuizBuildForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quizzesDataSet.tblQuizQuestion' table. You can move, or remove it, as needed.
            this.tblQuizQuestionTableAdapter.Fill(this.quizzesDataSet.tblQuizQuestion);
            // TODO: This line of code loads data into the 'quizzesDataSet.tblQuiz' table. You can move, or remove it, as needed.
            this.tblQuizTableAdapter.Fill(this.quizzesDataSet.tblQuiz);
            // TODO: This line of code loads data into the 'quizzesDataSet.tblQuestion' table. You can move, or remove it, as needed.
            this.tblQuestionTableAdapter.Fill(this.quizzesDataSet.tblQuestion);

        }

        private void modifyQuestionButton_Click(object sender, EventArgs e)
        {
            try
            {
                //get the selected record's fields
                DataGridViewCellCollection recordFields = tblQuestionDataGridView.SelectedRows[0].Cells;

                //create a question variable
                Question question;

                //create a question object using the fields in the selected record
                if (Convert.ToBoolean(recordFields[1].Value))
                {
                    question = new Question(recordFields[2].Value.ToString(), recordFields[3].Value.ToString(), recordFields[4].Value.ToString(),
                                                     recordFields[5].Value.ToString(), recordFields[6].Value.ToString(), Convert.ToInt32(recordFields[7].Value));
                }
                else
                {
                    question = new Question(recordFields[2].Value.ToString(), Convert.ToInt32(recordFields[7].Value));
                }

                //create a form object to modify the question in
                QuestionBuilderForm form = new QuestionBuilderForm(ref question);
                try
                {
                    //check if the user confirmed the changes
                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        int newQuestionID = 0;
                        //create a new primary key using the questions, answers, and correct answers
                        if (question.IsMultipleChoice)
                        {
                            newQuestionID = (question.QuestionText + question.Answers[0] + question.Answers[1] +
                                question.Answers[2] + question.Answers[3] + question.CorrectAnswer.ToString()).ToUpper().GetHashCode();
                        }
                        else
                        {
                            newQuestionID = (question.QuestionText + question.Answers[0] + question.Answers[1] +
                                question.CorrectAnswer.ToString()).ToUpper().GetHashCode();
                        }

                        //update the record's fields with the new data
                        FillQuestionRecord(tblQuestionDataGridView.SelectedRows[0].Index, newQuestionID, question);
                    }
                }
                catch (Exception ex)
                {
                    if (ex.GetType() == typeof(ConstraintException))
                    {
                        MessageBox.Show("This question already exists");
                    }
                    else
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void QuizBuildForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //save all changes to database
            CommitAll();
        }

        private void addQuestionButton_Click(object sender, EventArgs e)
        {
            try
            {
                //create a question object
                Question question = new Question("Question", "A", "B", "C", "D", 0);

                //create a form object to modify the question with
                QuestionBuilderForm form = new QuestionBuilderForm(ref question);

                //Check if user confirmed the changes
                if (form.ShowDialog() == DialogResult.OK)
                {
                    int newQuestionID = 0;
                    //generate a new primary key based on questions, answers, and correct answer
                    if (question.Answers.Length == 4)
                    {
                        newQuestionID = (question.QuestionText + question.Answers[0] + question.Answers[1] +
                            question.Answers[2] + question.Answers[3] + question.CorrectAnswer.ToString()).ToUpper().GetHashCode();
                    }
                    else
                    {
                        newQuestionID = (question.QuestionText + question.Answers[0] + question.Answers[1] +
                            question.CorrectAnswer.ToString()).ToUpper().GetHashCode();
                    }

                    //check if a record exists with the new primary key
                    try
                    {
                        //add new record and get its index
                        tblQuestionBindingSource.AddNew();
                        int rowIndex = tblQuestionDataGridView.Rows.Count - 1;

                        //fill in the fields of the new record
                        FillQuestionRecord(rowIndex, newQuestionID, question);

                        //go to new (last) item
                        bindingNavigatorMoveLastItem.PerformClick();
                        questionPartOfQuizCheckBox.Checked = false;
                    }
                    catch (Exception ex)
                    {
                        if (ex.GetType() == typeof(ConstraintException))
                        {
                            MessageBox.Show("This question already exists");
                        }
                        else
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void tblQuestionDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            CheckQuizForQuestion();
        }

        private void tblQuizDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            CheckQuizForQuestion();
        }

        private void questionPartOfQuizCheckBox_Click(object sender, EventArgs e)
        {
            try
            {
                //check if a questiion and quiz is selected
                if (tblQuestionDataGridView.SelectedRows.Count > 0 && tblQuizDataGridView.SelectedCells.Count > 0)
                {
                    //get question and quiz IDS
                    int questionID = Convert.ToInt32(tblQuestionDataGridView.CurrentRow.Cells[0].Value);
                    int quizID = Convert.ToInt32(tblQuizDataGridView.CurrentRow.Cells[0].Value);

                    //check if a record exists
                    if (tblQuizQuestionTableAdapter.GetRecordByIDs(quizID, questionID).Count > 0)
                    {
                        //delete the link
                        tblQuizQuestionTableAdapter.Delete(quizID, questionID);
                    }
                    else
                    {
                        //create a m:n relationship between the quiz and question
                        try
                        {
                            CommitQuizQuestions();

                            tblQuizQuestionTableAdapter.Insert(quizID, questionID);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                            string temp = "\n";
                            foreach (DataGridViewRow row in tblQuizDataGridView.Rows)
                            {
                                temp += $"{row.Cells[0].Value}\n";
                            }
                            MessageBox.Show($"{quizID}{temp}");
                        }
                    }

                    //save changes
                    CommitQuizQuestions();
                }
                else
                {
                    //set checkbox to unchecked
                    questionPartOfQuizCheckBox.Checked = false;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void removeQuestionbutton_Click(object sender, EventArgs e)
        {
            try
            {
                //check if a row is selected
                if (tblQuestionDataGridView.CurrentRow != null)
                {
                    //confirm that the user wants to remove the question
                    if (MessageBox.Show("Are you sure you want to remove the highlighted question?\nIt will be lost forever", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        tblQuestionBindingSource.RemoveAt(tblQuestionDataGridView.CurrentRow.Index);
                        CommitQuestions();
                        CommitQuizQuestions();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void removeQuizButton_Click(object sender, EventArgs e)
        {
            try
            {
                //check if a row is selected
                if (tblQuizDataGridView.CurrentRow != null)
                {
                    //confirm that the user wants to remove the question
                    if (MessageBox.Show("Are you sure you want to remove the highlighted quiz?\nIt will be lost forever", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        tblQuizBindingSource.RemoveAt(tblQuizDataGridView.CurrentRow.Index);
                        CommitQuizzes();
                        CommitQuizQuestions();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void tblQuestionDataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            try
            {
                //if the cell is not in the correct answer display column, return
                if (e.ColumnIndex != 8)
                {
                    return;
                }
                //set the display value to the corresponding character
                e.Value = ANSWER_CHARS[Convert.ToInt32(tblQuestionDataGridView.Rows[e.RowIndex].Cells[7].Value)];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void tblQuizDataGridView_Validated(object sender, EventArgs e)
        {
            CommitQuizzes();
        }

        private void exportQuestionButton_Click(object sender, EventArgs e)
        {
            try
            {
                //check if file is selected
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //open file
                    StreamWriter outQuestions = new StreamWriter(saveFileDialog.FileName);

                    //write questions to file
                    foreach (DataRow row in tblQuestionTableAdapter.GetData())
                    {
                        outQuestions.WriteLine($"{row[0]}#{row[1]}#{row[2]}#{row[3]}#"
                            + $"{row[4]}#{row[5]}#{row[6]}#{row[7]}");
                    }
                    //close file
                    outQuestions.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void importQuestionsButton_Click(object sender, EventArgs e)
        {
            try
            {
                //check if file is selected
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //open file and declare flag
                    StreamReader inQuestion = new StreamReader(openFileDialog.FileName);
                    bool errorsWhileImporting = false;

                    //read every line
                    while (!inQuestion.EndOfStream)
                    {
                        //declare string array that contains the data for the current line's question
                        string[] data = inQuestion.ReadLine().Split('#');

                        //check if the corrent number of fields are present in the line
                        if (data.Length == 8)
                        {
                            //try to parse an ID
                            if (!int.TryParse(data[0], out int id)) continue;
                            //try to parse a correct answer
                            if (!int.TryParse(data[7], out int correctAnswer)) continue;

                            //create question variable
                            Question question;

                            //determine constructor for question object
                            if (Convert.ToBoolean(data[1]))
                            {
                                question = new Question(data[2], data[3], data[4], data[5], data[6], correctAnswer);
                            }
                            else
                            {
                                question = new Question(data[2], correctAnswer);
                            }

                            //try to add question to table
                            try
                            {
                                //add new record and get its index
                                tblQuestionBindingSource.AddNew();
                                int rowIndex = tblQuestionDataGridView.Rows.Count - 1;

                                //fill in the fields of the new record
                                FillQuestionRecord(rowIndex, id, question);

                                //go to new (last) item
                                bindingNavigatorMoveLastItem.PerformClick();
                                questionPartOfQuizCheckBox.Checked = false;
                            }
                            catch (Exception ex)
                            {
                                //set error flag to true
                                errorsWhileImporting = true;

                                //handle duplicate foreign key error
                                if (ex.GetType() == typeof(System.Data.ConstraintException))
                                {
                                    tblQuestionDataGridView.Rows.Remove(tblQuestionDataGridView.CurrentRow);
                                    continue;
                                }

                                //show exception if unexpected
                                MessageBox.Show(ex.Message);
                            }
                        }
                        //set error flag to true because there is a different number of fields than expected
                        else
                        {
                            errorsWhileImporting = true;
                        }
                    }
                    //save questions table
                    CommitQuestions();

                    //show a message if there was an error
                    if (errorsWhileImporting)
                    {
                        MessageBox.Show("Some errors occured while importing data\nSome data in the file may not have been successfully imported");
                    }

                    //close question file
                    inQuestion.Close();
                }
            }
            catch (Exception ex)
            {
                //general unexpected errors in event
                MessageBox.Show(ex.Message);
            }
        }

        private void exportQuizButton_Click(object sender, EventArgs e)
        {
            //safety net for event
            try
            {
                //check if a quiz is selected
                if (tblQuizDataGridView.CurrentRow != null)
                {
                    //check if a file is selected or created
                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        //declare a file object and a list of question IDs
                        StreamWriter outQuiz = new StreamWriter(saveFileDialog.FileName);
                        List<int> questionIDs = new List<int>();

                        outQuiz.WriteLine($"{tblQuizDataGridView.CurrentRow.Cells[1].Value}");

                        //try reading selected quiz record
                        try
                        {
                            foreach (DataRow row in tblQuizQuestionTableAdapter.GetQuestionByQuizID(Convert.ToInt32(tblQuizDataGridView.CurrentRow.Cells[0].Value)))
                            {
                                //indices values
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

                                //write question info and add question ID to list
                                outQuiz.WriteLine($"{row[1]}#{row[2]}#{row[4]}#{row[5]}#{row[6]}#{row[7]}#{row[8]}#{row[9]}");
                                questionIDs.Add(Convert.ToInt32(row[1]));
                            }
                        }
                        catch (Exception ex)
                        {
                            //catch any errors
                            MessageBox.Show(ex.Message);
                        }

                        outQuiz.Close();
                    }

                }
                else
                {
                    MessageBox.Show("Please select a quiz to export");
                }
            }
            catch (Exception ex)
            {
                //catch general errors
                MessageBox.Show(ex.Message);
            }
        }

        private void importQuizButton_Click(object sender, EventArgs e)
        {
            try
            {
                //check if user selected file
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //create file object and error flag
                    StreamReader inQuiz = new StreamReader(openFileDialog.FileName);
                    bool errorsWhileImporting = false;

                    //create arrays for quiz data and line data
                    string[] quizData = inQuiz.ReadLine().Split('#');
                    string[] lineData;

                    //check if there is 1 field on the first line
                    if (quizData.Length != 1)
                    {
                        //close file, show message, and end event
                        inQuiz.Close();
                        MessageBox.Show("Quiz file not in correct format");
                        return;
                    }

                    //try to add quiz to tblQuiz
                    try
                    {
                        int rowIndex = tblQuizDataGridView.Rows.Count - 1;
                        FillQuizRecord(rowIndex, quizData[0]);
                    }
                    catch (Exception ex)
                    {
                        //display error message
                        MessageBox.Show(ex.Message);
                        return;
                    }

                    //get quizID
                    int quizID = tblQuizTableAdapter.GetData().Last().QuizID;

                    //create flag for reading in question
                    while (!inQuiz.EndOfStream)
                    {

                        lineData = inQuiz.ReadLine().Split('#');


                        if (lineData.Length == 8)
                        {
                            if (!int.TryParse(lineData[0], out int questionID)) continue;
                            if (!int.TryParse(lineData[7], out int correctAnswer)) continue;
                            Question question;
                            if (Convert.ToBoolean(lineData[1]))
                            {
                                question = new Question(lineData[2], lineData[3], lineData[4], lineData[5], lineData[6], correctAnswer);
                            }
                            else
                            {
                                question = new Question(lineData[2], correctAnswer);
                            }

                            try
                            {
                                //add new record and get its index
                                tblQuestionBindingSource.AddNew();
                                int rowIndex = tblQuestionDataGridView.Rows.Count - 1;

                                //fill in the fields of the new record
                                FillQuestionRecord(rowIndex, questionID, question);
                            }
                            catch (Exception ex)
                            {
                                //set error flag to true
                                errorsWhileImporting = true;

                                //handle duplicates primary key
                                if (ex.GetType() == typeof(System.Data.ConstraintException))
                                {
                                    //tblQuestionDataGridView.Rows.Remove(tblQuestionDataGridView.CurrentRow);

                                    tblQuestionBindingSource.Remove(tblQuestionBindingSource.Current);
                                    //continue;
                                }
                                MessageBox.Show(ex.Message);
                            }

                            try
                            {
                                //create m:n relationship between quiz and question
                                tblQuizQuestionTableAdapter.Insert(quizID, questionID);
                            }
                            catch (Exception ex)
                            {
                                //set error flag to true and display error if unexpected
                                errorsWhileImporting = true;
                                if (ex.GetType() != typeof(System.Data.ConstraintException))
                                {
                                    MessageBox.Show(ex.Message);
                                }
                            }

                        }
                        else
                        {
                            //set error flag to true if unexpected number of fields in line
                            errorsWhileImporting = true;
                        }
                    }
                    //save changes to tables
                    CommitQuestions();
                    CommitQuizQuestions();

                    //display that there were errors if necessary
                    if (errorsWhileImporting)
                    {
                        MessageBox.Show("Some errors occured while importing data\nSome data in the file may not have been successfully imported");
                    }

                    //close quiz file
                    inQuiz.Close();
                }
            }
            catch (Exception ex)
            { 
                //safety net
                MessageBox.Show(ex.Message);
            }
        }


        /*
         *
         * My methods
         *
         */
        private void FillQuestionRecord(int index, int newQuestionID, Question question)
        {
            //fill all fields
            tblQuestionDataGridView.Rows[index].Cells[0].Value = newQuestionID;
            tblQuestionDataGridView.Rows[index].Cells[1].Value = question.IsMultipleChoice;
            tblQuestionDataGridView.Rows[index].Cells[2].Value = question.QuestionText;
            tblQuestionDataGridView.Rows[index].Cells[3].Value = question.Answers[0];
            tblQuestionDataGridView.Rows[index].Cells[4].Value = question.Answers[1];
            if (question.IsMultipleChoice) // fill answers c and d if necessary
            {
                tblQuestionDataGridView.Rows[index].Cells[5].Value = question.Answers[2];
                tblQuestionDataGridView.Rows[index].Cells[6].Value = question.Answers[3];
            }
            tblQuestionDataGridView.Rows[index].Cells[7].Value = question.CorrectAnswer;

            //save changes
            CommitQuestions();
        }

        private void FillQuizRecord(int index, string quizName)
        {
            tblQuizBindingSource.AddNew();
            //fill all fields
            tblQuizDataGridView.Rows[index].Cells[1].Value = quizName;

            //save changes
            CommitQuizzes();
        }

        private void CheckQuizForQuestion()
        {
            try
            {
                //check that a record is selected from quiz and question
                if (tblQuestionDataGridView.SelectedRows.Count > 0 && tblQuizDataGridView.SelectedCells.Count > 0)
                {
                    //get index of quiz record
                    int index = tblQuizDataGridView.SelectedCells[0].RowIndex;

                    //check for nulls (happens when adding new question)
                    if (tblQuestionDataGridView.SelectedRows[0].Cells[0].Value != DBNull.Value &&
                        tblQuizDataGridView.Rows[index].Cells[0].Value != DBNull.Value)
                    {
                        //get question and quiz IDs
                        int questionID = Convert.ToInt32(tblQuestionDataGridView.SelectedRows[0].Cells[0].Value);
                        int quizID = Convert.ToInt32(tblQuizDataGridView.Rows[tblQuizDataGridView.SelectedCells[0].RowIndex].Cells[0].Value);

                        //check if a relationship exists for the quiz and question
                        if (tblQuizQuestionTableAdapter.GetRecordByIDs(quizID, questionID).Count > 0)
                        {
                            questionPartOfQuizCheckBox.Checked = true;
                        }
                        else
                        {
                            questionPartOfQuizCheckBox.Checked = false;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void CommitQuestions()
        {
            //try to save tblQuestions
            try
            {
                tblQuestionBindingSource.EndEdit();
                tblQuestionTableAdapter.Update(quizzesDataSet.tblQuestion);
            }
            catch (Exception ex)
            {
                if (ex.GetType() == typeof(ConstraintException))
                {
                    tblQuestionBindingSource.Remove(tblQuestionBindingSource.Current);
                    return;
                }
                MessageBox.Show(ex.Message);
            }
        }

        private void CommitQuizzes()
        {
            //try to save tblQuiz
            try
            {
                tblQuizBindingSource.EndEdit();
                tblQuizTableAdapter.Update(quizzesDataSet.tblQuiz);
            }
            catch (Exception ex)
            {
                if (ex.GetType() == typeof(ConstraintException))
                {
                    tblQuizBindingSource.Remove(tblQuizBindingSource.Current);
                    return;
                }
                MessageBox.Show(ex.Message);
            }
        }

        private void CommitQuizQuestions()
        {
            //try to save tblQuizQuestions
            try
            {
                tblQuizQuestionBindingSource.EndEdit();
                tblQuizQuestionTableAdapter.Update(quizzesDataSet.tblQuizQuestion);
            }
            catch (Exception ex)
            {
                if (ex.GetType() == typeof(ConstraintException))
                {
                    tblQuizQuestionBindingSource.Remove(tblQuizQuestionBindingSource.Current);
                    return;
                }
                MessageBox.Show(ex.Message);
            }
        }

        private void CommitAll()
        {
            //save all tables
            CommitQuestions();
            CommitQuizzes();
            CommitQuizQuestions();
        }

    }


}
