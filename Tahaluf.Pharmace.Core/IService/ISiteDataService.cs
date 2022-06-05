﻿using System;
using System.Collections.Generic;
using System.Text;
using Tahaluf.Pharmacy.API.Data;

namespace Tahaluf.LMS.Core.Service
{
    public interface ISiteDataService
    {
        bool CreateSiteData(Sitedatum siteData);
        List<Sitedatum> GetSiteData();
        bool UpdateSiteData(Sitedatum siteData);
        bool DeleteSiteData(int id);
    }
}
