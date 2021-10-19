public interface ICustomerService
{
    Task<Customer> GetCustomer(int customerId);
}
