using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magnus.Views.Atom
{
    public class AtomPostCodeExceptionView
    {
        public string Postcode { get; set; }
        public string PostCodeArea { get; set; }
        public bool PostCodeStatus { get; set; }
        public string ChangeDate { get; set; }
        public string ChangedBy { get; set; }
    }
}
