using System;
using System.Collections.Generic;
using System.Text;
using Tahaluf.Pharmace.Core.Data.DTO;
using Tahaluf.Pharmacy.API.Data;

namespace Tahaluf.Pharmace.Core.IRepository
{
 public interface ILoginRepository
    {
        DTOLogin userlogin(Useraccount login);

        Useraccount GetUserById(Useraccount useraccount);
    }


}
