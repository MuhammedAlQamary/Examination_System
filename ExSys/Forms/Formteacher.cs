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
        int id;
        ExSysContext db = new ExSysContext();
        public Instructor instructor;
        int? courseId;
        int? branchTrackId;
        string trackName;
        int ExamDuration;
        List<Course> courses;
        string AddQ;
        int selectedId;
        int ShowCourseID;
        public Formteacher(int ID)
        {
            AddQ = string.Empty;
            InitializeComponent();
            topFormControl topFormControl = new topFormControl();
            topFormControl.Dock = DockStyle.Top;
            this.Controls.Add(topFormControl);
            id = ID;
        }
        public Formteacher()
        {
            AddQ = string.Empty;
            InitializeComponent();
            topFormControl topFormControl = new topFormControl();
            topFormControl.Dock = DockStyle.Top;
            this.Controls.Add(topFormControl);

        }
        private void getProfile()
        {


            var courses = instructor.Courses.Select(a => new { a.CourseId, a.CourseName }).ToList();
            var branchName = instructor.Branch.BranchName;
            txtEmail.Text = instructor.InstructorEmail;
            txtName.Text = instructor.InstructorFname + " " + instructor.InstructorLname;
            txtBranch.Text = branchName;
            TeacherCourses.DataSource = courses;
        }
        private void GenerateExam()
        {
            //get branch name and course name 

            var branchName = instructor.Branch.BranchName;

            CoursesExam.DataSource = courses.Select(a => a.CourseName).ToList();
            BranchExam.Text = branchName;
        }
        private void Formteacher_Load(object sender, EventArgs e)
        {
            instructor = db.Instructors.Include(a => a.Branch).Include(a => a.Courses).
            FirstOrDefault(a => a.InstructorId == id);
            courses = instructor.Courses.ToList();
            getProfile();
            GenerateExam();
            Generate_Exam.Enabled = false;
            CoursesComb.DataSource = courses.Select(a => a.CourseName).ToList();
            ShowCourses.DataSource = courses.Select(a => a.CourseName).ToList();
            btnShowQ_Ans.Enabled = false;
            CenterControls();
            txtName.ReadOnly = true;
            txtEmail.ReadOnly = true;
            txtBranch.ReadOnly = true;
            SelectedCourse.ReadOnly = true;
            BranchExam.ReadOnly = true;
            TrackExam.ReadOnly = true;
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
                var exam = db.Exams.FirstOrDefault(a => a.BrTr_ID == branchTrackId && a.CourseId == courseId);
                if (exam == null)
                {
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
                    MessageBox.Show("this exam has been generated before");
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
        /*------------------------------------------------------------------------------------------------------*/
        /*Add quesrtion(question crud)*/
        private void AddQuestion()
        {
            List<string> _Answers = new List<string>();
            string _modelAnswer;
            if ((RadioMcq.Checked) || (RadioTF.Checked))
            {
                if (validateInput(TxtQ.Text) && validateInput(choice1.Text)
               && validateInput(choice2.Text) && ValidateModalAnswe(TxtAnswer.Text, out _Answers, out _modelAnswer))
                {
                    if (RadioMcq.Checked && validateInput(choice3.Text) && validateInput(choice4.Text))
                    {
                        string FirstChoice = _Answers[0];
                        string SecondChoice = _Answers[1];
                        string ThirdChoice = _Answers[2];
                        string FourthChoice = _Answers[3];
                        string AddQ = TxtQ.Text.Trim();
                        string Qtype = RadioMcq.Text;
                        string ModelAnswer = _modelAnswer;
                        string message = $"First Choice: {FirstChoice}\n" +
                                         $"Second Choice: {SecondChoice}\n" +
                                         $"Third Choice: {ThirdChoice}\n" +
                                         $"Fourth Choice: {FourthChoice}\n" +
                                         $"Question: {AddQ}\n" +
                                         $"Question Type: {Qtype}\n" +
                                         $"Model Answer: {ModelAnswer}\n" +
                                         $"Selected Index: {selectedId}";
                        Question q = new Question();
                        q.QuestionText = AddQ;
                        q.QuestionType = Qtype;
                        q.QuestionModelAnswer = ModelAnswer;
                        q.CourseId = selectedId;
                        db.Questions.Add(q);
                        db.SaveChanges();
                        //add chioces to choices table
                        int lastElement = db.Questions.OrderByDescending(e => e.QuestionId).FirstOrDefault().QuestionId;
                        var selectedIdParam = new SqlParameter("@selectexamID", lastElement);
                        foreach (var choice in _Answers)
                        {
                            var choiceParam = new SqlParameter("@choice", choice);

                            db.Database.ExecuteSqlRaw("EXEC AddNewChoice @choice, @selectexamID", choiceParam, selectedIdParam);
                        }
                        MessageBox.Show("added successfully");
                    }
                    else if (RadioTF.Checked)
                    {
                        string FirstChoice = _Answers[0];
                        string SecondChoice = _Answers[1];
                        string AddQ = TxtQ.Text.Trim();
                        string Qtype = RadioMcq.Text;
                        string ModelAnswer = _modelAnswer;
                        string message = $"First Choice: {FirstChoice}\n" +
                                         $"Second Choice: {SecondChoice}\n" +
                                         $"Question: {AddQ}\n" +
                                         $"Question Type: {Qtype}\n" +
                                         $"Model Answer: {ModelAnswer}\n" +
                                         $"Selected Index: {selectedId}";

                        Question q = new Question();
                        q.QuestionText = AddQ;
                        q.QuestionType = Qtype;
                        q.QuestionModelAnswer = ModelAnswer;
                        q.CourseId = selectedId;
                        db.Questions.Add(q);
                        MessageBox.Show(message);
                        db.SaveChanges();
                        //add chioces to choices table
                        int lastElement = db.Questions.OrderByDescending(e => e.QuestionId).FirstOrDefault().QuestionId;
                        var selectedIdParam = new SqlParameter("@selectexamID", lastElement);

                        foreach (var choice in _Answers)
                        {
                            var choiceParam = new SqlParameter("@choice", choice);

                            db.Database.ExecuteSqlRaw("EXEC AddNewChoice @choice, @selectexamID", choiceParam, selectedIdParam);
                        }
                    }
                }
                else
                {
                    MessageBox.Show($"you entered somthing wrong");
                }
            }
            else
            {
                MessageBox.Show($"you must choose Question type first");
            }
        }
        private void AddBtn_Click(object sender, EventArgs e)
        {
            AddQuestion();
        }

        private bool validateInput(string str)
        {
            if (!string.IsNullOrWhiteSpace(str))
                return true;
            else return false;
        }
        private bool ValidateModalAnswe(string str, out List<string> Answers, out string ModelAnswer)
        {
            string getMAnswer = string.Empty;
            Answers = new List<string>();
            if (RadioMcq.Checked)
            {
                Answers.Add(choice1.Text);
                Answers.Add(choice2.Text);
                Answers.Add(choice3.Text);
                Answers.Add(choice4.Text);
            }
            else if (RadioTF.Checked)
            {
                Answers.Add("true");
                Answers.Add("false");
            }
            else
            {

            }
            bool found = false;
            foreach (var answer in Answers)
            {
                if (string.Equals(str, answer, StringComparison.OrdinalIgnoreCase))
                {
                    found = true;
                    getMAnswer = answer;
                    break;
                }
            }
            if (!found)
            {
                MessageBox.Show("Modal Answer isn't included in Answers");
                ModelAnswer = "";
                return false;
            }
            ModelAnswer = getMAnswer;
            return true;
        }
        private void CoursesComb_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedCourse = db.Courses.SingleOrDefault(a => a.CourseName == CoursesComb.SelectedValue);
            selectedId = selectedCourse.CourseId;
        }
        private void RadioTF_CheckedChanged(object sender, EventArgs e)
        {
            choice3.Visible = false;
            choice4.Visible = false;
            label12.Visible = false;
            label13.Visible = false;
        }

        private void ShowQuestionWithAnswers()
        {
            foreach (DataGridViewColumn column in QuestionsAnswers.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            foreach (DataGridViewColumn column in QuestionsAnswers.Columns)
            {
                column.FillWeight = 100f / QuestionsAnswers.Columns.Count;
            }

            var questionsWithChoices = db.Questions.Include(q => q.Choices).Where(a => a.CourseId == ShowCourseID).ToList();

            var flattenedData = questionsWithChoices.SelectMany(q =>
                q.Choices.Select(c => new
                {
                    QuestionId = q.QuestionId,
                    QuestionText = q.QuestionText,
                    ModelAnswer = q.QuestionModelAnswer,
                    ChoiceId = c.ChoiceId,
                    ChoiceText = c.ChoiceText
                })).ToList();
            QuestionsAnswers.DataSource = flattenedData;
            QuestionsAnswers.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);
        }
        private void button2_Click_1(object sender, EventArgs e)
        {
            ShowQuestionWithAnswers();
        }

        private void ShowCourses_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnShowQ_Ans.Enabled = true;
            var selectedCourse = db.Courses.SingleOrDefault(a => a.CourseName == ShowCourses.SelectedValue);
            ShowCourseID = selectedCourse.CourseId;
        }
        private void CenterControls()
        {
            TeacherTabs.Location = new Point((ClientSize.Width - TeacherTabs.Width) / 2, (ClientSize.Height - TeacherTabs.Height) / 2);
        }

        private void RadioMcq_CheckedChanged(object sender, EventArgs e)
        {
            choice3.Visible = true;
            choice4.Visible = true;
            label12.Visible = true;
            label13.Visible = true;
        }
    }
}
