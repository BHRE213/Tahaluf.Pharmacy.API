using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using Tahaluf.LMS.Core.RepositoryInterface;
using Tahaluf.Pharmace.Core.Common;
using Tahaluf.Pharmacy.API.Data;

namespace Tahaluf.LMS.Infra.Repository
{
    public class ContactRepository : IContactRepository
    {
        private readonly IDbContext DbContext;
        public ContactRepository(IDbContext _DbContext)
        {
            DbContext = _DbContext;
        }
        public bool CreateContactUsForm(Contact contact)
        {
            var d = new DynamicParameters();
            d.Add("@CEMAIL", contact.Email, dbType: DbType.String, direction: ParameterDirection.Input);
            d.Add("@CTITLE", contact.Title, dbType: DbType.String, direction: ParameterDirection.Input);
            d.Add("@FEED", contact.Feedback, dbType: DbType.String, direction: ParameterDirection.Input);
            d.Add("@PHONE", contact.Phonenumber, dbType: DbType.String, direction: ParameterDirection.Input);
            var result = DbContext.Connection.ExecuteAsync("CONTACTUS_PACKAGE.CREATECONTACTUSFORM", d, commandType: CommandType.StoredProcedure);
            return true;
        }

        public bool DeleteContactUs(int id)
        {
            var d = new DynamicParameters();
            d.Add("@ID", id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = DbContext.Connection.ExecuteAsync("CONTACTUS_PACKAGE.DELETECONTACTUS", d, commandType: CommandType.StoredProcedure);
            return true;
        }

        public List<Contact> GetContactUsInfo()
        {
            IEnumerable<Contact> result =
            DbContext.Connection.Query<Contact>("CONTACTUS_PACKAGE.GETCONTACTUSINFO", commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        public bool UpdateContactUsInfo(Contact contact)
        {
            var d = new DynamicParameters();
            d.Add("@ID", contact.Contactid, dbType: DbType.Int32, direction: ParameterDirection.Input);
            d.Add("@CEMAIL", contact.Email, dbType: DbType.String, direction: ParameterDirection.Input);
            d.Add("@CTITLE", contact.Title, dbType: DbType.String, direction: ParameterDirection.Input);
            d.Add("@FEED", contact.Feedback, dbType: DbType.String, direction: ParameterDirection.Input);
            d.Add("@PHONE", contact.Phonenumber, dbType: DbType.String, direction: ParameterDirection.Input);
            var result = DbContext.Connection.ExecuteAsync("CONTACTUS_PACKAGE.UPDATCONTACTUSINFO", d, commandType: CommandType.StoredProcedure);
            return true;
        }




    }
}
