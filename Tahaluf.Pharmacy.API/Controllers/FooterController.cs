using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Tahaluf.LMS.Core.Service;
using Tahaluf.Pharmacy.API.Data;

namespace Tahaluf.LMS.API.Controllers
{
    
    [Route("api/[controller]")]
    [ApiController]
    public class FooterController : ControllerBase
    {
        private readonly IFooterService footerService;
        public FooterController(IFooterService _footerService)
        {
            footerService = _footerService;
        }
        [HttpPost]
        public bool CreateFooter(Footer footer)
        {
            return footerService.CreateFooter(footer);
        }

        [HttpGet]
        public List<Footer> GetFooter()
        {
            return footerService.GetFooter();
        }

        [HttpPut]
        public bool UpdateFooter(Footer footer)
        {
            return footerService.UpdateFooter(footer);
        }

        [HttpDelete]
        [Route("DeleteFooter/{id}")]
        public bool DeleteFooter(int id)
        {
            return footerService.DeleteFooter(id);
        }
    }
}
