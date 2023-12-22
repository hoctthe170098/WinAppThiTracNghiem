using System;
using System.Collections.Generic;

namespace Project.Models
{
    public partial class ExamCode
    {
        public ExamCode()
        {
            Practices = new HashSet<Practice>();
            QuestionOfCodes = new HashSet<QuestionOfCode>();
        }

        public string Code { get; set; } = null!;
        public string? Semester { get; set; }
        public string? Course { get; set; }
        public DateTime? DateBegin { get; set; }
        public int? TimeBegin { get; set; }
        public int? Long { get; set; }
        public string? Status { get; set; }
        public int? NumberOfQuestion { get; set; }

        public virtual Course? CourseNavigation { get; set; }
        public virtual Semester? SemesterNavigation { get; set; }
        public virtual ICollection<Practice> Practices { get; set; }
        public virtual ICollection<QuestionOfCode> QuestionOfCodes { get; set; }
    }
}
