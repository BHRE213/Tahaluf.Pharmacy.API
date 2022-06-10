using System;
using System.Collections.Generic;
using System.Text;
using Tahaluf.Pharmace.Core.IRepository;
using Tahaluf.Pharmace.Core.IService;
using Tahaluf.Pharmacy.API.Data;

namespace Tahaluf.Pharmace.Infra.Service
{
    public class PharmacyBranchesService: IPharmacyBranchesService
    {
        readonly IPharmacyBranchesRepository pharmacyBranchesRepository;
        public PharmacyBranchesService(IPharmacyBranchesRepository _pharmacyBranchesRepository)
        {
            pharmacyBranchesRepository=_pharmacyBranchesRepository;
        }

        public bool createPharmacyBranches(Pharmacybranch pharmacybranch)
        {
            return pharmacyBranchesRepository.createPharmacyBranches(pharmacybranch);
        }

        public bool deletePharmacyBranches(int pharmacybranchID)
        {
            return pharmacyBranchesRepository.deletePharmacyBranches(pharmacybranchID);
        }

        public List<Pharmacybranch> GetALLPharmacyBranches()
        {
            return pharmacyBranchesRepository.GetALLPharmacyBranches();
        }

        public bool updatePharmacyBranches(Pharmacybranch pharmacybranch)
        {
            return pharmacyBranchesRepository.updatePharmacyBranches(pharmacybranch);

        }
    }
}
