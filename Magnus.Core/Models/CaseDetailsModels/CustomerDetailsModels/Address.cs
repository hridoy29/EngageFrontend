namespace Magnus.Core.Models.CaseDetailsModels.CustomerDetailsModels;

using System.Collections.Generic;


public class Address
{
    public int ID { get; init; }

    public int CustomerID { get; init; }

    public int Priority { get; init; }

    public string PostCode { get; init; } = string.Empty;

    public string AddressType { get; init; } = string.Empty;

    public List<AddressLine> Lines { get; init; } = new();

    public string JoinedLines
        => string.Join(Environment.NewLine, Lines.OrderBy(l => l.LineNumber).Select(l => l.Line));
}