using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Data;
using Tahaluf.Pharmace.Core.Data.DTO;
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
        [HttpGet]
        [Route("GetNumberOfUserWhoGetOrder")]
        public NumberOfUserWhoMadeOrdersDTO GetNumberOfUserWhoGetOrder()
        {
            return UserService.GetNumberOfUserWhoGetOrder();
        }

        [HttpDelete]
        [Route("DeleteUser/{id}")]
        public bool DeleteUser(int id)
        {
            return UserService.DeleteUser(id);
        }

        [HttpPost]
        [Route("CreateUser")]
        public bool CreateUser(Useraccount useraccount)
        {
            return UserService.CreateUser(useraccount);
        }
    }
}
