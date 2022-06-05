using System;
using System.Collections.Generic;
using System.Text;
using Tahaluf.Pharmacy.API.Data;

namespace Tahaluf.Pharmace.Core.IRepository
{
    public interface IMedicineCategoryRepository
    {
        List<Medicinecategory> GetALLMedicineCategory();
        bool CreateMedicineCategory(Medicinecategory medicinecategory);
        bool DeleteMedicineCategory(int id);
    }
}
