using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RAP.Research
{
    
    public enum Campus { Hobart, Launceston, CradleCoast }
    public enum ResearcherType { Staff, Student }

    class Researcher
    {
        
        
        public int id { get; private set; }
        public ResearcherType researcherType { get; private set; }
        public String given_name { get; private set; }
        public String family_name { get; private set; }
        public String title { get; private set; }
        public String school { get; private set; }
        public Campus campus { get; private set; }
        public String email { get; private set; }
        public String photo { get; private set; }

        public int supervisor_id { get; private set; }
        public EmploymentLevel EmploymentLevel { get; private set; }
        public DateTime utas_start { get; private set; }
        public DateTime current_start { get; private set; }
        public String doi { get; private set; }

        //methods below
        public Position GetCurrentJob() { }
        public String CurrentJobTitle() { }
        public DateTime CurrentJobStart() { }
        public Position GetEarliestJob() { }
        public DateTime EarliestStart() { }
        public float Tenure() { }
        public int PublicationsCount() { }

    }
}
