public interface ICustomerRepository
{
    Task<Customer> GetCustomer(int customerId);
    Task<IReadOnlyCollection<Customer>> GetCustomers();
    void AddCustomer(AddCustomerRequest customer);
    Task UpdateCustomer(UpdateCustomerRequest request);
}
