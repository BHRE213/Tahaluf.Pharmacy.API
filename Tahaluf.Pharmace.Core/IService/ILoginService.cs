﻿using System;
using System.Collections.Generic;
using System.Text;
using Tahaluf.Pharmacy.API.Data;

namespace Tahaluf.Pharmace.Core.IService
{
   public interface ILoginService
    {
        string userlogin(Useraccount login);
        Useraccount GetUserById(Useraccount useraccount);
    }
}
