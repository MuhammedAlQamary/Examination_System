﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using Data.Models;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Threading;
using System.Threading.Tasks;

namespace Data.Models
{
    public partial interface IExSysContextProcedures
    {
        Task<int> _IsCorrectAsync(int? Question_ID, string StdQ_Ans, OutputParameter<string> Result, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<int> AddCourseAsync(string Course_Name, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<int> AddInstructorAsync(string Instructor_FName, string Instructor_LName, string Instructor_Email, string Instructor_Password, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<List<AddInstructor_CourseResult>> AddInstructor_CourseAsync(int? Instructor_ID, int? Course_ID, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<int> AddNewChoiceAsync(string Choice_Text, int? Question_ID, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<List<AddNewExamQuestionResult>> AddNewExamQuestionAsync(int? Exam_ID, int? Question_ID, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<int> AddNewQuestionAsync(string Question_type, string Question_Text, string Question_ModelAnswer, int? Course_ID, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<List<AddQuestion_ChoicesResult>> AddQuestion_ChoicesAsync(string QuestionType, string QuestionText, string Questions_ModelAnswer, string Option1, string Option2, string Option3, string Option4, int? CrsID, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<int> AddStudentAsync(string Student_FName, string Student_LName, string Student_Email, string Student_Password, int? Track_ID, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<int> DeleteBranchAsync(int? Branch_ID, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<int> DeleteChoiceAsync(int? Choice_ID, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<int> DeleteCourseAsync(int? Course_ID, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<int> DeleteCourseTopicAsync(int? Course_ID, int? Topic_ID, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<int> DeleteExamAsync(int? Exam_ID, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<int> DeleteExamQuestionAsync(int? Exam_ID, int? Question_ID, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<int> DeleteInstructorAsync(int? Instructor_ID, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<List<DeleteInstructor_CourseResult>> DeleteInstructor_CourseAsync(int? Instructor_ID, int? Course_ID, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<int> DeleteQuestionAsync(int? Question_ID, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<int> DeleteStudentAsync(int? Student_ID, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<int> DeleteTopicAsync(int? Topic_ID, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<int> DeleteTrackAsync(int? Track_ID, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<int> DeleteTrackCourseAsync(int? Track_ID, int? Course_ID, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<int> GenerateExam2Async(DateTime? Exam_date, int? duration, int? Crs_id, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<List<GetAllChoicesResult>> GetAllChoicesAsync(OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<List<GetAllExamQuestionsResult>> GetAllExamQuestionsAsync(OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<List<GetAllQuestionsResult>> GetAllQuestionsAsync(OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<List<GetChoiceByIDResult>> GetChoiceByIDAsync(int? Choice_ID, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<List<GetCourseTopicsResult>> GetCourseTopicsAsync(OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<List<GetExamQuestionByIDResult>> GetExamQuestionByIDAsync(int? Exam_ID, int? Question_ID, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<List<GetExamsResult>> GetExamsAsync(OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<List<GetInstructor_CoursesResult>> GetInstructor_CoursesAsync(int? Instructor_ID, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<List<GetInstructor_Courses_StudentsResult>> GetInstructor_Courses_StudentsAsync(int? Instructor_ID, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<List<GetInstructor_NotTeachingCoursesResult>> GetInstructor_NotTeachingCoursesAsync(int? Instructor_ID, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<List<GetInstructorsResult>> GetInstructorsAsync(OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<List<GetQuestionByIDResult>> GetQuestionByIDAsync(int? Question_ID, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<List<GetTopicsResult>> GetTopicsAsync(OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<List<hamadaResult>> hamadaAsync(OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<int> InsertBranchAsync(int? Branch_ID, string Branch_Name, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<int> InsertCourseTopicAsync(int? Course_ID, int? Topic_ID, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<int> InsertExamAsync(DateOnly? Exam_Date, int? Exam_Duration, int? Course_ID, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<int> InsertTopicAsync(string To_Name, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<int> InsertTrackAsync(string Track_Name, int? Supervisor_ID, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<int> InsertTrackCourseAsync(int? Track_ID, int? Course_ID, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<int> RemoveInstructor_CourseAsync(int? Instructor_ID, int? Course_ID, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<List<SelectBranchesResult>> SelectBranchesAsync(OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<List<SelectCoursesResult>> SelectCoursesAsync(OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<List<SelectInstructor_CourseResult>> SelectInstructor_CourseAsync(OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<List<SelectInstructorsResult>> SelectInstructorsAsync(OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<List<SelectStudentsWithTracksResult>> SelectStudentsWithTracksAsync(OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<List<SelectTrackCoursesResult>> SelectTrackCoursesAsync(OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<List<SelectTracksResult>> SelectTracksAsync(OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<List<ShowStudentCoursesResult>> ShowStudentCoursesAsync(int? Student_ID, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<int> SubmitStudentQuestionAsync(int? std_ID, int? Exam_ID, string StdQ1_Ans, string StdQ2_Ans, string StdQ3_Ans, string StdQ4_Ans, string StdQ5_Ans, string StdQ6_Ans, string StdQ7_Ans, string StdQ8_Ans, string StdQ9_Ans, string StdQ10_Ans, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<int> UpdateBranchAsync(int? Branch_ID, string Branch_Name, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<int> UpdateBranchTrackAsync(int? Branch_ID, int? Old_Track_ID, int? New_Track_ID, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<int> UpdateChoiceAsync(int? Choice_ID, string Choice_Text, int? Question_ID, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<int> UpdateCourseAsync(int? Course_ID, string Course_Name, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<int> UpdateCourseTopicAsync(int? Course_ID, int? Topic_ID, int? New_Course_ID, int? New_Topic_ID, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<int> UpdateExamAsync(int? Exam_ID, DateOnly? New_Exam_Date, int? New_Exam_Duration, int? New_Course_ID, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<int> UpdateExamQuestionAsync(int? Exam_ID, int? Question_ID, int? NewExam_ID, int? NewQuestion_ID, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<int> UpdateInstructorAsync(int? Instructor_ID, string Instructor_FName, string Instructor_LName, string Instructor_Email, string Instructor_Password, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<List<UpdateInstructor_CourseResult>> UpdateInstructor_CourseAsync(int? Instructor_ID, int? Course_ID, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<int> UpdateQuestionAsync(int? Question_ID, string Question_type, string Question_Text, string Question_ModelAnswer, int? Course_ID, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<int> UpdateStudentAsync(int? Student_ID, string Student_FName, string Student_LName, string Student_Email, string Student_Password, int? Track_ID, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<int> UpdateTopicAsync(int? Topic_ID, string To_Name, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<int> UpdateTrackAsync(int? Track_ID, string Track_Name, int? Supervisor_ID, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<int> UpdateTrackCourseAsync(int? Old_Track_ID, int? Old_Course_ID, int? New_Track_ID, int? New_Course_ID, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
    }
}
