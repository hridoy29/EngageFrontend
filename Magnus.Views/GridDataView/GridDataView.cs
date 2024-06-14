using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magnus.Views.GridDataView
{
    public class GridDataView<T>
    {
        public GridDataView()
        {
            DataViewList = new List<T>();
        }
        public ICollection<T> DataViewList { get; set; }
        public int TotalDataViewCount { get; set; }
    }
}
