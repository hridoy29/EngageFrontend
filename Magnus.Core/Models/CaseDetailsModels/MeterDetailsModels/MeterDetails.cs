using System.Collections.Generic;

namespace Magnus.Core.Models.CaseDetailsModels.MeterDetailsModels;

public class MeterDetails : FieldResultsCollection<MeterFieldResult>
{
    //Client provided information
    public List<Meter> Meters { get; init; } = new();

    public string? GetValue(string fieldName, int? meterOrd, int? readingOrd) 
        => GetValue(new() { FieldName = fieldName, MeterOrd = meterOrd, ReadingOrd = readingOrd });
}
