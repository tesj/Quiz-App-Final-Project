namespace Thomas_Speich_CPT_185_Final_Project
{
    partial class MainForm
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
            this.questionFormButton = new System.Windows.Forms.Button();
            this.formToolTips = new System.Windows.Forms.ToolTip(this.components);
            this.quizFormButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // questionFormButton
            // 
            this.questionFormButton.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.questionFormButton.Location = new System.Drawing.Point(146, 166);
            this.questionFormButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.questionFormButton.Name = "questionFormButton";
            this.questionFormButton.Size = new System.Drawing.Size(177, 42);
            this.questionFormButton.TabIndex = 4;
            this.questionFormButton.Text = "Create Quizzes";
            this.formToolTips.SetToolTip(this.questionFormButton, "Opens a window that allows you to create new questions");
            this.questionFormButton.UseVisualStyleBackColor = true;
            this.questionFormButton.Click += new System.EventHandler(this.questionFormButton_Click);
            // 
            // quizFormButton
            // 
            this.quizFormButton.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quizFormButton.Location = new System.Drawing.Point(351, 166);
            this.quizFormButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.quizFormButton.Name = "quizFormButton";
            this.quizFormButton.Size = new System.Drawing.Size(177, 42);
            this.quizFormButton.TabIndex = 5;
            this.quizFormButton.Text = "Quiz Me";
            this.formToolTips.SetToolTip(this.quizFormButton, "Opens a window that allows you to take a quiz");
            this.quizFormButton.UseVisualStyleBackColor = true;
            this.quizFormButton.Click += new System.EventHandler(this.quizFormButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Location = new System.Drawing.Point(246, 248);
            this.exitButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(177, 42);
            this.exitButton.TabIndex = 6;
            this.exitButton.Text = "E&xit";
            this.formToolTips.SetToolTip(this.exitButton, "Opens a window that allows you to take a quiz");
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(179, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(308, 40);
            this.label1.TabIndex = 7;
            this.label1.Text = "Thomas\' Quiz App";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(667, 370);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.quizFormButton);
            this.Controls.Add(this.questionFormButton);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thomas\' Quiz App";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolTip formToolTips;
        private System.Windows.Forms.Button questionFormButton;
        private System.Windows.Forms.Button quizFormButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label label1;
    }
}

