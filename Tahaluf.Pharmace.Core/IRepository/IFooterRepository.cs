using System;
using System.Collections.Generic;
using System.Text;
using Tahaluf.Pharmacy.API.Data;

namespace Tahaluf.LMS.Core.RepositoryInterface
{
    public interface IFooterRepository
    {
        bool CreateFooter(Footer footer);
        List<Footer> GetFooter();
        bool UpdateFooter(Footer footer);
        bool DeleteFooter(int id);
    }
}
