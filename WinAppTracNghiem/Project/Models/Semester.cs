using System;
using System.Collections.Generic;

namespace Project.Models
{
    public partial class Semester
    {
        public Semester()
        {
            Enrolls = new HashSet<Enroll>();
            ExamCodes = new HashSet<ExamCode>();
        }

        public string Code { get; set; } = null!;
        public int? Year { get; set; }
        public DateTime? BeginDate { get; set; }
        public DateTime? EndDate { get; set; }

        public virtual ICollection<Enroll> Enrolls { get; set; }
        public virtual ICollection<ExamCode> ExamCodes { get; set; }
    }
}
