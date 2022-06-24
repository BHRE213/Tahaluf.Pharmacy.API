using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using Tahaluf.LMS.Core.Service;
using Tahaluf.Pharmace.Core.Data.DTO;
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
        public List<TestDTO> GetTest()
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



        [HttpPost]
        [Route("Upload")]
        public Testimonial Upload()
        {
            try
            {
                // Image -----> Request ----> Form
                var file = Request.Form.Files[0];
                // file.FileName
                var fileName = Guid.NewGuid().ToString() + "_" + file.FileName;
                // create folder "Images" in Tahaluf.LMS.API
                var fullPath = Path.Combine("C:\\Users\\batool\\Desktop\\projectFinal\\src\\assets\\image", fileName);
                // FileStream
                using (var stream = new FileStream(fullPath, FileMode.Create))
                {
                    file.CopyTo(stream);
                }
                // DataBase
                Testimonial testimonial = new Testimonial();
                testimonial.Image = fileName;
                return testimonial;
            }
            catch (Exception e)
            {
                return null;
            }


        }
        [HttpPost]
        [Route("UpdateTestById")]
        public bool UpdateTestById(TestUpdateDyIdDTO testUpdateDyIdDTO)
        {
            return testemonialService.UpdateTestById(testUpdateDyIdDTO);
        }
    }
}
