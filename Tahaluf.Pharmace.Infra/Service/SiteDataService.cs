using System;
using System.Collections.Generic;
using System.Text;
using Tahaluf.LMS.Core.RepositoryInterface;
using Tahaluf.LMS.Core.Service;
using Tahaluf.Pharmacy.API.Data;

namespace Tahaluf.LMS.Infra.Service
{
    public class SiteDataService : ISiteDataService
    {
        public readonly ISiteDataRepository siteDataRepository;
        public SiteDataService(ISiteDataRepository _siteDataRepository)
        {
            siteDataRepository = _siteDataRepository;
        }

        public bool CreateSiteData(Sitedatum siteData)
        {
            return siteDataRepository.CreateSiteData(siteData);
        }
        public List<Sitedatum> GetSiteData()
        {
            return siteDataRepository.GetSiteData();
        }
        public bool UpdateSiteData(Sitedatum siteData)
        {
            return siteDataRepository.UpdateSiteData(siteData);
        }
        public bool DeleteSiteData(int id)
        {
            return siteDataRepository.DeleteSiteData(id);
        }
    }
}
