public interface ICustomerRepository
{
    Task<Customer> GetCustomer(int customerId);
    void AddCustomer(Customer customer);
}
