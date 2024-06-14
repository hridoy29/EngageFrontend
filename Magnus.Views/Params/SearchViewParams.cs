using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magnus.Views.Params
{
    public class SearchViewParams
    {

        public int ClientId { get; set; }
        public string? OurRef { get; set; }
        public string? SecondaryRef { get; set; }
        public string? ClientAccountNumber { get; set; }
        public string? CustomerName { get; set; }
        public string? FirstLineAddress { get; set; }
        public string? PostCode { get; set; }
        public DateTime? DateProcessedFrom { get; set; }
        public DateTime? DateProcessedTo { get; set; }
        public int CaseStatus { get; set; }
        public bool ExtensiveSearch { get; set; } = true;
        public int? Skip { get; set; }
        public int? Take { get; set; } = 10;
        public string? OrderBy { get; set; }


    }
}
