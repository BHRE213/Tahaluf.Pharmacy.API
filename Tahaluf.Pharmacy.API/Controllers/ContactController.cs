using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Tahaluf.LMS.Core.Service;
using Tahaluf.Pharmacy.API.Data;

namespace Tahaluf.LMS.API.Controllers
{
    
    [Route("api/[controller]")]
    [ApiController]
    public class ContactController : ControllerBase
    {
        private readonly IContactService contactService;
        public ContactController(IContactService _contactService)
        {
            contactService = _contactService;
        }


        [HttpPost]
       public bool CreateContactUsForm(Contact contact)
        {
            return contactService.CreateContactUsForm(contact);
        }


        [HttpDelete]
        [Route("DeleteContactUs/{id}")]
        public bool DeleteContactUs(int id)
        {
            return contactService.DeleteContactUs(id);
        }

        [HttpGet]
        public List<Contact> GetContactUsInfo()
        {
            return contactService.GetContactUsInfo();
        }

        [HttpPut]
        public bool UpdateContactUsInfo(Contact contact)
        {
            return contactService.UpdateContactUsInfo(contact);
        }
    }
}
