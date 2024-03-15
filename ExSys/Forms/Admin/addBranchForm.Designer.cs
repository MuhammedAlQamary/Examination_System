namespace ExSys.Forms.Admin
{
    partial class addBranchForm
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
            labelBranchName = new Label();
            groupBox1 = new GroupBox();
            buttonAddBranch = new Button();
            tbBranchName = new TextBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // labelBranchName
            // 
            labelBranchName.AutoSize = true;
            labelBranchName.Location = new Point(17, 37);
            labelBranchName.Name = "labelBranchName";
            labelBranchName.Size = new Size(79, 15);
            labelBranchName.TabIndex = 0;
            labelBranchName.Text = "Branch Name";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(buttonAddBranch);
            groupBox1.Controls.Add(tbBranchName);
            groupBox1.Controls.Add(labelBranchName);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(357, 121);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // buttonAddBranch
            // 
            buttonAddBranch.Location = new Point(245, 92);
            buttonAddBranch.Name = "buttonAddBranch";
            buttonAddBranch.Size = new Size(106, 23);
            buttonAddBranch.TabIndex = 2;
            buttonAddBranch.Text = "Add Branch";
            buttonAddBranch.UseVisualStyleBackColor = true;
            buttonAddBranch.Click += buttonAddBranch_Click;
            // 
            // tbBranchName
            // 
            tbBranchName.Location = new Point(102, 34);
            tbBranchName.Name = "tbBranchName";
            tbBranchName.Size = new Size(249, 23);
            tbBranchName.TabIndex = 1;
            // 
            // addBranchForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(429, 173);
            Controls.Add(groupBox1);
            Name = "addBranchForm";
            Text = "addBranchForm";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label labelBranchName;
        private GroupBox groupBox1;
        private Button buttonAddBranch;
        private TextBox tbBranchName;
    }
}