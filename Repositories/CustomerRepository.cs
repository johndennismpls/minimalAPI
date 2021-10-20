using Microsoft.EntityFrameworkCore;

public class CustomerRepository : ICustomerRepository
{
    MinimalApiDbContext _dbcontext;

    public CustomerRepository(MinimalApiDbContext dbcontext)
    {
        _dbcontext = dbcontext;
    }

    public async Task<Customer> GetCustomer(int customerId)
    {
        var customer = await _dbcontext.Customers
            .Include(c => c.CustomerAddresses)
            .SingleOrDefaultAsync(c => c.CustomerId == customerId);            
        return customer;
    }

    public async Task<IReadOnlyCollection<Customer>> GetCustomers()
    {
        var customers = await _dbcontext
            .Customers
            .Include(c => c.CustomerAddresses)
            .ToListAsync();
        return customers;
    }

    public void AddCustomer(AddCustomerRequest request)
    {
        var customer = new Customer{
            FamilyName = request.FamilyName,
            GivenName = request.GivenName
        };
        _dbcontext.Customers.Add(customer);
    }

    public async Task UpdateCustomer(UpdateCustomerRequest request)
    {
        var customerToUpdate = await GetCustomer(request.CustomerId);
        _dbcontext
            .Entry(customerToUpdate)
            .CurrentValues
            .SetValues(request);
    }
}