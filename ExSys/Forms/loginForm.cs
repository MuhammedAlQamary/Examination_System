using ExSys.Forms;
using Microsoft.VisualBasic.ApplicationServices;

namespace ExSys
{
    public partial class loginForm : Form
    {
        /*
        private readonly Dictionary<string, string> teachers = new Dictionary<string, string>
        {
            { "teacher1@teacher.com", "teacher1" },
            { "teacher2@teacher.com", "teacher2" },
            
        };
        private readonly Dictionary<string, string> students = new Dictionary<string, string>
        {
            { "student1@student.com", "student1" },
            { "student2@student.com", "student2" },
           
        };
        */

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

            if (email == "admin@admin.com" && password == "admin12345")
            {
                OpenAdminForm();

            }
            else if (email == "teacher@teacher.com" && password == "teacher12345")
            {
                OpenTeacherForm();
            }
            /*
            else if (teachers.ContainsKey(email) && teachers[email] == password)
            {
                OpenTeacherForm();
            }
            */
            else
            {
                ShowErrorMessage("Invalid email or password.");
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
