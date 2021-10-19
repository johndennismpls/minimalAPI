var builder = WebApplication.CreateBuilder(args);

//builder.Services.Add
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

//Configure
app.UseSwagger();
app.UseSwaggerUI();

app.MapGet("/", () => "Hello World!");



app.Run();
