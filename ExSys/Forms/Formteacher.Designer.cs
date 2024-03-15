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
            comboBox2 = new ComboBox();
            comboBox1 = new ComboBox();
            panel2 = new Panel();
            panel1 = new Panel();
            TeacherCourses = new DataGridView();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            pictureBox1 = new PictureBox();
            Email = new Label();
            Courses = new TabPage();
            label2 = new Label();
            tabPage3 = new TabPage();
            tabControl1 = new TabControl();
            Question = new TabPage();
            label3 = new Label();
            tabPage6 = new TabPage();
            button1 = new Button();
            tabPage8 = new TabPage();
            Reports = new TabPage();
            Exam = new TabPage();
            TeacherTabs.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)TeacherCourses).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            Courses.SuspendLayout();
            tabPage3.SuspendLayout();
            tabControl1.SuspendLayout();
            Question.SuspendLayout();
            tabPage6.SuspendLayout();
            SuspendLayout();
            // 
            // TeacherTabs
            // 
            TeacherTabs.Controls.Add(tabPage1);
            TeacherTabs.Controls.Add(Courses);
            TeacherTabs.Controls.Add(tabPage3);
            TeacherTabs.Controls.Add(Reports);
            TeacherTabs.Controls.Add(Exam);
            TeacherTabs.Dock = DockStyle.Fill;
            TeacherTabs.Location = new Point(0, 0);
            TeacherTabs.Name = "TeacherTabs";
            TeacherTabs.SelectedIndex = 0;
            TeacherTabs.Size = new Size(800, 450);
            TeacherTabs.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(comboBox2);
            tabPage1.Controls.Add(comboBox1);
            tabPage1.Controls.Add(panel2);
            tabPage1.Controls.Add(panel1);
            tabPage1.Controls.Add(TeacherCourses);
            tabPage1.Controls.Add(label6);
            tabPage1.Controls.Add(label5);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(pictureBox1);
            tabPage1.Controls.Add(Email);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(792, 417);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Profile";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(501, 183);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(151, 28);
            comboBox2.TabIndex = 9;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(144, 178);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 8;
            // 
            // panel2
            // 
            panel2.Location = new Point(372, 126);
            panel2.Name = "panel2";
            panel2.Size = new Size(250, 5);
            panel2.TabIndex = 7;
            // 
            // panel1
            // 
            panel1.Location = new Point(372, 68);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 5);
            panel1.TabIndex = 6;
            // 
            // TeacherCourses
            // 
            TeacherCourses.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            TeacherCourses.Dock = DockStyle.Bottom;
            TeacherCourses.Location = new Point(3, 226);
            TeacherCourses.Name = "TeacherCourses";
            TeacherCourses.RowHeadersWidth = 51;
            TeacherCourses.Size = new Size(786, 188);
            TeacherCourses.TabIndex = 5;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(438, 186);
            label6.Name = "label6";
            label6.Size = new Size(43, 20);
            label6.TabIndex = 4;
            label6.Text = "Track";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(48, 186);
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
            pictureBox1.Location = new Point(5, 6);
            pictureBox1.Margin = new Padding(0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(213, 150);
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
            // Courses
            // 
            Courses.Controls.Add(label2);
            Courses.Location = new Point(4, 29);
            Courses.Name = "Courses";
            Courses.Padding = new Padding(3);
            Courses.Size = new Size(792, 417);
            Courses.TabIndex = 1;
            Courses.Text = "Mycourses";
            Courses.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(263, 137);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 0;
            label2.Text = "label2";
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(tabControl1);
            tabPage3.Location = new Point(4, 29);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(792, 417);
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
            tabControl1.Size = new Size(786, 411);
            tabControl1.TabIndex = 0;
            // 
            // Question
            // 
            Question.Controls.Add(label3);
            Question.Location = new Point(4, 29);
            Question.Name = "Question";
            Question.Padding = new Padding(3);
            Question.Size = new Size(778, 378);
            Question.TabIndex = 0;
            Question.Text = "Add Question";
            Question.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(311, 91);
            label3.Name = "label3";
            label3.Size = new Size(50, 20);
            label3.TabIndex = 0;
            label3.Text = "label3";
            // 
            // tabPage6
            // 
            tabPage6.Controls.Add(button1);
            tabPage6.Location = new Point(4, 29);
            tabPage6.Margin = new Padding(0);
            tabPage6.Name = "tabPage6";
            tabPage6.Padding = new Padding(3);
            tabPage6.Size = new Size(778, 378);
            tabPage6.TabIndex = 1;
            tabPage6.Text = "Update Question";
            tabPage6.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(396, 87);
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
            tabPage8.Size = new Size(778, 378);
            tabPage8.TabIndex = 2;
            tabPage8.Text = "ViewQuestion";
            tabPage8.UseVisualStyleBackColor = true;
            // 
            // Reports
            // 
            Reports.Location = new Point(4, 29);
            Reports.Name = "Reports";
            Reports.Padding = new Padding(3);
            Reports.Size = new Size(792, 417);
            Reports.TabIndex = 3;
            Reports.Text = "Reports";
            Reports.UseVisualStyleBackColor = true;
            // 
            // Exam
            // 
            Exam.Location = new Point(4, 29);
            Exam.Name = "Exam";
            Exam.Padding = new Padding(3);
            Exam.Size = new Size(792, 417);
            Exam.TabIndex = 4;
            Exam.Text = "Exam";
            Exam.UseVisualStyleBackColor = true;
            // 
            // Formteacher
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(TeacherTabs);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Formteacher";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Formteacher";
            WindowState = FormWindowState.Maximized;
            TeacherTabs.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)TeacherCourses).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            Courses.ResumeLayout(false);
            Courses.PerformLayout();
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
        private TabPage Courses;
        private TabPage tabPage3;
        private TabPage Reports;
        private Label Email;
        private TabControl tabControl1;
        private TabPage Question;
        private TabPage tabPage6;
        private Label label2;
        private Label label3;
        private Button button1;
        private TabPage Exam;
        private TabPage tabPage8;
        private PictureBox pictureBox1;
        private DataGridView TeacherCourses;
        private Label label6;
        private Label label5;
        private Label label4;
        private Panel panel1;
        private Panel panel2;
        private ComboBox comboBox2;
        private ComboBox comboBox1;
    }
}
