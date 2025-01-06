namespace Thomas_Speich_CPT_185_Final_Project
{
    partial class QuizBuildForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuizBuildForm));
            this.questionPanel = new System.Windows.Forms.Panel();
            this.importQuestionButton = new System.Windows.Forms.Button();
            this.exportQuestionButton = new System.Windows.Forms.Button();
            this.questionLabel = new System.Windows.Forms.Label();
            this.removeQuestionbutton = new System.Windows.Forms.Button();
            this.questionPartOfQuizCheckBox = new System.Windows.Forms.CheckBox();
            this.addQuestionButton = new System.Windows.Forms.Button();
            this.modifyQuestionButton = new System.Windows.Forms.Button();
            this.questionBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.tblQuestionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quizzesDataSet = new Thomas_Speich_CPT_185_Final_Project.QuizzesDataSet();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.tblQuestionDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CorrectAnswerChar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quizPanel = new System.Windows.Forms.Panel();
            this.importQuizButton = new System.Windows.Forms.Button();
            this.exportQuizButton = new System.Windows.Forms.Button();
            this.quizLabel = new System.Windows.Forms.Label();
            this.removeQuizButton = new System.Windows.Forms.Button();
            this.quizBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.tblQuizBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.tblQuizDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.closeButton = new System.Windows.Forms.Button();
            this.tblQuestionTableAdapter = new Thomas_Speich_CPT_185_Final_Project.QuizzesDataSetTableAdapters.tblQuestionTableAdapter();
            this.tableAdapterManager = new Thomas_Speich_CPT_185_Final_Project.QuizzesDataSetTableAdapters.TableAdapterManager();
            this.tblQuizTableAdapter = new Thomas_Speich_CPT_185_Final_Project.QuizzesDataSetTableAdapters.tblQuizTableAdapter();
            this.tblQuizQuestionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblQuizQuestionTableAdapter = new Thomas_Speich_CPT_185_Final_Project.QuizzesDataSetTableAdapters.tblQuizQuestionTableAdapter();
            this.formToolTips = new System.Windows.Forms.ToolTip(this.components);
            this.titleLabel = new System.Windows.Forms.Label();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.questionPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.questionBindingNavigator)).BeginInit();
            this.questionBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblQuestionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quizzesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblQuestionDataGridView)).BeginInit();
            this.quizPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quizBindingNavigator)).BeginInit();
            this.quizBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblQuizBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblQuizDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblQuizQuestionBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // questionPanel
            // 
            this.questionPanel.BackColor = System.Drawing.SystemColors.Control;
            this.questionPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.questionPanel.Controls.Add(this.importQuestionButton);
            this.questionPanel.Controls.Add(this.exportQuestionButton);
            this.questionPanel.Controls.Add(this.questionLabel);
            this.questionPanel.Controls.Add(this.removeQuestionbutton);
            this.questionPanel.Controls.Add(this.questionPartOfQuizCheckBox);
            this.questionPanel.Controls.Add(this.addQuestionButton);
            this.questionPanel.Controls.Add(this.modifyQuestionButton);
            this.questionPanel.Controls.Add(this.questionBindingNavigator);
            this.questionPanel.Controls.Add(this.tblQuestionDataGridView);
            this.questionPanel.Location = new System.Drawing.Point(59, 100);
            this.questionPanel.Name = "questionPanel";
            this.questionPanel.Size = new System.Drawing.Size(682, 342);
            this.questionPanel.TabIndex = 0;
            // 
            // importQuestionButton
            // 
            this.importQuestionButton.Location = new System.Drawing.Point(499, 296);
            this.importQuestionButton.Name = "importQuestionButton";
            this.importQuestionButton.Size = new System.Drawing.Size(80, 40);
            this.importQuestionButton.TabIndex = 10;
            this.importQuestionButton.Text = "&Import Questions";
            this.formToolTips.SetToolTip(this.importQuestionButton, "Import questions from a text file (file must have been created by this app)");
            this.importQuestionButton.UseVisualStyleBackColor = true;
            this.importQuestionButton.Click += new System.EventHandler(this.importQuestionsButton_Click);
            // 
            // exportQuestionButton
            // 
            this.exportQuestionButton.Location = new System.Drawing.Point(585, 295);
            this.exportQuestionButton.Name = "exportQuestionButton";
            this.exportQuestionButton.Size = new System.Drawing.Size(80, 40);
            this.exportQuestionButton.TabIndex = 9;
            this.exportQuestionButton.Text = "&Export All Questions";
            this.formToolTips.SetToolTip(this.exportQuestionButton, "Export all questions to a file for use as a backup or sharing");
            this.exportQuestionButton.UseVisualStyleBackColor = true;
            this.exportQuestionButton.Click += new System.EventHandler(this.exportQuestionButton_Click);
            // 
            // questionLabel
            // 
            this.questionLabel.AutoSize = true;
            this.questionLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.questionLabel.Location = new System.Drawing.Point(314, 25);
            this.questionLabel.Name = "questionLabel";
            this.questionLabel.Size = new System.Drawing.Size(76, 19);
            this.questionLabel.TabIndex = 5;
            this.questionLabel.Text = "Questions";
            // 
            // removeQuestionbutton
            // 
            this.removeQuestionbutton.Location = new System.Drawing.Point(177, 296);
            this.removeQuestionbutton.Name = "removeQuestionbutton";
            this.removeQuestionbutton.Size = new System.Drawing.Size(75, 39);
            this.removeQuestionbutton.TabIndex = 3;
            this.removeQuestionbutton.Text = "&Remove";
            this.formToolTips.SetToolTip(this.removeQuestionbutton, "Remove the highlighted question");
            this.removeQuestionbutton.UseVisualStyleBackColor = true;
            this.removeQuestionbutton.Click += new System.EventHandler(this.removeQuestionbutton_Click);
            // 
            // questionPartOfQuizCheckBox
            // 
            this.questionPartOfQuizCheckBox.AutoSize = true;
            this.questionPartOfQuizCheckBox.Location = new System.Drawing.Point(258, 306);
            this.questionPartOfQuizCheckBox.Name = "questionPartOfQuizCheckBox";
            this.questionPartOfQuizCheckBox.Size = new System.Drawing.Size(200, 19);
            this.questionPartOfQuizCheckBox.TabIndex = 4;
            this.questionPartOfQuizCheckBox.Text = "Question is part of selected quiz";
            this.questionPartOfQuizCheckBox.UseVisualStyleBackColor = true;
            this.questionPartOfQuizCheckBox.Click += new System.EventHandler(this.questionPartOfQuizCheckBox_Click);
            // 
            // addQuestionButton
            // 
            this.addQuestionButton.Location = new System.Drawing.Point(15, 296);
            this.addQuestionButton.Name = "addQuestionButton";
            this.addQuestionButton.Size = new System.Drawing.Size(75, 39);
            this.addQuestionButton.TabIndex = 1;
            this.addQuestionButton.Text = "&Add";
            this.formToolTips.SetToolTip(this.addQuestionButton, "Open a window to create a question to add to the list of questions");
            this.addQuestionButton.UseVisualStyleBackColor = true;
            this.addQuestionButton.Click += new System.EventHandler(this.addQuestionButton_Click);
            // 
            // modifyQuestionButton
            // 
            this.modifyQuestionButton.Location = new System.Drawing.Point(96, 296);
            this.modifyQuestionButton.Name = "modifyQuestionButton";
            this.modifyQuestionButton.Size = new System.Drawing.Size(75, 39);
            this.modifyQuestionButton.TabIndex = 2;
            this.modifyQuestionButton.Text = "&Modify";
            this.formToolTips.SetToolTip(this.modifyQuestionButton, "Open a window to modify the highlighted question");
            this.modifyQuestionButton.UseVisualStyleBackColor = true;
            this.modifyQuestionButton.Click += new System.EventHandler(this.modifyQuestionButton_Click);
            // 
            // questionBindingNavigator
            // 
            this.questionBindingNavigator.AddNewItem = null;
            this.questionBindingNavigator.BindingSource = this.tblQuestionBindingSource;
            this.questionBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.questionBindingNavigator.DeleteItem = null;
            this.questionBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem});
            this.questionBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.questionBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.questionBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.questionBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.questionBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.questionBindingNavigator.Name = "questionBindingNavigator";
            this.questionBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.questionBindingNavigator.Size = new System.Drawing.Size(680, 25);
            this.questionBindingNavigator.TabIndex = 1;
            this.questionBindingNavigator.Text = "Question Navigator";
            // 
            // tblQuestionBindingSource
            // 
            this.tblQuestionBindingSource.DataMember = "tblQuestion";
            this.tblQuestionBindingSource.DataSource = this.quizzesDataSet;
            // 
            // quizzesDataSet
            // 
            this.quizzesDataSet.DataSetName = "QuizzesDataSet";
            this.quizzesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // tblQuestionDataGridView
            // 
            this.tblQuestionDataGridView.AllowUserToAddRows = false;
            this.tblQuestionDataGridView.AutoGenerateColumns = false;
            this.tblQuestionDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblQuestionDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewCheckBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.CorrectAnswerChar});
            this.tblQuestionDataGridView.DataSource = this.tblQuestionBindingSource;
            this.tblQuestionDataGridView.Location = new System.Drawing.Point(15, 70);
            this.tblQuestionDataGridView.MultiSelect = false;
            this.tblQuestionDataGridView.Name = "tblQuestionDataGridView";
            this.tblQuestionDataGridView.ReadOnly = true;
            this.tblQuestionDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tblQuestionDataGridView.Size = new System.Drawing.Size(650, 220);
            this.tblQuestionDataGridView.TabIndex = 0;
            this.tblQuestionDataGridView.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.tblQuestionDataGridView_CellFormatting);
            this.tblQuestionDataGridView.SelectionChanged += new System.EventHandler(this.tblQuestionDataGridView_SelectionChanged);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "QuestionID";
            this.dataGridViewTextBoxColumn1.HeaderText = "QuestionID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "IsMultipleChoice";
            this.dataGridViewCheckBoxColumn1.HeaderText = "IsMultipleChoice";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.ReadOnly = true;
            this.dataGridViewCheckBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Question";
            this.dataGridViewTextBoxColumn2.HeaderText = "Question";
            this.dataGridViewTextBoxColumn2.MaxInputLength = 255;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "AnswerA";
            this.dataGridViewTextBoxColumn3.HeaderText = "Answer A";
            this.dataGridViewTextBoxColumn3.MaxInputLength = 255;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "AnswerB";
            this.dataGridViewTextBoxColumn4.HeaderText = "Answer B";
            this.dataGridViewTextBoxColumn4.MaxInputLength = 255;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "AnswerC";
            this.dataGridViewTextBoxColumn5.HeaderText = "Answer C";
            this.dataGridViewTextBoxColumn5.MaxInputLength = 255;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "AnswerD";
            this.dataGridViewTextBoxColumn6.HeaderText = "Answer D";
            this.dataGridViewTextBoxColumn6.MaxInputLength = 255;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "CorrectAnswer";
            this.dataGridViewTextBoxColumn7.HeaderText = "CorrectAnswer";
            this.dataGridViewTextBoxColumn7.MaxInputLength = 1;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.ToolTipText = "Sets the correct answer to the question (A=0, B=1, C=2, D=3)";
            this.dataGridViewTextBoxColumn7.Visible = false;
            // 
            // CorrectAnswerChar
            // 
            this.CorrectAnswerChar.DataPropertyName = "QuestionID";
            this.CorrectAnswerChar.HeaderText = "Correct Answer";
            this.CorrectAnswerChar.MaxInputLength = 1;
            this.CorrectAnswerChar.Name = "CorrectAnswerChar";
            this.CorrectAnswerChar.ReadOnly = true;
            // 
            // quizPanel
            // 
            this.quizPanel.BackColor = System.Drawing.SystemColors.Control;
            this.quizPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.quizPanel.Controls.Add(this.importQuizButton);
            this.quizPanel.Controls.Add(this.exportQuizButton);
            this.quizPanel.Controls.Add(this.quizLabel);
            this.quizPanel.Controls.Add(this.removeQuizButton);
            this.quizPanel.Controls.Add(this.quizBindingNavigator);
            this.quizPanel.Controls.Add(this.tblQuizDataGridView);
            this.quizPanel.Location = new System.Drawing.Point(740, 100);
            this.quizPanel.Name = "quizPanel";
            this.quizPanel.Size = new System.Drawing.Size(282, 342);
            this.quizPanel.TabIndex = 1;
            // 
            // importQuizButton
            // 
            this.importQuizButton.Location = new System.Drawing.Point(95, 295);
            this.importQuizButton.Name = "importQuizButton";
            this.importQuizButton.Size = new System.Drawing.Size(80, 40);
            this.importQuizButton.TabIndex = 12;
            this.importQuizButton.Text = "I&mport Quiz";
            this.formToolTips.SetToolTip(this.importQuizButton, "Import a quiz from a file (file must have been created by this app)");
            this.importQuizButton.UseVisualStyleBackColor = true;
            this.importQuizButton.Click += new System.EventHandler(this.importQuizButton_Click);
            // 
            // exportQuizButton
            // 
            this.exportQuizButton.Location = new System.Drawing.Point(181, 295);
            this.exportQuizButton.Name = "exportQuizButton";
            this.exportQuizButton.Size = new System.Drawing.Size(80, 40);
            this.exportQuizButton.TabIndex = 11;
            this.exportQuizButton.Text = "Ex&port Quiz";
            this.formToolTips.SetToolTip(this.exportQuizButton, "Export selected quiz for use as a backup or for sharing");
            this.exportQuizButton.UseVisualStyleBackColor = true;
            this.exportQuizButton.Click += new System.EventHandler(this.exportQuizButton_Click);
            // 
            // quizLabel
            // 
            this.quizLabel.AutoSize = true;
            this.quizLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quizLabel.Location = new System.Drawing.Point(114, 25);
            this.quizLabel.Name = "quizLabel";
            this.quizLabel.Size = new System.Drawing.Size(60, 19);
            this.quizLabel.TabIndex = 6;
            this.quizLabel.Text = "Quizzes";
            // 
            // removeQuizButton
            // 
            this.removeQuizButton.Location = new System.Drawing.Point(18, 295);
            this.removeQuizButton.Name = "removeQuizButton";
            this.removeQuizButton.Size = new System.Drawing.Size(69, 40);
            this.removeQuizButton.TabIndex = 1;
            this.removeQuizButton.Text = "R&emove";
            this.formToolTips.SetToolTip(this.removeQuizButton, "Remove the selected quiz");
            this.removeQuizButton.UseVisualStyleBackColor = true;
            this.removeQuizButton.Click += new System.EventHandler(this.removeQuizButton_Click);
            // 
            // quizBindingNavigator
            // 
            this.quizBindingNavigator.AddNewItem = null;
            this.quizBindingNavigator.BindingSource = this.tblQuizBindingSource;
            this.quizBindingNavigator.CountItem = this.toolStripLabel1;
            this.quizBindingNavigator.DeleteItem = null;
            this.quizBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton2,
            this.toolStripButton3,
            this.toolStripSeparator1,
            this.toolStripTextBox1,
            this.toolStripLabel1,
            this.toolStripSeparator2,
            this.toolStripButton4,
            this.toolStripButton5});
            this.quizBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.quizBindingNavigator.MoveFirstItem = this.toolStripButton2;
            this.quizBindingNavigator.MoveLastItem = this.toolStripButton5;
            this.quizBindingNavigator.MoveNextItem = this.toolStripButton4;
            this.quizBindingNavigator.MovePreviousItem = this.toolStripButton3;
            this.quizBindingNavigator.Name = "quizBindingNavigator";
            this.quizBindingNavigator.PositionItem = this.toolStripTextBox1;
            this.quizBindingNavigator.Size = new System.Drawing.Size(280, 25);
            this.quizBindingNavigator.TabIndex = 2;
            this.quizBindingNavigator.Text = "Quiz Navigator";
            // 
            // tblQuizBindingSource
            // 
            this.tblQuizBindingSource.DataMember = "tblQuiz";
            this.tblQuizBindingSource.DataSource = this.quizzesDataSet;
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(35, 22);
            this.toolStripLabel1.Text = "of {0}";
            this.toolStripLabel1.ToolTipText = "Total number of items";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.RightToLeftAutoMirrorImage = true;
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "Move first";
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.RightToLeftAutoMirrorImage = true;
            this.toolStripButton3.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton3.Text = "Move previous";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.AccessibleName = "Position";
            this.toolStripTextBox1.AutoSize = false;
            this.toolStripTextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(50, 23);
            this.toolStripTextBox1.Text = "0";
            this.toolStripTextBox1.ToolTipText = "Current position";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.RightToLeftAutoMirrorImage = true;
            this.toolStripButton4.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton4.Text = "Move next";
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton5.Image")));
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.RightToLeftAutoMirrorImage = true;
            this.toolStripButton5.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton5.Text = "Move last";
            // 
            // tblQuizDataGridView
            // 
            this.tblQuizDataGridView.AutoGenerateColumns = false;
            this.tblQuizDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblQuizDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9});
            this.tblQuizDataGridView.DataSource = this.tblQuizBindingSource;
            this.tblQuizDataGridView.Location = new System.Drawing.Point(18, 70);
            this.tblQuizDataGridView.MultiSelect = false;
            this.tblQuizDataGridView.Name = "tblQuizDataGridView";
            this.tblQuizDataGridView.Size = new System.Drawing.Size(243, 220);
            this.tblQuizDataGridView.TabIndex = 0;
            this.tblQuizDataGridView.SelectionChanged += new System.EventHandler(this.tblQuizDataGridView_SelectionChanged);
            this.tblQuizDataGridView.Validated += new System.EventHandler(this.tblQuizDataGridView_Validated);
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "QuizID";
            this.dataGridViewTextBoxColumn8.HeaderText = "QuizID";
            this.dataGridViewTextBoxColumn8.MaxInputLength = 255;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Visible = false;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "QuizName";
            this.dataGridViewTextBoxColumn9.HeaderText = "Quiz Name";
            this.dataGridViewTextBoxColumn9.MaxInputLength = 255;
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.Width = 200;
            // 
            // closeButton
            // 
            this.closeButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.closeButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeButton.Location = new System.Drawing.Point(400, 483);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(265, 43);
            this.closeButton.TabIndex = 0;
            this.closeButton.Text = "E&xit";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // tblQuestionTableAdapter
            // 
            this.tblQuestionTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tblQuestionTableAdapter = this.tblQuestionTableAdapter;
            this.tableAdapterManager.tblQuizQuestionTableAdapter = null;
            this.tableAdapterManager.tblQuizTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Thomas_Speich_CPT_185_Final_Project.QuizzesDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tblQuizTableAdapter
            // 
            this.tblQuizTableAdapter.ClearBeforeFill = true;
            // 
            // tblQuizQuestionBindingSource
            // 
            this.tblQuizQuestionBindingSource.DataMember = "tblQuizQuestion";
            this.tblQuizQuestionBindingSource.DataSource = this.quizzesDataSet;
            // 
            // tblQuizQuestionTableAdapter
            // 
            this.tblQuizQuestionTableAdapter.ClearBeforeFill = true;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Showcard Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(393, 20);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(272, 40);
            this.titleLabel.TabIndex = 8;
            this.titleLabel.Text = "Create Quizzes";
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.DefaultExt = "txt";
            // 
            // QuizBuildForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.CancelButton = this.closeButton;
            this.ClientSize = new System.Drawing.Size(1084, 561);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.quizPanel);
            this.Controls.Add(this.questionPanel);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "QuizBuildForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quiz Creation";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.QuizBuildForm_FormClosing);
            this.Load += new System.EventHandler(this.QuizBuildForm_Load);
            this.questionPanel.ResumeLayout(false);
            this.questionPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.questionBindingNavigator)).EndInit();
            this.questionBindingNavigator.ResumeLayout(false);
            this.questionBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblQuestionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quizzesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblQuestionDataGridView)).EndInit();
            this.quizPanel.ResumeLayout(false);
            this.quizPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quizBindingNavigator)).EndInit();
            this.quizBindingNavigator.ResumeLayout(false);
            this.quizBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblQuizBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblQuizDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblQuizQuestionBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel questionPanel;
        private QuizzesDataSet quizzesDataSet;
        private System.Windows.Forms.BindingSource tblQuestionBindingSource;
        private QuizzesDataSetTableAdapters.tblQuestionTableAdapter tblQuestionTableAdapter;
        private System.Windows.Forms.BindingNavigator questionBindingNavigator;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.DataGridView tblQuestionDataGridView;
        private QuizzesDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button modifyQuestionButton;
        private System.Windows.Forms.Button addQuestionButton;
        private System.Windows.Forms.Panel quizPanel;
        private System.Windows.Forms.BindingSource tblQuizBindingSource;
        private QuizzesDataSetTableAdapters.tblQuizTableAdapter tblQuizTableAdapter;
        private System.Windows.Forms.DataGridView tblQuizDataGridView;
        private System.Windows.Forms.CheckBox questionPartOfQuizCheckBox;
        private System.Windows.Forms.BindingSource tblQuizQuestionBindingSource;
        private QuizzesDataSetTableAdapters.tblQuizQuestionTableAdapter tblQuizQuestionTableAdapter;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button removeQuestionbutton;
        private System.Windows.Forms.Button removeQuizButton;
        private System.Windows.Forms.BindingNavigator quizBindingNavigator;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.ToolTip formToolTips;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn CorrectAnswerChar;
        private System.Windows.Forms.Label questionLabel;
        private System.Windows.Forms.Label quizLabel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Button exportQuestionButton;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.Button importQuestionButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button exportQuizButton;
        private System.Windows.Forms.Button importQuizButton;
    }
}