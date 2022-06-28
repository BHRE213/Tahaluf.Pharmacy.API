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
    public class SharedDataController : ControllerBase
    {
        private readonly ISharedDataService sharedDataService;
        public SharedDataController(ISharedDataService _sharedDataService)
        {
            sharedDataService = _sharedDataService;
        }

        [HttpPost]
        public bool CreateSData(Shareddatum sharedData)
        {
            return sharedDataService.CreateSData(sharedData);
        }

        [HttpGet]
        public List<Shareddatum> GetSData()
        {
            return sharedDataService.GetSData();
        }

        [HttpPut]
        public bool UpdateSData(Shareddatum sharedData)
        {
            return sharedDataService.UpdateSData(sharedData);
        }

        [HttpDelete]
        [Route("DeleteSData/{id}")]
        public bool DeleteSData(int id)
        {
            return sharedDataService.DeleteSData(id);
        }


        [HttpPost]
        [Route("Upload")]
        public Shareddatum Upload()
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
                Shareddatum shareddatum = new Shareddatum();
                shareddatum.Image = fileName;
                return shareddatum;
            }
            catch (Exception e)
            {
                return null;
            }
        }
    }
}
