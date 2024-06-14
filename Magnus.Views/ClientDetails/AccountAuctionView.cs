using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magnus.Views.ClientDetails
{
    public class AccountAuctionView
    {
        public DateOnly Date { get; set; }
        public TimeOnly Time { get; set; }
        public string Action { get; set; }
        public string ActionDetails { get; set; }
        public string User { get; set; }
    }
}
