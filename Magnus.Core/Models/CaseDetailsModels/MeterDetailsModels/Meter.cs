namespace Magnus.Core.Models.CaseDetailsModels.MeterDetailsModels;

public class Meter
{
    public int ID { get; init; } = -1;

    public int CaseID { get; init; }

    public string MeterTypeID { get; init; }

    public string Type { get; init; } = string.Empty;

    public string MPxN { get; init; } = string.Empty;

    public string MSN { get; init; } = string.Empty;
}
