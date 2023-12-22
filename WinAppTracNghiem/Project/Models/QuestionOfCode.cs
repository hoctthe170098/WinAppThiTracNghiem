using System;
using System.Collections.Generic;

namespace Project.Models
{
    public partial class QuestionOfCode
    {
        public string ExamCode { get; set; } = null!;
        public int Question { get; set; }
        public int Id { get; set; }

        public virtual ExamCode ExamCodeNavigation { get; set; } = null!;
        public virtual Question QuestionNavigation { get; set; } = null!;
    }
}
