using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magnus.Views.OnLoadAlocation
{
    public class OnLoadAlocationView
    {
        public int OurRef { get; set; }
        public int ClientRef { get; set; }
        public string Company { get; set; }
        public string Region { get; set; }
        public string PostCode { get; set; }
        public string Area { get; set; }
        public string AltPostCode { get; set; }
        public string LoadDate { get; set; }
        public bool Lettered { get; set; }
        public string LetterDate { get; set; }
        public int Hold { get; set; }
        public int DueOnHold { get; set; }
        public string Status { get; set; }
        public bool Selection { get; set; }
    }
}
