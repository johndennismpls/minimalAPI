var builder = WebApplication.CreateBuilder(args);

//builder.Services.Add
builder.Services.AddScoped<ICustomerRepository, CustomerRepository>();
builder.Services.AddTransient<ICustomerService, CustomerService>();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

//Configure
if(!builder.Environment.IsProduction())
{
    app.UseSwaggerUI();
    app.UseSwagger();
}

app.MapGet("/", () => "Hello World!");

app.MapGet("/customer", (ICustomerService customerService, int id) => {
    return customerService.GetCustomer(id);
});



app.Run();
