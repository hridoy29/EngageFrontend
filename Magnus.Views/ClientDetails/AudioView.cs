using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magnus.Views.ClientDetails
{
    public class AudioView
    { 
        public DateTime DateTime { get; set; }
        public int AgentNo { get; set; }
        public string OutCome { get; set; }
        public string Action { get; set; }
        public string AgentNumber { get; set; }
        public DateTime  ReviewDate { get; set; }
        public string ReviewUser { get; set; }
        public string ReviewOutCome { get; set; }
        public string Accessed { get; set; }
        public string AccessedBy { get; set; }
    }
}
