using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magnus.Views.OnLoadAlocation
{
    public class LetterSelectionView
    {
        public int OurRef { get; set; }
        public string PostCode { get; set; }
        public string Area { get; set; }
        public string Balance { get; set; }
        public string SLADate { get; set; }
        public string PotentialAvail { get; set; }
        public bool Selected { get; set; } = false;
    }
}
