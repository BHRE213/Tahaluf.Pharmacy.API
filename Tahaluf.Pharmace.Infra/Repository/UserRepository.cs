using System;
using System.Collections.Generic;
using System.Text;
using Tahaluf.Pharmace.Core.Common;
using Tahaluf.Pharmace.Core.IRepository;

namespace Tahaluf.Pharmace.Infra.Repository
{
    public class UserRepository: IUserRepository
    {
        private readonly IDbContext dBContext;
        public UserRepository(IDbContext _dBContext)
        {
            dBContext = _dBContext;
        }
    }
}
