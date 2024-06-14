using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magnus.Views.OnLoadAlocation
{
    public class PostCodeCheckerView
    {
        public int OurRef { get; set; }
        public string CompanyName { get; set; }
        public string JobPostCode { get; set; }
        public string AltPostCode { get; set; }
        public string Incorrect { get; set; }
    }
}
