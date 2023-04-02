using Cafelutza.Data.Models;

namespace Cafelutza.Application.Services;

public interface IRaportService
{
    public Task AddRaport(RaportRequest raport,User user);
    public IEnumerable<Raport> GetAllRaports();
    public Task RemoveRaport(int id);
}
