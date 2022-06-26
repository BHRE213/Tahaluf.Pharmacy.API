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
    public class UserRepository: IUserRepository
    {
        private readonly IDbContext dBContext;
        public UserRepository(IDbContext _dBContext)
        {
            dBContext = _dBContext;
        }
        public List<Useraccount> GetALLUsers()
        {

       IEnumerable<Useraccount> result = dBContext.Connection.Query<Useraccount>("UserPackage.GetALLUsers", commandType: CommandType.StoredProcedure);
            return result.ToList();
        }
        public NumberOfUserWhoMadeOrdersDTO GetNumberOfUserWhoGetOrder()
        {

            IEnumerable<NumberOfUserWhoMadeOrdersDTO> result = dBContext.Connection.Query<NumberOfUserWhoMadeOrdersDTO>
                ("UserPackage.getNumberOfUserWhoMadeOrders",
                commandType: CommandType.StoredProcedure);
            return result.SingleOrDefault();
        }
        public bool DeleteUser(int id)
        {
            var p = new DynamicParameters();
            p.Add("id", id, dbType: DbType.Int32);

            var result = dBContext.Connection.ExecuteAsync("UserPackage.deleteuser", p, commandType: CommandType.StoredProcedure);
            return true;
        }
        public bool CreateUser(Useraccount useraccount)
        {
            var p = new DynamicParameters();
            p.Add("namee", useraccount.Fullname, dbType: DbType.String , direction: ParameterDirection.Input);
            p.Add("e", useraccount.Email, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("phone", useraccount.Phonenumber, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("pass", useraccount.Password, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("userr", useraccount.Username, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("r", 2, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("img", useraccount.Imagepath, dbType: DbType.String, direction: ParameterDirection.Input);
            var result = dBContext.Connection.ExecuteAsync("UserPackage.createUser", p, commandType: CommandType.StoredProcedure);
            return true;
        }

        public bool UpdateUser(Useraccount user)
        {
            var p = new DynamicParameters();
            p.Add("id", user.Useraccountid, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("namee", user.Fullname, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("img", user.Imagepath, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("phone", user.Phonenumber, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("pass", user.Password, dbType: DbType.String, direction: ParameterDirection.Input);
            var result = dBContext.Connection.ExecuteAsync("UserPackage.UpdateUser", p, commandType: CommandType.StoredProcedure);
            return true;
        }

        public Useraccount ViewProfile(int id)
        {
            var p = new DynamicParameters();
            p.Add("id", id, dbType: DbType.Int32);
            IEnumerable<Useraccount> result = dBContext.Connection.Query<Useraccount>("UserPackage.ViewProfile", p, commandType: CommandType.StoredProcedure);
            return result.SingleOrDefault();
        }
    }
}
