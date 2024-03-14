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
            X_pictureBox = new PictureBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)X_pictureBox).BeginInit();
            SuspendLayout();
            // 
            // X_pictureBox
            // 
            X_pictureBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            X_pictureBox.Location = new Point(497, 7);
            X_pictureBox.Margin = new Padding(0);
            X_pictureBox.Name = "X_pictureBox";
            X_pictureBox.Size = new Size(100, 50);
            X_pictureBox.TabIndex = 0;
            X_pictureBox.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(72, 12);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 1;
            label1.Text = "label1";
            // 
            // topFormControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label1);
            Controls.Add(X_pictureBox);
            Margin = new Padding(0);
            Name = "topFormControl";
            Size = new Size(605, 65);
            ((System.ComponentModel.ISupportInitialize)X_pictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox X_pictureBox;
        private Label label1;
    }
}
