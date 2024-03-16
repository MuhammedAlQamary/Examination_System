﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace ExSys.Models;

public partial class Question
{
    public int QuestionId { get; set; }

    public string QuestionType { get; set; }

    public string QuestionText { get; set; }

    public string QuestionModelAnswer { get; set; }

    public int? CourseId { get; set; }

    public virtual ICollection<Choice> Choices { get; set; } = new List<Choice>();

    public virtual Course Course { get; set; }

    public virtual ICollection<StudentExamQuestion> StudentExamQuestions { get; set; } = new List<StudentExamQuestion>();

    public virtual ICollection<Exam> Exams { get; set; } = new List<Exam>();
}