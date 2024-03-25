namespace ExSys
{
    partial class loginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(loginForm));
            label1 = new Label();
            label2 = new Label();
            txtEmail = new TextBox();
            txtPass = new TextBox();
            label3 = new Label();
            BtnClose = new PictureBox();
            BtnMinus = new PictureBox();
            Login = new Button();
            lblError = new Label();
            chkBoxPass = new CheckBox();
            panel1 = new Panel();
            panel2 = new Panel();
            ((System.ComponentModel.ISupportInitialize)BtnClose).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BtnMinus).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.ForeColor = Color.FromArgb(0, 117, 224);
            label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(label2, "label2");
            label2.ForeColor = Color.FromArgb(0, 117, 224);
            label2.Name = "label2";
            // 
            // txtEmail
            // 
            resources.ApplyResources(txtEmail, "txtEmail");
            txtEmail.Name = "txtEmail";
            // 
            // txtPass
            // 
            resources.ApplyResources(txtPass, "txtPass");
            txtPass.Name = "txtPass";
            txtPass.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            resources.ApplyResources(label3, "label3");
            label3.ForeColor = Color.FromArgb(0, 117, 224);
            label3.Name = "label3";
            // 
            // BtnClose
            // 
            BtnClose.Cursor = Cursors.Hand;
            resources.ApplyResources(BtnClose, "BtnClose");
            BtnClose.Name = "BtnClose";
            BtnClose.TabStop = false;
            BtnClose.Click += BtnClose_Click;
            // 
            // BtnMinus
            // 
            BtnMinus.Cursor = Cursors.Hand;
            resources.ApplyResources(BtnMinus, "BtnMinus");
            BtnMinus.Name = "BtnMinus";
            BtnMinus.TabStop = false;
            BtnMinus.Click += BtnMinus_Click;
            // 
            // Login
            // 
            Login.Cursor = Cursors.Hand;
            resources.ApplyResources(Login, "Login");
            Login.ForeColor = Color.FromArgb(0, 117, 224);
            Login.Name = "Login";
            Login.UseVisualStyleBackColor = true;
            Login.Click += Login_Click;
            // 
            // lblError
            // 
            resources.ApplyResources(lblError, "lblError");
            lblError.ForeColor = Color.Red;
            lblError.Name = "lblError";
            // 
            // chkBoxPass
            // 
            resources.ApplyResources(chkBoxPass, "chkBoxPass");
            chkBoxPass.Name = "chkBoxPass";
            chkBoxPass.UseVisualStyleBackColor = true;
            chkBoxPass.CheckedChanged += chkBoxPass_CheckedChanged;
            // 
            // panel1
            // 
            panel1.Controls.Add(BtnMinus);
            panel1.Controls.Add(BtnClose);
            resources.ApplyResources(panel1, "panel1");
            panel1.Name = "panel1";
            // 
            // panel2
            // 
            panel2.Controls.Add(label1);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(chkBoxPass);
            panel2.Controls.Add(txtEmail);
            panel2.Controls.Add(lblError);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(Login);
            panel2.Controls.Add(txtPass);
            resources.ApplyResources(panel2, "panel2");
            panel2.Name = "panel2";
            // 
            // loginForm
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "loginForm";
            WindowState = FormWindowState.Maximized;
            Load += loginForm_Load;
            ((System.ComponentModel.ISupportInitialize)BtnClose).EndInit();
            ((System.ComponentModel.ISupportInitialize)BtnMinus).EndInit();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtEmail;
        private TextBox txtPass;
        private Label label3;
        private PictureBox BtnClose;
        private PictureBox BtnMinus;
        private Button Login;
        private Label lblError;
        private CheckBox chkBoxPass;
        private Panel panel1;
        private Panel panel2;
    }
}
