using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Models
{
    public class KetQua
    {
        public KetQua() { }
        public String Ques { get; set; }
        public String Answer { get; set; }
        public String TrueAns { get; set; }
        public bool Istrue { get; set; }

        public KetQua(string ques, string answer, string trueAns, bool istrue)
        {
            Ques = ques;
            Answer = answer;
            TrueAns = trueAns;
            Istrue = istrue;
        }
    }
}
