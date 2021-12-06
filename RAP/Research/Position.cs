using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RAP.Research
{
    public enum Level { Student, A, B, C, D, E }
    class Position
    {
        public Position()
        {

        }
        public Level EmploymentLevel { get; set; }
        public DateTime start { get; set; }
        public DateTime end { get; set; }
    }
}
