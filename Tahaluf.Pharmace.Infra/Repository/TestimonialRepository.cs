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
    
    public class TestimonialRepository : ITestemonialRepository
    {
        private readonly IDbContext DbContext;
        public TestimonialRepository(IDbContext _DbContext)
        {
            DbContext = _DbContext;
        }

        public bool CreateTest(Testimonial testemonial)
        {
            var d = new DynamicParameters();
            d.Add("@TIMAGE", testemonial.Image, dbType: DbType.String, direction: ParameterDirection.Input);
            d.Add("@TEXT", testemonial.Txt, dbType: DbType.String, direction: ParameterDirection.Input);
            d.Add("@TTITLE", testemonial.Title, dbType: DbType.String, direction: ParameterDirection.Input);
            d.Add("@TESTSTATUSID", testemonial.Teststatid, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = DbContext.Connection.ExecuteAsync("TESTIMONAIL_PACKAGE.CREATETEST", d, commandType: CommandType.StoredProcedure);
            return true;
        }
        public List<Testimonial> GetTest()
        {
            IEnumerable<Testimonial> result =
            DbContext.Connection.Query<Testimonial>("TESTIMONAIL_PACKAGE.GETTEST", commandType: CommandType.StoredProcedure);
            return result.ToList();
        }
        public bool UpdateTest(Testimonial testemonial)
        {
            var d = new DynamicParameters();
            d.Add("@ID", testemonial.Testimonialid, dbType: DbType.Int32, direction: ParameterDirection.Input);
            d.Add("@TIMAGE", testemonial.Image, dbType: DbType.String, direction: ParameterDirection.Input);
            d.Add("@TEXT", testemonial.Txt, dbType: DbType.String, direction: ParameterDirection.Input);
            d.Add("@TTITLE", testemonial.Title, dbType: DbType.String, direction: ParameterDirection.Input);
            d.Add("@TESTSTATUSID", testemonial.Teststatid, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = DbContext.Connection.ExecuteAsync("TESTIMONAIL_PACKAGE.UPDATETEST", d, commandType: CommandType.StoredProcedure);
            return true;
        }
        public bool DeleteTest(int id)
        {
            var d = new DynamicParameters();
            d.Add("@ID", id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = DbContext.Connection.ExecuteAsync("TESTIMONAIL_PACKAGE.DELETETEST", d, commandType: CommandType.StoredProcedure);
            return true;
        }
    }
}
