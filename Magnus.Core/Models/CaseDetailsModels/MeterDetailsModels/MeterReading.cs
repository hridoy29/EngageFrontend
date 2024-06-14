using System;

namespace Magnus.Core.Models.CaseDetailsModels.MeterDetailsModels;

public class MeterReading
{
    public int ID { get; init; }

    public int MeterID { get; init; }

    public string PhaseType { get; init; } = string.Empty;

    public string ReadingSource { get; init; } = string.Empty;

    public DateTime ReadingDate { get; init; } = DateTime.MinValue;

    public int Reading { get; init; } = -1;
}
