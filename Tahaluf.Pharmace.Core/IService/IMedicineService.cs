using System;
using System.Collections.Generic;
using System.Text;
using Tahaluf.Pharmace.Core.Data.DTO;
using Tahaluf.Pharmacy.API.Data;

namespace Tahaluf.Pharmace.Core.IService
{
   public interface IMedicineService
    {
        List<MedicineDTO> GetMedicne();
        bool CreateMedicen(Medicine medicine);
        bool UpdateMedicen(Medicine medicine);
        bool deleteMedicne(int medicineId);
        List<MedicineDTO> searchProduct(Medicine medicine);
    }
}
