namespace Thomas_Speich_CPT_185_Final_Project
{
    partial class QuizMeForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.quizOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.quizSaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.formToolTips = new System.Windows.Forms.ToolTip(this.components);
            this.answerDButton = new System.Windows.Forms.Button();
            this.answerCButton = new System.Windows.Forms.Button();
            this.answerBButton = new System.Windows.Forms.Button();
            this.answerAButton = new System.Windows.Forms.Button();
            this.startQuizButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.questionLabel = new System.Windows.Forms.Label();
            this.aLabel = new System.Windows.Forms.Label();
            this.bLabel = new System.Windows.Forms.Label();
            this.dLabel = new System.Windows.Forms.Label();
            this.cLabel = new System.Windows.Forms.Label();
            this.quizSelectComboBox = new System.Windows.Forms.ComboBox();
            this.quizBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quizzesDataSet = new Thomas_Speich_CPT_185_Final_Project.QuizzesDataSet();
            this.tblQuizTableAdapter = new Thomas_Speich_CPT_185_Final_Project.QuizzesDataSetTableAdapters.tblQuizTableAdapter();
            this.quizQuestionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblQuizQuestionTableAdapter = new Thomas_Speich_CPT_185_Final_Project.QuizzesDataSetTableAdapters.tblQuizQuestionTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.quizBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quizzesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quizQuestionBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // quizOpenFileDialog
            // 
            this.quizOpenFileDialog.DefaultExt = "txt";
            // 
            // quizSaveFileDialog
            // 
            this.quizSaveFileDialog.DefaultExt = "txt";
            // 
            // answerDButton
            // 
            this.answerDButton.Enabled = false;
            this.answerDButton.Location = new System.Drawing.Point(383, 316);
            this.answerDButton.Name = "answerDButton";
            this.answerDButton.Size = new System.Drawing.Size(215, 84);
            this.answerDButton.TabIndex = 9;
            this.answerDButton.Text = "&D";
            this.formToolTips.SetToolTip(this.answerDButton, "Picks answer D");
            this.answerDButton.UseVisualStyleBackColor = true;
            this.answerDButton.Click += new System.EventHandler(this.answerDButton_Click);
            // 
            // answerCButton
            // 
            this.answerCButton.Enabled = false;
            this.answerCButton.Location = new System.Drawing.Point(110, 316);
            this.answerCButton.Name = "answerCButton";
            this.answerCButton.Size = new System.Drawing.Size(215, 84);
            this.answerCButton.TabIndex = 7;
            this.answerCButton.Text = "&C";
            this.formToolTips.SetToolTip(this.answerCButton, "Picks answer C");
            this.answerCButton.UseVisualStyleBackColor = true;
            this.answerCButton.Click += new System.EventHandler(this.answerCButton_Click);
            // 
            // answerBButton
            // 
            this.answerBButton.Enabled = false;
            this.answerBButton.Location = new System.Drawing.Point(383, 195);
            this.answerBButton.Name = "answerBButton";
            this.answerBButton.Size = new System.Drawing.Size(215, 84);
            this.answerBButton.TabIndex = 6;
            this.answerBButton.Text = "&B";
            this.formToolTips.SetToolTip(this.answerBButton, "Picks answer A or false");
            this.answerBButton.UseVisualStyleBackColor = true;
            this.answerBButton.Click += new System.EventHandler(this.answerBButton_Click);
            // 
            // answerAButton
            // 
            this.answerAButton.Enabled = false;
            this.answerAButton.Location = new System.Drawing.Point(110, 195);
            this.answerAButton.Name = "answerAButton";
            this.answerAButton.Size = new System.Drawing.Size(215, 84);
            this.answerAButton.TabIndex = 5;
            this.answerAButton.Text = "&A";
            this.formToolTips.SetToolTip(this.answerAButton, "Picks answer A or true");
            this.answerAButton.UseVisualStyleBackColor = true;
            this.answerAButton.Click += new System.EventHandler(this.answerAButton_Click);
            // 
            // startQuizButton
            // 
            this.startQuizButton.Location = new System.Drawing.Point(392, 446);
            this.startQuizButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.startQuizButton.Name = "startQuizButton";
            this.startQuizButton.Size = new System.Drawing.Size(88, 27);
            this.startQuizButton.TabIndex = 10;
            this.startQuizButton.Text = "&Start Quiz";
            this.formToolTips.SetToolTip(this.startQuizButton, "Load the selected quiz");
            this.startQuizButton.UseVisualStyleBackColor = true;
            this.startQuizButton.Click += new System.EventHandler(this.startQuizButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(510, 446);
            this.closeButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(88, 27);
            this.closeButton.TabIndex = 11;
            this.closeButton.Text = "Close";
            this.formToolTips.SetToolTip(this.closeButton, "Import a quiz file");
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // questionLabel
            // 
            this.questionLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.questionLabel.Location = new System.Drawing.Point(106, 45);
            this.questionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.questionLabel.Name = "questionLabel";
            this.questionLabel.Size = new System.Drawing.Size(492, 120);
            this.questionLabel.TabIndex = 8;
            this.questionLabel.Text = "Question";
            this.questionLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // aLabel
            // 
            this.aLabel.AutoSize = true;
            this.aLabel.Location = new System.Drawing.Point(209, 179);
            this.aLabel.Name = "aLabel";
            this.aLabel.Size = new System.Drawing.Size(16, 15);
            this.aLabel.TabIndex = 12;
            this.aLabel.Text = "A";
            // 
            // bLabel
            // 
            this.bLabel.AutoSize = true;
            this.bLabel.Location = new System.Drawing.Point(482, 179);
            this.bLabel.Name = "bLabel";
            this.bLabel.Size = new System.Drawing.Size(16, 15);
            this.bLabel.TabIndex = 13;
            this.bLabel.Text = "B";
            // 
            // dLabel
            // 
            this.dLabel.AutoSize = true;
            this.dLabel.Location = new System.Drawing.Point(482, 300);
            this.dLabel.Name = "dLabel";
            this.dLabel.Size = new System.Drawing.Size(16, 15);
            this.dLabel.TabIndex = 15;
            this.dLabel.Text = "D";
            // 
            // cLabel
            // 
            this.cLabel.AutoSize = true;
            this.cLabel.Location = new System.Drawing.Point(209, 300);
            this.cLabel.Name = "cLabel";
            this.cLabel.Size = new System.Drawing.Size(16, 15);
            this.cLabel.TabIndex = 14;
            this.cLabel.Text = "C";
            // 
            // quizSelectComboBox
            // 
            this.quizSelectComboBox.DataSource = this.quizBindingSource;
            this.quizSelectComboBox.DisplayMember = "QuizName";
            this.quizSelectComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.quizSelectComboBox.FormattingEnabled = true;
            this.quizSelectComboBox.Location = new System.Drawing.Point(110, 449);
            this.quizSelectComboBox.Name = "quizSelectComboBox";
            this.quizSelectComboBox.Size = new System.Drawing.Size(221, 23);
            this.quizSelectComboBox.TabIndex = 16;
            this.quizSelectComboBox.ValueMember = "QuizID";
            // 
            // quizBindingSource
            // 
            this.quizBindingSource.DataMember = "tblQuiz";
            this.quizBindingSource.DataSource = this.quizzesDataSet;
            // 
            // quizzesDataSet
            // 
            this.quizzesDataSet.DataSetName = "QuizzesDataSet";
            this.quizzesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblQuizTableAdapter
            // 
            this.tblQuizTableAdapter.ClearBeforeFill = true;
            // 
            // quizQuestionBindingSource
            // 
            this.quizQuestionBindingSource.DataMember = "tblQuizQuestion";
            this.quizQuestionBindingSource.DataSource = this.quizzesDataSet;
            // 
            // tblQuizQuestionTableAdapter
            // 
            this.tblQuizQuestionTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(182, 431);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 15);
            this.label1.TabIndex = 17;
            this.label1.Text = "Select a Quiz";
            // 
            // QuizMeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(726, 518);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.quizSelectComboBox);
            this.Controls.Add(this.dLabel);
            this.Controls.Add(this.cLabel);
            this.Controls.Add(this.bLabel);
            this.Controls.Add(this.aLabel);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.answerDButton);
            this.Controls.Add(this.answerCButton);
            this.Controls.Add(this.answerBButton);
            this.Controls.Add(this.answerAButton);
            this.Controls.Add(this.questionLabel);
            this.Controls.Add(this.startQuizButton);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "QuizMeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thomas\' Quiz App";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.QuizMeForm_FormClosing);
            this.Load += new System.EventHandler(this.QuizMeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.quizBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quizzesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quizQuestionBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog quizOpenFileDialog;
        private System.Windows.Forms.SaveFileDialog quizSaveFileDialog;
        private System.Windows.Forms.ToolTip formToolTips;
        private System.Windows.Forms.Button answerDButton;
        private System.Windows.Forms.Button answerCButton;
        private System.Windows.Forms.Button answerBButton;
        private System.Windows.Forms.Button answerAButton;
        private System.Windows.Forms.Label questionLabel;
        private System.Windows.Forms.Button startQuizButton;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Label aLabel;
        private System.Windows.Forms.Label bLabel;
        private System.Windows.Forms.Label dLabel;
        private System.Windows.Forms.Label cLabel;
        private System.Windows.Forms.ComboBox quizSelectComboBox;
        private QuizzesDataSet quizzesDataSet;
        private System.Windows.Forms.BindingSource quizBindingSource;
        private QuizzesDataSetTableAdapters.tblQuizTableAdapter tblQuizTableAdapter;
        private System.Windows.Forms.BindingSource quizQuestionBindingSource;
        private QuizzesDataSetTableAdapters.tblQuizQuestionTableAdapter tblQuizQuestionTableAdapter;
        private System.Windows.Forms.Label label1;
    }
}

