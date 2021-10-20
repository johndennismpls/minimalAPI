public interface ICustomerService
{
    Task<Customer> GetCustomer(int customerId);
    Task AddCustomer(AddCustomerRequest customer);
    Task<IReadOnlyCollection<Customer>> GetCustomers();
    Task UpdateCustomerAsync(UpdateCustomerRequest request);

}
