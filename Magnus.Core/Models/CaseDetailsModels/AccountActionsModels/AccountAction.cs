using System;

namespace Magnus.Core.Models.CaseDetailsModels.AccountActionsModels;

public class AccountAction
{
    public int ID { get; set; }

    public DateTime CreatedOn { get; init; }

    public string Action { get; init; } = string.Empty;

    public string User { get; init; } = string.Empty;
}
