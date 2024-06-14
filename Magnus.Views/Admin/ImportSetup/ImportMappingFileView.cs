using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magnus.Views.Admin.ImportSetup
{
    public class ImportMappingFileView
    {
        public int ClientID { get; set; }
        public string ClientName { get; set; }
        public int FileTypeID { get; set; }
        public string FileType { get; set; }
    }
}
