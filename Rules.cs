using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _232137_OOP_project
{
    public class Rules
    {
        public string RuleNumber { get; set; }
        public string SourceIP { get; set; }
        public string DestinationIP { get; set; }
        public string SourcePort { get; set; }
        public string DestinationPort { get; set; }
        public string Protocol { get; set; }
        public string Decision { get; set; }
    }
}
