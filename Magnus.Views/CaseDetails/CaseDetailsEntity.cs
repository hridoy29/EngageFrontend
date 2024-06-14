using System;
using System.Collections.Generic;

namespace Magnus.Views.CaseDetails;

public class CaseDetailsEntity
{
    public int ID { get; set; }

    public string ClientRef { get; set; }

    public DateTime DateLoaded { get; set; }

    public string WorkFlow { get; init; } = string.Empty;

    public string Status { get; init; } = string.Empty;

    public List<Customer> Customers { get; set; } = new();
}
