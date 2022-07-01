using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using Tahaluf.LMS.Core.RepositoryInterface;
using Tahaluf.Pharmace.Core.Common;
using Tahaluf.Pharmace.Core.Data.DTO;
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
            d.Add("@n", testemonial.name, dbType: DbType.String, direction: ParameterDirection.Input);
            d.Add("@TESTSTATUSID", 1, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = DbContext.Connection.ExecuteAsync("TESTIMONAIL_PACKAGE.CREATETEST", d, commandType: CommandType.StoredProcedure);
            return true;
        }
        public List<TestDTO> GetTest()
        {
            IEnumerable<TestDTO> result = DbContext.Connection.Query<TestDTO>("TESTIMONAIL_PACKAGE.GETTEST", commandType: CommandType.StoredProcedure);
            return result.ToList();
        }
        public List<TestDTO> GetAccTest()
        {
            IEnumerable<TestDTO> result = DbContext.Connection.Query<TestDTO>("TESTIMONAIL_PACKAGE.GetAccTest", commandType: CommandType.StoredProcedure);
            return result.ToList();
        }
        public bool DeleteTest(int id)
        {
            var d = new DynamicParameters();
            d.Add("@ID", id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = DbContext.Connection.ExecuteAsync("TESTIMONAIL_PACKAGE.DELETETEST", d, commandType: CommandType.StoredProcedure);
            return true;
        }

        public bool UpdateTestById(TestUpdateDyIdDTO  testUpdateDyIdDTO)
        {
            var d = new DynamicParameters();
            d.Add("testid", testUpdateDyIdDTO.Testimonialid, dbType: DbType.Int32, direction: ParameterDirection.Input);
            d.Add("StatId", testUpdateDyIdDTO.Teststatid, dbType: DbType.Int32, direction: ParameterDirection.Input);

            var result = DbContext.Connection.ExecuteAsync("testUpdateById", d, commandType: CommandType.StoredProcedure);
            return true;
        }
    }
}
