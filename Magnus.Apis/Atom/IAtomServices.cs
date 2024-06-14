
using Magnus.Views.Atom;
using Magnus.Views.GridDataView;
using Magnus.Views.Params;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magnus.APIs.Atom
{
    public interface IAtomServices
    {
        public Task<GridDataView<AtomPlanningView>> GetAllAsync(GridViewParams gridViewParams);
        public Task<List<PlanningMultiSelectView>> GetAllPlanningMutiselectAsync();
        public Task<GridDataView<AtomExportPlansView>> GetAllExportplanAsync(GridViewParams gridViewParams);
        public Task<GridDataView<AtomDisconnectionStatusView>> GetAllDisconnectionStatusAsync(GridViewParams gridViewParams);
        public Task<List<AtomDisconnectionStatusMultiSelect>> GetAllDisconnectioStatusMutiselectAsync();
    }
}
