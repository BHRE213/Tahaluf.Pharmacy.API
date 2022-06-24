using System;
using System.Collections.Generic;
using System.Text;
using Tahaluf.LMS.Core.RepositoryInterface;
using Tahaluf.LMS.Core.Service;
using Tahaluf.Pharmace.Core.Data.DTO;
using Tahaluf.Pharmacy.API.Data;

namespace Tahaluf.LMS.Infra.Service
{
    
    public class TestemonialService : ITestemonialService
    {
        public readonly ITestemonialRepository testemonialRepository;
        public TestemonialService(ITestemonialRepository _testemonialRepository)
        {
            testemonialRepository = _testemonialRepository;
        }

        public bool CreateTest(Testimonial testemonial)
        {
            return testemonialRepository.CreateTest(testemonial);
        }
       public List<TestDTO> GetTest()
        {
            return testemonialRepository.GetTest();
        }
        public bool UpdateTest(Testimonial testemonial)
        {
            return testemonialRepository.UpdateTest(testemonial);
        }
        public bool DeleteTest(int id)
        {
            return testemonialRepository.DeleteTest(id);
        }
        public bool UpdateTestById(TestUpdateDyIdDTO testUpdateDyIdDTO)
        {
            return testemonialRepository.UpdateTestById(testUpdateDyIdDTO);
        }
    }
}
