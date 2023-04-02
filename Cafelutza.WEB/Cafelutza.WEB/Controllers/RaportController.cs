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
        private readonly IUserService _userService;

        public RaportController(IRaportService raportService,IUserService userService)
        {
            _raportService= raportService;
            _userService= userService;
        }

        [HttpPost]
        public ActionResult<Raport> AddRaport([FromBody]RaportRequest raport)
        {
            var user = _userService.GetUser(HttpContext.User.Identity.Name);
            _raportService.AddRaport(raport,user);
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
