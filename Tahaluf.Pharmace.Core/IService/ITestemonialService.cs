using System;
using System.Collections.Generic;
using System.Text;
using Tahaluf.Pharmacy.API.Data;

namespace Tahaluf.LMS.Core.Service
{
    public interface ITestemonialService
    {
        bool CreateTest(Testimonial testemonial);
        List<Testimonial> GetTest();
        bool UpdateTest(Testimonial testemonial);
        bool DeleteTest(int id);
    }
}
