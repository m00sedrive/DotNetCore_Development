
using DotNetCore_Efuelling.Entities;
using DotNetCore_Efuelling.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace DotNetCore_Efuelling.Controllers
{
    [Authorize]
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private IUserService _userService;

        public UserController(IUserService userSevrice)
        {
            _userService = userSevrice;
        }

        [AllowAnonymous]
        [HttpPost("authenticate")]
        public async Task<IActionResult> Authenticate([FromBody]User userparam)
        {
            var user = await _userService.Authenticate(userparam.UserName, userparam.Password);

            if(user == null)
            {
                return BadRequest(new { massage = "Username or Password is incorrect!" });
            }

            return Ok(user);
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var users = await _userService.GetAll();
            return Ok(users);
        }
    }
}
