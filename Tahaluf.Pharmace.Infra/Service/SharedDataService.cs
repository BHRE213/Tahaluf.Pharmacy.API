using System;
using System.Collections.Generic;
using System.Text;
using Tahaluf.LMS.Core.RepositoryInterface;
using Tahaluf.LMS.Core.Service;
using Tahaluf.Pharmacy.API.Data;

namespace Tahaluf.LMS.Infra.Service
{
    public class SharedDataService : ISharedDataService
    {
        public readonly ISharedDataRepository sharedDataRepository;
        public SharedDataService(ISharedDataRepository _sharedDataRepository)
        {
            sharedDataRepository = _sharedDataRepository;
        }

        public bool CreateSData(Shareddatum sharedData)
        {
            return sharedDataRepository.CreateSData(sharedData);
        }
        public List<Shareddatum> GetSData()
        {
            return sharedDataRepository.GetSData();
        }
        public bool UpdateSData(Shareddatum sharedData)
        {
            return sharedDataRepository.UpdateSData(sharedData);
        }
        public bool DeleteSData(int id)
        {
            return sharedDataRepository.DeleteSData(id);
        }
    }
}
