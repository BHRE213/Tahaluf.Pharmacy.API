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
    public class MedicineRepository: IMedicineRepository
    {
        public readonly IDbContext dbContext;
        public MedicineRepository(IDbContext _dbContext)
        {
            dbContext = _dbContext;
        }
        public List<Medicine> GetMedicne()
        {
            IEnumerable<Medicine> result = dbContext.Connection.Query<Medicine>("MedicnePackage.GetMedicne", commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        public bool deleteMedicne(int medicineId)
        {

            var p = new DynamicParameters();
            p.Add("id", medicineId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = dbContext.Connection.ExecuteAsync("MedicnePackage.deleteMedicne", p, commandType: CommandType.StoredProcedure);
            return true;

        }

        public bool CreateMedicen(Medicine medicine)
        {
            var p = new DynamicParameters();
            p.Add("MName", medicine.Name, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("MN", medicine.Medicinenumber, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("C", medicine.Cost, dbType: DbType.Double, direction: ParameterDirection.Input);
            p.Add("P", medicine.Price, dbType: DbType.Double, direction: ParameterDirection.Input);
            p.Add("DES", medicine.Description, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("MCid", medicine.MedicineCategoryId, dbType: DbType.Int32, direction: ParameterDirection.Input);

            var result = dbContext.Connection.ExecuteAsync("MedicnePackage.CreateMedicen", p, commandType: CommandType.StoredProcedure);
            return true;
        }

        public bool UpdateMedicen(Medicine medicine)
        {
            var p = new DynamicParameters();
            p.Add("Id", medicine.Medicineid, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("MName", medicine.Name, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("MN", medicine.Medicinenumber, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("C", medicine.Cost, dbType: DbType.Double, direction: ParameterDirection.Input);
            p.Add("P", medicine.Price, dbType: DbType.Double, direction: ParameterDirection.Input);
            p.Add("DES", medicine.Description, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("MCid", medicine.MedicineCategoryId, dbType: DbType.Int32, direction: ParameterDirection.Input);

            var result = dbContext.Connection.ExecuteAsync("MedicnePackage.UpdateMedicen", p, commandType: CommandType.StoredProcedure);
            return true;
        }
    }

}
