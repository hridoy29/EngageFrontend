using System.Collections.Generic;

namespace Magnus.Core.Models.CaseDetailsModels.AdjustmentDetailsModels;

public class AdjustmentDetails
{
    public List<Adjustment> Adjustments { get; init; } = new();
}
