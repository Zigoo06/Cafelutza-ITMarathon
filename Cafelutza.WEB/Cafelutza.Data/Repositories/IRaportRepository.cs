using Cafelutza.Data.Models;

namespace Cafelutza.Data.Repositories;

public interface IRaportRepository
{
    public Task AddRaport(Raport raport);
    public void RemoveRaport(int id);
    public Raport GetRaport(string id);
    public IEnumerable<Raport> GetAllRaports();
}
