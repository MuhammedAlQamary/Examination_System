using ExSys;
using ExSys.Models;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
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
        }




        #region students CRUD
        private void tabٍStudents_Enter(object sender, EventArgs e)
        {

            //show all student names in the list box
            using (var context = new ExSysContext())
            {
                var students = context.Students.ToList();
                listBoxStd.DataSource = students;
                listBoxStd.DisplayMember = "StudentFname";
                listBoxStd.ValueMember = "StudentId";
            }
        }

        private void listBoxStd_SelectedIndexChanged(object sender, EventArgs e)
        {
            TBStudentFName.DataBindings.Clear();
            TBStudentLName.DataBindings.Clear();
            TBStudentMail.DataBindings.Clear();
            TBStudentPassword.DataBindings.Clear();
            TBStudentTrack.DataBindings.Clear();

            TBStudentFName.DataBindings.Add("Text", listBoxStd.DataSource, "StudentFname");
            TBStudentLName.DataBindings.Add("Text", listBoxStd.DataSource, "StudentLname");
            TBStudentMail.DataBindings.Add("Text", listBoxStd.DataSource, "StudentEmail");
            TBStudentPassword.DataBindings.Add("Text", listBoxStd.DataSource, "StudentPassword");
            TBStudentTrack.DataBindings.Add("Text", listBoxStd.DataSource, "TrackId");
        }

        private void btn_UpdateStd_Click(object sender, EventArgs e)
        {

            int studentId = (int)listBoxStd.SelectedValue;
            string studentFname = TBStudentFName.Text;
            string studentLname = TBStudentLName.Text;
            string studentEmail = TBStudentMail.Text;
            string studentPassword = TBStudentPassword.Text;
            int trackId = int.Parse(TBStudentTrack.Text);

            using (var context = new ExSysContext())
            {
                // Call the method to update the student
                context.UpdateStudent(studentId, studentFname, studentLname, studentEmail, studentPassword, trackId);

                MessageBox.Show("Student Updated Successfully");
            }


        }

        private void btn_DeleteStd_Click(object sender, EventArgs e)
        {
           

            //make it between try and catch for foreign key if it is used in another table
            try
            {
                int studentId = (int)listBoxStd.SelectedValue;
                DialogResult result = MessageBox.Show("Are you sure you want to delete this student?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    using (var context = new ExSysContext())
                    {
                        // Call the method to delete the student
                        context.DeleteStudent(studentId);

                        MessageBox.Show("Student Deleted Successfully");
                        RefreshStudentList();
                    }
                }
            }
            catch (SqlException ex)
            {
                // Handle database-related exceptions
                MessageBox.Show("You can't delete this student because it's used in another table", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Method to refresh the list of students

        private void btn_AddStudent_Click(object sender, EventArgs e)
        {
            // Perform client-side validation
            if (string.IsNullOrWhiteSpace(TBStudentFNameAdd.Text) ||
                string.IsNullOrWhiteSpace(TBStudentLNameAdd.Text) ||
                string.IsNullOrWhiteSpace(TBStudentMailAdd.Text) ||
                string.IsNullOrWhiteSpace(TBStudentPasswordAdd.Text) ||
                string.IsNullOrWhiteSpace(TBStudentTrackAdd.Text))
            {
                MessageBox.Show("All fields are required.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validate email format
            if (!IsValidEmail(TBStudentMailAdd.Text))
            {
                MessageBox.Show("Invalid email format.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validate password strength
            if (TBStudentPasswordAdd.Text.Length < 8)
            {
                MessageBox.Show("Password must be at least 8 characters long.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Convert track ID to integer
            if (!int.TryParse(TBStudentTrackAdd.Text, out int trackId))
            {
                MessageBox.Show("Invalid track ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Call the method to add the student
            using (var context = new ExSysContext())
            {
                try
                {
                    context.AddStudent(TBStudentFNameAdd.Text, TBStudentLNameAdd.Text, TBStudentMailAdd.Text, TBStudentPasswordAdd.Text, trackId);

                    // Save changes to the database
                    context.SaveChanges();

                    MessageBox.Show("Student added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RefreshStudentList();
                }
                catch (DbUpdateException ex)
                {
                    // Handle database-related exceptions
                    MessageBox.Show(ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Method to validate email format
        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        private void RefreshStudentList()
        {
            using (var context = new ExSysContext())
            {
                var students = context.Students.ToList();
                listBoxStd.DataSource = students;
                listBoxStd.DisplayMember = "StudentFname";
                listBoxStd.ValueMember = "StudentId";
            }
        }

        #endregion

        #region Courses CRUD
        private void tabUpdateCourse_Enter(object sender, EventArgs e)
        {
            //show all course in the listbox
            using (var context = new ExSysContext())
            {
                var courses = context.Courses.ToList();
                listBoxCourses.DataSource = courses;
                listBoxCourses.DisplayMember = "CourseName";
                listBoxCourses.ValueMember = "CourseId";
            }
        }

        private void listBoxCourses_SelectedIndexChanged(object sender, EventArgs e)
        {
            //data binding 
            TBCouseName.DataBindings.Clear();
            TBCouseName.DataBindings.Add("Text", listBoxCourses.DataSource, "CourseName");
        }

        private void btn_updateCourse_Click(object sender, EventArgs e)
        {
            //get the selected course id
            int courseId = (int)listBoxCourses.SelectedValue;
            string courseName = TBCouseName.Text;

            using (var context = new ExSysContext())
            {
                // Call the method to update the course
                context.UpdateCourse(courseId, courseName);
                context.SaveChanges(); 
                MessageBox.Show("Course Updated Successfully");
                RefreshCourseList();
            }

        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            

            //make it by try and catch for foreign key 
            try
            {
                int courseId = (int)listBoxCourses.SelectedValue;
                DialogResult result = MessageBox.Show("Are you sure you want to delete this course?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    using (var context = new ExSysContext())
                    {
                        // Call the method to delete the course
                        context.DeleteCourse(courseId);

                        MessageBox.Show("Course Deleted Successfully");
                        RefreshCourseList();
                    }
                }

               
            }
            catch (DbUpdateException ex)
            {
                // Handle database-related exceptions
                MessageBox.Show("You can't delete this course because it's used in another table", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //catch if the course id is forien key in another table 
            catch (SqlException ex)
            {
                MessageBox.Show("You can't delete this course because it's used in another table", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void RefreshCourseList()
        {
            using (var context = new ExSysContext())
            {
                var courses = context.Courses.ToList();
                listBoxCourses.DataSource = courses;
                listBoxCourses.DisplayMember = "CourseName";
                listBoxCourses.ValueMember = "CourseId";
            }
        }

        private void btn_addCourse_Click(object sender, EventArgs e)
        {
            // Perform client-side validation
            if (string.IsNullOrWhiteSpace(TBCouseNameAdd.Text))
            {
                MessageBox.Show("All fields are required.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Call the method to add the course
            using (var context = new ExSysContext())
            {
                try
                {
                    context.AddCourse(TBCouseNameAdd.Text);

                    // Save changes to the database
                    context.SaveChanges();

                    MessageBox.Show("Course added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RefreshCourseList();
                }
                catch (DbUpdateException ex)
                {
                    // Handle database-related exceptions
                    MessageBox.Show(ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }
        #endregion
    }
}
