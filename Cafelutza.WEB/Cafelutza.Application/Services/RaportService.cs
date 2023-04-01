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
    public async Task AddRaport(Raport raport) => _raportRepository.AddRaport(raport);
}
