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
    public class MedicineCategoryRepository : IMedicineCategoryRepository
    {
        private readonly IDbContext dbContext;
        public MedicineCategoryRepository(IDbContext _dbContext)
        {
            dbContext = _dbContext;
        }
        public bool CreateMedicineCategory(Medicinecategory medicinecategory)
        {
            var p = new DynamicParameters();
            p.Add("T", medicinecategory.Type, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("I", medicinecategory.Imagepath, dbType: DbType.String, direction: ParameterDirection.Input);
            var result = dbContext.Connection.ExecuteAsync("MedicineCategoryPackage.CreateMedicineCategory", p, commandType: CommandType.StoredProcedure);
            return true;
        }
        public bool UpdateMedicineCategory(Medicinecategory medicinecategory)
        {
            var p = new DynamicParameters();
            p.Add("Id", medicinecategory.Medicinecategoryid, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("T", medicinecategory.Type, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("I", medicinecategory.Imagepath, dbType: DbType.String, direction: ParameterDirection.Input);
            var result = dbContext.Connection.ExecuteAsync("MedicineCategoryPackage.UpdateMedicineCategory", p, commandType: CommandType.StoredProcedure);
            return true;
        }

        public bool DeleteMedicineCategory(int id)
        {
            var p = new DynamicParameters();
            p.Add("id", id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = dbContext.Connection.ExecuteAsync("MedicineCategoryPackage.DeleteMedicineCategory", p, commandType: CommandType.StoredProcedure);
            return true;
        }

        public List<Medicinecategory> GetALLMedicineCategory()
        {
            IEnumerable<Medicinecategory> result = dbContext.Connection.Query<Medicinecategory>("MedicineCategoryPackage.GetALLMedicineCategory", commandType: CommandType.StoredProcedure);
            return result.ToList();
        }
    }
}
