using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RAP.Research
{
    public enum Type { Conference, Journal, Other }
    class Publication
    {
        
        public String doi { get; private set; }
        public String title { get; private set; }
        public String authors { get; private set; }
        public DateTime year { get; private set; }
        public Type outputType { get; private set; }
        public String cite_as { get; private set; }
        public DateTime available { get; private set; }

        public int Age() { }
    }
}
