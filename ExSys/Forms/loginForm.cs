using ExSys.Forms;
using System.Linq;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.EntityFrameworkCore;
using Data.Models;

namespace ExSys
{
    public partial class loginForm : Form
    {

        public loginForm()
        {
            InitializeComponent();
        }

        private void loginForm_Load(object sender, EventArgs e)
        {

        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnMinus_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Login_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim();
            string password = txtPass.Text;

            using (var context = new ExSysContext())
            {
                var instructor = context.Instructors.FirstOrDefault(i => i.InstructorEmail == email && i.InstructorPassword == password);
                var student = context.Students.FirstOrDefault(s => s.StudentEmail == email && s.StudentPassword == password);   
                if (email == "admin@admin.com" && password == "admin12345")
                {
                    OpenAdminForm();
                }
                else if (instructor != null)
                {
                    Formteacher teacherForm = new Formteacher(instructor.InstructorFname + " " + instructor.InstructorLname , instructor.InstructorEmail);
                    teacherForm.Show();
                    this.Hide();

                }
                else if(student != null)
                {
                    StudentForm studentForm = new StudentForm(student.StudentId);
                    studentForm.Show();
                    this.Hide();
                }
                else
                {
                    ShowErrorMessage("Invalid email or password.");
                }
            }
        }



        private void OpenAdminForm()
        {

            adminForm adminForm = new adminForm();
            adminForm.Show();
            this.Hide();
        }


        private void ShowErrorMessage(string message)
        {
            lblError.Text = message;
            lblError.Visible = true;
        }

        private void chkBoxPass_CheckedChanged(object sender, EventArgs e)
        {
            if(chkBoxPass.Checked)
            {
                txtPass.UseSystemPasswordChar = false;
            }
            else
            {
                txtPass.UseSystemPasswordChar = true;
            }
        }
    }
}
