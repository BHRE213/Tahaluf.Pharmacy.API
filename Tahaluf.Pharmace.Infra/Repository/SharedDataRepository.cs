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
    
    public class SharedDataRepository : ISharedDataRepository
    {
        private readonly IDbContext DbContext;
        public SharedDataRepository(IDbContext _DbContext)
        {
            DbContext = _DbContext;
        }

        public bool CreateSData(Shareddatum sharedData)
        {
            var d = new DynamicParameters();
            d.Add("@SIMAGE", sharedData.Title, dbType: DbType.String, direction: ParameterDirection.Input);
            d.Add("@STITLE", sharedData.Image, dbType: DbType.String, direction: ParameterDirection.Input);
            d.Add("@TEXT", sharedData.Txt, dbType: DbType.String, direction: ParameterDirection.Input);
            var result = DbContext.Connection.ExecuteAsync("SHAREDDATA_PACKAGE.CREATESDATA", d, commandType: CommandType.StoredProcedure);
            return true;
        }
        public List<Shareddatum> GetSData()
        {
            IEnumerable<Shareddatum> result = DbContext.Connection.Query<Shareddatum>("SHAREDDATA_PACKAGE.GETSDATA", commandType: CommandType.StoredProcedure);
            return result.ToList();
        }
        public bool UpdateSData(Shareddatum sharedData)
        {
            var d = new DynamicParameters();
            d.Add("@ID", sharedData.Shareddataid, dbType: DbType.Int32, direction: ParameterDirection.Input);
            d.Add("@SIMAGE", sharedData.Title, dbType: DbType.String, direction: ParameterDirection.Input);
            d.Add("@STITLE", sharedData.Image, dbType: DbType.String, direction: ParameterDirection.Input);
            d.Add("@TEXT", sharedData.Txt, dbType: DbType.String, direction: ParameterDirection.Input);
            var result = DbContext.Connection.ExecuteAsync("SHAREDDATA_PACKAGE.UPDATESDATA", d, commandType: CommandType.StoredProcedure);
            return true;
        }
        public bool DeleteSData(int id)
        {
            var d = new DynamicParameters();
            d.Add("@ID", id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = DbContext.Connection.ExecuteAsync("SHAREDDATA_PACKAGE.DELETESDATA", d, commandType: CommandType.StoredProcedure);
            return true;
        }
    }
}
