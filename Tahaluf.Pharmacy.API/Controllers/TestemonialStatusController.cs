using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Tahaluf.LMS.Core.Service;
using Tahaluf.Pharmacy.API.Data;

namespace Tahaluf.LMS.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestemonialStatusController : ControllerBase
    {
        private readonly ITestemonialStatusService testemonialStatusService;
        public TestemonialStatusController(ITestemonialStatusService _testemonialStatusService)
        {
            testemonialStatusService = _testemonialStatusService;
        }

        [HttpPost]
        public bool CreateTestStatus(Testimonialstatus testemonialStatus)
        {
            return testemonialStatusService.CreateTestStatus(testemonialStatus);
        }

        [HttpGet]
        public List<Testimonialstatus> GetTestStatus()
        {
            return testemonialStatusService.GetTestStatus();
        }

        [HttpPut]
        public bool UpdateTestStatus(Testimonialstatus testemonialStatus)
        {
            return testemonialStatusService.UpdateTestStatus(testemonialStatus);
        }

        [HttpDelete]
        [Route("DeleteTestStatus/{id}")]
       public bool DeleteTestStatus(int id)
        {
            return testemonialStatusService.DeleteTestStatus(id);
        }

    }
}
