using System;

namespace Magnus.Core.Models.CaseDetailsModels.AdjustmentDetailsModels;

public class Adjustment
{
    public int CaseID { get; init; }
    
    public string ClientRef { get; init; } = string.Empty;

    public string UpdateType { get; init; } = string.Empty;

    public string ClientCancellationReason { get; init; } = string.Empty;   
    
    public string EngageCancellationReason { get; init; } = string.Empty;

    public string BalanceUpdateValue { get; init; } = string.Empty;

    public string FileName { get; init; } = string.Empty;

    public DateTime ProcessedOn { get; init; }

    public string Comments { get; init; } = string.Empty;

    public bool Success { get; init; }
}
