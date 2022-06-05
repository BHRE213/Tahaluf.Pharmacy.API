using System;
using System.Collections.Generic;
using System.Text;
using Tahaluf.Pharmacy.API.Data;

namespace Tahaluf.Pharmace.Core.IRepository
{
    public interface IMedicineCategory
    {
        List<Medicinecategory> GetALLMedicineCategory();
        
    }
}
