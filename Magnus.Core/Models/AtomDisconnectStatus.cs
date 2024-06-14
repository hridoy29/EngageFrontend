using System;

namespace Magnus.Core.Model;

public class AtomDisconnectStatus
{
    public int OurRef { get; set; }
    public int ClientRef { get; set; }
    public string Company { get; set; } = string.Empty;
    public string AgentName { get; set; } = string.Empty;
    public string PostCode { get; set; } = string.Empty;
    public decimal Balance { get; set; }
    public DateTime SLADate { get; set; }
    public DateTime PlannedDate { get; set; }
    public string Status { get; set; } = string.Empty;
    public string SubStatus { get; set; } = string.Empty;
}
