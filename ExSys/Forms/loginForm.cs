using ExSys.Forms;
using System.Linq;
using Microsoft.VisualBasic.ApplicationServices;
using ExSys.Models;
using Microsoft.EntityFrameworkCore;

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

            using (var context = new Exam_System_Generate_DatabaseContext())
            {
                var instructor = context.Instructors.FirstOrDefault(i => i.Instructor_Email == email && i.Instructor_Password == password);
                if (email == "admin@admin.com" && password == "admin12345")
                {
                    OpenAdminForm();
                }
                if (instructor != null)
                {
                    OpenTeacherForm();

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

        private void OpenTeacherForm()
        {
            Formteacher teacherForm = new Formteacher();
            teacherForm.Show();
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
