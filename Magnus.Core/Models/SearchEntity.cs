using System;

namespace Magnus.Core.Model;

public class SearchEntity
{
    public int CaseID { get; init; }
    public string ClientName { get; init; } = string.Empty;
    public string ClientRef { get; init; } = string.Empty;
    public string CustomerName { get; init; } = string.Empty;
    public string FirstLineAddress { get; init; } = string.Empty;
    public string PostCode { get; init; } = string.Empty;
    public DateTime DateLoaded { get; init; }
    public string Outcome { get; init; } = string.Empty;
    public string SecondaryReference { get; init; } = string.Empty; 
    public string CaseStatus { get; init; } = string.Empty;
    public string TelNo { get; init; } = string.Empty;
    public DateTime LastUpdate { get; init; }
    public string InvoiceRef { get; init; } = string.Empty;
}
