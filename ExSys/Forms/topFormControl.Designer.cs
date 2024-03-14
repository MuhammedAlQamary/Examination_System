namespace ExSys.Forms
{
    partial class topFormControl
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
            label1 = new Label();
            minimize_pictureBox = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)X_pictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)minimize_pictureBox).BeginInit();
            SuspendLayout();
            // 
            // X_pictureBox
            // 
            X_pictureBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            X_pictureBox.Image = Properties.Resources.cross_mark;
            X_pictureBox.Location = new Point(544, 7);
            X_pictureBox.Margin = new Padding(0);
            X_pictureBox.Name = "X_pictureBox";
            X_pictureBox.Size = new Size(50, 50);
            X_pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            X_pictureBox.TabIndex = 0;
            X_pictureBox.TabStop = false;
            X_pictureBox.Click += X_pictureBox_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(82, 16);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 1;
            label1.Text = "label1";
            // 
            // minimize_pictureBox
            // 
            minimize_pictureBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            minimize_pictureBox.Image = Properties.Resources.minus_button;
            minimize_pictureBox.Location = new Point(225, 7);
            minimize_pictureBox.Margin = new Padding(0);
            minimize_pictureBox.Name = "minimize_pictureBox";
            minimize_pictureBox.Size = new Size(50, 50);
            minimize_pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            minimize_pictureBox.TabIndex = 2;
            minimize_pictureBox.TabStop = false;
            minimize_pictureBox.Click += minimize_pictureBox_Click;
            // 
            // topFormControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(minimize_pictureBox);
            Controls.Add(label1);
            Margin = new Padding(0);
            Name = "topFormControl";
            Size = new Size(605, 65);
            ((System.ComponentModel.ISupportInitialize)X_pictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)minimize_pictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private PictureBox minimize_pictureBox;
    }
}
