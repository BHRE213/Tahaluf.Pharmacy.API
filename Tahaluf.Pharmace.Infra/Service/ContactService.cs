using System;
using System.Collections.Generic;
using System.Text;
using Tahaluf.LMS.Core.RepositoryInterface;
using Tahaluf.LMS.Core.Service;
using Tahaluf.Pharmacy.API.Data;

namespace Tahaluf.LMS.Infra.Service
{
    
    public class ContactService : IContactService
    {
        public readonly IContactRepository contactRepository;
        public ContactService(IContactRepository _contactRepository)
        {
            contactRepository = _contactRepository;
        }

        public bool CreateContactUsForm(Contact contact)
        {
            return contactRepository.CreateContactUsForm(contact);
        }
        public bool DeleteContactUs(int id)
        {
            return contactRepository.DeleteContactUs(id);
        }
        public List<Contact> GetContactUsInfo()
        {
            return contactRepository.GetContactUsInfo();
        }
       public bool UpdateContactUsInfo(Contact contact)
        {
            return contactRepository.UpdateContactUsInfo(contact);
        }
    }
}
