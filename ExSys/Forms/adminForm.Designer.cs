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
            groupBoxTrackes = new GroupBox();
            buttonTrackes = new Button();
            listBoxTrackes = new ListBox();
            groupBoxBranches = new GroupBox();
            buttonAddBranch = new Button();
            listBoxBranches = new ListBox();
            tpInstructors = new TabPage();
            tabControl1 = new TabControl();
            Branches = new TabPage();
            tTrackes = new TabPage();
            tdUpdateInstructor = new TabControl();
            tpAddInstructor = new TabPage();
            tpUpdateInstructor = new TabPage();
            label1 = new Label();
            tpStudents = new TabPage();
            adminTabControl.SuspendLayout();
            tp.SuspendLayout();
            groupBoxTrackes.SuspendLayout();
            groupBoxBranches.SuspendLayout();
            tpInstructors.SuspendLayout();
            tabControl1.SuspendLayout();
            Branches.SuspendLayout();
            tTrackes.SuspendLayout();
            tdUpdateInstructor.SuspendLayout();
            tpAddInstructor.SuspendLayout();
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
            // 
            // listBoxBranches
            // 
            resources.ApplyResources(listBoxBranches, "listBoxBranches");
            listBoxBranches.FormattingEnabled = true;
            listBoxBranches.Name = "listBoxBranches";
            // 
            // tpInstructors
            // 
            tpInstructors.Controls.Add(tdUpdateInstructor);
            resources.ApplyResources(tpInstructors, "tpInstructors");
            tpInstructors.Name = "tpInstructors";
            tpInstructors.UseVisualStyleBackColor = true;
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
            // tTrackes
            // 
            tTrackes.Controls.Add(groupBoxTrackes);
            resources.ApplyResources(tTrackes, "tTrackes");
            tTrackes.Name = "tTrackes";
            tTrackes.UseVisualStyleBackColor = true;
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
            tpAddInstructor.Controls.Add(label1);
            resources.ApplyResources(tpAddInstructor, "tpAddInstructor");
            tpAddInstructor.Name = "tpAddInstructor";
            tpAddInstructor.UseVisualStyleBackColor = true;
            // 
            // tpUpdateInstructor
            // 
            resources.ApplyResources(tpUpdateInstructor, "tpUpdateInstructor");
            tpUpdateInstructor.Name = "tpUpdateInstructor";
            tpUpdateInstructor.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.Name = "label1";
            // 
            // tpStudents
            // 
            resources.ApplyResources(tpStudents, "tpStudents");
            tpStudents.Name = "tpStudents";
            tpStudents.UseVisualStyleBackColor = true;
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
            groupBoxTrackes.ResumeLayout(false);
            groupBoxBranches.ResumeLayout(false);
            tpInstructors.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
            Branches.ResumeLayout(false);
            tTrackes.ResumeLayout(false);
            tdUpdateInstructor.ResumeLayout(false);
            tpAddInstructor.ResumeLayout(false);
            tpAddInstructor.PerformLayout();
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
        private Label label1;
        private TabPage tpStudents;
    }
}