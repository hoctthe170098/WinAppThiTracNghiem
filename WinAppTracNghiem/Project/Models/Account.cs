using System;
using System.Collections.Generic;

namespace Project.Models
{
    public partial class Account
    {
        public Account()
        {
            Enrolls = new HashSet<Enroll>();
            Practices = new HashSet<Practice>();
        }

        public string Username { get; set; } = null!;
        public string? Password { get; set; }
        public int? Role { get; set; }
        public string? Status { get; set; }

        public virtual ICollection<Enroll> Enrolls { get; set; }
        public virtual ICollection<Practice> Practices { get; set; }
    }
}
