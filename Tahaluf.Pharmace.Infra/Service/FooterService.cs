using System;
using System.Collections.Generic;
using System.Text;
using Tahaluf.LMS.Core.RepositoryInterface;
using Tahaluf.LMS.Core.Service;
using Tahaluf.Pharmacy.API.Data;

namespace Tahaluf.LMS.Infra.Service
{
     
    public class FooterService : IFooterService
    {
        public readonly IFooterRepository footerRepository;
        public FooterService(IFooterRepository _footerRepository)
        {
            footerRepository = _footerRepository;
        }

        public bool CreateFooter(Footer footer)
        {
            return footerRepository.CreateFooter(footer);
        }
        public List<Footer> GetFooter()
        {
            return footerRepository.GetFooter();
        }
        public bool UpdateFooter(Footer footer)
        {
            return footerRepository.UpdateFooter(footer);
        }
        public bool DeleteFooter(int id)
        {
            return footerRepository.DeleteFooter(id);
        }
    
}

}
