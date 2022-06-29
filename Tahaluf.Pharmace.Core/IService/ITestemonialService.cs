using System;
using System.Collections.Generic;
using System.Text;
using Tahaluf.Pharmace.Core.Data.DTO;
using Tahaluf.Pharmacy.API.Data;

namespace Tahaluf.LMS.Core.Service
{
    public interface ITestemonialService
    {

        bool CreateTest(Testimonial testemonial);
        List<TestDTO> GetTest();
        bool DeleteTest(int id);
        List<Testimonial> GetAccTest();
        bool UpdateTestById(TestUpdateDyIdDTO testUpdateDyIdDTO);
    }
}
