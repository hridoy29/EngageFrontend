using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magnus.Views.Atom
{
    public class AtomPlanningView
    {
        public int OurRef { get; set; }
        public string Company { get; set; }
        public string AgentName { get; set; }
        public string PostCode { get; set; }
        public string Area { get; set; }
        public string Dual { get; set; }
        public double Balance { get; set; }
        public string SpaDate { get; set; }
        public string Visit { get; set; }
        public string Pri { get; set; }
        public string Reg { get; set; }
        public string Code { get; set; }
        public string FCA { get; set; }
        public string STR { get; set; }
        public string PlannedDate { get; set; }
        public string PlannedStatus { get; set; }
        public string Row { get; set; }
        public int Count { get; set; }
        public bool selected { get; set; } = false;
    }
}
