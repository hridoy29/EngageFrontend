using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magnus.Views.Atom
{
    public class AtomExportPlansView
    {
        public string AgentName { get; set; }
        public int AgentNo { get; set; }
        public string JobDate { get; set; }
        public int NoOfJob { get; set; }
        public int TimersExported { get; set; }
        public string FileName { get; set; }
        public bool Select { get; set; }

    }
}
