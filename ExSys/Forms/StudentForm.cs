
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
		private int studentid;
		private ExSysContext dbContext;

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


				dbContext = new ExSysContext();

				//get the full name using the id 
				var student = dbContext.Students.FirstOrDefault(s => s.StudentId == studentid);
				if (student != null)
				{
					LBLStudentName.Text = student.StudentFname + " " + student.StudentLname;

					//get all the courses from the student course relation and put it in a list 
					var studentCourses = dbContext.StudentCourses
												 .Where(sc => sc.StudentId == studentid)
												 .Select(sc => sc.Course.CourseName)
												 .ToList();

					// Populate the combo box with the courses
					comboBoxStdCrs.DataSource = studentCourses;

					//get the track name from students and tracks relation by the id of track 
					var studentTrack = dbContext.Students
												 .Include(s => s.Track)
												 .FirstOrDefault(sc => sc.StudentId == studentid);

					if (studentTrack != null)
					{
						Console.WriteLine("Student found with ID: " + studentTrack.StudentId);
						if (studentTrack.Track != null)
						{
							Console.WriteLine("Track found for student: " + studentTrack.Track.TrackName);
							LBLStudentTrack.Text = studentTrack.Track.TrackName;
						}
						else
						{
							Console.WriteLine("No track found for student.");
							MessageBox.Show("No track found for student.");
						}
					}
					else
					{
						Console.WriteLine("Student not found with ID: " + studentid);
						MessageBox.Show("Student not found with ID: " + studentid);
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
			label6.Visible = true;
			groupBoxStartExam.Visible = false;
			groupBoxRemTime.Visible = true;
			groupBoxExam.Visible = true;

		}
	}
}
