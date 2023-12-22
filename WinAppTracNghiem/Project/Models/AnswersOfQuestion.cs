using System;
using System.Collections.Generic;

namespace Project.Models
{
    public partial class AnswersOfQuestion
    {
        public int Question { get; set; }
        public int Answer { get; set; }
        public bool? IsTrue { get; set; }

        public virtual Answer AnswerNavigation { get; set; } = null!;
        public virtual Question QuestionNavigation { get; set; } = null!;
    }
}
