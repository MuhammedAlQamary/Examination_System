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
    public partial class Formteacher : Form
    {
        public Formteacher()
        {
            InitializeComponent();
            topFormControl topFormControl = new topFormControl();
            topFormControl.Dock = DockStyle.Top;
            this.Controls.Add(topFormControl);
        }

        private void tabPage6_Click(object sender, EventArgs e)
        {

        }

        private void Question_Click(object sender, EventArgs e)
        {

        }
    }
}
