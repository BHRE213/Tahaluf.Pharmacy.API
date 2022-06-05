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
    
    public class FooterRepository : IFooterRepository
    {
        private readonly IDbContext DbContext;
        public FooterRepository(IDbContext _DbContext)
        { 
            DbContext = _DbContext;
        }

        public bool CreateFooter(Footer footer)
        {
            var d = new DynamicParameters();
            d.Add("@PABOUT", footer.About, dbType: DbType.String, direction: ParameterDirection.Input);
            d.Add("@PLOCATION", footer.Location, dbType: DbType.String, direction: ParameterDirection.Input);
            d.Add("@PEMAIL", footer.Email, dbType: DbType.String, direction: ParameterDirection.Input);
            d.Add("@PHONE", footer.Phonenumber, dbType: DbType.String, direction: ParameterDirection.Input);
            var result = DbContext.Connection.ExecuteAsync("FOOTER_PACKAGE.CREATEFOOTER", d, commandType: CommandType.StoredProcedure);
            return true;
        }
        public List<Footer> GetFooter()
        {
            IEnumerable<Footer> result = DbContext.Connection.Query<Footer>("FOOTER_PACKAGE.GETFOOTER", commandType: CommandType.StoredProcedure);
            return result.ToList();
        }
        public bool UpdateFooter(Footer footer)
        {
            var d = new DynamicParameters();
            d.Add("@ID", footer.Footerid, dbType: DbType.Int32, direction: ParameterDirection.Input);
            d.Add("@PABOUT", footer.About, dbType: DbType.String, direction: ParameterDirection.Input);
            d.Add("@PLOCATION", footer.Location, dbType: DbType.String, direction: ParameterDirection.Input);
            d.Add("@PEMAIL", footer.Email, dbType: DbType.String, direction: ParameterDirection.Input);
            d.Add("@PHONE", footer.Phonenumber, dbType: DbType.String, direction: ParameterDirection.Input);
            var result = DbContext.Connection.ExecuteAsync("FOOTER_PACKAGE.UPDATFOOTER", d, commandType: CommandType.StoredProcedure);
            return true;
        }
        public bool DeleteFooter(int id)
        {
            var d = new DynamicParameters();
            d.Add("@ID", id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = DbContext.Connection.ExecuteAsync("FOOTER_PACKAGE.DELETEFOOTER", d, commandType: CommandType.StoredProcedure);
            return true;
        }
    }
}
