
public record Customer
{
    public Customer()
    {
        CustomerAddresses = new HashSet<CustomerAddress>();
    }

    public int CustomerId { get; set; }
    public string? FamilyName { get; set; }
    public string? GivenName { get; set; }

    public ISet<CustomerAddress> CustomerAddresses { get; set; }
}