using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExSys.Forms
{
    public partial class topFormControl : UserControl
    {
        public topFormControl()
        {
            InitializeComponent();
        }

        private void X_pictureBox_Click(object sender, EventArgs e)
        {
            // Close the application
            Application.Exit();
        }

        private void minimize_pictureBox_Click(object sender, EventArgs e)
        {
            // Minimize the application
            this.FindForm().WindowState = FormWindowState.Minimized;

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //this.close();

            Application.Exit();
            Application.Restart();
        }
    }
}
