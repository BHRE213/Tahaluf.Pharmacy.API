using System;
using System.Collections.Generic;
using System.Text;
using Tahaluf.Pharmacy.API.Data;

namespace Tahaluf.Pharmace.Core.IService
{
    public interface IPharmacyBranchesService
    {

        List<Pharmacybranch> GetALLPharmacyBranches();
        bool createPharmacyBranches(Pharmacybranch pharmacybranch);
        bool updatePharmacyBranches(Pharmacybranch pharmacybranch);
        bool deletePharmacyBranches(int pharmacybranchID);
    }
}
