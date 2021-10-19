using Microsoft.EntityFrameworkCore;


#pragma warning disable CS8618
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