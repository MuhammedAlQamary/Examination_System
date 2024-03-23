
using Data.Models;
using ExSys.MyModels;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
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
		private int studentid = 55;
		 int courseid;

		ExSysContext dbContext = new ExSysContext();

		List<string> studentCourses;
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
			try
			{


				//dbContext = new ExSysContext();

				//get the full name using the id 
				var student = dbContext.Students
								.Include(s => s.BrTr)
								.ThenInclude(bt => bt.Track)
								.FirstOrDefault(sc => sc.StudentId == studentid);
				if (student != null)
				{
					LBLStudentName.Text = student.StudentFname + " " + student.StudentLname;

					//get all the courses from the student course relation and put it in a list 

					studentCourses = dbContext.StudentCourses
												.Where(sc => sc.StudentId == studentid)
												.Select(sc => sc.Course.CourseName)
												.ToList();

					// Populate the combo box with the courses
					comboBoxStdCrs.DataSource = studentCourses;
					// Populate the combo box with the courses to take exam	
					comboBoxCrsExam.DataSource = studentCourses;
					//get the track name from students and tracks relation by the id of track 

					var branchTrackStudent = student.BrTr;
					var studentTrack = branchTrackStudent.Track;
					var barnchID = branchTrackStudent.BranchId;
					var BranchName = dbContext.Branches.FirstOrDefault(b => b.BranchId == barnchID).BranchName;
					LBLBranchName.Text = BranchName;

					if (studentTrack != null)
					{
						LBLStudentTrack.Text = studentTrack.TrackName;
					}
					else
					{
						MessageBox.Show("No track found for student.");
					}
				}
				else
				{
					// Handle case when student is not found
					MessageBox.Show("Student not found.");
				}
			}
			catch (Exception ex)
			{
				// Handle any exceptions
				MessageBox.Show("An error occurred: " + ex.Message);
				Console.WriteLine("An error occurred: " + ex.Message);
			}
		}

		private void comboBoxStdCrs_SelectedIndexChanged(object sender, EventArgs e)
		{
			try
			{
				var selectedCourse = comboBoxStdCrs.SelectedItem.ToString();
				var course = dbContext.Courses
									.Include(c => c.StudentCourses)
									.FirstOrDefault(c => c.CourseName == selectedCourse);
				if (course != null)
				{
					// Assuming studentid is of type Int16
					var studentCourse = course.StudentCourses.FirstOrDefault(sc => sc.StudentId == Convert.ToInt16(studentid));
					if (studentCourse != null)
					{
						LBLStudentCrsDegree.Text = studentCourse.StudentGrade.ToString();
					}
					else
					{
						MessageBox.Show("Student grade not found for selected course.");
					}
				}
				else
				{
					MessageBox.Show("Course not found.");
				}
			}
			catch (Exception ex)
			{
				// Handle any exceptions
				MessageBox.Show("An error  occurred: " + ex.Message);
				Console.WriteLine("An error occurred: " + ex.Message);
			}
		}

		private void buttonStartExam_Click(object sender, EventArgs e)
		{
			groupBoxStartExam.Visible = false;
			try
			{
				var student = dbContext.Students
								.Include(s => s.BrTr)
								.ThenInclude(bt => bt.Track)
								.FirstOrDefault(sc => sc.StudentId == studentid);

				int branchID = student.BrTr.BranchId;
				int trackID = student.BrTr.TrackId;
				MessageBox.Show($"BranchID_{student.BrTr.BranchId}:TrackID_{student.BrTr.TrackId}:StudentID_{studentid}:Course_Id{courseid}");
				
				var examIdParam = new SqlParameter("@Exam_ID", SqlDbType.Int) { Direction = ParameterDirection.Output };

				dbContext.Database.ExecuteSqlRaw("EXEC GetStudentExam @Track_ID, @Branch_ID, @Course_ID, @Exam_ID OUT",
			   new SqlParameter("@Branch_ID", branchID),
			   new SqlParameter("@Track_ID", trackID),
			   new SqlParameter("@Course_ID", courseid),
			   examIdParam);
				int examID = (int)examIdParam.Value;


				var exam = dbContext.Exams
			    .Include(e => e.Questions)
				.ThenInclude(a => a.Choices)
				.FirstOrDefault(a => a.Exam_ID == examID);
				var questions = exam.Questions;
				int counter = 1;
				int yPos = 40;
				foreach (var q in questions)
				{
                    Console.WriteLine(q.ToString());
                }
				foreach (var question in questions)
				{
					// Display question text
					var labelQuestion = new Label();
					labelQuestion.Text = $"{question.QuestionText}";
					labelQuestion.AutoSize = true;
					labelQuestion.Location = new Point(20, yPos);
					panelExam.Controls.Add(labelQuestion);

					// Display answer choices
					yPos += 30;
					foreach (var choice in question.Choices)
					{
						var radioButtonChoice = new RadioButton();
						radioButtonChoice.Text = $"{choice.ChoiceText}";
						radioButtonChoice.AutoSize = true;
						radioButtonChoice.Location = new Point(40, yPos);
						panelExam.Controls.Add(radioButtonChoice);
						yPos += 20;
					}
					yPos += 10; // Add some spacing between questions
				}

			}
			catch
			{
			MessageBox.Show("An error occurred while getting the exam.");
				
			}

		}

		private void comboBoxCrsExam_SelectedIndexChanged(object sender, EventArgs e)
		{
			courseid = dbContext.Courses.FirstOrDefault(c => c.CourseName == comboBoxCrsExam.SelectedItem.ToString()).CourseId;

			}
	}
}
