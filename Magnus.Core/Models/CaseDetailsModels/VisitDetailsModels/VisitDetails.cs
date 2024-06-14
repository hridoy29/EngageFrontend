namespace Magnus.Core.Models.CaseDetailsModels.VisitDetailsModels;

public class VisitDetails : FieldResultsCollection<VisitFieldResult>
{
    public string? GetValue(string fieldName)
        => base.GetValue(new() { FieldName = fieldName });
}
