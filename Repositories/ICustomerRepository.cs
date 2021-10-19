public interface ICustomerRepository
{
    Task<Customer> GetCustomer(int customerId);
}
