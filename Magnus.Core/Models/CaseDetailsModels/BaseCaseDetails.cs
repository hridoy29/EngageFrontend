using System;

namespace Magnus.Core.Models.CaseDetailsModels;

public class BaseCaseDetails
{
    public int ID { get; init; } = -1;

    public string ClientRef { get; init; } = string.Empty;
   
    public string ClientName { get; init; } = string.Empty;

    public string CaseType { get; init; } = string.Empty;

    public string WorkFlow { get; init; } = string.Empty;

    public DateTime DateLoaded { get; init; } = DateTime.MinValue;

    public string Status { get; init; } = string.Empty;
}
