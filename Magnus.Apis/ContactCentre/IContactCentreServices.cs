using Magnus.Views.ContactCentre;
using Magnus.Views.GridDataView;
using Magnus.Views.Params;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magnus.APIs.ContactCentre
{
    public interface IContactCentreServices
    {
        Task<List<string>> DropdownData();
        public Task<GridDataView<ContactCentreView>> GetPagedAllAsync(GridViewParams gridViewParams);
    }
}
