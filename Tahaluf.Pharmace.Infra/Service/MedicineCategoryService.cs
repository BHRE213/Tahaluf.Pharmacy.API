using System;
using System.Collections.Generic;
using System.Text;
using Tahaluf.Pharmace.Core.IRepository;
using Tahaluf.Pharmace.Core.IService;
using Tahaluf.Pharmacy.API.Data;

namespace Tahaluf.Pharmace.Infra.Service
{
    public class MedicineCategoryService: IMedicineCategoryService
    {
        private readonly IMedicineCategoryRepository medicineCategoryRepository;
        public MedicineCategoryService (IMedicineCategoryRepository _medicineCategoryRepository)
        {
            this.medicineCategoryRepository = _medicineCategoryRepository;
        }

        public bool CreateMedicineCategory(Medicinecategory medicinecategory)
        {
            return medicineCategoryRepository.CreateMedicineCategory(medicinecategory);
        }

        public bool DeleteMedicineCategory(int id)
        {
            return medicineCategoryRepository.DeleteMedicineCategory(id);
        }

        public List<Medicinecategory> GetALLMedicineCategory()
        {
            return medicineCategoryRepository.GetALLMedicineCategory();
        }

        public bool UpdateMedicineCategory(Medicinecategory medicinecategory)
        {
            return medicineCategoryRepository.UpdateMedicineCategory(medicinecategory);
        }
    }
}
