using Cafelutza.Data.Models;

namespace Cafelutza.Data.Repositories;
public class RaportRepository : IRaportRepository
{
    private readonly DatabaseContext _dbContext;
    public RaportRepository(DatabaseContext dbContext)
    {
        _dbContext = dbContext;
    }

    public Task AddRaport(RaportRequest raport, User user)
    {
        var newRaport = new Raport
        {
            Category = raport.Category,
            Description = raport.Description,
            ImageURL = raport.ImageURL,
            Location = raport.Location,
            User = user
        };
       _dbContext.Raports.Add(newRaport);
       _dbContext.SaveChanges();
        return Task.CompletedTask;
    }

    public IEnumerable<Raport> GetAllRaports()
    {
        var raports = _dbContext.Raports.AsEnumerable();
        return raports;
    }

    public Raport GetRaport(string id)
    {
        throw new NotImplementedException();

    }

    public Task RemoveRaport(int id)
    {
        var raport = _dbContext.Raports.FirstOrDefault(x => x.Id == id);
        _dbContext.Raports.Remove(raport);
        _dbContext.SaveChanges();
        return Task.CompletedTask;
    }
}
