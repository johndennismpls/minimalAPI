public class CustomerService : ICustomerService
{
    private readonly ICustomerRepository _customerRepository;

    public CustomerService(ICustomerRepository customerRepository)
    {
        _customerRepository = customerRepository;
    }

    public Task<Customer> GetCustomer(int customerId)
    {
        return _customerRepository.GetCustomer(customerId);
    }
}