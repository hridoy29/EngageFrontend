using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magnus.Views.Atom
{
    public class AtomDistributionView
    {
        public string Company { get; set; }
        public int Jobs { get; set; }
        public bool Distribute { get; set; } = false;
    }
}
