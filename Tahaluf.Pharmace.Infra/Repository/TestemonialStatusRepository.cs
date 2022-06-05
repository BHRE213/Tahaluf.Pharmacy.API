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
    public class TestemonialStatusRepository : ITestemonialStatusRepository
    {
        private readonly IDbContext DbContext;
        public TestemonialStatusRepository(IDbContext _DbContext)
        {
            DbContext = _DbContext;
        }

        public bool CreateTestStatus(Testimonialstatus testemonialStatus)
        {
            var d = new DynamicParameters();
            d.Add("@TSTATUS", testemonialStatus.Status, dbType: DbType.String, direction: ParameterDirection.Input);
            var result = DbContext.Connection.ExecuteAsync("TESTIMONIALSTATUS_PACKAGE.CREATETESTSTATUS", d, commandType: CommandType.StoredProcedure);
            return true;
        }
        public List<Testimonialstatus> GetTestStatus()
        {
            IEnumerable<Testimonialstatus> result = DbContext.Connection.Query<Testimonialstatus>("TESTIMONIALSTATUS_PACKAGE.GETTESTSTATUS", commandType: CommandType.StoredProcedure);
            return result.ToList();
        }
        public bool UpdateTestStatus(Testimonialstatus testemonialStatus)
        {
            var d = new DynamicParameters();
            d.Add("@ID", testemonialStatus.Teststatid, dbType: DbType.Int32, direction: ParameterDirection.Input);
            d.Add("@TSTATUS", testemonialStatus.Status, dbType: DbType.String, direction: ParameterDirection.Input);
            var result = DbContext.Connection.ExecuteAsync("TESTIMONIALSTATUS_PACKAGE.UPDATETESTSTATUS", d, commandType: CommandType.StoredProcedure);
            return true;
        }
        public bool DeleteTestStatus(int id)
        {
            var d = new DynamicParameters();
            d.Add("@ID", id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = DbContext.Connection.ExecuteAsync("TESTIMONIALSTATUS_PACKAGE.DELETETESTSTATUS", d, commandType: CommandType.StoredProcedure);
            return true;
        }
    
}
}
