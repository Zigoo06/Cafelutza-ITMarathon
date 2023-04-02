using Cafelutza.Data.Models;
using Cafelutza.Data.Repositories;

namespace Cafelutza.Application.Services;
public class RaportService : IRaportService
{
    private readonly IRaportRepository _raportRepository;
    public RaportService(IRaportRepository raportRepository)
    {
        _raportRepository = raportRepository;
    }
    public async Task AddRaport(RaportRequest raport,User user) => await _raportRepository.AddRaport(raport,user);

    public IEnumerable<Raport> GetAllRaports()=> _raportRepository.GetAllRaports();
}
