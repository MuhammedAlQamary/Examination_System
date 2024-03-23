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
            txtTrack = new TextBox();
            txtBranch = new TextBox();
            txtName = new TextBox();
            txtEmail = new TextBox();
            TeacherCourses = new DataGridView();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            pictureBox1 = new PictureBox();
            Email = new Label();
            tabPage3 = new TabPage();
            tabControl1 = new TabControl();
            Question = new TabPage();
            comboBox1 = new ComboBox();
            label1 = new Label();
            AddBtn = new Button();
            qType = new Label();
            textBox6 = new TextBox();
            QAnswer = new Label();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            textBox1 = new TextBox();
            questionLbl = new Label();
            tabPage6 = new TabPage();
            button1 = new Button();
            tabPage8 = new TabPage();
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
            TeacherTabs.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)TeacherCourses).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabPage3.SuspendLayout();
            tabControl1.SuspendLayout();
            Question.SuspendLayout();
            tabPage6.SuspendLayout();
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
            TeacherTabs.Name = "TeacherTabs";
            TeacherTabs.SelectedIndex = 0;
            TeacherTabs.Size = new Size(800, 451);
            TeacherTabs.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(txtTrack);
            tabPage1.Controls.Add(txtBranch);
            tabPage1.Controls.Add(txtName);
            tabPage1.Controls.Add(txtEmail);
            tabPage1.Controls.Add(TeacherCourses);
            tabPage1.Controls.Add(label6);
            tabPage1.Controls.Add(label5);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(pictureBox1);
            tabPage1.Controls.Add(Email);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(792, 418);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Profile";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // txtTrack
            // 
            txtTrack.Location = new Point(502, 179);
            txtTrack.Margin = new Padding(3, 4, 3, 4);
            txtTrack.Name = "txtTrack";
            txtTrack.Size = new Size(133, 27);
            txtTrack.TabIndex = 13;
            // 
            // txtBranch
            // 
            txtBranch.Location = new Point(121, 179);
            txtBranch.Margin = new Padding(3, 4, 3, 4);
            txtBranch.Name = "txtBranch";
            txtBranch.Size = new Size(133, 27);
            txtBranch.TabIndex = 12;
            // 
            // txtName
            // 
            txtName.Location = new Point(402, 100);
            txtName.Margin = new Padding(3, 4, 3, 4);
            txtName.Name = "txtName";
            txtName.Size = new Size(260, 27);
            txtName.TabIndex = 11;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(402, 49);
            txtEmail.Margin = new Padding(3, 4, 3, 4);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(260, 27);
            txtEmail.TabIndex = 10;
            // 
            // TeacherCourses
            // 
            TeacherCourses.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            TeacherCourses.Dock = DockStyle.Bottom;
            TeacherCourses.Location = new Point(3, 227);
            TeacherCourses.Name = "TeacherCourses";
            TeacherCourses.RowHeadersWidth = 51;
            TeacherCourses.Size = new Size(786, 188);
            TeacherCourses.TabIndex = 5;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(438, 187);
            label6.Name = "label6";
            label6.Size = new Size(43, 20);
            label6.TabIndex = 4;
            label6.Text = "Track";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(48, 187);
            label5.Name = "label5";
            label5.Size = new Size(54, 20);
            label5.TabIndex = 3;
            label5.Text = "Branch";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(273, 111);
            label4.Name = "label4";
            label4.Size = new Size(49, 20);
            label4.TabIndex = 2;
            label4.Text = "Name";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(5, 5);
            pictureBox1.Margin = new Padding(0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(213, 149);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // Email
            // 
            Email.AutoSize = true;
            Email.Location = new Point(273, 53);
            Email.Name = "Email";
            Email.Size = new Size(46, 20);
            Email.TabIndex = 0;
            Email.Text = "Email";
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(tabControl1);
            tabPage3.Location = new Point(4, 29);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(792, 418);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Question";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(Question);
            tabControl1.Controls.Add(tabPage6);
            tabControl1.Controls.Add(tabPage8);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(3, 3);
            tabControl1.Margin = new Padding(0);
            tabControl1.Name = "tabControl1";
            tabControl1.Padding = new Point(0, 0);
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(786, 412);
            tabControl1.TabIndex = 0;
            // 
            // Question
            // 
            Question.Controls.Add(comboBox1);
            Question.Controls.Add(label1);
            Question.Controls.Add(AddBtn);
            Question.Controls.Add(qType);
            Question.Controls.Add(textBox6);
            Question.Controls.Add(QAnswer);
            Question.Controls.Add(radioButton2);
            Question.Controls.Add(radioButton1);
            Question.Controls.Add(textBox1);
            Question.Controls.Add(questionLbl);
            Question.Location = new Point(4, 29);
            Question.Name = "Question";
            Question.Padding = new Padding(3);
            Question.Size = new Size(778, 379);
            Question.TabIndex = 0;
            Question.Text = "Add Question";
            Question.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(188, 127);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 23;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(41, 127);
            label1.Name = "label1";
            label1.Size = new Size(54, 20);
            label1.TabIndex = 21;
            label1.Text = "Course";
            // 
            // AddBtn
            // 
            AddBtn.BackColor = Color.DeepSkyBlue;
            AddBtn.Font = new Font("Rockwell", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AddBtn.ForeColor = Color.White;
            AddBtn.Location = new Point(631, 237);
            AddBtn.Margin = new Padding(0);
            AddBtn.Name = "AddBtn";
            AddBtn.Size = new Size(94, 43);
            AddBtn.TabIndex = 20;
            AddBtn.Text = "Add";
            AddBtn.UseVisualStyleBackColor = false;
            // 
            // qType
            // 
            qType.AutoSize = true;
            qType.Location = new Point(553, 33);
            qType.Name = "qType";
            qType.Size = new Size(110, 20);
            qType.TabIndex = 18;
            qType.Tag = " ";
            qType.Text = "Question Type :";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(176, 70);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(315, 27);
            textBox6.TabIndex = 17;
            // 
            // QAnswer
            // 
            QAnswer.AutoSize = true;
            QAnswer.Location = new Point(27, 73);
            QAnswer.Name = "QAnswer";
            QAnswer.Size = new Size(118, 20);
            QAnswer.TabIndex = 16;
            QAnswer.Text = "Question answer";
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(591, 77);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(59, 24);
            radioButton2.TabIndex = 3;
            radioButton2.TabStop = true;
            radioButton2.Text = "Mcq";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(591, 123);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(95, 24);
            radioButton1.TabIndex = 2;
            radioButton1.TabStop = true;
            radioButton1.Text = "True/false";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(176, 20);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(315, 33);
            textBox1.TabIndex = 1;
            // 
            // questionLbl
            // 
            questionLbl.AutoSize = true;
            questionLbl.Location = new Point(27, 35);
            questionLbl.Name = "questionLbl";
            questionLbl.Size = new Size(68, 20);
            questionLbl.TabIndex = 0;
            questionLbl.Text = "Question";
            // 
            // tabPage6
            // 
            tabPage6.Controls.Add(button1);
            tabPage6.Location = new Point(4, 29);
            tabPage6.Margin = new Padding(0);
            tabPage6.Name = "tabPage6";
            tabPage6.Padding = new Padding(3);
            tabPage6.Size = new Size(778, 379);
            tabPage6.TabIndex = 1;
            tabPage6.Text = "Update Question";
            tabPage6.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(395, 87);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // tabPage8
            // 
            tabPage8.Location = new Point(4, 29);
            tabPage8.Name = "tabPage8";
            tabPage8.Padding = new Padding(3);
            tabPage8.Size = new Size(778, 379);
            tabPage8.TabIndex = 2;
            tabPage8.Text = "ViewQuestion";
            tabPage8.UseVisualStyleBackColor = true;
            // 
            // Reports
            // 
            Reports.Location = new Point(4, 29);
            Reports.Name = "Reports";
            Reports.Padding = new Padding(3);
            Reports.Size = new Size(792, 418);
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
            Exam.Location = new Point(4, 29);
            Exam.Name = "Exam";
            Exam.Padding = new Padding(3);
            Exam.Size = new Size(792, 418);
            Exam.TabIndex = 4;
            Exam.Text = "Exam";
            Exam.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(347, 192);
            label9.Name = "label9";
            label9.Size = new Size(175, 20);
            label9.TabIndex = 11;
            label9.Text = "Enter duration in minutes";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(74, 196);
            label8.Name = "label8";
            label8.Size = new Size(67, 20);
            label8.TabIndex = 10;
            label8.Text = "Duration";
            // 
            // DurationTxt
            // 
            DurationTxt.Location = new Point(178, 189);
            DurationTxt.Name = "DurationTxt";
            DurationTxt.Size = new Size(125, 27);
            DurationTxt.TabIndex = 9;
            DurationTxt.TextChanged += DurationTxt_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(391, 40);
            label7.Name = "label7";
            label7.Size = new Size(111, 20);
            label7.TabIndex = 8;
            label7.Text = "SelectedCourse";
            // 
            // SelectedCourse
            // 
            SelectedCourse.Location = new Point(515, 37);
            SelectedCourse.Name = "SelectedCourse";
            SelectedCourse.Size = new Size(125, 27);
            SelectedCourse.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(391, 113);
            label2.Name = "label2";
            label2.Size = new Size(83, 20);
            label2.TabIndex = 6;
            label2.Text = "TrackName";
            // 
            // CoursesExam
            // 
            CoursesExam.FormattingEnabled = true;
            CoursesExam.Location = new Point(161, 41);
            CoursesExam.Name = "CoursesExam";
            CoursesExam.Size = new Size(151, 28);
            CoursesExam.TabIndex = 5;
            CoursesExam.SelectedIndexChanged += CoursesExam_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(81, 44);
            label3.Name = "label3";
            label3.Size = new Size(60, 20);
            label3.TabIndex = 4;
            label3.Text = "Courses";
            // 
            // branchlbl
            // 
            branchlbl.AutoSize = true;
            branchlbl.Location = new Point(54, 113);
            branchlbl.Name = "branchlbl";
            branchlbl.Size = new Size(94, 20);
            branchlbl.TabIndex = 3;
            branchlbl.Text = "BranchName";
            // 
            // TrackExam
            // 
            TrackExam.Location = new Point(515, 106);
            TrackExam.Name = "TrackExam";
            TrackExam.Size = new Size(125, 27);
            TrackExam.TabIndex = 2;
            // 
            // Generate_Exam
            // 
            Generate_Exam.Location = new Point(314, 300);
            Generate_Exam.Name = "Generate_Exam";
            Generate_Exam.Size = new Size(160, 29);
            Generate_Exam.TabIndex = 1;
            Generate_Exam.Text = "GenerateExam";
            Generate_Exam.UseVisualStyleBackColor = true;
            Generate_Exam.Click += button2_Click;
            // 
            // BranchExam
            // 
            BranchExam.Location = new Point(178, 113);
            BranchExam.Name = "BranchExam";
            BranchExam.Size = new Size(125, 27);
            BranchExam.TabIndex = 0;
            // 
            // Formteacher
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.White;
            ClientSize = new Size(800, 451);
            Controls.Add(TeacherTabs);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Formteacher";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Formteacher";
            WindowState = FormWindowState.Maximized;
            Load += Formteacher_Load;
            TeacherTabs.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)TeacherCourses).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tabPage3.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
            Question.ResumeLayout(false);
            Question.PerformLayout();
            tabPage6.ResumeLayout(false);
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
        private TabPage tabPage6;
        private Button button1;
        private TabPage Exam;
        private TabPage tabPage8;
        private PictureBox pictureBox1;
        private DataGridView TeacherCourses;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label questionLbl;
        private TextBox textBox1;
        private RadioButton radioButton2;
        private Label qType;
        private TextBox textBox6;
        private Label QAnswer;
        private Button AddBtn;
        private RadioButton radioButton1;
        private Panel panel4;
        private Label label1;
        private TextBox txtName;
        private TextBox txtEmail;
        private TextBox textBox4;
        private TextBox txtBranch;
        private TextBox txtTrack;
        private ComboBox comboBox1;
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
    }
}
