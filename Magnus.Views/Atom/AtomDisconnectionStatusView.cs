using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magnus.Views.Atom
{
    public class AtomDisconnectionStatusView
    {
        public int OurRef { get; set; }
        public int ClientRef { get; set; }
        public string Company { get; set; }
        public string AgentName { get; set; }
        public string PostCode { get; set; }
        public string Balance { get; set; }
        public string SLADate { get; set; }
        public string PlannedDate { get; set; }
        public string Status { get; set; }
        public string SubStatus { get; set; }
        public bool Select { get; set; }
    }
}
