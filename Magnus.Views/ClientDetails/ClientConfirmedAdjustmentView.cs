using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magnus.Views.ClientDetails
{
    public class ClientConfirmedAdjustmentView
    {
        public string AdjType { get; set; }
        public string AdjDate { get; set; }
        public string AdjAmount { get; set; }
        public string NewBalance { get; set; }
        public string AdjRef { get; set; }
        public string Reason { get; set; }
        public string FileName { get; set; }
    }
}
