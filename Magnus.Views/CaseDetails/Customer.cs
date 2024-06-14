using System.Collections.Generic;

namespace Magnus.Views.CaseDetails;

public class Customer
{
    public int ID { get; init; }

    public int CaseID { get; init; }

    public int ContactPriority { get; init; }

    public CustomerName Name { get; set; } = new();

    public List<PhoneNumber> PhoneNumbers { get; init; } = new();

    public List<EmailAddress> EmailAddresses { get; init; } = new();

    public List<Address> Addresses { get; init; } = new();
}
