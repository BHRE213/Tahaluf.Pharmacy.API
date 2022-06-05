using System;
using System.Collections.Generic;
using System.Text;
using Tahaluf.Pharmacy.API.Data;

namespace Tahaluf.LMS.Core.Service
{
    public interface ITestemonialStatusService
    {
       
        bool CreateTestStatus(Testimonialstatus testemonialStatus);
        List<Testimonialstatus> GetTestStatus();
        bool UpdateTestStatus(Testimonialstatus testemonialStatus);
        bool DeleteTestStatus(int id);
    }
}
