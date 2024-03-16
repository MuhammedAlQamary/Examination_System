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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentForm));
            tabControlStudentForm = new TabControl();
            TabStdDet1 = new TabPage();
            groupBoxStdDet = new GroupBox();
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
            tabControlStudentForm.SuspendLayout();
            TabStdDet1.SuspendLayout();
            groupBoxStdDet.SuspendLayout();
            TabStdDet2.SuspendLayout();
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
            resources.ApplyResources(groupBox1, "groupBox1");
            groupBox1.Name = "groupBox1";
            groupBox1.TabStop = false;
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
    }
}