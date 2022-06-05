using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using Tahaluf.Pharmace.Core.Common;
using Tahaluf.Pharmace.Core.IRepository;
using Tahaluf.Pharmacy.API.Data;

namespace Tahaluf.Pharmace.Infra.Repository
{
    public class UserRepository: IUserRepository
    {
        private readonly IDbContext dBContext;
        public UserRepository(IDbContext _dBContext)
        {
            dBContext = _dBContext;
        }
        public List<Useraccount> GetALLUsers()
        {

       IEnumerable<Useraccount> result = dBContext.Connection.Query<Useraccount>("UsersInformationPackage.GetALLUsers", commandType: CommandType.StoredProcedure);
            return result.ToList();
        }
        public bool DeleteUser(int id)
        {
            var p = new DynamicParameters();
            p.Add("id", id, dbType: DbType.Int32);

            var result = dBContext.Connection.ExecuteAsync("UsersInformationPackage.deleteuser", p, commandType: CommandType.StoredProcedure);
            return true;
        }
    }
}
