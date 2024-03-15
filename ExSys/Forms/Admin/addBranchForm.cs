using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExSys.Forms.Admin
{
    public partial class addBranchForm : Form
    {
        public addBranchForm()
        {
            InitializeComponent();
        }

        private void buttonAddBranch_Click(object sender, EventArgs e)
        {
            string branchName = tbBranchName.Text;
            /// <summary>
            /// StoredProcedure
            /// Add a new branch(name) to the database 
            /// check if the branch name is already exist
            /// if not exist add the branch to the database return true
            /// else return false
            /// </summary>
            // boolean sp_Result = 
            // if (sp_Result)
            // {
            //     MessageBox.Show("Branch added successfully");
            // }
            // else
            // {
            //     MessageBox.Show("Branch already exist");
            // }

        }
    }
}
