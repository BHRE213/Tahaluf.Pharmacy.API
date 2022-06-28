using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using Tahaluf.Pharmace.Core.Data.DTO;
using Tahaluf.Pharmace.Core.IService;
using Tahaluf.Pharmacy.API.Data;

namespace Tahaluf.Pharmacy.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MedicineController : ControllerBase
    {

        public readonly IMedicineService medicneService;
        public MedicineController(IMedicineService _medicneService)
        {
            medicneService = _medicneService;
        }
        [HttpGet]
        [Route("GetMedicne")]
        public List<MedicineDTO> GetMedicne()
        {
            return medicneService.GetMedicne();
        }

        [HttpDelete]
        [Route("deleteMedicne/{medicineId}")]
        public bool deleteMedicne(int medicineId)
        {
            return medicneService.deleteMedicne(medicineId);
        }
        [HttpPost]
        [Route("CreateMedicen")]
        public bool CreateMedicen(Medicine medicine)
        {
            return medicneService.CreateMedicen(medicine);
        }
        [HttpPut]
        [Route("UpdateMedicen")]
        public bool UpdateMedicen(Medicine medicine)
        {
            return medicneService.UpdateMedicen(medicine);
        }
        [HttpPost]
        [Route("searchProduct")]
        public List<MedicineDTO> searchProduct(Medicine medicine)
        {
            return medicneService.searchProduct (medicine);
        }

        [HttpPost]
        [Route("Upload")]
        public Medicine Upload()
        {
            try
            {
                // Image -----> Request ----> Form
                var file = Request.Form.Files[0];
                // file.FileName
                var fileName = Guid.NewGuid().ToString() + "_" + file.FileName;
                // create folder "Images" in Tahaluf.LMS.API

                var fullPath = Path.Combine("E:\\tahaluf\\api\\projectFinal\\src\\assets\\image", fileName);

                var fullPath = Path.Combine("E:\\tahaluf\\api\\projectFinal\\src\\assets", fileName);

                // FileStream
                using (var stream = new FileStream(fullPath, FileMode.Create))
                {
                    file.CopyTo(stream);
                }
                // DataBase
                Medicine medicine = new Medicine();
                medicine.Imagepath = fileName;
                return medicine;
            }
            catch (Exception e)
            {
                return null;
            }
        }
    }
}