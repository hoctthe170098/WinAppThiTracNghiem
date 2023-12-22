using System;
using System.Collections.Generic;

namespace Project.Models
{
    public partial class Enroll
    {
        public string Username { get; set; } = null!;
        public string Semester { get; set; } = null!;
        public string Course { get; set; } = null!;

        public virtual Course CourseNavigation { get; set; } = null!;
        public virtual Semester SemesterNavigation { get; set; } = null!;
        public virtual Account UsernameNavigation { get; set; } = null!;
    }
}
