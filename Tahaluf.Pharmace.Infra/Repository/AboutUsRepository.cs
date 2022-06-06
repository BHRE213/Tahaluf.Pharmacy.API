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
   
    public class AboutUsRepository : IAboutUsRepository
    {
        private readonly IDbContext DbContext;
        public AboutUsRepository(IDbContext _DbContext)
        {
            DbContext = _DbContext;
        }

        public bool CreatePage(Abuotu aboutUs)
        {
            var d = new DynamicParameters();
            d.Add("@PTITLE", aboutUs.Title, dbType: DbType.String, direction: ParameterDirection.Input);
            d.Add("@PIMAGE", aboutUs.Image, dbType: DbType.String, direction: ParameterDirection.Input);
            d.Add("@TEXT", aboutUs.Txt, dbType: DbType.String, direction: ParameterDirection.Input);
            var result = DbContext.Connection.ExecuteAsync("AboutUs_Package.Createpage", d, commandType: CommandType.StoredProcedure);
            return true;
        }

        public List<Abuotu> GetPageInfo()
        {
            IEnumerable<Abuotu> result = DbContext.Connection.Query<Abuotu>("ABOUTUS_PACKAGE.GETPAGEINFO", commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        public bool DeletePage(int id)
        {
            var d = new DynamicParameters();
            d.Add("@ID", id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = DbContext.Connection.ExecuteAsync("ABOUTUS_PACKAGE.DELETEPAGE", d, commandType: CommandType.StoredProcedure);
            return true;
        }

        public bool UpdatePage(Abuotu aboutUs)
        {
            var d = new DynamicParameters();
            d.Add("@ID", aboutUs.Abuotusid, dbType: DbType.Int32, direction: ParameterDirection.Input);
            d.Add("@PTITLE", aboutUs.Title, dbType: DbType.String, direction: ParameterDirection.Input);
            d.Add("@PIMAGE", aboutUs.Image, dbType: DbType.String, direction: ParameterDirection.Input);
            d.Add("@TEXT", aboutUs.Txt, dbType: DbType.String, direction: ParameterDirection.Input);
            var result = DbContext.Connection.ExecuteAsync("ABOUTUS_PACKAGE.UPDATEPAGE", d, commandType: CommandType.StoredProcedure);
            return true;
        }



    }
}
