using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magnus.Views.Params
{
    public class GridViewParams
    {
        public string? Filter { get; set; }
        public string? OrderBy { get; set; }
        public int? Skip { get; set; }
        public int? Take { get; set; } = 10;
        public string? DateFilter { get; set; } = null;
    }
}
