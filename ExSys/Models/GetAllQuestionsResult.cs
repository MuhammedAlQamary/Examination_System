﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Data.Models
{
    public partial class GetAllQuestionsResult
    {
        public int Question_ID { get; set; }
        public string Question_Type { get; set; }
        public string Question_Text { get; set; }
        public string Question_ModelAnswer { get; set; }
        public int Course_ID { get; set; }
    }
}
