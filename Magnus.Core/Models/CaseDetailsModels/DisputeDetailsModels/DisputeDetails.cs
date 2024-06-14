namespace Magnus.Core.Models.CaseDetailsModels.DisputeDetailsModels;

public class DisputeDetails : FieldResultsCollection<DisputeFieldResult>
{
    public string? GetValue(string fieldName) 
        => base.GetValue(new() { FieldName = fieldName });
}
