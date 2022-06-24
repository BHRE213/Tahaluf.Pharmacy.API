using System;
using System.Collections.Generic;
using System.Text;
using Tahaluf.Pharmace.Core.Data.DTO;
using Tahaluf.Pharmacy.API.Data;

namespace Tahaluf.LMS.Core.RepositoryInterface
{
    public interface ITestemonialRepository
    {
       
        bool CreateTest(Testimonial testemonial);
        List<TestDTO> GetTest();
        bool UpdateTest(Testimonial testemonial);
        bool DeleteTest(int id);
        bool UpdateTestById(TestUpdateDyIdDTO testUpdateDyIdDTO);
    }
}
