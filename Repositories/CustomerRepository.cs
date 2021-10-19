public class CustomerRepository : ICustomerRepository
{
    MinimalApiDbContext _dbcontext;

    public CustomerRepository(MinimalApiDbContext dbcontext)
    {
        _dbcontext = dbcontext;
    }

    public async Task<Customer> GetCustomer(int customerId)
    {
        var customer = await _dbcontext.Customers.FindAsync(customerId);
        return customer;
    }

    public void AddCustomer(Customer customer)
    {
        _dbcontext.Add(customer);
    }
}