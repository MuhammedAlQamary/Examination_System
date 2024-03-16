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
            tabٍStudents = new TabControl();
            tabAddStudent = new TabPage();
            groupBox1 = new GroupBox();
            TBStudentTrackAdd = new TextBox();
            label14 = new Label();
            TBStudentPasswordAdd = new TextBox();
            label4 = new Label();
            TBStudentMailAdd = new TextBox();
            label5 = new Label();
            TBStudentLNameAdd = new TextBox();
            label6 = new Label();
            btn_AddStudent = new Button();
            TBStudentFNameAdd = new TextBox();
            label7 = new Label();
            tabUpdateStudent = new TabPage();
            groupBoxUpdateStd = new GroupBox();
            TBStudentTrack = new TextBox();
            btn_DeleteStd = new Button();
            label13 = new Label();
            label12 = new Label();
            listBoxStd = new ListBox();
            TBStudentPassword = new TextBox();
            label8 = new Label();
            TBStudentMail = new TextBox();
            label9 = new Label();
            TBStudentLName = new TextBox();
            label10 = new Label();
            btn_UpdateStd = new Button();
            TBStudentFName = new TextBox();
            label11 = new Label();
            tabPageDeleteStd = new TabPage();
            groupBox2 = new GroupBox();
            tabPage4 = new TabPage();
            tabPageCourses = new TabPage();
            tabControlforcourses = new TabControl();
            tabPageAddcourse = new TabPage();
            groupBoxAddCourses = new GroupBox();
            btn_addCourse = new Button();
            TBCouseNameAdd = new TextBox();
            label15 = new Label();
            tabUpdateCourse = new TabPage();
            groupBoxupdate = new GroupBox();
            btn_delete = new Button();
            btn_updateCourse = new Button();
            label17 = new Label();
            listBoxCourses = new ListBox();
            TBCouseName = new TextBox();
            label16 = new Label();
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
            tabٍStudents.SuspendLayout();
            tabAddStudent.SuspendLayout();
            groupBox1.SuspendLayout();
            tabUpdateStudent.SuspendLayout();
            groupBoxUpdateStd.SuspendLayout();
            tabPageDeleteStd.SuspendLayout();
            tabPageCourses.SuspendLayout();
            tabControlforcourses.SuspendLayout();
            tabPageAddcourse.SuspendLayout();
            groupBoxAddCourses.SuspendLayout();
            tabUpdateCourse.SuspendLayout();
            groupBoxupdate.SuspendLayout();
            SuspendLayout();
            // 
            // adminTabControl
            // 
            adminTabControl.Controls.Add(tp);
            adminTabControl.Controls.Add(tpInstructors);
            adminTabControl.Controls.Add(tpStudents);
            adminTabControl.Controls.Add(tabPageCourses);
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
            tpStudents.Controls.Add(tabٍStudents);
            resources.ApplyResources(tpStudents, "tpStudents");
            tpStudents.Name = "tpStudents";
            tpStudents.UseVisualStyleBackColor = true;
            // 
            // tabٍStudents
            // 
            tabٍStudents.Controls.Add(tabAddStudent);
            tabٍStudents.Controls.Add(tabUpdateStudent);
            tabٍStudents.Controls.Add(tabPageDeleteStd);
            tabٍStudents.Controls.Add(tabPage4);
            resources.ApplyResources(tabٍStudents, "tabٍStudents");
            tabٍStudents.Name = "tabٍStudents";
            tabٍStudents.SelectedIndex = 0;
            tabٍStudents.Enter += tabٍStudents_Enter;
            // 
            // tabAddStudent
            // 
            tabAddStudent.Controls.Add(groupBox1);
            resources.ApplyResources(tabAddStudent, "tabAddStudent");
            tabAddStudent.Name = "tabAddStudent";
            tabAddStudent.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(TBStudentTrackAdd);
            groupBox1.Controls.Add(label14);
            groupBox1.Controls.Add(TBStudentPasswordAdd);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(TBStudentMailAdd);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(TBStudentLNameAdd);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(btn_AddStudent);
            groupBox1.Controls.Add(TBStudentFNameAdd);
            groupBox1.Controls.Add(label7);
            resources.ApplyResources(groupBox1, "groupBox1");
            groupBox1.Name = "groupBox1";
            groupBox1.TabStop = false;
            // 
            // TBStudentTrackAdd
            // 
            resources.ApplyResources(TBStudentTrackAdd, "TBStudentTrackAdd");
            TBStudentTrackAdd.Name = "TBStudentTrackAdd";
            // 
            // label14
            // 
            resources.ApplyResources(label14, "label14");
            label14.Name = "label14";
            // 
            // TBStudentPasswordAdd
            // 
            resources.ApplyResources(TBStudentPasswordAdd, "TBStudentPasswordAdd");
            TBStudentPasswordAdd.Name = "TBStudentPasswordAdd";
            // 
            // label4
            // 
            resources.ApplyResources(label4, "label4");
            label4.Name = "label4";
            // 
            // TBStudentMailAdd
            // 
            resources.ApplyResources(TBStudentMailAdd, "TBStudentMailAdd");
            TBStudentMailAdd.Name = "TBStudentMailAdd";
            // 
            // label5
            // 
            resources.ApplyResources(label5, "label5");
            label5.Name = "label5";
            // 
            // TBStudentLNameAdd
            // 
            resources.ApplyResources(TBStudentLNameAdd, "TBStudentLNameAdd");
            TBStudentLNameAdd.Name = "TBStudentLNameAdd";
            // 
            // label6
            // 
            resources.ApplyResources(label6, "label6");
            label6.Name = "label6";
            // 
            // btn_AddStudent
            // 
            resources.ApplyResources(btn_AddStudent, "btn_AddStudent");
            btn_AddStudent.Name = "btn_AddStudent";
            btn_AddStudent.UseVisualStyleBackColor = true;
            btn_AddStudent.Click += btn_AddStudent_Click;
            // 
            // TBStudentFNameAdd
            // 
            resources.ApplyResources(TBStudentFNameAdd, "TBStudentFNameAdd");
            TBStudentFNameAdd.Name = "TBStudentFNameAdd";
            // 
            // label7
            // 
            resources.ApplyResources(label7, "label7");
            label7.Name = "label7";
            // 
            // tabUpdateStudent
            // 
            tabUpdateStudent.Controls.Add(groupBoxUpdateStd);
            resources.ApplyResources(tabUpdateStudent, "tabUpdateStudent");
            tabUpdateStudent.Name = "tabUpdateStudent";
            tabUpdateStudent.UseVisualStyleBackColor = true;
            // 
            // groupBoxUpdateStd
            // 
            groupBoxUpdateStd.Controls.Add(TBStudentTrack);
            groupBoxUpdateStd.Controls.Add(btn_DeleteStd);
            groupBoxUpdateStd.Controls.Add(label13);
            groupBoxUpdateStd.Controls.Add(label12);
            groupBoxUpdateStd.Controls.Add(listBoxStd);
            groupBoxUpdateStd.Controls.Add(TBStudentPassword);
            groupBoxUpdateStd.Controls.Add(label8);
            groupBoxUpdateStd.Controls.Add(TBStudentMail);
            groupBoxUpdateStd.Controls.Add(label9);
            groupBoxUpdateStd.Controls.Add(TBStudentLName);
            groupBoxUpdateStd.Controls.Add(label10);
            groupBoxUpdateStd.Controls.Add(btn_UpdateStd);
            groupBoxUpdateStd.Controls.Add(TBStudentFName);
            groupBoxUpdateStd.Controls.Add(label11);
            resources.ApplyResources(groupBoxUpdateStd, "groupBoxUpdateStd");
            groupBoxUpdateStd.Name = "groupBoxUpdateStd";
            groupBoxUpdateStd.TabStop = false;
            // 
            // TBStudentTrack
            // 
            resources.ApplyResources(TBStudentTrack, "TBStudentTrack");
            TBStudentTrack.Name = "TBStudentTrack";
            // 
            // btn_DeleteStd
            // 
            resources.ApplyResources(btn_DeleteStd, "btn_DeleteStd");
            btn_DeleteStd.Name = "btn_DeleteStd";
            btn_DeleteStd.UseVisualStyleBackColor = true;
            btn_DeleteStd.Click += btn_DeleteStd_Click;
            // 
            // label13
            // 
            resources.ApplyResources(label13, "label13");
            label13.Name = "label13";
            // 
            // label12
            // 
            resources.ApplyResources(label12, "label12");
            label12.Name = "label12";
            // 
            // listBoxStd
            // 
            listBoxStd.FormattingEnabled = true;
            resources.ApplyResources(listBoxStd, "listBoxStd");
            listBoxStd.Name = "listBoxStd";
            listBoxStd.SelectedIndexChanged += listBoxStd_SelectedIndexChanged;
            // 
            // TBStudentPassword
            // 
            resources.ApplyResources(TBStudentPassword, "TBStudentPassword");
            TBStudentPassword.Name = "TBStudentPassword";
            // 
            // label8
            // 
            resources.ApplyResources(label8, "label8");
            label8.Name = "label8";
            // 
            // TBStudentMail
            // 
            resources.ApplyResources(TBStudentMail, "TBStudentMail");
            TBStudentMail.Name = "TBStudentMail";
            // 
            // label9
            // 
            resources.ApplyResources(label9, "label9");
            label9.Name = "label9";
            // 
            // TBStudentLName
            // 
            resources.ApplyResources(TBStudentLName, "TBStudentLName");
            TBStudentLName.Name = "TBStudentLName";
            // 
            // label10
            // 
            resources.ApplyResources(label10, "label10");
            label10.Name = "label10";
            // 
            // btn_UpdateStd
            // 
            resources.ApplyResources(btn_UpdateStd, "btn_UpdateStd");
            btn_UpdateStd.Name = "btn_UpdateStd";
            btn_UpdateStd.UseVisualStyleBackColor = true;
            btn_UpdateStd.Click += btn_UpdateStd_Click;
            // 
            // TBStudentFName
            // 
            resources.ApplyResources(TBStudentFName, "TBStudentFName");
            TBStudentFName.Name = "TBStudentFName";
            // 
            // label11
            // 
            resources.ApplyResources(label11, "label11");
            label11.Name = "label11";
            // 
            // tabPageDeleteStd
            // 
            tabPageDeleteStd.Controls.Add(groupBox2);
            resources.ApplyResources(tabPageDeleteStd, "tabPageDeleteStd");
            tabPageDeleteStd.Name = "tabPageDeleteStd";
            tabPageDeleteStd.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            resources.ApplyResources(groupBox2, "groupBox2");
            groupBox2.Name = "groupBox2";
            groupBox2.TabStop = false;
            // 
            // tabPage4
            // 
            resources.ApplyResources(tabPage4, "tabPage4");
            tabPage4.Name = "tabPage4";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPageCourses
            // 
            tabPageCourses.Controls.Add(tabControlforcourses);
            resources.ApplyResources(tabPageCourses, "tabPageCourses");
            tabPageCourses.Name = "tabPageCourses";
            tabPageCourses.UseVisualStyleBackColor = true;
            // 
            // tabControlforcourses
            // 
            tabControlforcourses.Controls.Add(tabPageAddcourse);
            tabControlforcourses.Controls.Add(tabUpdateCourse);
            resources.ApplyResources(tabControlforcourses, "tabControlforcourses");
            tabControlforcourses.Name = "tabControlforcourses";
            tabControlforcourses.SelectedIndex = 0;
            // 
            // tabPageAddcourse
            // 
            tabPageAddcourse.Controls.Add(groupBoxAddCourses);
            resources.ApplyResources(tabPageAddcourse, "tabPageAddcourse");
            tabPageAddcourse.Name = "tabPageAddcourse";
            tabPageAddcourse.UseVisualStyleBackColor = true;
            // 
            // groupBoxAddCourses
            // 
            groupBoxAddCourses.Controls.Add(btn_addCourse);
            groupBoxAddCourses.Controls.Add(TBCouseNameAdd);
            groupBoxAddCourses.Controls.Add(label15);
            resources.ApplyResources(groupBoxAddCourses, "groupBoxAddCourses");
            groupBoxAddCourses.Name = "groupBoxAddCourses";
            groupBoxAddCourses.TabStop = false;
            // 
            // btn_addCourse
            // 
            resources.ApplyResources(btn_addCourse, "btn_addCourse");
            btn_addCourse.Name = "btn_addCourse";
            btn_addCourse.UseVisualStyleBackColor = true;
            btn_addCourse.Click += btn_addCourse_Click;
            // 
            // TBCouseNameAdd
            // 
            resources.ApplyResources(TBCouseNameAdd, "TBCouseNameAdd");
            TBCouseNameAdd.Name = "TBCouseNameAdd";
            // 
            // label15
            // 
            resources.ApplyResources(label15, "label15");
            label15.Name = "label15";
            // 
            // tabUpdateCourse
            // 
            tabUpdateCourse.Controls.Add(groupBoxupdate);
            resources.ApplyResources(tabUpdateCourse, "tabUpdateCourse");
            tabUpdateCourse.Name = "tabUpdateCourse";
            tabUpdateCourse.UseVisualStyleBackColor = true;
            tabUpdateCourse.Enter += tabUpdateCourse_Enter;
            // 
            // groupBoxupdate
            // 
            groupBoxupdate.Controls.Add(btn_delete);
            groupBoxupdate.Controls.Add(btn_updateCourse);
            groupBoxupdate.Controls.Add(label17);
            groupBoxupdate.Controls.Add(listBoxCourses);
            groupBoxupdate.Controls.Add(TBCouseName);
            groupBoxupdate.Controls.Add(label16);
            resources.ApplyResources(groupBoxupdate, "groupBoxupdate");
            groupBoxupdate.Name = "groupBoxupdate";
            groupBoxupdate.TabStop = false;
            // 
            // btn_delete
            // 
            resources.ApplyResources(btn_delete, "btn_delete");
            btn_delete.Name = "btn_delete";
            btn_delete.UseVisualStyleBackColor = true;
            btn_delete.Click += btn_delete_Click;
            // 
            // btn_updateCourse
            // 
            resources.ApplyResources(btn_updateCourse, "btn_updateCourse");
            btn_updateCourse.Name = "btn_updateCourse";
            btn_updateCourse.UseVisualStyleBackColor = true;
            btn_updateCourse.Click += btn_updateCourse_Click;
            // 
            // label17
            // 
            resources.ApplyResources(label17, "label17");
            label17.Name = "label17";
            // 
            // listBoxCourses
            // 
            listBoxCourses.FormattingEnabled = true;
            resources.ApplyResources(listBoxCourses, "listBoxCourses");
            listBoxCourses.Name = "listBoxCourses";
            listBoxCourses.SelectedIndexChanged += listBoxCourses_SelectedIndexChanged;
            // 
            // TBCouseName
            // 
            resources.ApplyResources(TBCouseName, "TBCouseName");
            TBCouseName.Name = "TBCouseName";
            // 
            // label16
            // 
            resources.ApplyResources(label16, "label16");
            label16.Name = "label16";
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
            tabٍStudents.ResumeLayout(false);
            tabAddStudent.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            tabUpdateStudent.ResumeLayout(false);
            groupBoxUpdateStd.ResumeLayout(false);
            groupBoxUpdateStd.PerformLayout();
            tabPageDeleteStd.ResumeLayout(false);
            tabPageCourses.ResumeLayout(false);
            tabControlforcourses.ResumeLayout(false);
            tabPageAddcourse.ResumeLayout(false);
            groupBoxAddCourses.ResumeLayout(false);
            groupBoxAddCourses.PerformLayout();
            tabUpdateCourse.ResumeLayout(false);
            groupBoxupdate.ResumeLayout(false);
            groupBoxupdate.PerformLayout();
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
        private TabControl tabٍStudents;
        private TabPage tabAddStudent;
        private TabPage tabUpdateStudent;
        private TabPage tabPageDeleteStd;
        private TabPage tabPage4;
        private GroupBox groupBox1;
        private GroupBox groupBoxUpdateStd;
        private TextBox TBStudentPasswordAdd;
        private Label label4;
        private TextBox TBStudentMailAdd;
        private Label label5;
        private TextBox TBStudentLNameAdd;
        private Label label6;
        private Button btn_AddStudent;
        private TextBox TBStudentFNameAdd;
        private Label label7;
        private GroupBox groupBox2;
        private Label label12;
        private ListBox listBoxStd;
        private TextBox TBStudentPassword;
        private Label label8;
        private TextBox TBStudentMail;
        private Label label9;
        private TextBox TBStudentLName;
        private Label label10;
        private Button btn_UpdateStd;
        private TextBox TBStudentFName;
        private Label label11;
        private Label label13;
        private Button btn_DeleteStd;
        private TextBox TBStudentTrackAdd;
        private Label label14;
        private TextBox TBStudentTrack;
        private TabPage tabPageCourses;
        private TabControl tabControlforcourses;
        private TabPage tabPageAddcourse;
        private TabPage tabUpdateCourse;
        private GroupBox groupBoxAddCourses;
        private GroupBox groupBoxupdate;
        private TextBox TBCouseNameAdd;
        private Label label15;
        private Label label17;
        private ListBox listBoxCourses;
        private TextBox TBCouseName;
        private Label label16;
        private Button btn_addCourse;
        private Button btn_delete;
        private Button btn_updateCourse;
    }
}