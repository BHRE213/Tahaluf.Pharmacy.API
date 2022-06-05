﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
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
        public List<Medicine> GetMedicne()
        {
            return medicneService.GetMedicne();
        }

        [HttpDelete]
        [Route("deleteMedicne")]
        public bool deleteMedicne(int medicineId)
        {
            return medicneService.deleteMedicne(medicineId);
        }
    }
}