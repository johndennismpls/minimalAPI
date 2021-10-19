public interface ICustomerService
{
    Task<Customer> GetCustomer(int customerId);
    Task AddCustomer(Customer customer);

}
