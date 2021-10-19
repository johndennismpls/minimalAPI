public interface IApplicationRepository
{
    Task SaveChangesAsync();
}

public class ApplicationRepository : IApplicationRepository
{
    MinimalApiDbContext _dbcontext;

    public ApplicationRepository(MinimalApiDbContext dbcontext)
    {
        _dbcontext = dbcontext;
    }

    public Task SaveChangesAsync()
    {
        return _dbcontext.SaveChangesAsync();
    }
}