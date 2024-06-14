using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magnus.Views.Import
{
    public class ImportExcelFileView
    {
        public int OrderId { get; set; }
        public int OrderSize { get; set; }
        public string FullName { get; set; }
        public string UserCity { get; set; }
        public string OrderPrice { get; set; }
        public string status { get; set; }
        public string CreateDate { get; set; }
    }
}
