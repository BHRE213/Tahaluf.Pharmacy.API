using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
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

        [HttpPost]
        [Route("Upload")]
        public Medicinecategory Upload()
        {
            try
            {
                // Image -----> Request ----> Form
                var file = Request.Form.Files[0];
                // file.FileName
                var fileName = Guid.NewGuid().ToString() + "_" + file.FileName;
                // create folder "Images" in Tahaluf.LMS.API
                var fullPath = Path.Combine("E:\\tahaluf\\api\\projectFinal\\src\\assets", fileName);
                // FileStream
                using (var stream = new FileStream(fullPath, FileMode.Create))
                {
                    file.CopyTo(stream);
                }
                // DataBase
                Medicinecategory medicinecategory = new Medicinecategory();
                medicinecategory.Imagepath = fileName;
                return medicinecategory;
            }
            catch (Exception e)
            {
                return null;
            }
        }
    }
}
