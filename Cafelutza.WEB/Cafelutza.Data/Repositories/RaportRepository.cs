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

    public async Task AddRaport(RaportRequest raport, User user)
    {
        var newRaport = new Raport
        {
            Category = raport.Category,
            Description = raport.Description,
            ImageURL = raport.ImageURL,
            Location = raport.Location,
            User = user
        };
        var response = _dbContext.Users.FirstOrDefault(c => c.Name == user.Name);
        response.Raports.Add(newRaport);
       _dbContext.Raports.Add(newRaport);
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
