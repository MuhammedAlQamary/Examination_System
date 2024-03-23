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
            comboBoxINSBRCH = new ComboBox();
            label28 = new Label();
            TBInstructorPassAdd = new TextBox();
            label3 = new Label();
            TBInstructorMailAdd = new TextBox();
            label2 = new Label();
            TBInstructorLNameAdd = new TextBox();
            label1 = new Label();
            btnAddInstructor = new Button();
            tbInstructorNameAdd = new TextBox();
            lblInstructorName = new Label();
            tpUpdateInstructor = new TabPage();
            groupBoxupIns = new GroupBox();
            labelIssBranch = new Label();
            comboBoxInsBranches = new ComboBox();
            label27 = new Label();
            btn_AssignNewCrs = new Button();
            btn_delIns = new Button();
            listBoxinstructors = new ListBox();
            label19 = new Label();
            TBInstructorPass = new TextBox();
            label20 = new Label();
            TBInstructorMail = new TextBox();
            label21 = new Label();
            TBInstructorLName = new TextBox();
            label22 = new Label();
            btn_updateIns = new Button();
            TBInstructorFName = new TextBox();
            label23 = new Label();
            tabAssignCourseToInstructor = new TabPage();
            groupBoxAssignCourses = new GroupBox();
            btn_AddthisCoursetoIns = new Button();
            listBoxUnassignedCourses = new ListBox();
            label25 = new Label();
            label24 = new Label();
            comboBoxInstructors = new ComboBox();
            btn_RemoveThisInsCrs = new Button();
            listBoxAssignedCourses = new ListBox();
            label18 = new Label();
            tpStudents = new TabPage();
            tabٍStudents = new TabControl();
            tabAddStudent = new TabPage();
            groupBox1 = new GroupBox();
            comboBoxBranches = new ComboBox();
            comboBoxTracks = new ComboBox();
            label31 = new Label();
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
            comboBoxStdBranch = new ComboBox();
            comboBoxStdTrack = new ComboBox();
            labelStdBranch = new Label();
            labelStdTrack = new Label();
            label32 = new Label();
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
            tpUpdateInstructor.SuspendLayout();
            groupBoxupIns.SuspendLayout();
            tabAssignCourseToInstructor.SuspendLayout();
            groupBoxAssignCourses.SuspendLayout();
            tpStudents.SuspendLayout();
            tabٍStudents.SuspendLayout();
            tabAddStudent.SuspendLayout();
            groupBox1.SuspendLayout();
            tabUpdateStudent.SuspendLayout();
            groupBoxUpdateStd.SuspendLayout();
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
            tdUpdateInstructor.Controls.Add(tabAssignCourseToInstructor);
            resources.ApplyResources(tdUpdateInstructor, "tdUpdateInstructor");
            tdUpdateInstructor.Name = "tdUpdateInstructor";
            tdUpdateInstructor.SelectedIndex = 0;
            tdUpdateInstructor.Enter += tdUpdateInstructor_Enter;
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
            gbAddInstructor.Controls.Add(comboBoxINSBRCH);
            gbAddInstructor.Controls.Add(label28);
            gbAddInstructor.Controls.Add(TBInstructorPassAdd);
            gbAddInstructor.Controls.Add(label3);
            gbAddInstructor.Controls.Add(TBInstructorMailAdd);
            gbAddInstructor.Controls.Add(label2);
            gbAddInstructor.Controls.Add(TBInstructorLNameAdd);
            gbAddInstructor.Controls.Add(label1);
            gbAddInstructor.Controls.Add(btnAddInstructor);
            gbAddInstructor.Controls.Add(tbInstructorNameAdd);
            gbAddInstructor.Controls.Add(lblInstructorName);
            resources.ApplyResources(gbAddInstructor, "gbAddInstructor");
            gbAddInstructor.Name = "gbAddInstructor";
            gbAddInstructor.TabStop = false;
            gbAddInstructor.Enter += gbAddInstructor_Enter;
            // 
            // comboBoxINSBRCH
            // 
            comboBoxINSBRCH.FormattingEnabled = true;
            resources.ApplyResources(comboBoxINSBRCH, "comboBoxINSBRCH");
            comboBoxINSBRCH.Name = "comboBoxINSBRCH";
            // 
            // label28
            // 
            resources.ApplyResources(label28, "label28");
            label28.Name = "label28";
            // 
            // TBInstructorPassAdd
            // 
            resources.ApplyResources(TBInstructorPassAdd, "TBInstructorPassAdd");
            TBInstructorPassAdd.Name = "TBInstructorPassAdd";
            // 
            // label3
            // 
            resources.ApplyResources(label3, "label3");
            label3.Name = "label3";
            // 
            // TBInstructorMailAdd
            // 
            resources.ApplyResources(TBInstructorMailAdd, "TBInstructorMailAdd");
            TBInstructorMailAdd.Name = "TBInstructorMailAdd";
            // 
            // label2
            // 
            resources.ApplyResources(label2, "label2");
            label2.Name = "label2";
            // 
            // TBInstructorLNameAdd
            // 
            resources.ApplyResources(TBInstructorLNameAdd, "TBInstructorLNameAdd");
            TBInstructorLNameAdd.Name = "TBInstructorLNameAdd";
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
            // tbInstructorNameAdd
            // 
            resources.ApplyResources(tbInstructorNameAdd, "tbInstructorNameAdd");
            tbInstructorNameAdd.Name = "tbInstructorNameAdd";
            // 
            // lblInstructorName
            // 
            resources.ApplyResources(lblInstructorName, "lblInstructorName");
            lblInstructorName.Name = "lblInstructorName";
            // 
            // tpUpdateInstructor
            // 
            tpUpdateInstructor.Controls.Add(groupBoxupIns);
            resources.ApplyResources(tpUpdateInstructor, "tpUpdateInstructor");
            tpUpdateInstructor.Name = "tpUpdateInstructor";
            tpUpdateInstructor.UseVisualStyleBackColor = true;
            // 
            // groupBoxupIns
            // 
            groupBoxupIns.Controls.Add(labelIssBranch);
            groupBoxupIns.Controls.Add(comboBoxInsBranches);
            groupBoxupIns.Controls.Add(label27);
            groupBoxupIns.Controls.Add(btn_AssignNewCrs);
            groupBoxupIns.Controls.Add(btn_delIns);
            groupBoxupIns.Controls.Add(listBoxinstructors);
            groupBoxupIns.Controls.Add(label19);
            groupBoxupIns.Controls.Add(TBInstructorPass);
            groupBoxupIns.Controls.Add(label20);
            groupBoxupIns.Controls.Add(TBInstructorMail);
            groupBoxupIns.Controls.Add(label21);
            groupBoxupIns.Controls.Add(TBInstructorLName);
            groupBoxupIns.Controls.Add(label22);
            groupBoxupIns.Controls.Add(btn_updateIns);
            groupBoxupIns.Controls.Add(TBInstructorFName);
            groupBoxupIns.Controls.Add(label23);
            resources.ApplyResources(groupBoxupIns, "groupBoxupIns");
            groupBoxupIns.ForeColor = SystemColors.ActiveCaptionText;
            groupBoxupIns.Name = "groupBoxupIns";
            groupBoxupIns.TabStop = false;
            // 
            // labelIssBranch
            // 
            resources.ApplyResources(labelIssBranch, "labelIssBranch");
            labelIssBranch.Name = "labelIssBranch";
            // 
            // comboBoxInsBranches
            // 
            comboBoxInsBranches.FormattingEnabled = true;
            resources.ApplyResources(comboBoxInsBranches, "comboBoxInsBranches");
            comboBoxInsBranches.Name = "comboBoxInsBranches";
            // 
            // label27
            // 
            resources.ApplyResources(label27, "label27");
            label27.Name = "label27";
            // 
            // btn_AssignNewCrs
            // 
            resources.ApplyResources(btn_AssignNewCrs, "btn_AssignNewCrs");
            btn_AssignNewCrs.Name = "btn_AssignNewCrs";
            btn_AssignNewCrs.UseVisualStyleBackColor = true;
            btn_AssignNewCrs.Click += btn_AssignNewCrs_Click;
            // 
            // btn_delIns
            // 
            resources.ApplyResources(btn_delIns, "btn_delIns");
            btn_delIns.Name = "btn_delIns";
            btn_delIns.UseVisualStyleBackColor = true;
            btn_delIns.Click += btn_delIns_Click;
            // 
            // listBoxinstructors
            // 
            listBoxinstructors.ForeColor = Color.Black;
            listBoxinstructors.FormattingEnabled = true;
            resources.ApplyResources(listBoxinstructors, "listBoxinstructors");
            listBoxinstructors.Name = "listBoxinstructors";
            listBoxinstructors.SelectedIndexChanged += listBoxinstructors_SelectedIndexChanged;
            // 
            // label19
            // 
            resources.ApplyResources(label19, "label19");
            label19.Name = "label19";
            // 
            // TBInstructorPass
            // 
            resources.ApplyResources(TBInstructorPass, "TBInstructorPass");
            TBInstructorPass.Name = "TBInstructorPass";
            // 
            // label20
            // 
            resources.ApplyResources(label20, "label20");
            label20.Name = "label20";
            // 
            // TBInstructorMail
            // 
            resources.ApplyResources(TBInstructorMail, "TBInstructorMail");
            TBInstructorMail.Name = "TBInstructorMail";
            // 
            // label21
            // 
            resources.ApplyResources(label21, "label21");
            label21.Name = "label21";
            // 
            // TBInstructorLName
            // 
            resources.ApplyResources(TBInstructorLName, "TBInstructorLName");
            TBInstructorLName.Name = "TBInstructorLName";
            // 
            // label22
            // 
            resources.ApplyResources(label22, "label22");
            label22.Name = "label22";
            // 
            // btn_updateIns
            // 
            resources.ApplyResources(btn_updateIns, "btn_updateIns");
            btn_updateIns.Name = "btn_updateIns";
            btn_updateIns.UseVisualStyleBackColor = true;
            btn_updateIns.Click += btn_updateIns_Click;
            // 
            // TBInstructorFName
            // 
            resources.ApplyResources(TBInstructorFName, "TBInstructorFName");
            TBInstructorFName.Name = "TBInstructorFName";
            // 
            // label23
            // 
            resources.ApplyResources(label23, "label23");
            label23.Name = "label23";
            // 
            // tabAssignCourseToInstructor
            // 
            tabAssignCourseToInstructor.Controls.Add(groupBoxAssignCourses);
            resources.ApplyResources(tabAssignCourseToInstructor, "tabAssignCourseToInstructor");
            tabAssignCourseToInstructor.Name = "tabAssignCourseToInstructor";
            tabAssignCourseToInstructor.UseVisualStyleBackColor = true;
            tabAssignCourseToInstructor.Enter += tabAssignCourseToInstructor_Enter;
            // 
            // groupBoxAssignCourses
            // 
            groupBoxAssignCourses.Controls.Add(btn_AddthisCoursetoIns);
            groupBoxAssignCourses.Controls.Add(listBoxUnassignedCourses);
            groupBoxAssignCourses.Controls.Add(label25);
            groupBoxAssignCourses.Controls.Add(label24);
            groupBoxAssignCourses.Controls.Add(comboBoxInstructors);
            groupBoxAssignCourses.Controls.Add(btn_RemoveThisInsCrs);
            groupBoxAssignCourses.Controls.Add(listBoxAssignedCourses);
            groupBoxAssignCourses.Controls.Add(label18);
            resources.ApplyResources(groupBoxAssignCourses, "groupBoxAssignCourses");
            groupBoxAssignCourses.Name = "groupBoxAssignCourses";
            groupBoxAssignCourses.TabStop = false;
            // 
            // btn_AddthisCoursetoIns
            // 
            resources.ApplyResources(btn_AddthisCoursetoIns, "btn_AddthisCoursetoIns");
            btn_AddthisCoursetoIns.Name = "btn_AddthisCoursetoIns";
            btn_AddthisCoursetoIns.UseVisualStyleBackColor = true;
            btn_AddthisCoursetoIns.Click += btn_AddthisCoursetoIns_Click;
            // 
            // listBoxUnassignedCourses
            // 
            listBoxUnassignedCourses.FormattingEnabled = true;
            resources.ApplyResources(listBoxUnassignedCourses, "listBoxUnassignedCourses");
            listBoxUnassignedCourses.Name = "listBoxUnassignedCourses";
            // 
            // label25
            // 
            resources.ApplyResources(label25, "label25");
            label25.Name = "label25";
            // 
            // label24
            // 
            resources.ApplyResources(label24, "label24");
            label24.Name = "label24";
            // 
            // comboBoxInstructors
            // 
            comboBoxInstructors.FormattingEnabled = true;
            resources.ApplyResources(comboBoxInstructors, "comboBoxInstructors");
            comboBoxInstructors.Name = "comboBoxInstructors";
            comboBoxInstructors.SelectedIndexChanged += comboBoxInstructors_SelectedIndexChanged;
            // 
            // btn_RemoveThisInsCrs
            // 
            resources.ApplyResources(btn_RemoveThisInsCrs, "btn_RemoveThisInsCrs");
            btn_RemoveThisInsCrs.Name = "btn_RemoveThisInsCrs";
            btn_RemoveThisInsCrs.UseVisualStyleBackColor = true;
            btn_RemoveThisInsCrs.Click += btn_RemoveThisInsCrs_Click;
            // 
            // listBoxAssignedCourses
            // 
            listBoxAssignedCourses.FormattingEnabled = true;
            resources.ApplyResources(listBoxAssignedCourses, "listBoxAssignedCourses");
            listBoxAssignedCourses.Name = "listBoxAssignedCourses";
            // 
            // label18
            // 
            resources.ApplyResources(label18, "label18");
            label18.Name = "label18";
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
            groupBox1.Controls.Add(comboBoxBranches);
            groupBox1.Controls.Add(comboBoxTracks);
            groupBox1.Controls.Add(label31);
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
            // comboBoxBranches
            // 
            comboBoxBranches.FormattingEnabled = true;
            resources.ApplyResources(comboBoxBranches, "comboBoxBranches");
            comboBoxBranches.Name = "comboBoxBranches";
            // 
            // comboBoxTracks
            // 
            comboBoxTracks.FormattingEnabled = true;
            resources.ApplyResources(comboBoxTracks, "comboBoxTracks");
            comboBoxTracks.Name = "comboBoxTracks";
            // 
            // label31
            // 
            resources.ApplyResources(label31, "label31");
            label31.Name = "label31";
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
            groupBoxUpdateStd.Controls.Add(comboBoxStdBranch);
            groupBoxUpdateStd.Controls.Add(comboBoxStdTrack);
            groupBoxUpdateStd.Controls.Add(labelStdBranch);
            groupBoxUpdateStd.Controls.Add(labelStdTrack);
            groupBoxUpdateStd.Controls.Add(label32);
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
            groupBoxUpdateStd.Enter += groupBoxUpdateStd_Enter;
            // 
            // comboBoxStdBranch
            // 
            comboBoxStdBranch.FormattingEnabled = true;
            resources.ApplyResources(comboBoxStdBranch, "comboBoxStdBranch");
            comboBoxStdBranch.Name = "comboBoxStdBranch";
            // 
            // comboBoxStdTrack
            // 
            comboBoxStdTrack.FormattingEnabled = true;
            resources.ApplyResources(comboBoxStdTrack, "comboBoxStdTrack");
            comboBoxStdTrack.Name = "comboBoxStdTrack";
            // 
            // labelStdBranch
            // 
            resources.ApplyResources(labelStdBranch, "labelStdBranch");
            labelStdBranch.Name = "labelStdBranch";
            // 
            // labelStdTrack
            // 
            resources.ApplyResources(labelStdTrack, "labelStdTrack");
            labelStdTrack.Name = "labelStdTrack";
            // 
            // label32
            // 
            resources.ApplyResources(label32, "label32");
            label32.Name = "label32";
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
            tpUpdateInstructor.ResumeLayout(false);
            groupBoxupIns.ResumeLayout(false);
            groupBoxupIns.PerformLayout();
            tabAssignCourseToInstructor.ResumeLayout(false);
            groupBoxAssignCourses.ResumeLayout(false);
            groupBoxAssignCourses.PerformLayout();
            tpStudents.ResumeLayout(false);
            tabٍStudents.ResumeLayout(false);
            tabAddStudent.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            tabUpdateStudent.ResumeLayout(false);
            groupBoxUpdateStd.ResumeLayout(false);
            groupBoxUpdateStd.PerformLayout();
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

        private void TabAssignCourseToInstructor_Enter(object sender, EventArgs e)
        {
            throw new NotImplementedException();
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
        private TextBox tbInstructorNameAdd;
        private Label lblInstructorName;
        private TextBox TBInstructorPassAdd;
        private Label label3;
        private TextBox TBInstructorMailAdd;
        private Label label2;
        private TextBox TBInstructorLNameAdd;
        private Label label1;
        private TabControl tabٍStudents;
        private TabPage tabAddStudent;
        private TabPage tabUpdateStudent;
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
        private Label label14;
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
        private GroupBox groupBoxupIns;
        private TextBox textBox4;
        private Button btn_AssignNewCrs;
        private Label label19;
        private TextBox TBInstructorPass;
        private Label label20;
        private TextBox TBInstructorMail;
        private Label label21;
        private TextBox TBInstructorLName;
        private Label label22;
        private Button btn_updateIns;
        private TextBox TBInstructorFName;
        private Label label23;
        private Button btn_delIns;
        private ListBox listBoxinstructors;
        private TabPage tabAssignCourseToInstructor;
        private GroupBox groupBoxAssignCourses;
        private ListBox listBoxAssignedCourses;
        private Label label18;
        private Button btn_RemoveThisInsCrs;
        private Button btn_AddthisCoursetoIns;
        private ListBox listBoxUnassignedCourses;
        private Label label25;
        private Label label24;
        private ComboBox comboBoxInstructors;
        private ComboBox comboBoxInsBranches;
        private Label label27;
        private Label labelIssBranch;
        private ComboBox comboBoxINSBRCH;
        private Label label28;
        private Label label31;
        private ComboBox comboBoxBranches;
        private ComboBox comboBoxTracks;
        private Label label32;
        private Label labelStdTrack;
        private ComboBox comboBoxStdBranch;
        private ComboBox comboBoxStdTrack;
        private Label labelStdBranch;
    }
}