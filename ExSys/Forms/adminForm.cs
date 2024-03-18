using Data.Models;
using ExSys;
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
            // Add event handler for the Enter event of the tab
            //+= new EventHandler(tabAssignCourseToInstructor_Enter);

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

        #region instructors CRUD
        private void tdUpdateInstructor_Enter(object sender, EventArgs e)
        {
            //show all instructors in the listbox
            using (var context = new ExSysContext())
            {
                var instructors = context.Instructors.ToList();
                listBoxinstructors.DataSource = instructors;
                listBoxinstructors.DisplayMember = "InstructorFname";
                listBoxinstructors.ValueMember = "InstructorId";
            }

        }
        private void listBoxinstructors_SelectedIndexChanged(object sender, EventArgs e)
        {
            //data binding 
            TBInstructorFName.DataBindings.Clear();
            TBInstructorLName.DataBindings.Clear();
            TBInstructorMail.DataBindings.Clear();
            TBInstructorPass.DataBindings.Clear();


            TBInstructorFName.DataBindings.Add("Text", listBoxinstructors.DataSource, "InstructorFname");
            TBInstructorLName.DataBindings.Add("Text", listBoxinstructors.DataSource, "InstructorLname");
            TBInstructorMail.DataBindings.Add("Text", listBoxinstructors.DataSource, "InstructorEmail");
            TBInstructorPass.DataBindings.Add("Text", listBoxinstructors.DataSource, "InstructorPassword");

        }
        private void btn_updateIns_Click(object sender, EventArgs e)
        {
            //get the selected instructor id
            int instructorId = (int)listBoxinstructors.SelectedValue;
            string instructorFname = TBInstructorFName.Text;
            string instructorLname = TBInstructorLName.Text;
            string instructorEmail = TBInstructorMail.Text;
            string instructorPassword = TBInstructorPass.Text;

            using (var context = new ExSysContext())
            {
                // Call the method to update the instructor
                context.UpdateInstructor(instructorId, instructorFname, instructorLname, instructorEmail, instructorPassword);
                context.SaveChanges();
                MessageBox.Show("Instructor Updated Successfully");
                RefreshInstructorList();
            }

        }
        public void RefreshInstructorList()
        {
            using (var context = new ExSysContext())
            {
                var instructors = context.Instructors.ToList();
                listBoxinstructors.DataSource = instructors;
                listBoxinstructors.DisplayMember = "InstructorFname";
                listBoxinstructors.ValueMember = "InstructorId";
            }

        }

        private void btn_delIns_Click(object sender, EventArgs e)
        {
            //make it by try and catch for foreign key 
            try
            {
                int instructorId = (int)listBoxinstructors.SelectedValue;
                DialogResult result = MessageBox.Show("Are you sure you want to delete this instructor?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    using (var context = new ExSysContext())
                    {
                        // Call the method to delete the instructor
                        context.DeleteInstructor(instructorId);

                        MessageBox.Show("Instructor Deleted Successfully");
                        RefreshInstructorList();
                    }
                }
            }
            catch
            {
                MessageBox.Show($"You can't delete this instructor because it's used in another table ", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnAddInstructor_Click(object sender, EventArgs e)
        {
            // Perform client-side validation
            if (string.IsNullOrWhiteSpace(tbInstructorNameAdd.Text) ||
                               string.IsNullOrWhiteSpace(TBInstructorLNameAdd.Text) ||
                               string.IsNullOrWhiteSpace(TBInstructorMailAdd.Text) ||
                               string.IsNullOrWhiteSpace(TBInstructorPassAdd.Text))
            {
                MessageBox.Show("All fields are required.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validate email format
            if (!IsValidEmail(TBInstructorMailAdd.Text))
            {
                MessageBox.Show("Invalid email format.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validate password strength
            if (TBInstructorPassAdd.Text.Length < 8)
            {
                MessageBox.Show("Password must be at least 8 characters long.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Call the method to add the instructor
            using (var context = new ExSysContext())
            {
                try
                {
                    context.AddInstructor(tbInstructorNameAdd.Text, TBInstructorLNameAdd.Text, TBInstructorMailAdd.Text, TBInstructorPassAdd.Text);

                    // Save changes to the database
                    context.SaveChanges();

                    MessageBox.Show("Instructor added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RefreshInstructorList();
                }
                catch (DbUpdateException ex)
                {
                    // Handle database-related exceptions
                    MessageBox.Show(ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }
        #endregion

        #region instructor courses assignment

        private void btn_AssignNewCrs_Click(object sender, EventArgs e)
        {

            // Get the selected instructor ID
            int instructorId = (int)listBoxinstructors.SelectedValue;

            // Go to the tab of assign course to instructor
            // Find the index of the tab named "tabAssignCourseToInstructor"
            int tabIndex = -1;
            for (int i = 0; i < tdUpdateInstructor.TabPages.Count; i++)
            {
                if (tdUpdateInstructor.TabPages[i].Name == "tabAssignCourseToInstructor")
                {
                    tabIndex = i;
                    break;
                }
            }

            // Set the selected index to the found index
            if (tabIndex != -1)
                tdUpdateInstructor.SelectedIndex = tabIndex;

            // Select the instructor name in the combo box
            comboBoxInstructors.SelectedValue = instructorId;

            // Fill the courses in the list box of assigned courses
            using (var context = new ExSysContext())
            {
                var assignedCourses = context.GetInstructorCourses(instructorId).ToList();
                listBoxAssignedCourses.DataSource = assignedCourses;
                listBoxAssignedCourses.DisplayMember = "CourseName";
                listBoxAssignedCourses.ValueMember = "CourseId";
            }

            // Fill the other list box of unassigned courses
            using (var context = new ExSysContext())
            {
                var unassignedCourses = context.GetInstructorNotTeachingCourses(instructorId).ToList();
                listBoxUnassignedCourses.DataSource = unassignedCourses;
                listBoxUnassignedCourses.DisplayMember = "CourseName";
                listBoxUnassignedCourses.ValueMember = "CourseId";
            }

        }

        private void tabAssignCourseToInstructor_Enter(object sender, EventArgs e)
        {
            PopulateComboBoxInstructors();
        }
        private void PopulateComboBoxInstructors()
        {
            //using GetAllInstructors stored proc 
            using (var context = new ExSysContext())
            {
                var instructors = context.Instructors.ToList();
                comboBoxInstructors.DataSource = instructors;
                comboBoxInstructors.DisplayMember = "InstructorFname";
                comboBoxInstructors.ValueMember = "InstructorId";
            }
        }

        private void comboBoxInstructors_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (comboBoxInstructors.SelectedValue is int instructorId)
            {
                using (var context = new ExSysContext())
                {
                    var assignedCourses = context.GetInstructorCourses(instructorId).ToList();
                    listBoxAssignedCourses.DataSource = assignedCourses;
                    listBoxAssignedCourses.DisplayMember = "CourseName";
                    listBoxAssignedCourses.ValueMember = "CourseId";

                    var unassignedCourses = context.GetInstructorNotTeachingCourses(instructorId).ToList();
                    listBoxUnassignedCourses.DataSource = unassignedCourses;
                    listBoxUnassignedCourses.DisplayMember = "CourseName";
                    listBoxUnassignedCourses.ValueMember = "CourseId";
                }
            }




        }

        private void btn_RemoveThisInsCrs_Click(object sender, EventArgs e)
        {
            //on clicking remove btn remove the course from assigned courses  list  and move it to un assigned  courses list and refresh the database 
            int instructorId = (int)comboBoxInstructors.SelectedValue;
            using (var context = new ExSysContext())
            {
                int courseId = (int)listBoxAssignedCourses.SelectedValue;
                DialogResult result = MessageBox.Show("Are you sure you want to remove this course from the instructor?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    context.RemoveInstructorCourse(instructorId, courseId);
                    context.SaveChanges();
                    // Fill the courses in the list box of assigned courses
                    var assignedCourses = context.GetInstructorCourses(instructorId).ToList();
                    listBoxAssignedCourses.DataSource = assignedCourses;
                    listBoxAssignedCourses.DisplayMember = "CourseName";
                    listBoxAssignedCourses.ValueMember = "CourseId";

                    // Fill the other list box of unassigned courses
                    var unassignedCourses = context.GetInstructorNotTeachingCourses(instructorId).ToList();
                    listBoxUnassignedCourses.DataSource = unassignedCourses;
                    listBoxUnassignedCourses.DisplayMember = "CourseName";
                    listBoxUnassignedCourses.ValueMember = "CourseId";
                }
                else
                {
                    return;
                }


            }



        }

        private void btn_AddthisCoursetoIns_Click(object sender, EventArgs e)
        {
            //on clicking add btn add the course from unassigned courses  list  and move it to assigned  courses list and refresh the database
            int instructorId = (int)comboBoxInstructors.SelectedValue;
            using (var context = new ExSysContext())
            {
                int courseId = (int)listBoxUnassignedCourses.SelectedValue;
                //add mesaage box to confirm the action
                DialogResult result = MessageBox.Show("Are you sure you want to add this course to the instructor?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {

                    context.AddInstructorCourse(instructorId, courseId);
                    context.SaveChanges();
                    // Fill the courses in the list box of assigned courses
                    var assignedCourses = context.GetInstructorCourses(instructorId).ToList();
                    listBoxAssignedCourses.DataSource = assignedCourses;
                    listBoxAssignedCourses.DisplayMember = "CourseName";
                    listBoxAssignedCourses.ValueMember = "CourseId";

                    // Fill the other list box of unassigned courses
                    var unassignedCourses = context.GetInstructorNotTeachingCourses(instructorId).ToList();
                    listBoxUnassignedCourses.DataSource = unassignedCourses;
                    listBoxUnassignedCourses.DisplayMember = "CourseName";
                    listBoxUnassignedCourses.ValueMember = "CourseId";
                }
                else
                {
                    return;
                }

            }


        }
        #endregion
    }
}
