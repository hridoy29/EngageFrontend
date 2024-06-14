using System;

namespace Magnus.Views.Search;

public class SearchView
{
    public int CaseID { get; init; }
    public string ClientName { get; init; }
    public string ClientRef { get; init; }
    public string CustomerName { get; init; }
    public string FirstLineAddress { get; init; }
    public string PostCode { get; init; }
    public DateTime DateLoaded { get; init; }
    public string Outcome { get; init; }
    public string SecondaryReference { get; init; }
    public string CaseStatus { get; init; }
    public string TelNo { get; init; }
    public DateTime LastUpdate { get; init; }
    public string InvoiceRef { get; init; }
}
