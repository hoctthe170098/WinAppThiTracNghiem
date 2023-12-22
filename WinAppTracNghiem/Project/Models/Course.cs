using System;
using System.Collections.Generic;

namespace Project.Models
{
    public partial class Course
    {
        public Course()
        {
            Enrolls = new HashSet<Enroll>();
            ExamCodes = new HashSet<ExamCode>();
            Questions = new HashSet<Question>();
        }

        public string Code { get; set; } = null!;
        public string? Title { get; set; }

        public virtual ICollection<Enroll> Enrolls { get; set; }
        public virtual ICollection<ExamCode> ExamCodes { get; set; }
        public virtual ICollection<Question> Questions { get; set; }
    }
}
