using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
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
    }
}
