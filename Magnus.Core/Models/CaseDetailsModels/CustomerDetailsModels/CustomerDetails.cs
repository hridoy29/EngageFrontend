using System.Collections.Generic;

namespace Magnus.Core.Models.CaseDetailsModels.CustomerDetailsModels;

public class CustomerDetails : FieldResultsCollection<CustomerFieldResult>
{
    //Client provided information
    public List<Customer> Customers { get; init; } = new();
}
