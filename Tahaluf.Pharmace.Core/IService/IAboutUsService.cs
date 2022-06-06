using System;
using System.Collections.Generic;
using System.Text;
using Tahaluf.Pharmacy.API.Data;

namespace Tahaluf.LMS.Core.Service
{
    public interface IAboutUsService
    {
        
        bool CreatePage(Abuotu aboutUs);
        bool DeletePage(int id);
        List<Abuotu> GetPageInfo();
        bool UpdatePage(Abuotu aboutUs);
    }
}
