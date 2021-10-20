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

    public async Task AddCustomer(AddCustomerRequest customer)
    {
        _customerRepository.AddCustomer(customer);
        await _applicationRepository.SaveChangesAsync();
    }

    public Task<IReadOnlyCollection<Customer>> GetCustomers()
    {
        return _customerRepository.GetCustomers();
    }

    public async Task UpdateCustomerAsync(UpdateCustomerRequest request)
    {
        await _customerRepository.UpdateCustomer(request);
        await _applicationRepository.SaveChangesAsync();
    }

}