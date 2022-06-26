using System;
using System.Collections.Generic;
using System.Text;
using Tahaluf.Pharmace.Core.Data.DTO;
using Tahaluf.Pharmacy.API.Data;

namespace Tahaluf.Pharmace.Core.IRepository
{
    public interface IMedicineRepository
    {
        List<MedicineDTO> GetMedicne();
        bool CreateMedicen(Medicine medicine);
        bool UpdateMedicen(Medicine medicine);
        bool deleteMedicne(int medicineId);
        List<MedicineDTO> searchProduct(Medicine medicine);
    }
}
