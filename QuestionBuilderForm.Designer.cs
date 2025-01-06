namespace Thomas_Speich_CPT_185_Final_Project
{
    partial class QuestionBuilderForm
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
            this.questionBuilderTabControl = new System.Windows.Forms.TabControl();
            this.multiChoiceTabPage = new System.Windows.Forms.TabPage();
            this.clearMCQuestionButton = new System.Windows.Forms.Button();
            this.buildMCQuestionButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.correctAnswerDropDownBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.answerCTextBox = new System.Windows.Forms.TextBox();
            this.answerDTextBox = new System.Windows.Forms.TextBox();
            this.answerBTextBox = new System.Windows.Forms.TextBox();
            this.answerATextBox = new System.Windows.Forms.TextBox();
            this.builderMCQuestionTextBox = new System.Windows.Forms.TextBox();
            this.trueFalseTabPage = new System.Windows.Forms.TabPage();
            this.clearTFQuestionButton = new System.Windows.Forms.Button();
            this.buildTFQuestionButton = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.trueFalseAnswerDropDownBox = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.builderTFQuestionTextBox = new System.Windows.Forms.TextBox();
            this.formToolTips = new System.Windows.Forms.ToolTip(this.components);
            this.closeButton = new System.Windows.Forms.Button();
            this.questionBuilderTabControl.SuspendLayout();
            this.multiChoiceTabPage.SuspendLayout();
            this.trueFalseTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // questionBuilderTabControl
            // 
            this.questionBuilderTabControl.Controls.Add(this.multiChoiceTabPage);
            this.questionBuilderTabControl.Controls.Add(this.trueFalseTabPage);
            this.questionBuilderTabControl.Location = new System.Drawing.Point(49, 12);
            this.questionBuilderTabControl.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.questionBuilderTabControl.Name = "questionBuilderTabControl";
            this.questionBuilderTabControl.SelectedIndex = 0;
            this.questionBuilderTabControl.Size = new System.Drawing.Size(687, 483);
            this.questionBuilderTabControl.TabIndex = 1;
            // 
            // multiChoiceTabPage
            // 
            this.multiChoiceTabPage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.multiChoiceTabPage.Controls.Add(this.clearMCQuestionButton);
            this.multiChoiceTabPage.Controls.Add(this.buildMCQuestionButton);
            this.multiChoiceTabPage.Controls.Add(this.label6);
            this.multiChoiceTabPage.Controls.Add(this.correctAnswerDropDownBox);
            this.multiChoiceTabPage.Controls.Add(this.label5);
            this.multiChoiceTabPage.Controls.Add(this.label4);
            this.multiChoiceTabPage.Controls.Add(this.label3);
            this.multiChoiceTabPage.Controls.Add(this.label2);
            this.multiChoiceTabPage.Controls.Add(this.label1);
            this.multiChoiceTabPage.Controls.Add(this.answerCTextBox);
            this.multiChoiceTabPage.Controls.Add(this.answerDTextBox);
            this.multiChoiceTabPage.Controls.Add(this.answerBTextBox);
            this.multiChoiceTabPage.Controls.Add(this.answerATextBox);
            this.multiChoiceTabPage.Controls.Add(this.builderMCQuestionTextBox);
            this.multiChoiceTabPage.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.multiChoiceTabPage.Location = new System.Drawing.Point(4, 24);
            this.multiChoiceTabPage.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.multiChoiceTabPage.Name = "multiChoiceTabPage";
            this.multiChoiceTabPage.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.multiChoiceTabPage.Size = new System.Drawing.Size(679, 455);
            this.multiChoiceTabPage.TabIndex = 0;
            this.multiChoiceTabPage.Text = "Multiple Choice Builder";
            this.multiChoiceTabPage.UseVisualStyleBackColor = true;
            // 
            // clearMCQuestionButton
            // 
            this.clearMCQuestionButton.Location = new System.Drawing.Point(465, 419);
            this.clearMCQuestionButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.clearMCQuestionButton.Name = "clearMCQuestionButton";
            this.clearMCQuestionButton.Size = new System.Drawing.Size(91, 27);
            this.clearMCQuestionButton.TabIndex = 7;
            this.clearMCQuestionButton.Text = "Clear";
            this.formToolTips.SetToolTip(this.clearMCQuestionButton, "Clear all fields");
            this.clearMCQuestionButton.UseVisualStyleBackColor = true;
            this.clearMCQuestionButton.Click += new System.EventHandler(this.clearMCQuestionButton_Click);
            // 
            // buildMCQuestionButton
            // 
            this.buildMCQuestionButton.Location = new System.Drawing.Point(337, 419);
            this.buildMCQuestionButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buildMCQuestionButton.Name = "buildMCQuestionButton";
            this.buildMCQuestionButton.Size = new System.Drawing.Size(121, 27);
            this.buildMCQuestionButton.TabIndex = 6;
            this.buildMCQuestionButton.Text = "Save";
            this.formToolTips.SetToolTip(this.buildMCQuestionButton, "Save this question to the question database");
            this.buildMCQuestionButton.UseVisualStyleBackColor = true;
            this.buildMCQuestionButton.Click += new System.EventHandler(this.buildMCQuestionButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(177, 400);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 15);
            this.label6.TabIndex = 12;
            this.label6.Text = "Correct Answer";
            // 
            // correctAnswerDropDownBox
            // 
            this.correctAnswerDropDownBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.correctAnswerDropDownBox.FormattingEnabled = true;
            this.correctAnswerDropDownBox.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D"});
            this.correctAnswerDropDownBox.Location = new System.Drawing.Point(154, 420);
            this.correctAnswerDropDownBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.correctAnswerDropDownBox.Name = "correctAnswerDropDownBox";
            this.correctAnswerDropDownBox.Size = new System.Drawing.Size(140, 23);
            this.correctAnswerDropDownBox.TabIndex = 5;
            this.formToolTips.SetToolTip(this.correctAnswerDropDownBox, "Choose the correct answer for this question");
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(416, 270);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "Answer D";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(190, 270);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Answer C";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(414, 153);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Answer B";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(190, 153);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Answer A";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(304, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Question";
            // 
            // answerCTextBox
            // 
            this.answerCTextBox.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.answerCTextBox.Location = new System.Drawing.Point(114, 290);
            this.answerCTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.answerCTextBox.MaxLength = 100;
            this.answerCTextBox.Multiline = true;
            this.answerCTextBox.Name = "answerCTextBox";
            this.answerCTextBox.Size = new System.Drawing.Size(215, 84);
            this.answerCTextBox.TabIndex = 3;
            // 
            // answerDTextBox
            // 
            this.answerDTextBox.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.answerDTextBox.Location = new System.Drawing.Point(337, 290);
            this.answerDTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.answerDTextBox.MaxLength = 100;
            this.answerDTextBox.Multiline = true;
            this.answerDTextBox.Name = "answerDTextBox";
            this.answerDTextBox.Size = new System.Drawing.Size(219, 84);
            this.answerDTextBox.TabIndex = 4;
            // 
            // answerBTextBox
            // 
            this.answerBTextBox.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.answerBTextBox.Location = new System.Drawing.Point(338, 173);
            this.answerBTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.answerBTextBox.MaxLength = 100;
            this.answerBTextBox.Multiline = true;
            this.answerBTextBox.Name = "answerBTextBox";
            this.answerBTextBox.Size = new System.Drawing.Size(219, 84);
            this.answerBTextBox.TabIndex = 2;
            // 
            // answerATextBox
            // 
            this.answerATextBox.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.answerATextBox.Location = new System.Drawing.Point(114, 173);
            this.answerATextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.answerATextBox.MaxLength = 100;
            this.answerATextBox.Multiline = true;
            this.answerATextBox.Name = "answerATextBox";
            this.answerATextBox.Size = new System.Drawing.Size(215, 84);
            this.answerATextBox.TabIndex = 1;
            // 
            // builderMCQuestionTextBox
            // 
            this.builderMCQuestionTextBox.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.builderMCQuestionTextBox.Location = new System.Drawing.Point(114, 47);
            this.builderMCQuestionTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.builderMCQuestionTextBox.MaxLength = 255;
            this.builderMCQuestionTextBox.Multiline = true;
            this.builderMCQuestionTextBox.Name = "builderMCQuestionTextBox";
            this.builderMCQuestionTextBox.Size = new System.Drawing.Size(442, 100);
            this.builderMCQuestionTextBox.TabIndex = 0;
            this.builderMCQuestionTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // trueFalseTabPage
            // 
            this.trueFalseTabPage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.trueFalseTabPage.Controls.Add(this.clearTFQuestionButton);
            this.trueFalseTabPage.Controls.Add(this.buildTFQuestionButton);
            this.trueFalseTabPage.Controls.Add(this.label8);
            this.trueFalseTabPage.Controls.Add(this.trueFalseAnswerDropDownBox);
            this.trueFalseTabPage.Controls.Add(this.label7);
            this.trueFalseTabPage.Controls.Add(this.builderTFQuestionTextBox);
            this.trueFalseTabPage.Location = new System.Drawing.Point(4, 24);
            this.trueFalseTabPage.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.trueFalseTabPage.Name = "trueFalseTabPage";
            this.trueFalseTabPage.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.trueFalseTabPage.Size = new System.Drawing.Size(679, 455);
            this.trueFalseTabPage.TabIndex = 1;
            this.trueFalseTabPage.Text = "True/False Builder";
            this.trueFalseTabPage.UseVisualStyleBackColor = true;
            // 
            // clearTFQuestionButton
            // 
            this.clearTFQuestionButton.Location = new System.Drawing.Point(439, 279);
            this.clearTFQuestionButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.clearTFQuestionButton.Name = "clearTFQuestionButton";
            this.clearTFQuestionButton.Size = new System.Drawing.Size(91, 27);
            this.clearTFQuestionButton.TabIndex = 18;
            this.clearTFQuestionButton.Text = "Clear";
            this.formToolTips.SetToolTip(this.clearTFQuestionButton, "Clear the question and correct answer fields");
            this.clearTFQuestionButton.UseVisualStyleBackColor = true;
            this.clearTFQuestionButton.Click += new System.EventHandler(this.clearTFQuestionButton_Click);
            // 
            // buildTFQuestionButton
            // 
            this.buildTFQuestionButton.Location = new System.Drawing.Point(310, 280);
            this.buildTFQuestionButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buildTFQuestionButton.Name = "buildTFQuestionButton";
            this.buildTFQuestionButton.Size = new System.Drawing.Size(121, 27);
            this.buildTFQuestionButton.TabIndex = 17;
            this.buildTFQuestionButton.Text = "Save";
            this.formToolTips.SetToolTip(this.buildTFQuestionButton, "Build this question to save for later");
            this.buildTFQuestionButton.UseVisualStyleBackColor = true;
            this.buildTFQuestionButton.Click += new System.EventHandler(this.buildTFQuestionButton_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(151, 260);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 15);
            this.label8.TabIndex = 16;
            this.label8.Text = "Correct Answer";
            // 
            // trueFalseAnswerDropDownBox
            // 
            this.trueFalseAnswerDropDownBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.trueFalseAnswerDropDownBox.FormattingEnabled = true;
            this.trueFalseAnswerDropDownBox.Items.AddRange(new object[] {
            "True",
            "False"});
            this.trueFalseAnswerDropDownBox.Location = new System.Drawing.Point(127, 280);
            this.trueFalseAnswerDropDownBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.trueFalseAnswerDropDownBox.Name = "trueFalseAnswerDropDownBox";
            this.trueFalseAnswerDropDownBox.Size = new System.Drawing.Size(140, 23);
            this.trueFalseAnswerDropDownBox.TabIndex = 15;
            this.formToolTips.SetToolTip(this.trueFalseAnswerDropDownBox, "Choose if the answer to this question is true or false");
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(304, 105);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 15);
            this.label7.TabIndex = 8;
            this.label7.Text = "Question";
            // 
            // builderTFQuestionTextBox
            // 
            this.builderTFQuestionTextBox.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.builderTFQuestionTextBox.Location = new System.Drawing.Point(113, 126);
            this.builderTFQuestionTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.builderTFQuestionTextBox.MaxLength = 255;
            this.builderTFQuestionTextBox.Multiline = true;
            this.builderTFQuestionTextBox.Name = "builderTFQuestionTextBox";
            this.builderTFQuestionTextBox.Size = new System.Drawing.Size(442, 100);
            this.builderTFQuestionTextBox.TabIndex = 7;
            this.builderTFQuestionTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // closeButton
            // 
            this.closeButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.closeButton.Location = new System.Drawing.Point(349, 501);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 23);
            this.closeButton.TabIndex = 2;
            this.closeButton.Text = "E&xit";
            this.formToolTips.SetToolTip(this.closeButton, "Close this window without saving the question");
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // QuestionBuilderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.CancelButton = this.closeButton;
            this.ClientSize = new System.Drawing.Size(785, 536);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.questionBuilderTabControl);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "QuestionBuilderForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Question Builder";
            this.questionBuilderTabControl.ResumeLayout(false);
            this.multiChoiceTabPage.ResumeLayout(false);
            this.multiChoiceTabPage.PerformLayout();
            this.trueFalseTabPage.ResumeLayout(false);
            this.trueFalseTabPage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl questionBuilderTabControl;
        private System.Windows.Forms.TabPage multiChoiceTabPage;
        private System.Windows.Forms.Button clearMCQuestionButton;
        private System.Windows.Forms.Button buildMCQuestionButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox correctAnswerDropDownBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox answerCTextBox;
        private System.Windows.Forms.TextBox answerDTextBox;
        private System.Windows.Forms.TextBox answerBTextBox;
        private System.Windows.Forms.TextBox answerATextBox;
        private System.Windows.Forms.TextBox builderMCQuestionTextBox;
        private System.Windows.Forms.TabPage trueFalseTabPage;
        private System.Windows.Forms.Button clearTFQuestionButton;
        private System.Windows.Forms.Button buildTFQuestionButton;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox trueFalseAnswerDropDownBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox builderTFQuestionTextBox;
        private System.Windows.Forms.ToolTip formToolTips;
        private System.Windows.Forms.Button closeButton;
    }
}