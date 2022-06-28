using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using Tahaluf.LMS.Core.Service;
using Tahaluf.Pharmacy.API.Data;

namespace Tahaluf.LMS.API.Controllers
{
    
    [Route("api/[controller]")]
    [ApiController]
    public class AboutUsController : ControllerBase
    {
        private readonly IAboutUsService aboutUsService;
        public AboutUsController(IAboutUsService _aboutUsService)
        {
            aboutUsService = _aboutUsService;
        }

        [HttpPost]
        [Route("Create")]
        public bool CreatePage(Abuotu aboutUs)
        {
            return aboutUsService.CreatePage(aboutUs);
        } 




        [HttpGet]
        public List<Abuotu> GetPageInfo()
        {
            return aboutUsService.GetPageInfo();
        }

        [HttpDelete]
        [Route("delete/{id}")]
        public bool DeletePage(int id)
        {
            return aboutUsService.DeletePage(id);
        }

        [HttpPut]
        [Route("update")]
        public bool UpdatePage(Abuotu aboutUs)
        {
            return aboutUsService.UpdatePage(aboutUs);
        }


        [HttpPost]
        [Route("Upload")]
        public Abuotu Upload()
        {
            try
            {
                // Image -----> Request ----> Form
                var file = Request.Form.Files[0];
                // file.FileName
                var fileName = Guid.NewGuid().ToString() + "_" + file.FileName;
                // create folder "Images" in Tahaluf.LMS.API

                var fullPath = Path.Combine("E:\\tahaluf\\api\\projectFinal\\src\\assets\\image", fileName);

                var fullPath = Path.Combine("E:\\tahaluf\\api\\projectFinal\\src\\assets", fileName);

                // FileStream
                using (var stream = new FileStream(fullPath, FileMode.Create))
                {
                    file.CopyTo(stream);
                }
                // DataBase
                Abuotu aboutus= new Abuotu();
                aboutus.Image = fileName;
                return aboutus;
            }
            catch (Exception e)
            {
                return null;
            }
        }

    }
}

