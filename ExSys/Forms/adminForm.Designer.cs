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
            tpTrack = new TabPage();
            tabControl1 = new TabControl();
            Branches = new TabPage();
            groupBox1 = new GroupBox();
            textBox2 = new TextBox();
            label7 = new Label();
            btnAddBranch = new Button();
            gbAddBranch = new GroupBox();
            gbBranchTracks = new GroupBox();
            listBox1 = new ListBox();
            listBox2 = new ListBox();
            button1 = new Button();
            label6 = new Label();
            tbBranchSerialNumber = new TextBox();
            label5 = new Label();
            tbBranchName = new TextBox();
            label4 = new Label();
            buttonUpdateBranch = new Button();
            groupBoxBranches = new GroupBox();
            listBoxBranches = new ListBox();
            tTrackes = new TabPage();
            groupBoxTrackes = new GroupBox();
            buttonTrackes = new Button();
            listBoxTrackes = new ListBox();
            tpInstructors = new TabPage();
            tdUpdateInstructor = new TabControl();
            tpAddInstructor = new TabPage();
            gbAddInstructor = new GroupBox();
            tbInstructorPassword = new TextBox();
            label3 = new Label();
            tbInstructorEmail = new TextBox();
            label2 = new Label();
            tbInstructorLName = new TextBox();
            label1 = new Label();
            btnAddInstructor = new Button();
            tbInstructorFName = new TextBox();
            lblInstructorName = new Label();
            tpUpdateInstructor = new TabPage();
            gbUpdateInstructor = new GroupBox();
            lbInstructors = new ListBox();
            tpStudents = new TabPage();
            label8 = new Label();
            adminTabControl.SuspendLayout();
            tpTrack.SuspendLayout();
            tabControl1.SuspendLayout();
            Branches.SuspendLayout();
            groupBox1.SuspendLayout();
            gbAddBranch.SuspendLayout();
            gbBranchTracks.SuspendLayout();
            groupBoxBranches.SuspendLayout();
            tTrackes.SuspendLayout();
            groupBoxTrackes.SuspendLayout();
            tpInstructors.SuspendLayout();
            tdUpdateInstructor.SuspendLayout();
            tpAddInstructor.SuspendLayout();
            gbAddInstructor.SuspendLayout();
            tpUpdateInstructor.SuspendLayout();
            gbUpdateInstructor.SuspendLayout();
            SuspendLayout();
            // 
            // adminTabControl
            // 
            adminTabControl.Controls.Add(tpTrack);
            adminTabControl.Controls.Add(tpInstructors);
            adminTabControl.Controls.Add(tpStudents);
            resources.ApplyResources(adminTabControl, "adminTabControl");
            adminTabControl.Name = "adminTabControl";
            adminTabControl.SelectedIndex = 0;
            adminTabControl.SizeMode = TabSizeMode.FillToRight;
            // 
            // tpTrack
            // 
            tpTrack.Controls.Add(tabControl1);
            resources.ApplyResources(tpTrack, "tpTrack");
            tpTrack.Name = "tpTrack";
            tpTrack.UseVisualStyleBackColor = true;
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
            Branches.Controls.Add(groupBox1);
            Branches.Controls.Add(gbAddBranch);
            Branches.Controls.Add(groupBoxBranches);
            resources.ApplyResources(Branches, "Branches");
            Branches.Name = "Branches";
            Branches.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(btnAddBranch);
            resources.ApplyResources(groupBox1, "groupBox1");
            groupBox1.Name = "groupBox1";
            groupBox1.TabStop = false;
            // 
            // textBox2
            // 
            resources.ApplyResources(textBox2, "textBox2");
            textBox2.Name = "textBox2";
            // 
            // label7
            // 
            resources.ApplyResources(label7, "label7");
            label7.Name = "label7";
            // 
            // btnAddBranch
            // 
            resources.ApplyResources(btnAddBranch, "btnAddBranch");
            btnAddBranch.Name = "btnAddBranch";
            btnAddBranch.UseVisualStyleBackColor = true;
            // 
            // gbAddBranch
            // 
            gbAddBranch.Controls.Add(gbBranchTracks);
            gbAddBranch.Controls.Add(label6);
            gbAddBranch.Controls.Add(tbBranchSerialNumber);
            gbAddBranch.Controls.Add(label5);
            gbAddBranch.Controls.Add(tbBranchName);
            gbAddBranch.Controls.Add(label4);
            gbAddBranch.Controls.Add(buttonUpdateBranch);
            resources.ApplyResources(gbAddBranch, "gbAddBranch");
            gbAddBranch.Name = "gbAddBranch";
            gbAddBranch.TabStop = false;
            // 
            // gbBranchTracks
            // 
            gbBranchTracks.Controls.Add(label8);
            gbBranchTracks.Controls.Add(listBox1);
            gbBranchTracks.Controls.Add(listBox2);
            gbBranchTracks.Controls.Add(button1);
            resources.ApplyResources(gbBranchTracks, "gbBranchTracks");
            gbBranchTracks.Name = "gbBranchTracks";
            gbBranchTracks.TabStop = false;
            // 
            // listBox1
            // 
            resources.ApplyResources(listBox1, "listBox1");
            listBox1.FormattingEnabled = true;
            listBox1.Name = "listBox1";
            // 
            // listBox2
            // 
            resources.ApplyResources(listBox2, "listBox2");
            listBox2.FormattingEnabled = true;
            listBox2.Name = "listBox2";
            // 
            // button1
            // 
            resources.ApplyResources(button1, "button1");
            button1.Name = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            resources.ApplyResources(label6, "label6");
            label6.Name = "label6";
            // 
            // tbBranchSerialNumber
            // 
            resources.ApplyResources(tbBranchSerialNumber, "tbBranchSerialNumber");
            tbBranchSerialNumber.Name = "tbBranchSerialNumber";
            tbBranchSerialNumber.ReadOnly = true;
            // 
            // label5
            // 
            resources.ApplyResources(label5, "label5");
            label5.Name = "label5";
            // 
            // tbBranchName
            // 
            resources.ApplyResources(tbBranchName, "tbBranchName");
            tbBranchName.Name = "tbBranchName";
            // 
            // label4
            // 
            resources.ApplyResources(label4, "label4");
            label4.Name = "label4";
            // 
            // buttonUpdateBranch
            // 
            resources.ApplyResources(buttonUpdateBranch, "buttonUpdateBranch");
            buttonUpdateBranch.Name = "buttonUpdateBranch";
            buttonUpdateBranch.UseVisualStyleBackColor = true;
            buttonUpdateBranch.Click += buttonAddBranch_Click;
            // 
            // groupBoxBranches
            // 
            groupBoxBranches.Controls.Add(listBoxBranches);
            resources.ApplyResources(groupBoxBranches, "groupBoxBranches");
            groupBoxBranches.Name = "groupBoxBranches";
            groupBoxBranches.TabStop = false;
            // 
            // listBoxBranches
            // 
            resources.ApplyResources(listBoxBranches, "listBoxBranches");
            listBoxBranches.FormattingEnabled = true;
            listBoxBranches.Name = "listBoxBranches";
            listBoxBranches.SelectedIndexChanged += listBoxBranches_SelectedIndexChanged;
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
            gbAddInstructor.Controls.Add(tbInstructorPassword);
            gbAddInstructor.Controls.Add(label3);
            gbAddInstructor.Controls.Add(tbInstructorEmail);
            gbAddInstructor.Controls.Add(label2);
            gbAddInstructor.Controls.Add(tbInstructorLName);
            gbAddInstructor.Controls.Add(label1);
            gbAddInstructor.Controls.Add(btnAddInstructor);
            gbAddInstructor.Controls.Add(tbInstructorFName);
            gbAddInstructor.Controls.Add(lblInstructorName);
            resources.ApplyResources(gbAddInstructor, "gbAddInstructor");
            gbAddInstructor.Name = "gbAddInstructor";
            gbAddInstructor.TabStop = false;
            // 
            // tbInstructorPassword
            // 
            resources.ApplyResources(tbInstructorPassword, "tbInstructorPassword");
            tbInstructorPassword.Name = "tbInstructorPassword";
            // 
            // label3
            // 
            resources.ApplyResources(label3, "label3");
            label3.Name = "label3";
            // 
            // tbInstructorEmail
            // 
            resources.ApplyResources(tbInstructorEmail, "tbInstructorEmail");
            tbInstructorEmail.Name = "tbInstructorEmail";
            // 
            // label2
            // 
            resources.ApplyResources(label2, "label2");
            label2.Name = "label2";
            // 
            // tbInstructorLName
            // 
            resources.ApplyResources(tbInstructorLName, "tbInstructorLName");
            tbInstructorLName.Name = "tbInstructorLName";
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
            // tbInstructorFName
            // 
            resources.ApplyResources(tbInstructorFName, "tbInstructorFName");
            tbInstructorFName.Name = "tbInstructorFName";
            // 
            // lblInstructorName
            // 
            resources.ApplyResources(lblInstructorName, "lblInstructorName");
            lblInstructorName.Name = "lblInstructorName";
            // 
            // tpUpdateInstructor
            // 
            tpUpdateInstructor.Controls.Add(gbUpdateInstructor);
            resources.ApplyResources(tpUpdateInstructor, "tpUpdateInstructor");
            tpUpdateInstructor.Name = "tpUpdateInstructor";
            tpUpdateInstructor.UseVisualStyleBackColor = true;
            // 
            // gbUpdateInstructor
            // 
            gbUpdateInstructor.Controls.Add(lbInstructors);
            resources.ApplyResources(gbUpdateInstructor, "gbUpdateInstructor");
            gbUpdateInstructor.Name = "gbUpdateInstructor";
            gbUpdateInstructor.TabStop = false;
            // 
            // lbInstructors
            // 
            resources.ApplyResources(lbInstructors, "lbInstructors");
            lbInstructors.FormattingEnabled = true;
            lbInstructors.Name = "lbInstructors";
            // 
            // tpStudents
            // 
            resources.ApplyResources(tpStudents, "tpStudents");
            tpStudents.Name = "tpStudents";
            tpStudents.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            resources.ApplyResources(label8, "label8");
            label8.Name = "label8";
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
            tpTrack.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
            Branches.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            gbAddBranch.ResumeLayout(false);
            gbAddBranch.PerformLayout();
            gbBranchTracks.ResumeLayout(false);
            gbBranchTracks.PerformLayout();
            groupBoxBranches.ResumeLayout(false);
            tTrackes.ResumeLayout(false);
            groupBoxTrackes.ResumeLayout(false);
            tpInstructors.ResumeLayout(false);
            tdUpdateInstructor.ResumeLayout(false);
            tpAddInstructor.ResumeLayout(false);
            gbAddInstructor.ResumeLayout(false);
            gbAddInstructor.PerformLayout();
            tpUpdateInstructor.ResumeLayout(false);
            gbUpdateInstructor.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl adminTabControl;
        private TabPage tpTrack;
        private TabPage tpInstructors;
        private GroupBox groupBoxBranches;
        private Button buttonUpdateBranch;
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
        private TextBox tbInstructorFName;
        private Label lblInstructorName;
        private TextBox tbInstructorPassword;
        private Label label3;
        private TextBox tbInstructorEmail;
        private Label label2;
        private TextBox tbInstructorLName;
        private Label label1;
        private GroupBox gbUpdateInstructor;
        private ListBox lbInstructors;
        private ListBox listBoxBranches;
        private GroupBox gbAddBranch;
        private TextBox tbBranchName;
        private Label label4;
        private TextBox tbBranchSerialNumber;
        private Label label5;
        private GroupBox groupBox1;
        private TextBox textBox2;
        private Label label7;
        private Button btnAddBranch;
        private Label label6;
        private GroupBox gbBranchTracks;
        private ListBox listBox1;
        private ListBox listBox2;
        private Button button1;
        private Label label8;
    }
}