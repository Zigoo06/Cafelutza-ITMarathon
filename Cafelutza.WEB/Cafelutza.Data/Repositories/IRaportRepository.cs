using Cafelutza.Data.Models;

namespace Cafelutza.Data.Repositories;

public interface IRaportRepository
{
    public Task AddRaport(RaportRequest raport, User user);
    public void RemoveRaport(int id);
    public Raport GetRaport(string id);
    public IEnumerable<Raport> GetAllRaports();
}
