using Magnus.Views.GridDataView;
using Magnus.Views.Params;
using Magnus.Views.Search;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Magnus.Core.Models;

namespace Magnus.APIs.Search;

public interface ISearchServices
{
    public Task<IList<SearchView>> GetAllAsync(SearchViewParams searchViewParams);

    public Task<IList<ClientView>> GetAllClient(bool active);

    public Task<IList<CaseStatusView>> GetAllCaseStatus();
}
