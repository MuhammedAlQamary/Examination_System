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
    public partial class adminForm : Form
    {
        public adminForm()
        {
            // topformcontrol = new topFormControl();
            InitializeComponent();
            topFormControl topFormControl = new topFormControl();
            topFormControl.Dock = DockStyle.Top;
            this.Controls.Add(topFormControl);
        }
    }
}
