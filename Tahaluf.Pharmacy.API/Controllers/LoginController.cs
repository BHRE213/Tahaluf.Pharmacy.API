using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Tahaluf.Pharmace.Core.IService;
using Tahaluf.Pharmacy.API.Data;

namespace Tahaluf.Pharmacy.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly ILoginService LoginService;

        public LoginController(ILoginService _LoginService)
        {
            LoginService = _LoginService;
        }
        [HttpPost]
        [Route("userlogin")]

        public IActionResult userlogin(Useraccount login)
        {
            var token = LoginService.userlogin(login);
            if (token != null)
            {
                return Ok(token);
            }
            else
            {
                return Unauthorized();
            }
        }
    }
}
