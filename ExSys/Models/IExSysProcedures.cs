﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using ExSys.Models;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Threading;
using System.Threading.Tasks;

namespace ExSys.Models
{
    public partial interface IExSysProcedures
    {
        Task<List<AddCoursesResult>> AddCoursesAsync(int? Id, string Name, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<List<AddInstructor_CourseResult>> AddInstructor_CourseAsync(int? Instructor_ID, int? Course_ID, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<List<AddInstructorsResult>> AddInstructorsAsync(string Fname, string Lname, string Email, string Password, int? Id, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<int> AddNewChoiceAsync(string Choice_Text, int? Question_ID, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<List<AddNewExamQuestionResult>> AddNewExamQuestionAsync(int? Exam_ID, int? Question_ID, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<int> AddNewQuestionAsync(string Question_type, string Question_Text, string Question_ModelAnswer, int? Course_ID, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<List<AddStudentResult>> AddStudentAsync(string Fname, string Lname, string Email, string Password, int? TrackId, int? id, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<int> DeleteBranchAsync(int? Branch_ID, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<int> DeleteChoiceAsync(int? Choice_ID, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<List<DeleteCourseResult>> DeleteCourseAsync(int? Id, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<int> DeleteCourseTopicAsync(int? Course_ID, int? Topic_ID, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<int> DeleteExamAsync(int? Exam_ID, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<int> DeleteExamQuestionAsync(int? Exam_ID, int? Question_ID, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<List<DeleteInstructor_CourseResult>> DeleteInstructor_CourseAsync(int? Instructor_ID, int? Course_ID, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<List<DeleteInstructorsResult>> DeleteInstructorsAsync(int? Id, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<int> DeleteQuestionAsync(int? Question_ID, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<List<DeleteStudentResult>> DeleteStudentAsync(int? id, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<int> DeleteTopicAsync(int? Topic_ID, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<int> DeleteTrackAsync(int? Track_ID, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<List<GetAllChoicesResult>> GetAllChoicesAsync(OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<List<GetAllExamQuestionsResult>> GetAllExamQuestionsAsync(OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<List<GetAllQuestionsResult>> GetAllQuestionsAsync(OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<List<GetChoiceByIDResult>> GetChoiceByIDAsync(int? Choice_ID, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<List<GetCourseTopicsResult>> GetCourseTopicsAsync(OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<List<GetExamQuestionByIDResult>> GetExamQuestionByIDAsync(int? Exam_ID, int? Question_ID, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<List<GetExamsResult>> GetExamsAsync(OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<List<GetQuestionByIDResult>> GetQuestionByIDAsync(int? Question_ID, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<List<GetTopicsResult>> GetTopicsAsync(OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<List<hamadaResult>> hamadaAsync(OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<int> InsertBranchAsync(int? Branch_ID, string Branch_Name, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<int> InsertCourseTopicAsync(int? Course_ID, int? Topic_ID, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<int> InsertExamAsync(DateOnly? Exam_Date, int? Exam_Duration, int? Course_ID, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<int> InsertTopicAsync(string To_Name, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<int> InsertTrackAsync(string Track_Name, int? Supervisor_ID, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<List<SelectBranchesResult>> SelectBranchesAsync(OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<List<SelectCoursesResult>> SelectCoursesAsync(OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<List<SelectInstructor_CourseResult>> SelectInstructor_CourseAsync(OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<List<SelectInstructorsResult>> SelectInstructorsAsync(OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<List<SelectTracksResult>> SelectTracksAsync(OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<int> UpdateBranchAsync(int? Branch_ID, string Branch_Name, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<int> UpdateBranchTrackAsync(int? Branch_ID, int? Old_Track_ID, int? New_Track_ID, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<int> UpdateChoiceAsync(int? Choice_ID, string Choice_Text, int? Question_ID, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<List<UpdateCoursesResult>> UpdateCoursesAsync(int? Id, string Name, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<int> UpdateCourseTopicAsync(int? Course_ID, int? Topic_ID, int? New_Course_ID, int? New_Topic_ID, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<int> UpdateExamAsync(int? Exam_ID, DateOnly? New_Exam_Date, int? New_Exam_Duration, int? New_Course_ID, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<int> UpdateExamQuestionAsync(int? Exam_ID, int? Question_ID, int? NewExam_ID, int? NewQuestion_ID, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<List<UpdateInstructor_CourseResult>> UpdateInstructor_CourseAsync(int? Instructor_ID, int? Course_ID, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<List<UpdateInstructorsResult>> UpdateInstructorsAsync(int? Id, string Fname, string Lname, string Email, string Password, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<int> UpdateQuestionAsync(int? Question_ID, string Question_type, string Question_Text, string Question_ModelAnswer, int? Course_ID, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<int> UpdateTopicAsync(int? Topic_ID, string To_Name, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<int> UpdateTrackAsync(int? Track_ID, string Track_Name, int? Supervisor_ID, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
    }
}
