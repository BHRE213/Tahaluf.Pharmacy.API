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
    public class PharmacyBranchesController : ControllerBase
    {
        readonly IPharmacyBranchesService pharmacyBranchesService;
        public PharmacyBranchesController(IPharmacyBranchesService _pharmacyBranchesService)
        {
            pharmacyBranchesService=_pharmacyBranchesService;
        }

        [HttpGet]
        [Route("GetALLPharmacyBranches")]

        public List<Pharmacybranch> GetALLPharmacyBranches()
        {
            return pharmacyBranchesService.GetALLPharmacyBranches();
        }

        [HttpPost]
        [Route("createPharmacyBranches")]
        public bool createPharmacyBranches(Pharmacybranch pharmacybranch)
        {
            return pharmacyBranchesService.createPharmacyBranches(pharmacybranch);

        }

        [HttpPut]
        [Route("updatePharmacyBranches")]
        public bool updatePharmacyBranches(Pharmacybranch pharmacybranch)
        {
            return pharmacyBranchesService.updatePharmacyBranches(pharmacybranch);

        }


        [HttpDelete]
        [Route("deletePharmacyBranches/{pharmacybranchID}")]
        public bool deletePharmacyBranches(int pharmacybranchID)
        {
            return pharmacyBranchesService.deletePharmacyBranches(pharmacybranchID);
        }
        [HttpPost]
        [Route("Upload")]
        public Pharmacybranch Upload()
        {
            try
            {
                // Image -----> Request ----> Form
                var file = Request.Form.Files[0];
                // file.FileName
                var fileName = Guid.NewGuid().ToString() + "_" + file.FileName;
                // create folder "Images" in Tahaluf.LMS.API
                var fullPath = Path.Combine("E:\\tahaluf\\api\\projectFinal\\src\\assets\\image", fileName);
                // FileStream 
                using (var stream = new FileStream(fullPath, FileMode.Create))
                {
                    file.CopyTo(stream);
                }
                // DataBase
                Pharmacybranch  pharmacybranch = new Pharmacybranch();
                pharmacybranch.Image = fileName;
                return pharmacybranch;
            }
            catch (Exception e)
            {
                return null;
            }
        }
    }
}
