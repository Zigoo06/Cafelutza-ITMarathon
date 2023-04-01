using Cafelutza.Application.Services;
using Cafelutza.Data.Models;
using Microsoft.AspNetCore.Mvc;

namespace Cafelutza.WEB.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RaportController : ControllerBase
    {
        private readonly IRaportService _raportService;

        public RaportController(IRaportService raportService)
        {
            _raportService= raportService;
        }

        [HttpPost]
        public ActionResult<Raport> AddRaport([FromBody] Raport raport)
        {
            _raportService.AddRaport(raport);
            return Ok(raport);
        }

        [HttpGet("getall")]
        public ActionResult<IEnumerable<Raport>> GetAllRaports()
        {
            var raports =_raportService.GetAllRaports();
            return Ok(raports);
        }
    }
}
