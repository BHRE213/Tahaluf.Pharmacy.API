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
        public bool CreatePage(Abuotu aboutUs)
        {
            return aboutUsService.CreatePage(aboutUs);
        }



        [HttpPost]
        [Route("uploadImage")]
        public Abuotu UploadImage()
        {
            try
            {
                var file = Request.Form.Files[0];
                var fileName = Guid.NewGuid().ToString() + "_"+ file.FileName;
                var fullPath = Path.Combine("Images",fileName);
                using (var stream = new FileStream(fullPath,FileMode.Create))
                {
                    file.CopyTo(stream);
                }
                Abuotu Item = new Abuotu();
                Item.Image = fileName;
                return Item;
            }
            catch 
            //(Exception e)
            {
                return null;
            }
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
        public bool UpdatePage(Abuotu aboutUs)
        {
            return aboutUsService.UpdatePage(aboutUs);
        }
    }
}
