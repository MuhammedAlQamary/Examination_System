using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExSys.Dtos
{
    public class ExamDto
    {
        [Key]
        public int Exam_ID { get; set; }

        public DateOnly? ExamDate { get; set; }

        public int? ExamDuration { get; set; }

        public int? CourseId { get; set; }


    }
}
