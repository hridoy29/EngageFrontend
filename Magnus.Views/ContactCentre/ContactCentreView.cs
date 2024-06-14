using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magnus.Views.ContactCentre
{
    public class ContactCentreView
    {
        public int Chaseref { get; set; }
        public string ClientName { get; set; }
        public string CustomerName { get; set; }
        public string Telephone1 { get; set; }
        public string Telephone2 { get; set; }
        public string Telephone3 { get; set; }
        public string Telephone4 { get; set; }
        public bool Active { get; set; }
        public string Workstream { get; set; }
    }
}
