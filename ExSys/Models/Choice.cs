﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace ExSys.Models;

public partial class Choice
{
    public int ChoiceId { get; set; }

    public string ChoiceText { get; set; }

    public int? QuestionId { get; set; }

    public virtual Question Question { get; set; }
}