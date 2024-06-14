namespace Magnus.Views.CaseDetails;

public class AddressLine
{
    public int ID { get; init; }

    public int AddressID { get; init; }

    public int LineNumber { get; init; }

    public string Line { get; init; } = string.Empty;
}