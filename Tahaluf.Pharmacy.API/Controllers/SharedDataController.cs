using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
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
    }
}
