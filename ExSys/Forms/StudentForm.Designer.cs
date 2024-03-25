namespace ExSys.Forms
{
    partial class StudentForm
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentForm));
            tabControlStudentForm = new TabControl();
            TabStdDet1 = new TabPage();
            groupBoxStdDet = new GroupBox();
            btnShowReports = new Button();
            button1 = new Button();
            LBLBranchName = new Label();
            label8 = new Label();
            LBLStudentCrsDegree = new Label();
            label4 = new Label();
            comboBoxStdCrs = new ComboBox();
            label3 = new Label();
            LBLStudentTrack = new Label();
            label2 = new Label();
            LBLStudentName = new Label();
            label1 = new Label();
            TabStdDet2 = new TabPage();
            groupBox1 = new GroupBox();
            panelExam = new Panel();
            groupBoxStartExam = new GroupBox();
            buttonStartExam = new Button();
            comboBoxCrsExam = new ComboBox();
            label5 = new Label();
            courseBindingSource = new BindingSource(components);
            button2 = new Button();
            tabControlStudentForm.SuspendLayout();
            TabStdDet1.SuspendLayout();
            groupBoxStdDet.SuspendLayout();
            TabStdDet2.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBoxStartExam.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)courseBindingSource).BeginInit();
            SuspendLayout();
            // 
            // tabControlStudentForm
            // 
            tabControlStudentForm.Controls.Add(TabStdDet1);
            tabControlStudentForm.Controls.Add(TabStdDet2);
            resources.ApplyResources(tabControlStudentForm, "tabControlStudentForm");
            tabControlStudentForm.Name = "tabControlStudentForm";
            tabControlStudentForm.SelectedIndex = 0;
            // 
            // TabStdDet1
            // 
            TabStdDet1.Controls.Add(groupBoxStdDet);
            resources.ApplyResources(TabStdDet1, "TabStdDet1");
            TabStdDet1.Name = "TabStdDet1";
            TabStdDet1.UseVisualStyleBackColor = true;
            // 
            // groupBoxStdDet
            // 
            groupBoxStdDet.Controls.Add(button2);
            groupBoxStdDet.Controls.Add(btnShowReports);
            groupBoxStdDet.Controls.Add(button1);
            groupBoxStdDet.Controls.Add(LBLBranchName);
            groupBoxStdDet.Controls.Add(label8);
            groupBoxStdDet.Controls.Add(LBLStudentCrsDegree);
            groupBoxStdDet.Controls.Add(label4);
            groupBoxStdDet.Controls.Add(comboBoxStdCrs);
            groupBoxStdDet.Controls.Add(label3);
            groupBoxStdDet.Controls.Add(LBLStudentTrack);
            groupBoxStdDet.Controls.Add(label2);
            groupBoxStdDet.Controls.Add(LBLStudentName);
            groupBoxStdDet.Controls.Add(label1);
            resources.ApplyResources(groupBoxStdDet, "groupBoxStdDet");
            groupBoxStdDet.Name = "groupBoxStdDet";
            groupBoxStdDet.TabStop = false;
            // 
            // btnShowReports
            // 
            resources.ApplyResources(btnShowReports, "btnShowReports");
            btnShowReports.Name = "btnShowReports";
            btnShowReports.UseVisualStyleBackColor = true;
            btnShowReports.Click += btnShowReports_Click;
            // 
            // button1
            // 
            resources.ApplyResources(button1, "button1");
            button1.Name = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // LBLBranchName
            // 
            resources.ApplyResources(LBLBranchName, "LBLBranchName");
            LBLBranchName.Name = "LBLBranchName";
            // 
            // label8
            // 
            resources.ApplyResources(label8, "label8");
            label8.Name = "label8";
            // 
            // LBLStudentCrsDegree
            // 
            resources.ApplyResources(LBLStudentCrsDegree, "LBLStudentCrsDegree");
            LBLStudentCrsDegree.Name = "LBLStudentCrsDegree";
            // 
            // label4
            // 
            resources.ApplyResources(label4, "label4");
            label4.Name = "label4";
            // 
            // comboBoxStdCrs
            // 
            comboBoxStdCrs.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxStdCrs.FormattingEnabled = true;
            resources.ApplyResources(comboBoxStdCrs, "comboBoxStdCrs");
            comboBoxStdCrs.Name = "comboBoxStdCrs";
            comboBoxStdCrs.SelectedIndexChanged += comboBoxStdCrs_SelectedIndexChanged;
            // 
            // label3
            // 
            resources.ApplyResources(label3, "label3");
            label3.Name = "label3";
            // 
            // LBLStudentTrack
            // 
            resources.ApplyResources(LBLStudentTrack, "LBLStudentTrack");
            LBLStudentTrack.Name = "LBLStudentTrack";
            // 
            // label2
            // 
            resources.ApplyResources(label2, "label2");
            label2.Name = "label2";
            // 
            // LBLStudentName
            // 
            resources.ApplyResources(LBLStudentName, "LBLStudentName");
            LBLStudentName.Name = "LBLStudentName";
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.Name = "label1";
            // 
            // TabStdDet2
            // 
            TabStdDet2.Controls.Add(groupBox1);
            resources.ApplyResources(TabStdDet2, "TabStdDet2");
            TabStdDet2.Name = "TabStdDet2";
            TabStdDet2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(panelExam);
            groupBox1.Controls.Add(groupBoxStartExam);
            resources.ApplyResources(groupBox1, "groupBox1");
            groupBox1.Name = "groupBox1";
            groupBox1.TabStop = false;
            // 
            // panelExam
            // 
            resources.ApplyResources(panelExam, "panelExam");
            panelExam.Name = "panelExam";
            // 
            // groupBoxStartExam
            // 
            groupBoxStartExam.Controls.Add(buttonStartExam);
            groupBoxStartExam.Controls.Add(comboBoxCrsExam);
            groupBoxStartExam.Controls.Add(label5);
            resources.ApplyResources(groupBoxStartExam, "groupBoxStartExam");
            groupBoxStartExam.Name = "groupBoxStartExam";
            groupBoxStartExam.TabStop = false;
            // 
            // buttonStartExam
            // 
            buttonStartExam.Cursor = Cursors.Hand;
            resources.ApplyResources(buttonStartExam, "buttonStartExam");
            buttonStartExam.Name = "buttonStartExam";
            buttonStartExam.UseVisualStyleBackColor = true;
            buttonStartExam.Click += buttonStartExam_Click;
            // 
            // comboBoxCrsExam
            // 
            comboBoxCrsExam.FormattingEnabled = true;
            resources.ApplyResources(comboBoxCrsExam, "comboBoxCrsExam");
            comboBoxCrsExam.Name = "comboBoxCrsExam";
            comboBoxCrsExam.SelectedIndexChanged += comboBoxCrsExam_SelectedIndexChanged;
            // 
            // label5
            // 
            resources.ApplyResources(label5, "label5");
            label5.Name = "label5";
            // 
            // courseBindingSource
            // 
            courseBindingSource.DataSource = typeof(Data.Models.Course);
            // 
            // button2
            // 
            resources.ApplyResources(button2, "button2");
            button2.Name = "button2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // StudentForm
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(tabControlStudentForm);
            FormBorderStyle = FormBorderStyle.None;
            Name = "StudentForm";
            WindowState = FormWindowState.Maximized;
            Load += StudentForm_Load;
            tabControlStudentForm.ResumeLayout(false);
            TabStdDet1.ResumeLayout(false);
            groupBoxStdDet.ResumeLayout(false);
            groupBoxStdDet.PerformLayout();
            TabStdDet2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBoxStartExam.ResumeLayout(false);
            groupBoxStartExam.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)courseBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControlStudentForm;
        private TabPage TabStdDet1;
        private TabPage TabStdDet2;
        private GroupBox groupBoxStdDet;
        private GroupBox groupBox1;
        private Label label2;
        private Label LBLStudentName;
        private Label label1;
        private ComboBox comboBoxStdCrs;
        private Label label3;
        private Label LBLStudentTrack;
        private Label LBLStudentCrsDegree;
        private Label label4;
		private ComboBox comboBoxCrsExam;
		private Label label5;
		private Button buttonStartExam;
		private GroupBox groupBoxStartExam;
		private Label LBLBranchName;
		private Label label8;
		private Panel panelExam;
        private BindingSource courseBindingSource;
        private Button button1;
        private Button btnShowReports;
        private Button button2;
    }
}