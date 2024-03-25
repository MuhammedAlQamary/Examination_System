using Data.Models;
using ExSys.Forms;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using ExSys.MyModels;
using System.Data;
using ExSys.Forms.Reports;
namespace ExSys
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            //ApplicationConfiguration.Initialize();
            //Application.Run(new Formteacher());
            // Application.Run(new loginForm());
            // Application.Run(new adminForm());
            //Application.Run(new StudentForm(55));
            //Application.Run(new Report_1());
            //Application.Run(new Report_1());
            //Application.Run(new Report1("Report5", 110));
			Application.Run(new Report2("Report6", 110, 55));


            //Console.WriteLine("hello");
            ExSysContext db = new ExSysContext();


			//var query = db.Instructors.Include(a => a.Branch).Include(a => a.Courses).
			//    FirstOrDefault(a => a.InstructorId == 3);
			//var courses = query.Courses.ToList();
			//var track = query.Branch.BranchName;
			//Console.WriteLine(track);
			//Console.WriteLine(query);
			//foreach (var course in courses)
			//{
			//    Console.WriteLine(course);
			//}

			//DateOnly currentDate = DateOnly.FromDateTime(DateTime.Now);
			// Execute stored procedure with parameters
			/* var result = db.Exams
                 .FromSqlRaw("exec GenerateExam2 {0}, {1}, {2}", currentDate, 2, 5)
                 .ToList();*/
			//var courseIdParam = new Microsoft.Data.SqlClient.SqlParameter("@Crs_id", 5);
			//var 
			// Execute stored procedure with parameters
			//var result = db.Exams
			//    .FromSqlRaw("exec GenerateExam2 @Exam_date, @duration, @Crs_id", examDateParam, durationParam, courseIdParam)
			//    .ToList();

			//using (ExSysContext db2 = new ExSysContext())
			//{
			//    var courseNameParam = new SqlParameter("@Course_Name", "C");
			//    var branchNameParam = new SqlParameter("@branch_name", "cairo University");
			//    var insIdParam = new SqlParameter("@InsID", 30); 

			//    var tracks = db2.Tracks
			//        .FromSqlRaw("EXEC getTrackName_BYCourseAndBranchAndInstructor @Course_Name, @branch_name, @InsID"
			//        , courseNameParam, branchNameParam, insIdParam).ToList();

			//    string trackName = string.Empty;

			//    foreach (var _track in tracks)
			//    {
			//        trackName = _track.TrackName.ToString();
			//       // Console.WriteLine(_track.TrackName);
			//    }
			//   // Console.WriteLine(trackName);
			//    /*-----------------------------------------------------------------------------------*/

			//    //string trackName = "3d Art";
			//    string branchname = "Cairo University";
			//    string coursename = "c"; 
			//    // Define output parameters
			//    var _courseIdParam = new SqlParameter("@Course_ID", SqlDbType.Int) { Direction = ParameterDirection.Output };
			//    var branchTrackIdParam = new SqlParameter("@BranchTrack_ID", SqlDbType.Int) { Direction = ParameterDirection.Output };

			//    // Execute stored procedure
			//    db.Database.ExecuteSqlRaw("EXEC Get_Course_ID_BrTr_ID @Branch_Name, @Track_Name, @Course_Name, @Course_ID OUT, @BranchTrack_ID OUT",
			//        new SqlParameter("@Branch_Name", branchname),
			//        new SqlParameter("@Track_Name", trackName),
			//        new SqlParameter("@Course_Name", coursename),
			//        _courseIdParam,
			//        branchTrackIdParam);

			//    // Retrieve output parameter values
			//    int courseId = (int)_courseIdParam.Value;
			//    int branchTrackId = (int)branchTrackIdParam.Value;

			//     Console.WriteLine($"Course ID: {courseId}");
			//    Console.WriteLine($"Branch Track ID: {branchTrackId}");
			//    DateOnly currentDate = DateOnly.FromDateTime(DateTime.Now);
			//    // Define parameters
			//    var examDateParam = new Microsoft.Data.SqlClient.SqlParameter("@Exam_date", currentDate);
			//    var durationParam = new Microsoft.Data.SqlClient.SqlParameter("@duration", 2);
			//    var crsIdParam = new Microsoft.Data.SqlClient.SqlParameter("@Crs_id", courseId); // Replace with actual Course ID
			//    var brTrIdParam = new Microsoft.Data.SqlClient.SqlParameter("@branchTrack_id", branchTrackId); // Replace with actual BranchTrack ID
			//    var exam_id = new Microsoft.Data.SqlClient.SqlParameter("@exam_id", SqlDbType.Int) { Direction = ParameterDirection.Output };

			//    //var result = db.Exams
			//    //                .FromSqlRaw("exec GenerateExam2 @Exam_date, @duration, @Crs_id,@branchTrack_id,@exam_id out", examDateParam, durationParam, crsIdParam, brTrIdParam, exam_id)
			//    //                .ToList();

			// Output the exam ID
			//    Console.WriteLine($"Exam ID: {exam_id.Value}");
			//    var exam = db.Exams
			//                .Include(e => e.Questions)
			//                .ThenInclude(a => a.Choices)
			//                .FirstOrDefault(a => a.Exam_ID == 45);
			//    var questions = exam.Questions;
			//    foreach (var q in questions)
			//    {
			//        Console.WriteLine(q.QuestionText.ToString());

			//        var options = q.Choices.ToList();
			//        foreach (var option in options)
			//        {
			//            Console.WriteLine(option.ChoiceText);
			//        }
			//    }
			//}
		}
	}
}