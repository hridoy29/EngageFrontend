using System;

namespace Magnus.Core.Model;

public class AtomExportPlans
{
    public string AgentName { get; set; } = string.Empty;
    public int AgentNo { get; set; }
    public DateTime JobDate { get; set; }
    public int NoOfJob { get; set; }
    public int TimersExported { get; set; }
    public string FileName { get; set; } = string.Empty;
}
