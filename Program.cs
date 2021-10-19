var builder = WebApplication.CreateBuilder(args);

//builder.Services.Add
builder.Services.AddScoped<ICustomerRepository, CustomerRepository>();
builder.Services.AddTransient<ICustomerService, CustomerService>();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

//Configure
app.UseSwagger();
app.UseSwaggerUI();

app.MapGet("/", () => "Hello World!");

app.MapGet("/customer{id}", (ICustomerService customerService, int id) => {
    return customerService.GetCustomer(id);
});



app.Run();
