using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExSys.MyModels
{
    public class TrackBYCourseBranchInstructor
    {
        [Key]
        public int branchId { get; set; }
        public int Track_ID { get; set; }
        public int Course_ID { get; set; }
        public int Instructor_id { get; set; }

        public string TrackName { get; set; }
        public string Course_Name { get; set; }
        public string branch_name { get; set; }
    }

    public class Branch_Tracks
    {
        public int Track_ID { get; set; }
        public int Course_ID { get; set; }
        [Key]
        public int BrTr_ID { get; set; }
    }

    public class ExamQuestion{
        public int Exam_Id { get; set; }
        public int Question_ID { get; set;}
    }
}
