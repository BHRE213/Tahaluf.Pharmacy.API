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
    public class PharmacyBranchesRepository : IPharmacyBranchesRepository
    {
        public readonly IDbContext dbContext;
        public PharmacyBranchesRepository(IDbContext _dbContext)
        {
            dbContext = _dbContext;
        }

        public bool createPharmacyBranches(Pharmacybranch pharmacybranch)
        {
            var p = new DynamicParameters();
            p.Add("namee", pharmacybranch.Name, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("t", pharmacybranch.Text, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("ph", pharmacybranch.Phone, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("x", pharmacybranch.X, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("y", pharmacybranch.Y, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("openDate", pharmacybranch.Open, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("closeDate", pharmacybranch.Close, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("img", pharmacybranch.Image, dbType: DbType.String, direction: ParameterDirection.Input);



            var result = dbContext.Connection.ExecuteAsync("PharmacyBranchesPackage.createPharmacyBranches", p, commandType: CommandType.StoredProcedure);
            return true;

        }

        public bool deletePharmacyBranches(int pharmacybranchID)
        {

            var p = new DynamicParameters();
            p.Add("id", pharmacybranchID, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = dbContext.Connection.ExecuteAsync("PharmacyBranchesPackage.deletePharmacyBranches", p, commandType: CommandType.StoredProcedure);
            return true;
        }

        public List<Pharmacybranch> GetALLPharmacyBranches()
        {
            IEnumerable<Pharmacybranch> result = dbContext.Connection.Query<Pharmacybranch>("PharmacyBranchesPackage.GetALLPharmacyBranches", commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        public bool updatePharmacyBranches(Pharmacybranch pharmacybranch)
        {
            var p = new DynamicParameters();
            p.Add("id", pharmacybranch.Pharmacybranchesid, dbType: DbType.Int32, direction: ParameterDirection.Input);

            p.Add("namee", pharmacybranch.Name, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("t", pharmacybranch.Text, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("ph", pharmacybranch.Phone, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("xx", pharmacybranch.X, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("yy", pharmacybranch.Y, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("openDate", pharmacybranch.Open, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("closeDate", pharmacybranch.Close, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("img", pharmacybranch.Image, dbType: DbType.String, direction: ParameterDirection.Input);



            var result = dbContext.Connection.ExecuteAsync("PharmacyBranchesPackage.updatePharmacyBranches", p, commandType: CommandType.StoredProcedure);
            return true;
        }


        public List<Pharmacybranch> GetPharmacyByName(Pharmacybranch pharmacybranch)
        {
            var p = new DynamicParameters();
            p.Add("n", pharmacybranch.Name, dbType: DbType.String, direction: ParameterDirection.Input);
            IEnumerable<Pharmacybranch> result = dbContext.Connection.Query<Pharmacybranch>("getPharmacyByName",p, commandType: CommandType.StoredProcedure);
            return result.ToList();
        }
    }
}
