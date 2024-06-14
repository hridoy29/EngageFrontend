using System.Collections.Generic;

namespace Magnus.Core.Models.CaseDetailsModels.AccountActionsModels;

public class AccountActions
{
    public List<AccountAction> Actions { get; init; } = new();
}
