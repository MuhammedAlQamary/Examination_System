﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Data.Models
{
    public partial class SelectInstructorsResult
    {
        public int Instructor_ID { get; set; }
        public string Instructor_Fname { get; set; }
        public string Instructor_Lname { get; set; }
        public string Instructor_Email { get; set; }
        public string Instructor_Password { get; set; }
        public int? Branch_ID { get; set; }
    }
}
