using Magnus.Core.Models.CaseDetailsModels.CustomerDetailsModels;

namespace Magnus.Core.Models.CaseDetailsModels.PropertyDetailsModels;

public class PropertyDetails : FieldResultsCollection<PropertyFieldResult>
{
    //Client provided information
    public List<Address> Addresses { get; init; } = new();

    public string? GetValue(string fieldName, int? propertyOrd)
        => GetValue(new() { FieldName = fieldName, PropertyOrd = propertyOrd });
}
