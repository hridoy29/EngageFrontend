using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magnus.Views.ClientDetails
{
    public class AdjustmentView
    {
        public string ChaseRef { get; set; }

        public string UpdateType { get; set;}
        public string ClientReference { get; set; }
        public string ClientCancellationReason { get; set; }
        public string EngageCancellattionReason { get; set; }
        public string BalanceUpdateValue { get; set; }
        public string FileName { get; set; }
        public DateTime DateTimeProcessed { get; set; }
        public string ActionComments { get; set; }
        public string Success { get; set; }
    }
}
