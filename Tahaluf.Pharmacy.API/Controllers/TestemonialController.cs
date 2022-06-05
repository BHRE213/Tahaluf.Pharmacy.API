using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Tahaluf.LMS.Core.Service;
using Tahaluf.Pharmacy.API.Data;

namespace Tahaluf.LMS.API.Controllers
{
    
    [Route("api/[controller]")]
    [ApiController]
    public class TestemonialController : ControllerBase
    {
        private readonly ITestemonialService testemonialService;
        public TestemonialController(ITestemonialService _testemonialService)
        {
            testemonialService = _testemonialService;
        }

        [HttpPost]
        public bool CreateTest(Testimonial testemonial)
        {
            return testemonialService.CreateTest(testemonial);
        }

        [HttpGet]
        public List<Testimonial> GetTest()
        {
            return testemonialService.GetTest();
        }

        [HttpPut]
        public bool UpdateTest(Testimonial testemonial)
        {
            return testemonialService.UpdateTest(testemonial);
        }

        [HttpDelete]
        [Route("DeleteTest/{id}")]
       public bool DeleteTest(int id)
        {
            return testemonialService.DeleteTest(id);
        }
    }
}
