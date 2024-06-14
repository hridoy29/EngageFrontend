using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magnus.Views.Atom
{
    public class AtomChangePrioritiesView
    {
        public int Id { get; set; }
        public string Company { get; set; }
        public string Description { get; set; }
        public int  Priority { get; set; }
        public bool Visit1 { get; set; }
        public bool Visit2 { get; set; }
        public bool Row { get; set; }
        public bool OD { get; set; }
        public bool OD7 { get; set; }
        public bool OD8To14 { get; set; }
        public bool OD15 { get; set; }
        public bool Disabled { get; set; }
    }
}
