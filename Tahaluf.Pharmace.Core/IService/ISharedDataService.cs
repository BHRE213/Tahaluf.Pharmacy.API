using System;
using System.Collections.Generic;
using System.Text;
using Tahaluf.Pharmacy.API.Data;

namespace Tahaluf.LMS.Core.Service
{
    public interface ISharedDataService 
    {
        bool CreateSData(Shareddatum sharedData);
        List<Shareddatum> GetSData();
        bool UpdateSData(Shareddatum sharedData);
        bool DeleteSData(int id);
    }
}
