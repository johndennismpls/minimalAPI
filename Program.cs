using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

//builder.Services.Add
builder.Services.AddScoped<ICustomerRepository, CustomerRepository>();
builder.Services.AddScoped<IApplicationRepository, ApplicationRepository>();
builder.Services.AddTransient<ICustomerService, CustomerService>();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<MinimalApiDbContext>(
        options => options.UseSqlServer("Server=localhost;Database=MinimalApi;Trusted_Connection=True;MultipleActiveResultSets=true"));

var app = builder.Build();

//Configure
if(!builder.Environment.IsProduction())
{
    app.UseSwaggerUI();
    app.UseSwagger();
}


//routes
app.MapGet("/", () => "Hello World!");

app.MapGet("/customer/{id}", (ICustomerService customerService, int id) => {
    return customerService.GetCustomer(id);
});
app.MapGet("/customer", (ICustomerService customerService) => {
    return customerService.GetCustomers();
});

app.MapPost("/customer", (ICustomerService customerService, AddCustomerRequest request) => {
    return customerService.AddCustomer(request);
});

app.MapPut("/customer", (ICustomerService customerService, UpdateCustomerRequest request) => {
    return customerService.UpdateCustomerAsync(request);
});


app.Run();
