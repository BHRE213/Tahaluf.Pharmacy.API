using System;
using System.Collections.Generic;
using System.Text;
using Tahaluf.LMS.Core.RepositoryInterface;
using Tahaluf.LMS.Core.Service;
using Tahaluf.Pharmacy.API.Data;

namespace Tahaluf.LMS.Infra.Service
{
    public class TestemonialStatusService : ITestemonialStatusService
    {
        public readonly ITestemonialStatusRepository testemonialstatusRepository;
        public TestemonialStatusService(ITestemonialStatusRepository _testemonialstatusRepository)
        {
            testemonialstatusRepository = _testemonialstatusRepository;
        }

        public bool CreateTestStatus(Testimonialstatus testemonialStatus)
        {
            return testemonialstatusRepository.CreateTestStatus(testemonialStatus);
        }
        public List<Testimonialstatus> GetTestStatus()
        {
            return testemonialstatusRepository.GetTestStatus();
        }
        public bool UpdateTestStatus(Testimonialstatus testemonialStatus)
        {
            return testemonialstatusRepository.UpdateTestStatus(testemonialStatus);
        }
        public bool DeleteTestStatus(int id)
        {
            return testemonialstatusRepository.DeleteTestStatus(id);
        }
    }
}
