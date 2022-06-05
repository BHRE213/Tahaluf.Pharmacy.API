using System;
using System.Collections.Generic;
using System.Text;
using Tahaluf.Pharmacy.API.Data;

namespace Tahaluf.LMS.Core.RepositoryInterface
{
    public interface IContactRepository
    {
        bool CreateContactUsForm(Contact contact);
        bool DeleteContactUs(int id);
        List<Contact> GetContactUsInfo();
        bool UpdateContactUsInfo(Contact contact);

    }
}
