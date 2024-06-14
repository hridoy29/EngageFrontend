using System.Collections.Generic;

namespace Magnus.Core.Models.CaseDetailsModels.AuditDetailsModels;

public class AuditDetails
{
    public List<Audit> Audits { get; init; } = new();
}
