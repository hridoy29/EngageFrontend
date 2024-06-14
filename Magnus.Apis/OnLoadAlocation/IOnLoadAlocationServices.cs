using Magnus.Views.GridDataView;
using Magnus.Views.OnLoadAlocation;
using Magnus.Views.Params;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magnus.APIs.OnLoadAlocation
{
    public interface ILoadAlocationServices
    {
        public Task<GridDataView<OnLoadAlocationView>> GetAllAsync(GridViewParams gridViewParams);
        public Task<List<NotAvailableMultiSelectView>> GetAllNotAvailableMultiSelectViews();
        public Task<GridDataView<LetterSelectionView>> LetterSelectionGetPagedAsync(GridViewParams gridViewParams);
        public Task<GridDataView<PostCodeCheckerView>> PostCodeCheckerGetPagedAsync(GridViewParams gridViewParams);
        public Task<GridDataView<OlAFSettingView>> olAFSettingGetPagedAsync(GridViewParams gridViewParams);
    }
}
