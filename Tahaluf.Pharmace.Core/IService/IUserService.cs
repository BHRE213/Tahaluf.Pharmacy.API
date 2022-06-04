using System;
using System.Collections.Generic;
using System.Text;
using Tahaluf.Pharmacy.API.Data;

namespace Tahaluf.Pharmace.Core.IService
{
    public interface IUserService
    {
        List<Useraccount> GetALLUsers();
        bool DeleteUser(int id);
    }
}
