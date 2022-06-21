using System;
using System.Collections.Generic;
using System.Text;
using Tahaluf.Pharmace.Core.Data.DTO;
using Tahaluf.Pharmacy.API.Data;

namespace Tahaluf.Pharmace.Core.IService
{
    public interface IUserService
    {
        List<Useraccount> GetALLUsers();
        bool DeleteUser(int id);
        bool CreateUser(Useraccount useraccount);
        NumberOfUserWhoMadeOrdersDTO GetNumberOfUserWhoGetOrder();
        bool UpdateUser(Useraccount user);
        Useraccount ViewProfile(int id);

    }
}
