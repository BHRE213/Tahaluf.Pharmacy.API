﻿using System;
using System.Collections.Generic;
using System.Text;
using Tahaluf.Pharmace.Core.IRepository;
using Tahaluf.Pharmace.Core.IService;
using Tahaluf.Pharmacy.API.Data;

namespace Tahaluf.Pharmace.Infra.Service
{
  public class UserService: IUserService
    {
        private readonly IUserRepository UserRepository;
        public UserService(IUserRepository _UserRepository)
        {
            UserRepository = _UserRepository;
        }
      public  List<Useraccount> GetALLUsers() {
            return UserRepository.GetALLUsers();
        
        }
        public bool DeleteUser(int id)
        {
           return UserRepository.DeleteUser(id);
        }
    }
}
