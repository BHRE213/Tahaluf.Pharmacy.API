using System;
using System.Collections.Generic;
using System.Text;
using Tahaluf.Pharmacy.API.Data;

namespace Tahaluf.Pharmace.Core.IRepository
{
    public interface IPharmacyBranchesRepository
    {
        List<Pharmacybranch> GetALLPharmacyBranches();
        bool createPharmacyBranches(Pharmacybranch pharmacybranch);
        bool updatePharmacyBranches(Pharmacybranch pharmacybranch);
        bool deletePharmacyBranches(int pharmacybranchID);
        List<Pharmacybranch>  GetPharmacyByName(Pharmacybranch pharmacybranch);
    }
}
