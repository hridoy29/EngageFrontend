using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magnus.Views.Params
{
    public class ActionHistoryViewParams
    {
        public int OurReference { get; set; }
        
        public string AADObjectID { get; set; }
        
        public int ActionID { get; set; }
        
        public DateTime CreatedOn { get; set; }
    }
}
