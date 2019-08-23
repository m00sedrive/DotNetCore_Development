
using IdentityServer3.Core.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using System.Web.Providers.Entities;

namespace DotNetCore_Efuelling.Controllers
{
    public class UserController : Controller
    {
        [Authorize]
        [Route("[controller]")]
        public class UserControllers : ControllerBase
        {
            private IUserService _userService;

            public UserControllers(IUserService userSevrice)
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
}
