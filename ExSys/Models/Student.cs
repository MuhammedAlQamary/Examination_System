﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Data.Models;

public partial class Student
{
    public int StudentId { get; set; }

    public string StudentFname { get; set; }

    public string StudentLname { get; set; }

    public string StudentEmail { get; set; }

    public string StudentPassword { get; set; }

    public int? BrTrId { get; set; }

    public virtual BranchTrack BrTr { get; set; }

    public virtual ICollection<StudentCourse> StudentCourses { get; set; } = new List<StudentCourse>();

    public virtual ICollection<StudentExamQuestion> StudentExamQuestions { get; set; } = new List<StudentExamQuestion>();
}