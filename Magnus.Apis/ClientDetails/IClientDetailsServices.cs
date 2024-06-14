using Magnus.Core.Models.CaseDetailsModels;
using Magnus.Views.ClientDetails;
using Magnus.Views.Params;
using Magnus.Views.Search;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magnus.APIs.ClientDetails;

public interface IClientDetailsServices
{
    public Task<CaseDetails> GetCaseDetailsAsync(int ourReference);

    public Task<bool> PostActionHistoryAsync(ActionHistoryViewParams actionHistoryViewParams);
}
