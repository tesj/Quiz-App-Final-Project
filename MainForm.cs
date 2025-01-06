//Thomas Speich
//CPT-185-A01H
//Final Project
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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void questionFormButton_Click(object sender, EventArgs e)
        {
            try
            {
                QuizBuildForm questionForm = new QuizBuildForm();
                questionForm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void quizFormButton_Click(object sender, EventArgs e)
        {
            try
            {
                QuizMeForm quizMeForm = new QuizMeForm();
                quizMeForm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
