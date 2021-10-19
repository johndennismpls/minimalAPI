public class CustomerService : ICustomerService
{
    private readonly ICustomerRepository _customerRepository;
    private readonly IApplicationRepository _applicationRepository;

    public CustomerService(ICustomerRepository customerRepository, IApplicationRepository applicationRepository)
    {
        _customerRepository = customerRepository;
        _applicationRepository = applicationRepository;
    }

    public Task<Customer> GetCustomer(int customerId)
    {
        return _customerRepository.GetCustomer(customerId);
    }

    public async Task AddCustomer(Customer customer)
    {
        _customerRepository.AddCustomer(customer);
        await _applicationRepository.SaveChangesAsync();
    }
}