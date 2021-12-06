using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RAP.Research
{
    privite enum Type { Conference, Journal, Other }
    class Publication
    {
        public Publication () 
        {

        }

        public String doi { get; set; }
        public String title { get; set; }
        public String authors { get; set; }
        public DateTime year { get; set; }
        public Type outputType { get; set; }
        public String cite_as { get; set; }
        public DateTime available { get; set; }
    }
}
