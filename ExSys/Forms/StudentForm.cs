
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
using Timer = System.Windows.Forms.Timer;

namespace ExSys.Forms
{
	public partial class StudentForm : Form
	{
		private int studentid = 55;
		int courseid;
        Timer examTimer;
		int examDurationMinutes = 60;
		DateTime examStartTime;
		 Label labelTimer;

		ExSysContext dbContext = new ExSysContext();

		List<string> studentCourses;
		public StudentForm(int id)
		{
			studentid = id;
			InitializeComponent();
			topFormControl topFormControl = new topFormControl();
			topFormControl.Dock = DockStyle.Top;
			this.Controls.Add(topFormControl);

			// Initialize timer
			examTimer = new Timer();
			examTimer.Interval = 1000; // Timer ticks every second
			examTimer.Tick += ExamTimer_Tick;
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
			StartExam();
		}

		private void comboBoxCrsExam_SelectedIndexChanged(object sender, EventArgs e)
		{
			courseid = dbContext.Courses.FirstOrDefault(c => c.CourseName == comboBoxCrsExam.SelectedItem.ToString()).CourseId;

		}

		private void StartExam()
		{
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

					// Create a panel for the question answers 
					var panelAnswers = new Panel();
					panelAnswers.Name = $"panelAnswers_{question.QuestionId}";
					panelAnswers.AutoSize = true;
					panelAnswers.Location = new Point(20, yPos + labelQuestion.Height + 10); // Adjust position relative to the question label
					panelExam.Controls.Add(panelAnswers);

					// Display answer choices
					foreach (var choice in question.Choices)
					{
						var radioButtonChoice = new RadioButton();
						radioButtonChoice.Text = $"{choice.ChoiceText}";
						radioButtonChoice.AutoSize = true;
						radioButtonChoice.Location = new Point(0, panelAnswers.Controls.Count * (radioButtonChoice.Height + 5)); // Adjust position within the panel
						panelAnswers.Controls.Add(radioButtonChoice);
					}

					yPos += labelQuestion.Height + panelAnswers.Height + 20; // Increment yPos to accommodate the next question and its answers
				}

				// Create a timer label
				labelTimer = new Label();
				labelTimer.Text = "Remaining time : 00:60:00"; // Initial timer value
				labelTimer.AutoSize = true;
				labelTimer.Name = "labelTimer";
				labelTimer.Font = new Font("Arial", 12, FontStyle.Bold);
				labelTimer.Location = new Point((panelExam.Width / 2), 40); // Adjust the position as needed
				panelExam.Controls.Add(labelTimer); // Add the label to the form

				// Create a submit button
				Button buttonSubmitExam = new Button();
				buttonSubmitExam.Text = "Submit Exam";
				buttonSubmitExam.AutoSize = true;
				buttonSubmitExam.Name = "buttonSubmitExam";
				buttonSubmitExam.Font = new Font("Arial", 12, FontStyle.Bold);
				buttonSubmitExam.BackColor = Color.Red;
				buttonSubmitExam.ForeColor = Color.White;
				buttonSubmitExam.Cursor = Cursors.Hand;
				buttonSubmitExam.FlatStyle = FlatStyle.Flat;
				buttonSubmitExam.Location = new Point((panelExam.Width/2), yPos+20); // Adjust the position as needed
				buttonSubmitExam.Click += ButtonSubmitExam_Click; // Attach event handler
				panelExam.Controls.Add(buttonSubmitExam); // Add the button to the form
				// Start the timer
				examStartTime = DateTime.Now;
				examTimer.Start();
			}
			catch
			{
				MessageBox.Show("An error occurred while starting the exam.");
			}
		}

		private void ButtonSubmitExam_Click(object? sender, EventArgs e)
		{
			// Ask for confirmation before submitting the exam
			DialogResult result = MessageBox.Show("Are you sure you want to submit the exam?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

			// Check if the user clicked Yes
			if (result == DialogResult.Yes)
			{
				// Iterate through each question panel
				foreach (var control in panelExam.Controls)
				{
					if (control is Panel questionPanel && questionPanel.Name.StartsWith("panelAnswers_"))
					{
						// Extract the question ID from the panel name
						int questionId = int.Parse(questionPanel.Name.Split('_')[1]);

						// Find the selected answer
						string selectedAnswer = "";
						foreach (var answerControl in questionPanel.Controls)
						{
							if (answerControl is RadioButton radioButton && radioButton.Checked)
							{
								selectedAnswer = radioButton.Text;
								break;
							}
						}

						// Output the question ID and the selected answer
						Console.WriteLine($"Question ID: {questionId}, Selected Answer: {selectedAnswer}");
					}
				}
			}
		}


		//private void ButtonSubmitExam_Click(object? sender, EventArgs e)
		//{

		//	foreach (var control in panelExam.Controls)
		//	{
		//		if (control is Panel questionPanel && questionPanel.Name.StartsWith("panelAnswers_"))
		//		{
		//			// Extract the question ID from the panel name
		//			int questionId = int.Parse(questionPanel.Name.Split('_')[1]);

		//			// Find the selected answer
		//			string selectedAnswer = "";
		//			foreach (var answerControl in questionPanel.Controls)
		//			{
		//				if (answerControl is RadioButton radioButton && radioButton.Checked)
		//				{
		//					selectedAnswer = radioButton.Text;
		//					break;
		//				}
		//			}

		//			// Output the question ID and the selected answer
		//			Console.WriteLine($"Question ID: {questionId}, Selected Answer: {selectedAnswer}");
		//		}
		//	}
		//}

		private void ExamTimer_Tick(object sender, EventArgs e)
		{
			// Calculate remaining time
			TimeSpan elapsedTime = DateTime.Now - examStartTime;
			TimeSpan remainingTime = TimeSpan.FromMinutes(examDurationMinutes) - elapsedTime;

			// Update timer label
			TimeSpan formattedTime = remainingTime.Duration();
			labelTimer.Text = $"Remaining time : {formattedTime.Hours:00}:{formattedTime.Minutes:00}:{formattedTime.Seconds:00}";

			// Check if time is up
			if (elapsedTime.TotalMinutes >= examDurationMinutes)
			{
				examTimer.Stop();
				MessageBox.Show("Time's up! Your exam has ended.");
				// Optionally, automatically submit the exam here.
			}
		}

	}

}
