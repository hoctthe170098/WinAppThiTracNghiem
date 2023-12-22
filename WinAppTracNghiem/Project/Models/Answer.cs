using System;
using System.Collections.Generic;

namespace Project.Models
{
    public partial class Answer
    {
        public Answer()
        {
            AnswersOfQuestions = new HashSet<AnswersOfQuestion>();
        }

        public int Id { get; set; }
        public string? Content { get; set; }

        public virtual ICollection<AnswersOfQuestion> AnswersOfQuestions { get; set; }
    }
}
