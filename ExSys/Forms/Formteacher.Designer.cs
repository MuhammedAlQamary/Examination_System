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
            panel4 = new Panel();
            panel3 = new Panel();
            TeacherCourses = new DataGridView();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            pictureBox1 = new PictureBox();
            Email = new Label();
            tabPage3 = new TabPage();
            tabControl1 = new TabControl();
            Question = new TabPage();
            Update = new Button();
            textBox2 = new TextBox();
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
            txtEmail = new TextBox();
            txtName = new TextBox();
            TeacherTabs.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)TeacherCourses).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabPage3.SuspendLayout();
            tabControl1.SuspendLayout();
            Question.SuspendLayout();
            tabPage6.SuspendLayout();
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
            TeacherTabs.Size = new Size(700, 338);
            TeacherTabs.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(txtName);
            tabPage1.Controls.Add(txtEmail);
            tabPage1.Controls.Add(panel4);
            tabPage1.Controls.Add(panel3);
            tabPage1.Controls.Add(TeacherCourses);
            tabPage1.Controls.Add(label6);
            tabPage1.Controls.Add(label5);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(pictureBox1);
            tabPage1.Controls.Add(Email);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Margin = new Padding(3, 2, 3, 2);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3, 2, 3, 2);
            tabPage1.Size = new Size(692, 310);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Profile";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            panel4.Location = new Point(426, 151);
            panel4.Margin = new Padding(3, 2, 3, 2);
            panel4.Name = "panel4";
            panel4.Size = new Size(121, 4);
            panel4.TabIndex = 9;
            // 
            // panel3
            // 
            panel3.Location = new Point(102, 151);
            panel3.Margin = new Padding(3, 2, 3, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(121, 4);
            panel3.TabIndex = 8;
            // 
            // TeacherCourses
            // 
            TeacherCourses.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            TeacherCourses.Dock = DockStyle.Bottom;
            TeacherCourses.Location = new Point(3, 167);
            TeacherCourses.Margin = new Padding(3, 2, 3, 2);
            TeacherCourses.Name = "TeacherCourses";
            TeacherCourses.RowHeadersWidth = 51;
            TeacherCourses.Size = new Size(686, 141);
            TeacherCourses.TabIndex = 5;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(383, 140);
            label6.Name = "label6";
            label6.Size = new Size(34, 15);
            label6.TabIndex = 4;
            label6.Text = "Track";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(42, 140);
            label5.Name = "label5";
            label5.Size = new Size(44, 15);
            label5.TabIndex = 3;
            label5.Text = "Branch";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(239, 83);
            label4.Name = "label4";
            label4.Size = new Size(39, 15);
            label4.TabIndex = 2;
            label4.Text = "Name";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(4, 4);
            pictureBox1.Margin = new Padding(0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(186, 112);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // Email
            // 
            Email.AutoSize = true;
            Email.Location = new Point(239, 40);
            Email.Name = "Email";
            Email.Size = new Size(36, 15);
            Email.TabIndex = 0;
            Email.Text = "Email";
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(tabControl1);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Margin = new Padding(3, 2, 3, 2);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3, 2, 3, 2);
            tabPage3.Size = new Size(692, 310);
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
            tabControl1.Location = new Point(3, 2);
            tabControl1.Margin = new Padding(0);
            tabControl1.Name = "tabControl1";
            tabControl1.Padding = new Point(0, 0);
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(686, 306);
            tabControl1.TabIndex = 0;
            // 
            // Question
            // 
            Question.Controls.Add(Update);
            Question.Controls.Add(textBox2);
            Question.Controls.Add(label1);
            Question.Controls.Add(AddBtn);
            Question.Controls.Add(qType);
            Question.Controls.Add(textBox6);
            Question.Controls.Add(QAnswer);
            Question.Controls.Add(radioButton2);
            Question.Controls.Add(radioButton1);
            Question.Controls.Add(textBox1);
            Question.Controls.Add(questionLbl);
            Question.Location = new Point(4, 24);
            Question.Margin = new Padding(3, 2, 3, 2);
            Question.Name = "Question";
            Question.Padding = new Padding(3, 2, 3, 2);
            Question.Size = new Size(678, 278);
            Question.TabIndex = 0;
            Question.Text = "Add Question";
            Question.UseVisualStyleBackColor = true;
            Question.Click += Question_Click;
            // 
            // Update
            // 
            Update.BackColor = Color.DeepSkyBlue;
            Update.Font = new Font("Rockwell", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Update.ForeColor = Color.White;
            Update.Location = new Point(539, 160);
            Update.Margin = new Padding(0);
            Update.Name = "Update";
            Update.Size = new Size(82, 32);
            Update.TabIndex = 23;
            Update.Text = "Update";
            Update.UseVisualStyleBackColor = false;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(162, 191);
            textBox2.Margin = new Padding(3, 2, 3, 2);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(276, 26);
            textBox2.TabIndex = 22;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 202);
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
            AddBtn.Location = new Point(539, 67);
            AddBtn.Margin = new Padding(0);
            AddBtn.Name = "AddBtn";
            AddBtn.Size = new Size(82, 32);
            AddBtn.TabIndex = 20;
            AddBtn.Text = "Add";
            AddBtn.UseVisualStyleBackColor = false;
            // 
            // qType
            // 
            qType.AutoSize = true;
            qType.Location = new Point(32, 118);
            qType.Name = "qType";
            qType.Size = new Size(88, 15);
            qType.TabIndex = 18;
            qType.Tag = " ";
            qType.Text = "Question Type :";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(154, 56);
            textBox6.Margin = new Padding(3, 2, 3, 2);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(276, 23);
            textBox6.TabIndex = 17;
            // 
            // QAnswer
            // 
            QAnswer.AutoSize = true;
            QAnswer.Location = new Point(24, 58);
            QAnswer.Name = "QAnswer";
            QAnswer.Size = new Size(95, 15);
            QAnswer.TabIndex = 16;
            QAnswer.Text = "Question answer";
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(76, 144);
            radioButton2.Margin = new Padding(3, 2, 3, 2);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(49, 19);
            radioButton2.TabIndex = 3;
            radioButton2.TabStop = true;
            radioButton2.Text = "Mcq";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(201, 144);
            radioButton1.Margin = new Padding(3, 2, 3, 2);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(76, 19);
            radioButton1.TabIndex = 2;
            radioButton1.TabStop = true;
            radioButton1.Text = "True/false";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(154, 15);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(276, 26);
            textBox1.TabIndex = 1;
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
            // tabPage6
            // 
            tabPage6.Controls.Add(button1);
            tabPage6.Location = new Point(4, 24);
            tabPage6.Margin = new Padding(0);
            tabPage6.Name = "tabPage6";
            tabPage6.Padding = new Padding(3, 2, 3, 2);
            tabPage6.Size = new Size(680, 280);
            tabPage6.TabIndex = 1;
            tabPage6.Text = "Update Question";
            tabPage6.UseVisualStyleBackColor = true;
            tabPage6.Click += tabPage6_Click;
            // 
            // button1
            // 
            button1.Location = new Point(346, 65);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(82, 22);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // tabPage8
            // 
            tabPage8.Location = new Point(4, 24);
            tabPage8.Margin = new Padding(3, 2, 3, 2);
            tabPage8.Name = "tabPage8";
            tabPage8.Padding = new Padding(3, 2, 3, 2);
            tabPage8.Size = new Size(680, 280);
            tabPage8.TabIndex = 2;
            tabPage8.Text = "ViewQuestion";
            tabPage8.UseVisualStyleBackColor = true;
            // 
            // Reports
            // 
            Reports.Location = new Point(4, 24);
            Reports.Margin = new Padding(3, 2, 3, 2);
            Reports.Name = "Reports";
            Reports.Padding = new Padding(3, 2, 3, 2);
            Reports.Size = new Size(692, 310);
            Reports.TabIndex = 3;
            Reports.Text = "Reports";
            Reports.UseVisualStyleBackColor = true;
            // 
            // Exam
            // 
            Exam.Location = new Point(4, 24);
            Exam.Margin = new Padding(3, 2, 3, 2);
            Exam.Name = "Exam";
            Exam.Padding = new Padding(3, 2, 3, 2);
            Exam.Size = new Size(692, 310);
            Exam.TabIndex = 4;
            Exam.Text = "Exam";
            Exam.UseVisualStyleBackColor = true;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(352, 37);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(228, 23);
            txtEmail.TabIndex = 10;
            // 
            // txtName
            // 
            txtName.Location = new Point(352, 75);
            txtName.Name = "txtName";
            txtName.Size = new Size(228, 23);
            txtName.TabIndex = 11;
            // 
            // Formteacher
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.White;
            ClientSize = new Size(700, 338);
            Controls.Add(TeacherTabs);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "Formteacher";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Formteacher";
            WindowState = FormWindowState.Maximized;
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
        private Panel panel3;
        private Button Update;
        private TextBox textBox2;
        private Label label1;
        private TextBox txtName;
        private TextBox txtEmail;
    }
}
