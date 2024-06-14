namespace Magnus.Views.CaseDetails;

public class PhoneNumber
{
    public int ID { get; init; }

    public int CustomerID { get; init; }

    public string Number { get; init; } = string.Empty;

    public int ContactPriority { get; init; }
}
