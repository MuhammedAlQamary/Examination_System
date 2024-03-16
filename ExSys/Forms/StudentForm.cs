using ExSys.Models;
using ExSys.MyModels;
using Microsoft.Data.SqlClient;
using Microsoft.Identity.Client.NativeInterop;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ExSys.Forms
{
    public partial class StudentForm : Form
    {
        private int studentid;

        public StudentForm(int id)
        {
            studentid = id;
            InitializeComponent();
            topFormControl topFormControl = new topFormControl();
            topFormControl.Dock = DockStyle.Top;
            this.Controls.Add(topFormControl);
        }

        private void StudentForm_Load(object sender, EventArgs e)
        {
            
           
        }

        private void comboBoxStdCrs_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
    }
}
