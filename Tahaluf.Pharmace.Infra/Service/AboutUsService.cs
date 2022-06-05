using System;
using System.Collections.Generic;
using System.Text;
using Tahaluf.LMS.Core.RepositoryInterface;
using Tahaluf.LMS.Core.Service;
using Tahaluf.Pharmacy.API.Data;

namespace Tahaluf.LMS.Infra.Service
{
    
    public class AboutUsService : IAboutUsService
    {
        public readonly IAboutUsRepository aboutUsRepository;
        public AboutUsService(IAboutUsRepository _aboutUsRepository)
        {
            aboutUsRepository = _aboutUsRepository;
        }

        public bool CreatePage(Abuotu aboutUs)
        {
            return aboutUsRepository.CreatePage(aboutUs);
        }

        public List<Abuotu> GetPageInfo()
        {
            return aboutUsRepository.GetPageInfo();
        }


        public bool DeletePage(int id)
        {
            return aboutUsRepository.DeletePage(id);
        }

        public bool UpdatePage(Abuotu aboutUs)
        {
            return aboutUsRepository.UpdatePage(aboutUs);
        }
    }
}
