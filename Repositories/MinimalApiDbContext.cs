using Microsoft.EntityFrameworkCore;

public class MinimalApiDbContext : DbContext
{
    public MinimalApiDbContext() : base()
    {

    }

    public MinimalApiDbContext(DbContextOptions options) : base(options)
    {
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=localhost;Database=MinimalApi;Trusted_Connection=True;MultipleActiveResultSets=true");
    }

    public DbSet<Customer> Customers { get; set; }

}