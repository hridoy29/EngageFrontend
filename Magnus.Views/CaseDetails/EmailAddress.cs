namespace Magnus.Views.CaseDetails;

public class EmailAddress
{
    public int ID { get; init; }

    public int CustomerID { get; init; }

    public string Email { get; init; } = string.Empty;
    
    public int ContactPriority { get; init; }
}
