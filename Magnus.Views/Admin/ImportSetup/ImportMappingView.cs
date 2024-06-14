using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magnus.Views.Admin.ImportSetup
{
    public class ImportMappingView
    {
        public int ClientID { get; set; }
        public int FileIypeID { get; set; }
        public List<HeaderMappingView> headerMappingViewList { get; set; }
        public int statusCode { get; set; }
        public string errorMessage { get; set; }
    }
}
