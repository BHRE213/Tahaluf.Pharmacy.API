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
    public class SiteDataController : ControllerBase
    {
        private readonly ISiteDataService siteDataService;
        public SiteDataController(ISiteDataService _siteDataService)
        {
            siteDataService = _siteDataService;
        }

        [HttpPost]
        public bool CreateSiteData(Sitedatum siteData)
        {
            return siteDataService.CreateSiteData(siteData);
        }

        [HttpGet]
        public List<Sitedatum> GetSiteData()
        {
            return siteDataService.GetSiteData();
        }
        [HttpPut]
        public bool UpdateSiteData(Sitedatum siteData)
        {
            return siteDataService.UpdateSiteData(siteData);
        }

        [HttpDelete]
        [Route("DeleteSiteData/{id}")]
        public bool DeleteSiteData(int id)
        {
            return siteDataService.DeleteSiteData(id);
        }

        [HttpPost]
        [Route("Upload")]
        public Sitedatum Upload()
        {
            try
            {
                // Image -----> Request ----> Form
                var file = Request.Form.Files[0];
                // file.FileName
                var fileName = Guid.NewGuid().ToString() + "_" + file.FileName;
                // create folder "Images" in Tahaluf.LMS.API
                var fullPath = Path.Combine("E:\\tahaluf\\api\\projectFinal\\src\\assets", fileName);
                // FileStream
                using (var stream = new FileStream(fullPath, FileMode.Create))
                {
                    file.CopyTo(stream);
                }
                // DataBase
                Sitedatum saitedatum = new Sitedatum();
                saitedatum.Image = fileName;
                return saitedatum;
            }
            catch (Exception e)
            {
                return null;
            }
        }
    }
}
