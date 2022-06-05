using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Tahaluf.Pharmace.Core.IService;
using Tahaluf.Pharmacy.API.Data;

namespace Tahaluf.Pharmacy.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MedicineCategoryController : ControllerBase
    {
        private readonly IMedicineCategoryService medicineCategoryService;
        public MedicineCategoryController(IMedicineCategoryService _medicineCategoryService)
        {
            this.medicineCategoryService = _medicineCategoryService;
        }
        [HttpGet]
        public List<Medicinecategory> GetALLMedicineCategory()
        {
            return medicineCategoryService.GetALLMedicineCategory();
        }
        [HttpPost]
        [Route("CreateMedicineCategory")]
        public bool CreateMedicineCategory(Medicinecategory medicinecategory)
        {
            return medicineCategoryService.CreateMedicineCategory(medicinecategory);
        }
        [HttpDelete]
        [Route("DeleteMedicineCategory/{id}")]
        public bool DeleteMedicineCategory(int id)
        {
            return medicineCategoryService.DeleteMedicineCategory(id);
        }
    }
}
