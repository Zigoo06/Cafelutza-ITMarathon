using Cafelutza.Data.Models;
using Cafelutza.Data;

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
    }
}
