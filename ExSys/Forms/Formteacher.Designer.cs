namespace ExSys.Forms{
    partial class Formteacher
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Formteacher));
            TeacherTabs = new TabControl();
            tabPage1 = new TabPage();
            groupBox1 = new GroupBox();
            pictureBox1 = new PictureBox();
            label4 = new Label();
            label5 = new Label();
            txtBranch = new TextBox();
            TeacherCourses = new DataGridView();
            txtName = new TextBox();
            Email = new Label();
            txtEmail = new TextBox();
            tabPage3 = new TabPage();
            tabControl1 = new TabControl();
            Question = new TabPage();
            choice4 = new TextBox();
            label13 = new Label();
            choice3 = new TextBox();
            label12 = new Label();
            choice2 = new TextBox();
            label11 = new Label();
            choice1 = new TextBox();
            label10 = new Label();
            CoursesComb = new ComboBox();
            label1 = new Label();
            AddBtn = new Button();
            qType = new Label();
            TxtAnswer = new TextBox();
            QAnswer = new Label();
            RadioMcq = new RadioButton();
            RadioTF = new RadioButton();
            TxtQ = new TextBox();
            questionLbl = new Label();
            tabPage8 = new TabPage();
            ShowCourses = new ComboBox();
            label14 = new Label();
            btnShowQ_Ans = new Button();
            QuestionsAnswers = new DataGridView();
            Reports = new TabPage();
            Exam = new TabPage();
            label9 = new Label();
            label8 = new Label();
            DurationTxt = new TextBox();
            label7 = new Label();
            SelectedCourse = new TextBox();
            label2 = new Label();
            CoursesExam = new ComboBox();
            label3 = new Label();
            branchlbl = new Label();
            TrackExam = new TextBox();
            Generate_Exam = new Button();
            BranchExam = new TextBox();
            btnShowCourses = new Button();
            TeacherTabs.SuspendLayout();
            tabPage1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)TeacherCourses).BeginInit();
            tabPage3.SuspendLayout();
            tabControl1.SuspendLayout();
            Question.SuspendLayout();
            tabPage8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)QuestionsAnswers).BeginInit();
            Exam.SuspendLayout();
            SuspendLayout();
            // 
            // TeacherTabs
            // 
            TeacherTabs.Controls.Add(tabPage1);
            TeacherTabs.Controls.Add(tabPage3);
            TeacherTabs.Controls.Add(Reports);
            TeacherTabs.Controls.Add(Exam);
            TeacherTabs.Dock = DockStyle.Fill;
            TeacherTabs.Location = new Point(0, 0);
            TeacherTabs.Margin = new Padding(3, 2, 3, 2);
            TeacherTabs.Name = "TeacherTabs";
            TeacherTabs.SelectedIndex = 0;
            TeacherTabs.Size = new Size(1213, 591);
            TeacherTabs.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(groupBox1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Margin = new Padding(3, 2, 3, 2);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3, 2, 3, 2);
            tabPage1.Size = new Size(1205, 563);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Profile";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnShowCourses);
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtBranch);
            groupBox1.Controls.Add(TeacherCourses);
            groupBox1.Controls.Add(txtName);
            groupBox1.Controls.Add(Email);
            groupBox1.Controls.Add(txtEmail);
            groupBox1.Location = new Point(388, 115);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(724, 349);
            groupBox1.TabIndex = 13;
            groupBox1.TabStop = false;
            groupBox1.Text = "Profile";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(418, 17);
            pictureBox1.Margin = new Padding(0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(290, 308);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(22, 49);
            label4.Name = "label4";
            label4.Size = new Size(39, 15);
            label4.TabIndex = 2;
            label4.Text = "Name";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(18, 93);
            label5.Name = "label5";
            label5.Size = new Size(44, 15);
            label5.TabIndex = 3;
            label5.Text = "Branch";
            // 
            // txtBranch
            // 
            txtBranch.Location = new Point(139, 93);
            txtBranch.Name = "txtBranch";
            txtBranch.Size = new Size(117, 23);
            txtBranch.TabIndex = 12;
            // 
            // TeacherCourses
            // 
            TeacherCourses.BackgroundColor = SystemColors.Window;
            TeacherCourses.BorderStyle = BorderStyle.None;
            TeacherCourses.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            TeacherCourses.Location = new Point(4, 164);
            TeacherCourses.Margin = new Padding(3, 2, 3, 2);
            TeacherCourses.Name = "TeacherCourses";
            TeacherCourses.RowHeadersWidth = 51;
            TeacherCourses.Size = new Size(374, 141);
            TeacherCourses.TabIndex = 5;
            // 
            // txtName
            // 
            txtName.Location = new Point(113, 46);
            txtName.Name = "txtName";
            txtName.Size = new Size(228, 23);
            txtName.TabIndex = 11;
            // 
            // Email
            // 
            Email.AutoSize = true;
            Email.Location = new Point(18, 17);
            Email.Name = "Email";
            Email.Size = new Size(36, 15);
            Email.TabIndex = 0;
            Email.Text = "Email";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(113, 15);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(228, 23);
            txtEmail.TabIndex = 10;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(tabControl1);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Margin = new Padding(3, 2, 3, 2);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3, 2, 3, 2);
            tabPage3.Size = new Size(1336, 620);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Question";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(Question);
            tabControl1.Controls.Add(tabPage8);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(3, 2);
            tabControl1.Margin = new Padding(0);
            tabControl1.Name = "tabControl1";
            tabControl1.Padding = new Point(0, 0);
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1330, 616);
            tabControl1.TabIndex = 0;
            // 
            // Question
            // 
            Question.Controls.Add(choice4);
            Question.Controls.Add(label13);
            Question.Controls.Add(choice3);
            Question.Controls.Add(label12);
            Question.Controls.Add(choice2);
            Question.Controls.Add(label11);
            Question.Controls.Add(choice1);
            Question.Controls.Add(label10);
            Question.Controls.Add(CoursesComb);
            Question.Controls.Add(label1);
            Question.Controls.Add(AddBtn);
            Question.Controls.Add(qType);
            Question.Controls.Add(TxtAnswer);
            Question.Controls.Add(QAnswer);
            Question.Controls.Add(RadioMcq);
            Question.Controls.Add(RadioTF);
            Question.Controls.Add(TxtQ);
            Question.Controls.Add(questionLbl);
            Question.Location = new Point(4, 24);
            Question.Margin = new Padding(3, 2, 3, 2);
            Question.Name = "Question";
            Question.Padding = new Padding(3, 2, 3, 2);
            Question.Size = new Size(1322, 588);
            Question.TabIndex = 0;
            Question.Text = "Add Question";
            Question.UseVisualStyleBackColor = true;
            // 
            // choice4
            // 
            choice4.Location = new Point(154, 219);
            choice4.Margin = new Padding(3, 2, 3, 2);
            choice4.Name = "choice4";
            choice4.Size = new Size(276, 23);
            choice4.TabIndex = 31;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(24, 221);
            label13.Name = "label13";
            label13.Size = new Size(48, 15);
            label13.TabIndex = 30;
            label13.Text = "choice4";
            // 
            // choice3
            // 
            choice3.Location = new Point(154, 193);
            choice3.Margin = new Padding(3, 2, 3, 2);
            choice3.Name = "choice3";
            choice3.Size = new Size(276, 23);
            choice3.TabIndex = 29;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(24, 195);
            label12.Name = "label12";
            label12.Size = new Size(48, 15);
            label12.TabIndex = 28;
            label12.Text = "choice3";
            // 
            // choice2
            // 
            choice2.Location = new Point(154, 163);
            choice2.Margin = new Padding(3, 2, 3, 2);
            choice2.Name = "choice2";
            choice2.Size = new Size(276, 23);
            choice2.TabIndex = 27;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(24, 165);
            label11.Name = "label11";
            label11.Size = new Size(48, 15);
            label11.TabIndex = 26;
            label11.Text = "choice2";
            // 
            // choice1
            // 
            choice1.Location = new Point(154, 133);
            choice1.Margin = new Padding(3, 2, 3, 2);
            choice1.Name = "choice1";
            choice1.Size = new Size(276, 23);
            choice1.TabIndex = 25;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(24, 135);
            label10.Name = "label10";
            label10.Size = new Size(48, 15);
            label10.TabIndex = 24;
            label10.Text = "choice1";
            // 
            // CoursesComb
            // 
            CoursesComb.FormattingEnabled = true;
            CoursesComb.Location = new Point(164, 95);
            CoursesComb.Margin = new Padding(3, 2, 3, 2);
            CoursesComb.Name = "CoursesComb";
            CoursesComb.Size = new Size(133, 23);
            CoursesComb.TabIndex = 23;
            CoursesComb.SelectedIndexChanged += CoursesComb_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(36, 95);
            label1.Name = "label1";
            label1.Size = new Size(44, 15);
            label1.TabIndex = 21;
            label1.Text = "Course";
            // 
            // AddBtn
            // 
            AddBtn.BackColor = Color.DeepSkyBlue;
            AddBtn.Font = new Font("Rockwell", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AddBtn.ForeColor = Color.White;
            AddBtn.Location = new Point(73, 397);
            AddBtn.Margin = new Padding(0);
            AddBtn.Name = "AddBtn";
            AddBtn.Size = new Size(82, 32);
            AddBtn.TabIndex = 20;
            AddBtn.Text = "Add";
            AddBtn.UseVisualStyleBackColor = false;
            AddBtn.Click += AddBtn_Click;
            // 
            // qType
            // 
            qType.AutoSize = true;
            qType.Location = new Point(59, 263);
            qType.Name = "qType";
            qType.Size = new Size(88, 15);
            qType.TabIndex = 18;
            qType.Tag = " ";
            qType.Text = "Question Type :";
            // 
            // TxtAnswer
            // 
            TxtAnswer.Location = new Point(154, 52);
            TxtAnswer.Margin = new Padding(3, 2, 3, 2);
            TxtAnswer.Name = "TxtAnswer";
            TxtAnswer.Size = new Size(276, 23);
            TxtAnswer.TabIndex = 17;
            // 
            // QAnswer
            // 
            QAnswer.AutoSize = true;
            QAnswer.Location = new Point(24, 55);
            QAnswer.Name = "QAnswer";
            QAnswer.Size = new Size(95, 15);
            QAnswer.TabIndex = 16;
            QAnswer.Text = "Question answer";
            // 
            // RadioMcq
            // 
            RadioMcq.AutoSize = true;
            RadioMcq.Location = new Point(92, 296);
            RadioMcq.Margin = new Padding(3, 2, 3, 2);
            RadioMcq.Name = "RadioMcq";
            RadioMcq.Size = new Size(49, 19);
            RadioMcq.TabIndex = 3;
            RadioMcq.TabStop = true;
            RadioMcq.Text = "Mcq";
            RadioMcq.UseVisualStyleBackColor = true;
            // 
            // RadioTF
            // 
            RadioTF.AutoSize = true;
            RadioTF.Location = new Point(92, 331);
            RadioTF.Margin = new Padding(3, 2, 3, 2);
            RadioTF.Name = "RadioTF";
            RadioTF.Size = new Size(76, 19);
            RadioTF.TabIndex = 2;
            RadioTF.TabStop = true;
            RadioTF.Text = "True/false";
            RadioTF.UseVisualStyleBackColor = true;
            RadioTF.CheckedChanged += RadioTF_CheckedChanged;
            // 
            // TxtQ
            // 
            TxtQ.Location = new Point(154, 15);
            TxtQ.Margin = new Padding(3, 2, 3, 2);
            TxtQ.Multiline = true;
            TxtQ.Name = "TxtQ";
            TxtQ.Size = new Size(276, 26);
            TxtQ.TabIndex = 1;
            // 
            // questionLbl
            // 
            questionLbl.AutoSize = true;
            questionLbl.Location = new Point(24, 26);
            questionLbl.Name = "questionLbl";
            questionLbl.Size = new Size(55, 15);
            questionLbl.TabIndex = 0;
            questionLbl.Text = "Question";
            // 
            // tabPage8
            // 
            tabPage8.Controls.Add(ShowCourses);
            tabPage8.Controls.Add(label14);
            tabPage8.Controls.Add(btnShowQ_Ans);
            tabPage8.Controls.Add(QuestionsAnswers);
            tabPage8.Location = new Point(4, 24);
            tabPage8.Margin = new Padding(3, 2, 3, 2);
            tabPage8.Name = "tabPage8";
            tabPage8.Padding = new Padding(3, 2, 3, 2);
            tabPage8.Size = new Size(1324, 591);
            tabPage8.TabIndex = 2;
            tabPage8.Text = "ViewQuestion";
            tabPage8.UseVisualStyleBackColor = true;
            // 
            // ShowCourses
            // 
            ShowCourses.FormattingEnabled = true;
            ShowCourses.Location = new Point(132, 238);
            ShowCourses.Margin = new Padding(3, 2, 3, 2);
            ShowCourses.Name = "ShowCourses";
            ShowCourses.Size = new Size(133, 23);
            ShowCourses.TabIndex = 7;
            ShowCourses.SelectedIndexChanged += ShowCourses_SelectedIndexChanged;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(62, 240);
            label14.Name = "label14";
            label14.Size = new Size(49, 15);
            label14.TabIndex = 6;
            label14.Text = "Courses";
            // 
            // btnShowQ_Ans
            // 
            btnShowQ_Ans.BackColor = SystemColors.ActiveCaption;
            btnShowQ_Ans.Location = new Point(462, 230);
            btnShowQ_Ans.Margin = new Padding(3, 2, 3, 2);
            btnShowQ_Ans.Name = "btnShowQ_Ans";
            btnShowQ_Ans.Size = new Size(169, 37);
            btnShowQ_Ans.TabIndex = 1;
            btnShowQ_Ans.Text = "ShowQuestionsAnswers";
            btnShowQ_Ans.UseVisualStyleBackColor = false;
            btnShowQ_Ans.Click += button2_Click_1;
            // 
            // QuestionsAnswers
            // 
            QuestionsAnswers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            QuestionsAnswers.Dock = DockStyle.Top;
            QuestionsAnswers.Location = new Point(3, 2);
            QuestionsAnswers.Margin = new Padding(3, 2, 3, 2);
            QuestionsAnswers.Name = "QuestionsAnswers";
            QuestionsAnswers.RowHeadersWidth = 51;
            QuestionsAnswers.Size = new Size(1318, 202);
            QuestionsAnswers.TabIndex = 0;
            // 
            // Reports
            // 
            Reports.Location = new Point(4, 24);
            Reports.Margin = new Padding(3, 2, 3, 2);
            Reports.Name = "Reports";
            Reports.Padding = new Padding(3, 2, 3, 2);
            Reports.Size = new Size(1205, 563);
            Reports.TabIndex = 3;
            Reports.Text = "Reports";
            Reports.UseVisualStyleBackColor = true;
            // 
            // Exam
            // 
            Exam.Controls.Add(label9);
            Exam.Controls.Add(label8);
            Exam.Controls.Add(DurationTxt);
            Exam.Controls.Add(label7);
            Exam.Controls.Add(SelectedCourse);
            Exam.Controls.Add(label2);
            Exam.Controls.Add(CoursesExam);
            Exam.Controls.Add(label3);
            Exam.Controls.Add(branchlbl);
            Exam.Controls.Add(TrackExam);
            Exam.Controls.Add(Generate_Exam);
            Exam.Controls.Add(BranchExam);
            Exam.Location = new Point(4, 24);
            Exam.Margin = new Padding(3, 2, 3, 2);
            Exam.Name = "Exam";
            Exam.Padding = new Padding(3, 2, 3, 2);
            Exam.Size = new Size(1336, 620);
            Exam.TabIndex = 4;
            Exam.Text = "Exam";
            Exam.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(304, 144);
            label9.Name = "label9";
            label9.Size = new Size(141, 15);
            label9.TabIndex = 11;
            label9.Text = "Enter duration in minutes";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(65, 147);
            label8.Name = "label8";
            label8.Size = new Size(53, 15);
            label8.TabIndex = 10;
            label8.Text = "Duration";
            // 
            // DurationTxt
            // 
            DurationTxt.Location = new Point(156, 142);
            DurationTxt.Margin = new Padding(3, 2, 3, 2);
            DurationTxt.Name = "DurationTxt";
            DurationTxt.Size = new Size(110, 23);
            DurationTxt.TabIndex = 9;
            DurationTxt.TextChanged += DurationTxt_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(342, 30);
            label7.Name = "label7";
            label7.Size = new Size(88, 15);
            label7.TabIndex = 8;
            label7.Text = "SelectedCourse";
            // 
            // SelectedCourse
            // 
            SelectedCourse.Location = new Point(451, 28);
            SelectedCourse.Margin = new Padding(3, 2, 3, 2);
            SelectedCourse.Name = "SelectedCourse";
            SelectedCourse.Size = new Size(110, 23);
            SelectedCourse.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(342, 85);
            label2.Name = "label2";
            label2.Size = new Size(66, 15);
            label2.TabIndex = 6;
            label2.Text = "TrackName";
            // 
            // CoursesExam
            // 
            CoursesExam.FormattingEnabled = true;
            CoursesExam.Location = new Point(141, 31);
            CoursesExam.Margin = new Padding(3, 2, 3, 2);
            CoursesExam.Name = "CoursesExam";
            CoursesExam.Size = new Size(133, 23);
            CoursesExam.TabIndex = 5;
            CoursesExam.SelectedIndexChanged += CoursesExam_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(71, 33);
            label3.Name = "label3";
            label3.Size = new Size(49, 15);
            label3.TabIndex = 4;
            label3.Text = "Courses";
            // 
            // branchlbl
            // 
            branchlbl.AutoSize = true;
            branchlbl.Location = new Point(47, 85);
            branchlbl.Name = "branchlbl";
            branchlbl.Size = new Size(76, 15);
            branchlbl.TabIndex = 3;
            branchlbl.Text = "BranchName";
            // 
            // TrackExam
            // 
            TrackExam.Location = new Point(451, 80);
            TrackExam.Margin = new Padding(3, 2, 3, 2);
            TrackExam.Name = "TrackExam";
            TrackExam.Size = new Size(110, 23);
            TrackExam.TabIndex = 2;
            // 
            // Generate_Exam
            // 
            Generate_Exam.Location = new Point(275, 225);
            Generate_Exam.Margin = new Padding(3, 2, 3, 2);
            Generate_Exam.Name = "Generate_Exam";
            Generate_Exam.Size = new Size(140, 22);
            Generate_Exam.TabIndex = 1;
            Generate_Exam.Text = "GenerateExam";
            Generate_Exam.UseVisualStyleBackColor = true;
            Generate_Exam.Click += button2_Click;
            // 
            // BranchExam
            // 
            BranchExam.Location = new Point(156, 85);
            BranchExam.Margin = new Padding(3, 2, 3, 2);
            BranchExam.Name = "BranchExam";
            BranchExam.Size = new Size(110, 23);
            BranchExam.TabIndex = 0;
            // 
            // btnShowCourses
            // 
            btnShowCourses.Location = new Point(200, 153);
            btnShowCourses.Name = "btnShowCourses";
            btnShowCourses.Size = new Size(141, 23);
            btnShowCourses.TabIndex = 13;
            btnShowCourses.Text = "btnShowCourses";
            btnShowCourses.UseVisualStyleBackColor = true;
            btnShowCourses.Click += btnShowCourses_Click;
            // 
            // Formteacher
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.White;
            ClientSize = new Size(1213, 591);
            Controls.Add(TeacherTabs);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "Formteacher";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Formteacher";
            WindowState = FormWindowState.Maximized;
            Load += Formteacher_Load;
            TeacherTabs.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)TeacherCourses).EndInit();
            tabPage3.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
            Question.ResumeLayout(false);
            Question.PerformLayout();
            tabPage8.ResumeLayout(false);
            tabPage8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)QuestionsAnswers).EndInit();
            Exam.ResumeLayout(false);
            Exam.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl TeacherTabs;
        private TabPage tabPage1;
        private TabPage tabPage3;
        private TabPage Reports;
        private Label Email;
        private TabControl tabControl1;
        private TabPage Question;
        private TabPage Exam;
        private TabPage tabPage8;
        private DataGridView TeacherCourses;
        private Label label5;
        private Label label4;
        private Label questionLbl;
        private TextBox TxtQ;
        private RadioButton RadioMcq;
        private Label qType;
        private TextBox TxtAnswer;
        private Label QAnswer;
        private Button AddBtn;
        private RadioButton RadioTF;
        private Panel panel4;
        private Label label1;
        private TextBox txtName;
        private TextBox txtEmail;
        private TextBox textBox4;
        private TextBox txtBranch;
        private ComboBox CoursesComb;
        private TextBox TrackExam;
        private Button Generate_Exam;
        private TextBox BranchExam;
        private ComboBox CoursesExam;
        private Label label3;
        private Label branchlbl;
        private Label label2;
        private Label label7;
        private TextBox SelectedCourse;
        private Label label8;
        private TextBox DurationTxt;
        private Label label9;
        private TextBox choice4;
        private Label label13;
        private TextBox choice3;
        private Label label12;
        private TextBox choice2;
        private Label label11;
        private TextBox choice1;
        private Label label10;
        private Button btnShowQ_Ans;
        private DataGridView QuestionsAnswers;
        private ComboBox ShowCourses;
        private Label label14;
        private PictureBox pictureBox1;
        private GroupBox groupBox1;
        private Button btnShowCourses;
    }
}
