﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace ExSys.Models;

public partial class Exam
{
    public int ExamId { get; set; }

    public DateOnly? ExamDate { get; set; }

    public int? ExamDuration { get; set; }

    public int? CourseId { get; set; }

    public virtual Course Course { get; set; }

    public virtual ICollection<StudentExamQuestion> StudentExamQuestions { get; set; } = new List<StudentExamQuestion>();

    public virtual ICollection<Question> Questions { get; set; } = new List<Question>();
}