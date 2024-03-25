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
            minimize_pictureBox = new PictureBox();
            pictureBox1 = new PictureBox();
            sqlCommandBuilder1 = new Microsoft.Data.SqlClient.SqlCommandBuilder();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)X_pictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)minimize_pictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // X_pictureBox
            // 
            X_pictureBox.Cursor = Cursors.Hand;
            X_pictureBox.Dock = DockStyle.Right;
            X_pictureBox.Image = Properties.Resources.cross_mark;
            X_pictureBox.Location = new Point(628, 0);
            X_pictureBox.Margin = new Padding(5);
            X_pictureBox.Name = "X_pictureBox";
            X_pictureBox.Size = new Size(57, 81);
            X_pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            X_pictureBox.TabIndex = 0;
            X_pictureBox.TabStop = false;
            X_pictureBox.Click += X_pictureBox_Click;
            // 
            // minimize_pictureBox
            // 
            minimize_pictureBox.Cursor = Cursors.Hand;
            minimize_pictureBox.Dock = DockStyle.Right;
            minimize_pictureBox.Image = Properties.Resources.minus_button;
            minimize_pictureBox.Location = new Point(571, 0);
            minimize_pictureBox.Margin = new Padding(5);
            minimize_pictureBox.Name = "minimize_pictureBox";
            minimize_pictureBox.Size = new Size(57, 81);
            minimize_pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            minimize_pictureBox.TabIndex = 2;
            minimize_pictureBox.TabStop = false;
            minimize_pictureBox.Click += minimize_pictureBox_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Dock = DockStyle.Left;
            pictureBox1.Image = Properties.Resources.logout;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Margin = new Padding(0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(57, 81);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(minimize_pictureBox);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(X_pictureBox);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(685, 81);
            panel1.TabIndex = 4;
            // 
            // topFormControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Margin = new Padding(2);
            Name = "topFormControl";
            Padding = new Padding(3);
            Size = new Size(691, 87);
            ((System.ComponentModel.ISupportInitialize)X_pictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)minimize_pictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private PictureBox X_pictureBox;
        private PictureBox minimize_pictureBox;
        private PictureBox pictureBox1;
        private Microsoft.Data.SqlClient.SqlCommandBuilder sqlCommandBuilder1;
        private Panel panel1;
    }
}
