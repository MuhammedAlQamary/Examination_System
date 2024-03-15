namespace ExSys.Forms
{
    partial class adminForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(adminForm));
            adminTabControl = new TabControl();
            tp = new TabPage();
            tabControl1 = new TabControl();
            Branches = new TabPage();
            groupBoxBranches = new GroupBox();
            buttonAddBranch = new Button();
            listBoxBranches = new ListBox();
            tTrackes = new TabPage();
            groupBoxTrackes = new GroupBox();
            buttonTrackes = new Button();
            listBoxTrackes = new ListBox();
            tpInstructors = new TabPage();
            tdUpdateInstructor = new TabControl();
            tpAddInstructor = new TabPage();
            gbAddInstructor = new GroupBox();
            textBox3 = new TextBox();
            label3 = new Label();
            textBox2 = new TextBox();
            label2 = new Label();
            textBox1 = new TextBox();
            label1 = new Label();
            btnAddInstructor = new Button();
            tbInstructorName = new TextBox();
            lblInstructorName = new Label();
            tpUpdateInstructor = new TabPage();
            tpStudents = new TabPage();
            tabAdd = new TabControl();
            tabAddStudent = new TabPage();
            tabUpdateStudent = new TabPage();
            tabPage3 = new TabPage();
            tabPage4 = new TabPage();
            groupBox1 = new GroupBox();
            adminTabControl.SuspendLayout();
            tp.SuspendLayout();
            tabControl1.SuspendLayout();
            Branches.SuspendLayout();
            groupBoxBranches.SuspendLayout();
            tTrackes.SuspendLayout();
            groupBoxTrackes.SuspendLayout();
            tpInstructors.SuspendLayout();
            tdUpdateInstructor.SuspendLayout();
            tpAddInstructor.SuspendLayout();
            gbAddInstructor.SuspendLayout();
            tpStudents.SuspendLayout();
            tabAdd.SuspendLayout();
            tabAddStudent.SuspendLayout();
            SuspendLayout();
            // 
            // adminTabControl
            // 
            adminTabControl.Controls.Add(tp);
            adminTabControl.Controls.Add(tpInstructors);
            adminTabControl.Controls.Add(tpStudents);
            resources.ApplyResources(adminTabControl, "adminTabControl");
            adminTabControl.Name = "adminTabControl";
            adminTabControl.SelectedIndex = 0;
            adminTabControl.SizeMode = TabSizeMode.FillToRight;
            // 
            // tp
            // 
            tp.Controls.Add(tabControl1);
            resources.ApplyResources(tp, "tp");
            tp.Name = "tp";
            tp.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(Branches);
            tabControl1.Controls.Add(tTrackes);
            resources.ApplyResources(tabControl1, "tabControl1");
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            // 
            // Branches
            // 
            Branches.Controls.Add(groupBoxBranches);
            resources.ApplyResources(Branches, "Branches");
            Branches.Name = "Branches";
            Branches.UseVisualStyleBackColor = true;
            // 
            // groupBoxBranches
            // 
            groupBoxBranches.Controls.Add(buttonAddBranch);
            groupBoxBranches.Controls.Add(listBoxBranches);
            resources.ApplyResources(groupBoxBranches, "groupBoxBranches");
            groupBoxBranches.Name = "groupBoxBranches";
            groupBoxBranches.TabStop = false;
            // 
            // buttonAddBranch
            // 
            resources.ApplyResources(buttonAddBranch, "buttonAddBranch");
            buttonAddBranch.Name = "buttonAddBranch";
            buttonAddBranch.UseVisualStyleBackColor = true;
            buttonAddBranch.Click += buttonAddBranch_Click;
            // 
            // listBoxBranches
            // 
            resources.ApplyResources(listBoxBranches, "listBoxBranches");
            listBoxBranches.FormattingEnabled = true;
            listBoxBranches.Name = "listBoxBranches";
            // 
            // tTrackes
            // 
            tTrackes.Controls.Add(groupBoxTrackes);
            resources.ApplyResources(tTrackes, "tTrackes");
            tTrackes.Name = "tTrackes";
            tTrackes.UseVisualStyleBackColor = true;
            // 
            // groupBoxTrackes
            // 
            groupBoxTrackes.Controls.Add(buttonTrackes);
            groupBoxTrackes.Controls.Add(listBoxTrackes);
            resources.ApplyResources(groupBoxTrackes, "groupBoxTrackes");
            groupBoxTrackes.Name = "groupBoxTrackes";
            groupBoxTrackes.TabStop = false;
            // 
            // buttonTrackes
            // 
            resources.ApplyResources(buttonTrackes, "buttonTrackes");
            buttonTrackes.Name = "buttonTrackes";
            buttonTrackes.UseVisualStyleBackColor = true;
            // 
            // listBoxTrackes
            // 
            resources.ApplyResources(listBoxTrackes, "listBoxTrackes");
            listBoxTrackes.FormattingEnabled = true;
            listBoxTrackes.Name = "listBoxTrackes";
            // 
            // tpInstructors
            // 
            tpInstructors.Controls.Add(tdUpdateInstructor);
            resources.ApplyResources(tpInstructors, "tpInstructors");
            tpInstructors.Name = "tpInstructors";
            tpInstructors.UseVisualStyleBackColor = true;
            // 
            // tdUpdateInstructor
            // 
            tdUpdateInstructor.Controls.Add(tpAddInstructor);
            tdUpdateInstructor.Controls.Add(tpUpdateInstructor);
            resources.ApplyResources(tdUpdateInstructor, "tdUpdateInstructor");
            tdUpdateInstructor.Name = "tdUpdateInstructor";
            tdUpdateInstructor.SelectedIndex = 0;
            // 
            // tpAddInstructor
            // 
            tpAddInstructor.Controls.Add(gbAddInstructor);
            resources.ApplyResources(tpAddInstructor, "tpAddInstructor");
            tpAddInstructor.Name = "tpAddInstructor";
            tpAddInstructor.UseVisualStyleBackColor = true;
            // 
            // gbAddInstructor
            // 
            gbAddInstructor.Controls.Add(textBox3);
            gbAddInstructor.Controls.Add(label3);
            gbAddInstructor.Controls.Add(textBox2);
            gbAddInstructor.Controls.Add(label2);
            gbAddInstructor.Controls.Add(textBox1);
            gbAddInstructor.Controls.Add(label1);
            gbAddInstructor.Controls.Add(btnAddInstructor);
            gbAddInstructor.Controls.Add(tbInstructorName);
            gbAddInstructor.Controls.Add(lblInstructorName);
            resources.ApplyResources(gbAddInstructor, "gbAddInstructor");
            gbAddInstructor.Name = "gbAddInstructor";
            gbAddInstructor.TabStop = false;
            // 
            // textBox3
            // 
            resources.ApplyResources(textBox3, "textBox3");
            textBox3.Name = "textBox3";
            // 
            // label3
            // 
            resources.ApplyResources(label3, "label3");
            label3.Name = "label3";
            // 
            // textBox2
            // 
            resources.ApplyResources(textBox2, "textBox2");
            textBox2.Name = "textBox2";
            // 
            // label2
            // 
            resources.ApplyResources(label2, "label2");
            label2.Name = "label2";
            // 
            // textBox1
            // 
            resources.ApplyResources(textBox1, "textBox1");
            textBox1.Name = "textBox1";
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.Name = "label1";
            // 
            // btnAddInstructor
            // 
            resources.ApplyResources(btnAddInstructor, "btnAddInstructor");
            btnAddInstructor.Name = "btnAddInstructor";
            btnAddInstructor.UseVisualStyleBackColor = true;
            btnAddInstructor.Click += btnAddInstructor_Click;
            // 
            // tbInstructorName
            // 
            resources.ApplyResources(tbInstructorName, "tbInstructorName");
            tbInstructorName.Name = "tbInstructorName";
            // 
            // lblInstructorName
            // 
            resources.ApplyResources(lblInstructorName, "lblInstructorName");
            lblInstructorName.Name = "lblInstructorName";
            // 
            // tpUpdateInstructor
            // 
            resources.ApplyResources(tpUpdateInstructor, "tpUpdateInstructor");
            tpUpdateInstructor.Name = "tpUpdateInstructor";
            tpUpdateInstructor.UseVisualStyleBackColor = true;
            // 
            // tpStudents
            // 
            tpStudents.Controls.Add(tabAdd);
            resources.ApplyResources(tpStudents, "tpStudents");
            tpStudents.Name = "tpStudents";
            tpStudents.UseVisualStyleBackColor = true;
            // 
            // tabAdd
            // 
            tabAdd.Controls.Add(tabAddStudent);
            tabAdd.Controls.Add(tabUpdateStudent);
            tabAdd.Controls.Add(tabPage3);
            tabAdd.Controls.Add(tabPage4);
            resources.ApplyResources(tabAdd, "tabAdd");
            tabAdd.Name = "tabAdd";
            tabAdd.SelectedIndex = 0;
            // 
            // tabAddStudent
            // 
            tabAddStudent.Controls.Add(groupBox1);
            resources.ApplyResources(tabAddStudent, "tabAddStudent");
            tabAddStudent.Name = "tabAddStudent";
            tabAddStudent.UseVisualStyleBackColor = true;
            // 
            // tabUpdateStudent
            // 
            resources.ApplyResources(tabUpdateStudent, "tabUpdateStudent");
            tabUpdateStudent.Name = "tabUpdateStudent";
            tabUpdateStudent.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            resources.ApplyResources(tabPage3, "tabPage3");
            tabPage3.Name = "tabPage3";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            resources.ApplyResources(tabPage4, "tabPage4");
            tabPage4.Name = "tabPage4";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            resources.ApplyResources(groupBox1, "groupBox1");
            groupBox1.Name = "groupBox1";
            groupBox1.TabStop = false;
            // 
            // adminForm
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(adminTabControl);
            FormBorderStyle = FormBorderStyle.None;
            Name = "adminForm";
            WindowState = FormWindowState.Maximized;
            Load += adminForm_Load;
            adminTabControl.ResumeLayout(false);
            tp.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
            Branches.ResumeLayout(false);
            groupBoxBranches.ResumeLayout(false);
            tTrackes.ResumeLayout(false);
            groupBoxTrackes.ResumeLayout(false);
            tpInstructors.ResumeLayout(false);
            tdUpdateInstructor.ResumeLayout(false);
            tpAddInstructor.ResumeLayout(false);
            gbAddInstructor.ResumeLayout(false);
            gbAddInstructor.PerformLayout();
            tpStudents.ResumeLayout(false);
            tabAdd.ResumeLayout(false);
            tabAddStudent.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl adminTabControl;
        private TabPage tp;
        private TabPage tpInstructors;
        private GroupBox groupBoxBranches;
        private ListBox listBoxBranches;
        private Button buttonAddBranch;
        private GroupBox groupBoxTrackes;
        private Button buttonTrackes;
        private ListBox listBoxTrackes;
        private TabControl tabControl1;
        private TabPage Branches;
        private TabPage tTrackes;
        private TabControl tdUpdateInstructor;
        private TabPage tpAddInstructor;
        private TabPage tpUpdateInstructor;
        private TabPage tpStudents;
        private GroupBox gbAddInstructor;
        private Button btnAddInstructor;
        private TextBox tbInstructorName;
        private Label lblInstructorName;
        private TextBox textBox3;
        private Label label3;
        private TextBox textBox2;
        private Label label2;
        private TextBox textBox1;
        private Label label1;
        private TabControl tabAdd;
        private TabPage tabAddStudent;
        private TabPage tabUpdateStudent;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private GroupBox groupBox1;
    }
}