using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Data.Models;
using ExSys.Forms;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic;

namespace ExSys.Forms
{
    public partial class Formteacher : Form
    {
        int id = 30;
        ExSysContext db = new ExSysContext();
        public Instructor instructor;
        int? courseId;
        int? branchTrackId;
        string trackName;
        int ExamDuration;
        public Formteacher(string name, string email)
        {

            InitializeComponent();
            topFormControl topFormControl = new topFormControl();
            topFormControl.Dock = DockStyle.Top;
            this.Controls.Add(topFormControl);
            txtName.Text = name;
            txtEmail.Text = email;
        }
        public Formteacher()
        {
            InitializeComponent();
            topFormControl topFormControl = new topFormControl();
            topFormControl.Dock = DockStyle.Top;
            this.Controls.Add(topFormControl);

        }
        private void getProfile()
        {

            instructor = db.Instructors.Include(a => a.Branch).Include(a => a.Courses).
               FirstOrDefault(a => a.InstructorId == id);
            var courses = instructor.Courses.ToList();
            var branchName = instructor.Branch.BranchName;
            txtEmail.Text = instructor.InstructorEmail;
            txtName.Text = instructor.InstructorFname + " " + instructor.InstructorLname;
            txtBranch.Text = branchName;
            TeacherCourses.DataSource = courses;
        }
        private void GenerateExam()
        {
            //get branch name and course name 
            var courses = instructor.Courses.ToList();
            var branchName = instructor.Branch.BranchName;
            CoursesExam.DataSource = courses.Select(a => a.CourseName).ToList();
            BranchExam.Text = branchName;


            //TrackExam.Text = CoursesExam.SelectedValue.ToString();

        }
        private void Formteacher_Load(object sender, EventArgs e)
        {
            getProfile();
            GenerateExam();
            Generate_Exam.Enabled = false;
        }


        private void CoursesExam_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectedCourse.Text = CoursesExam.SelectedValue.ToString();
            var courseNameParam = new SqlParameter("@Course_Name", SelectedCourse.Text);
            var branchNameParam = new SqlParameter("@branch_name", BranchExam.Text);
            var insIdParam = new SqlParameter("@InsID", id);

            var tracks = db.Tracks
                .FromSqlRaw("EXEC getTrackName_BYCourseAndBranchAndInstructor @Course_Name, @branch_name, @InsID"
                , courseNameParam, branchNameParam, insIdParam).ToList();
            trackName = string.Empty;
            foreach (var _track in tracks)
            {
                trackName = _track.TrackName.ToString();
                // Console.WriteLine(_track.TrackName);
            }
            TrackExam.Text = trackName;
            if (DurationTxt.Text.Length != 0 && SelectedCourse.Text.Length != 0)
            {
                Generate_Exam.Enabled = true;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Define output parameters
            var _courseIdParam = new SqlParameter("@Course_ID", SqlDbType.Int) { Direction = ParameterDirection.Output };
            var branchTrackIdParam = new SqlParameter("@BranchTrack_ID", SqlDbType.Int) { Direction = ParameterDirection.Output };

            // Execute stored procedure
            db.Database.ExecuteSqlRaw("EXEC Get_Course_ID_BrTr_ID @Branch_Name, @Track_Name, @Course_Name, @Course_ID OUT, @BranchTrack_ID OUT",
                new SqlParameter("@Branch_Name", BranchExam.Text),
                new SqlParameter("@Track_Name", trackName),
                new SqlParameter("@Course_Name", SelectedCourse.Text),
                _courseIdParam,
                branchTrackIdParam);

            // Retrieve output parameter values
            int? courseId = null;
            int? branchTrackId = null;

            if (_courseIdParam.Value != DBNull.Value)
            {
                courseId = (int)_courseIdParam.Value;
            }

            if (branchTrackIdParam.Value != DBNull.Value)
            {
                branchTrackId = (int)branchTrackIdParam.Value;
            }

            // Display courseId and branchTrackId
            if (courseId.HasValue && branchTrackId.HasValue)
            {
                MessageBox.Show($"Course ID: {courseId}, Branch Track ID: {branchTrackId}");
                DateOnly currentDate = DateOnly.FromDateTime(DateTime.Now);
                // Define parameters
                var examDateParam = new Microsoft.Data.SqlClient.SqlParameter("@Exam_date", currentDate);
                var durationParam = new Microsoft.Data.SqlClient.SqlParameter("@duration", 2);
                var crsIdParam = new Microsoft.Data.SqlClient.SqlParameter("@Crs_id", courseId);
                var brTrIdParam = new Microsoft.Data.SqlClient.SqlParameter("@branchTrack_id", branchTrackId);
                var exam_id = new Microsoft.Data.SqlClient.SqlParameter("@exam_id", SqlDbType.Int) { Direction = ParameterDirection.Output };
                //exec GenerateExam2 '1/2/2023' ,2,@course_id,@branchTrack_id,@id out
                //var result = db.Exams
                //        .FromSqlRaw("exec GenerateExam2 @Exam_date, @duration, @Crs_id,@branchTrack_id,@exam_id out", examDateParam, durationParam, crsIdParam, brTrIdParam, exam_id)
                //        .ToList();
                //int Passed_EX_ID = (int)exam_id.Value;
                //GenerateExam GExam = new GenerateExam(Passed_EX_ID, currentDate, ExamDuration);
                //GExam.Show();
                try
                {
                    var result = db.Exams
                        .FromSqlRaw("exec GenerateExam2 @Exam_date, @duration, @Crs_id,@branchTrack_id,@exam_id out", examDateParam, durationParam, crsIdParam, brTrIdParam, exam_id)
                        .ToList();

                    int Passed_EX_ID = (int)exam_id.Value;
                    GenerateExam GExam = new GenerateExam(Passed_EX_ID, currentDate, ExamDuration);
                    GExam.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("you cant generate exam.");
                }
            }
            else
            {
                MessageBox.Show("you cant generate exam.");
            }
        }

        private void DurationTxt_TextChanged(object sender, EventArgs e)
        {
            int result;
            if (!(int.TryParse(DurationTxt.Text, out result)))
            {
                MessageBox.Show("enter integer value");
                DurationTxt.Text = "";
            }


            ExamDuration = result;
            if (DurationTxt.Text.Length != 0 && SelectedCourse.Text.Length != 0)
            {
                Generate_Exam.Enabled = true;
            }
        }


    }
}
