using Cafelutza.Data.Models;
using System.Linq;
namespace Cafelutza.Data.Repositories;
public class RaportRepository : IRaportRepository
{
    private readonly DatabaseContext _dbContext;
    public RaportRepository(DatabaseContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task AddRaport(Raport raport)
    {
       _dbContext.Raports.Add(raport);
       await _dbContext.SaveChangesAsync();
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

    public void RemoveRaport(int id)
    {
        throw new NotImplementedException();
    }
}
