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
    
    public class SiteDataRepository : ISiteDataRepository
    {
        private readonly IDbContext DbContext;
        public SiteDataRepository(IDbContext _DbContext)
        {
            DbContext = _DbContext;
        }

        public bool CreateSiteData(Sitedatum siteData)
        {
            var d = new DynamicParameters();
            d.Add("@SIMAGE", siteData.Title, dbType: DbType.String, direction: ParameterDirection.Input);
            d.Add("@STITLE", siteData.Image, dbType: DbType.String, direction: ParameterDirection.Input);
            d.Add("@TEXT", siteData.Txt, dbType: DbType.String, direction: ParameterDirection.Input);
            var result = DbContext.Connection.ExecuteAsync("SITEDATA_PACKAGE.CREATSITEDATA", d, commandType: CommandType.StoredProcedure);
            return true;
        }
        public List<Sitedatum> GetSiteData()
        {
            IEnumerable<Sitedatum> result = DbContext.Connection.Query<Sitedatum>("SITEDATA_PACKAGE.GETSITEDATA", commandType: CommandType.StoredProcedure);
            return result.ToList();
        }
       public bool UpdateSiteData(Sitedatum siteData)
        {
            var d = new DynamicParameters();
            d.Add("@ID", siteData.Sitedataid, dbType: DbType.Int32, direction: ParameterDirection.Input);
            d.Add("@SIMAGE", siteData.Title, dbType: DbType.String, direction: ParameterDirection.Input);
            d.Add("@STITLE", siteData.Image, dbType: DbType.String, direction: ParameterDirection.Input);
            d.Add("@TEXT", siteData.Txt, dbType: DbType.String, direction: ParameterDirection.Input);
            var result = DbContext.Connection.ExecuteAsync("SITEDATA_PACKAGE.UPDATESITEDATA", d, commandType: CommandType.StoredProcedure);
            return true;
        }
        public bool DeleteSiteData(int id)
        {
            var d = new DynamicParameters();
            d.Add("@ID", id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = DbContext.Connection.ExecuteAsync("SITEDATA_PACKAGE.DELETESITEDATA", d, commandType: CommandType.StoredProcedure);
            return true;
        }

    }
}
