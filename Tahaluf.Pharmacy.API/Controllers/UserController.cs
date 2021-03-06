using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
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



        [HttpPut]
        [Route("UpdateUser")]
        public bool UpdateUser(Useraccount useraccount)
        {
            return UserService.UpdateUser(useraccount);
        }


        [HttpPost]
        [Route("Upload")]
        public Useraccount Upload()
        {
            try
            {
               
                // Image -----> Request ----> Form
                var file = Request.Form.Files[0];
                // file.FileName
                var fileName = Guid.NewGuid().ToString() + "_" + file.FileName;
                // create folder "Images" in Tahaluf.LMS.API
                var fullPath = Path.Combine("E:\\tahaluf\\api\\projectFinal\\src\\assets\\image", fileName);
                // FileStream
                using (var stream = new FileStream(fullPath, FileMode.Create))
                {
                    file.CopyTo(stream);
                }
                // DataBase
                Useraccount useraccount = new Useraccount();
                useraccount.Imagepath = fileName;
                return useraccount;
            }
            catch (Exception e)
            {
                return null;
            }
        }
    }
}
