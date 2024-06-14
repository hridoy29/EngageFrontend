using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magnus.Views.Import
{
    public class ImportMultiselectView
    {
        public List<string> clients { get; set; } = new();
        public List<string> workTypes { get; set; } = new();
    }
}
