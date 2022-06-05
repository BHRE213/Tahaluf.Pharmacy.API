using System;
using System.Collections.Generic;
using System.Text;
using Tahaluf.Pharmace.Core.IRepository;
using Tahaluf.Pharmace.Core.IService;
using Tahaluf.Pharmacy.API.Data;

namespace Tahaluf.Pharmace.Infra.Service
{
    public class MedicineService : IMedicineService
    {
        public readonly IMedicineRepository medicineRepository;
        public MedicineService(IMedicineRepository _medicineRepository)
        {
            medicineRepository = _medicineRepository;
        }
        public List<Medicine> GetMedicne()
        {
            return medicineRepository.GetMedicne();
        }
        public bool deleteMedicne(int medicineId)
        {
            return medicineRepository.deleteMedicne(medicineId);
        }
        //public bool CreateMedicen(Medicine medicine)
        //{
        //    throw new NotImplementedException();

        //}

        //public bool UpdateMedicen(Medicine medicine)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
