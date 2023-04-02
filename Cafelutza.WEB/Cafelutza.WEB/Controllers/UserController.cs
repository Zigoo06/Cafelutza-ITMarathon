using Cafelutza.Application.Services;
using Cafelutza.Data.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace Cafelutza.WEB.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [Authorize]
        [HttpGet]   
        public IActionResult Index()
        {
            var user = HttpContext.User;
            var newUser = new User
            {
                    Id = user.Claims.FirstOrDefault(c=> c.Type == ClaimTypes.NameIdentifier).Value,
                    Name = user.Claims.FirstOrDefault(c => c.Type == ClaimTypes.Name).Value,
                    Email = user.Claims.FirstOrDefault(c => c.Type == ClaimTypes.Email).Value,
                    Role= "user"
            };

            try
            {
                _userService.AddUser(newUser);
            }
            catch(Exception)
            {
                return BadRequest("Can't add user");
            }
            return Redirect("~/");
        }

        [Authorize]
        [HttpGet("isOperator")]
        public ActionResult<bool> IsOperator()
        {
            var userName = HttpContext.User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.Name).Value;

            var role = _userService.GetUserRole(userName);

            return Ok(role == "operator");
        }
    }
}
