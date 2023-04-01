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

    public void AddRaport(Raport raport)
    {
        _dbContext.Raports.Add(raport);
        _dbContext.SaveChanges();
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
