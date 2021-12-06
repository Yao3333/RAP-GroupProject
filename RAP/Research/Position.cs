using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RAP.Research
{
    public enum EmploymentLevel { A, B, C, D, E }
    class Position
    {
        
        public EmploymentLevel level { get; private set; }
        public DateTime start { get; private set; }
        public DateTime end { get; private set; }

        //methods below:
        public string Title() 
        {
            Dictionary<EmploymentLevel, string> title = new Dictionary<EmploymentLevel, string>
            {
                {EmploymentLevel.A, },
                {B, },
                {C, },
                {D, },
                {E, }
            };

        }
        public string ToTitle(I: EmploymentLevel) { }
    }
}
