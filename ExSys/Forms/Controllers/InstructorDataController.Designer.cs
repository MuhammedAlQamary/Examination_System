namespace ExSys.Forms
{
    partial class InstructorDataController
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tbInstructorPassword = new TextBox();
            label3 = new Label();
            tbInstructorEmail = new TextBox();
            label2 = new Label();
            tbInstructorLName = new TextBox();
            label1 = new Label();
            tbInstructorFName = new TextBox();
            lblInstructorName = new Label();
            SuspendLayout();
            // 
            // tbInstructorPassword
            // 
            tbInstructorPassword.Location = new Point(148, 132);
            tbInstructorPassword.Name = "tbInstructorPassword";
            tbInstructorPassword.Size = new Size(235, 23);
            tbInstructorPassword.TabIndex = 16;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ImeMode = ImeMode.NoControl;
            label3.Location = new Point(24, 135);
            label3.Name = "label3";
            label3.Size = new Size(111, 15);
            label3.TabIndex = 15;
            label3.Text = "Instructor Password";
            // 
            // tbInstructorEmail
            // 
            tbInstructorEmail.Location = new Point(148, 93);
            tbInstructorEmail.Name = "tbInstructorEmail";
            tbInstructorEmail.Size = new Size(235, 23);
            tbInstructorEmail.TabIndex = 14;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ImeMode = ImeMode.NoControl;
            label2.Location = new Point(24, 96);
            label2.Name = "label2";
            label2.Size = new Size(90, 15);
            label2.TabIndex = 13;
            label2.Text = "Instructor Email";
            // 
            // tbInstructorLName
            // 
            tbInstructorLName.Location = new Point(147, 56);
            tbInstructorLName.Name = "tbInstructorLName";
            tbInstructorLName.Size = new Size(235, 23);
            tbInstructorLName.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ImeMode = ImeMode.NoControl;
            label1.Location = new Point(23, 59);
            label1.Name = "label1";
            label1.Size = new Size(117, 15);
            label1.TabIndex = 11;
            label1.Text = "Instructor Last Name";
            // 
            // tbInstructorFName
            // 
            tbInstructorFName.Location = new Point(147, 20);
            tbInstructorFName.Name = "tbInstructorFName";
            tbInstructorFName.Size = new Size(235, 23);
            tbInstructorFName.TabIndex = 10;
            // 
            // lblInstructorName
            // 
            lblInstructorName.AutoSize = true;
            lblInstructorName.ImeMode = ImeMode.NoControl;
            lblInstructorName.Location = new Point(23, 23);
            lblInstructorName.Name = "lblInstructorName";
            lblInstructorName.Size = new Size(118, 15);
            lblInstructorName.TabIndex = 9;
            lblInstructorName.Text = "Instructor First Name";
            // 
            // BranchDataController
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tbInstructorPassword);
            Controls.Add(label3);
            Controls.Add(tbInstructorEmail);
            Controls.Add(label2);
            Controls.Add(tbInstructorLName);
            Controls.Add(label1);
            Controls.Add(tbInstructorFName);
            Controls.Add(lblInstructorName);
            Name = "BranchDataController";
            Size = new Size(411, 181);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbInstructorPassword;
        private Label label3;
        private TextBox tbInstructorEmail;
        private Label label2;
        private TextBox tbInstructorLName;
        private Label label1;
        private TextBox tbInstructorFName;
        private Label lblInstructorName;
    }
}
