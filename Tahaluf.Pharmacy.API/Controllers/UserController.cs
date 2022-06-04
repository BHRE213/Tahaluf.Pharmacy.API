using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Data;
using Tahaluf.Pharmace.Core.IService;
using Tahaluf.Pharmacy.API.Data;

namespace Tahaluf.Pharmacy.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService UserService;

        public UserController(IUserService _UserService)
        {
            UserService = _UserService;
        }
        [HttpGet]
        //[Authorize(Roles ="Admin")]
        public List<Useraccount> GetALLUsers()
        {

            return UserService.GetALLUsers();
        }

        [HttpDelete]
        [Route("DeleteUser/{id}")]
        public bool DeleteUser(int id)
        {
            return UserService.DeleteUser(id);
        }
    }
}
