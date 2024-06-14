namespace Magnus.Core.Models.CaseDetailsModels.PaymentDetailsModels;

public class PaymentDetails : FieldResultsCollection<PaymentFieldResult>
{
    public string? GetValue(string fieldName)
        => base.GetValue(new() { FieldName = fieldName });
}
