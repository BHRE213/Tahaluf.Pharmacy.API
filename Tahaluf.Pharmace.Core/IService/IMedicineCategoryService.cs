using System;
using System.Collections.Generic;
using System.Text;
using Tahaluf.Pharmacy.API.Data;

namespace Tahaluf.Pharmace.Core.IService
{
    public interface IMedicineCategoryService
    {
        List<Medicinecategory> GetALLMedicineCategory();
        bool CreateMedicineCategory(Medicinecategory medicinecategory);
        bool DeleteMedicineCategory(int id);
    }
}
