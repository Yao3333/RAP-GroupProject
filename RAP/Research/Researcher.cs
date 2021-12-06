using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RAP.Research
{
    
    public enum Campus { Hobart, Launceston, CradleCoast }
    

    class Researcher
    {
        protected enum Type { Staff, Student }
        public Researcher()
        {

        }
        public int id { get; set; }
        public Type ResearcherType { get; set; }
        public String given_name { get; set; }
        public String family_name { get; set; }
        public String title { get; set; }
        public String unit { get; set; }
        public Campus campus { get; set; }
        public String email { get; set; }
        public String photo { get; set; }
        public String degree { get; set; }
        public int supervisor_id { get; set; }
        public Level EmploymentLevel { get; set; }
        public DateTime utas_start { get; set; }
        public DateTime current_start { get; set; }


    }
}
