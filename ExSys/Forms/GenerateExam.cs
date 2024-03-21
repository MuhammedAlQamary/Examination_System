using Data.Models;
using ExSys.Dtos;
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
    public partial class GenerateExam : Form
    {
        ExSysContext db = new ExSysContext();
        int Exam_ID;
        int ExDuration;
        DateOnly ExamDate;
        System.Windows.Forms.Timer timer;
        int elapsedTime = 0;
        int duration = 0;
        Label labelRemainingTime { get; set; }

        public GenerateExam(int x, DateOnly _date, int _durtion)
        {

            InitializeComponent();
            // Create and initialize the label for displaying remaining time
            labelRemainingTime = new Label();
            labelRemainingTime.Location = new Point(20, 20); // Adjust the location as needed
            labelRemainingTime.AutoSize = false;
            labelRemainingTime.Width = 400;
            this.Controls.Add(labelRemainingTime);

            // Initialize timer
            timer = new System.Windows.Forms.Timer();
            timer.Interval = 1000;
            timer.Tick += Timer_Tick;
            timer.Start();

            // Assign parameters
            Exam_ID = x;
            ExDuration = _durtion;
            ExamDate = _date;
            duration = ExDuration * 60 * 1000; // Convert hours to milliseconds

            // Update the label with the initial time remaining
            UpdateTimeRemaining(duration - elapsedTime);


        }
        private void GetQuestion()
        {

            var exam = db.Exams
             .Include(e => e.Questions)
             .ThenInclude(a => a.Choices)
             .FirstOrDefault(a => a.Exam_ID == Exam_ID);
            var questions = exam.Questions;
            int counter = 1;
            Dictionary<int, string> Dic_ANS_Count = new Dictionary<int, string>()
                {
                    {1, "a-"},
                    {2, "b-"},
                    {3, "c-"},
                    {4, "d-"}
                };
            //MessageBox.Show($"{ExDuration}:{this.ExamDate.ToString()}");
            Label ExamDuration = new Label();
            ExamDuration.Text = "Exam Duration: "+ExDuration.ToString()+"minutes" ;
            ExamDuration.Location = new Point(20, 40);
            ExamDuration.AutoSize = false;
            ExamDuration.Width = 150;
            this.Controls.Add(ExamDuration);

           
            Label Examdate = new Label();
            Examdate.Text = "Exam Date: " + ExamDate.ToString("dd-MM-yyyy");
            Examdate.Location = new Point(400, 40);
            Examdate.AutoSize = false;
            Examdate.Width = 150;
            this.Controls.Add(Examdate);

            int yPos = 80; 

            foreach (var q in questions)
            {
              
                Label questionLabel = new Label();
                questionLabel.Text = counter.ToString() + "-" + q.QuestionText;
                questionLabel.Location = new Point(20, yPos);
                questionLabel.AutoSize = true;
                this.Controls.Add(questionLabel);
                counter++;
                yPos += 50;

                
                int Answerounter = 1;
                foreach (var option in q.Choices)
                {
                   
                    RadioButton radioButton = new RadioButton();
                    radioButton.Text = option.ChoiceText;
                    radioButton.Location = new Point(40, yPos);
                    radioButton.AutoSize = true;
                    this.Controls.Add(radioButton);
                    Answerounter++;
                    yPos += 20;
                }
                yPos += 20;
            }
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            elapsedTime += 1000;
            UpdateTimeRemaining(duration - elapsedTime);
            if (elapsedTime >= duration)
            {
                timer.Stop();
                this.Close();
            }
        }
        private void UpdateTimeRemaining(int millisecondsRemaining)
        {
            
            TimeSpan timeRemaining = TimeSpan.FromMilliseconds(millisecondsRemaining);
            labelRemainingTime.Text = string.Format("Time remaining: {0:00}:{1:00}:{2:00}",
                timeRemaining.Hours, timeRemaining.Minutes, timeRemaining.Seconds);
        }

        private async void GenerateExam_Load(object sender, EventArgs e)
        {
            try
            {
                await Task.Delay(100); 
                GetQuestion();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
