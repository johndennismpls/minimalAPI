public class CustomerRepository : ICustomerRepository
{
    public Task<Customer> GetCustomer(int customerId)
    {
        var customer = new Customer { CustomerId = customerId, GivenName = "John", FamilyName = "Dennis" };
        return Task.FromResult(customer);
    }
}