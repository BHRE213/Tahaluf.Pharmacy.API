using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
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
    }
}
