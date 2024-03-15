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
        // Create Branch class (id, 
        class Branch
        {
            public int id { get; set; }
            public string name { get; set; }
            public string address { get; set; }
            public string phone { get; set; }
            public string email { get; set; }
        }

        public adminForm()
        {
            // topformcontrol = new topFormControl();
            InitializeComponent();
            topFormControl topFormControl = new topFormControl();
            topFormControl.Dock = DockStyle.Top;
            this.Controls.Add(topFormControl);

            this.Controls.Add(new InstructorDataController());

        }

        // Create a list of Branches

        private void adminForm_Load(object sender, EventArgs e)
        {
            // Create a list of Branches
            List<Branch> branches = new List<Branch>()
            {
                new Branch() { id = 1, name = "Branch 1"},
                new Branch() { id = 2, name = "Branch 2"},
                new Branch() { id = 3, name = "Branch 3"},
            };
            // populate the list of branches
            listBoxBranches.DataSource = branches;
            listBoxBranches.DisplayMember = "name";
            listBoxBranches.SelectedIndex = 0;

            // Create a list of Trackes
            List<Branch> trackes = new List<Branch>()
            {
                new Branch() { id = 1, name = "Tracke 1"},
                new Branch() { id = 2, name = "Tracke 2"},
                new Branch() { id = 3, name = "Tracke 3"},
            };
            // populate the list of trackes
            listBoxTrackes.DataSource = trackes;
            listBoxTrackes.DisplayMember = "name";
            listBoxTrackes.SelectedIndex = 0;

            // assign 

        }

        private void buttonAddBranch_Click(object sender, EventArgs e)
        {

        }

        private void btnAddInstructor_Click(object sender, EventArgs e)
        {
            /// <summary>
            /// StoredProcedure add a new instructor to the database
            /// check if the instructor email is already exist
            /// if not exist add the instructor to the database return true
            /// else return false
            /// 
            string fname = tbInstructorFName.Text;
            string lname = tbInstructorLName.Text;
            string email = tbInstructorEmail.Text;
            string password = tbInstructorPassword.Text;
            // using (SqlConnection con = new SqlConnection(connectionString))
            // {
            //     using (SqlCommand cmd = new SqlCommand("AddInstructor", con))
            //     {
            //         cmd.CommandType = CommandType.StoredProcedure;
            //         cmd.Parameters.AddWithValue("@FName", fname);
            //         cmd.Parameters.AddWithValue("@LName", lname);
            //         cmd.Parameters.AddWithValue("@Email", email);
            //         cmd.Parameters.AddWithValue("@Password", password);
            //         con.Open();
            //         cmd.ExecuteNonQuery();
            //         con.Close();
            //     }
            // }

        }

        private void listBoxBranches_SelectedIndexChanged(object sender, EventArgs e)
        {
            // when selected index changed, populate the list of trackes based on the selected branch
            



        }

        // on form load, populate the list of branches



    }
}
