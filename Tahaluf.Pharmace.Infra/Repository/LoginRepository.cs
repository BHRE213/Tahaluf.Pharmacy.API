using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using Tahaluf.Pharmace.Core.Common;
using Tahaluf.Pharmace.Core.Data.DTO;
using Tahaluf.Pharmace.Core.IRepository;
using Tahaluf.Pharmacy.API.Data;

namespace Tahaluf.Pharmace.Infra.Repository
{
    public class LoginRepository : ILoginRepository
    {
        private readonly IDbContext dBContext;
        public LoginRepository(IDbContext _dBContext)
        {
            dBContext = _dBContext;
        }
        public DTOLogin userlogin(Useraccount login)
        {
            var p = new DynamicParameters();
            p.Add("@e", login.Email, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@Pass", login.Password, dbType: DbType.String, direction: ParameterDirection.Input);
            IEnumerable<DTOLogin> result = dBContext.Connection.Query<DTOLogin>("LOGINPackage.userlogin", p, commandType: CommandType.StoredProcedure);
            return result.FirstOrDefault();
        }
    }
}
