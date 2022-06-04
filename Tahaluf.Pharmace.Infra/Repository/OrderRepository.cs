using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using Tahaluf.Pharmace.Core.Common;
using Tahaluf.Pharmace.Core.IRepository;
using Tahaluf.Pharmacy.API.Data;

namespace Tahaluf.Pharmace.Infra.Repository
{
    public class OrderRepository : IOrderRepository
    {
        public readonly IDbContext dbContext;
        public OrderRepository(IDbContext _dbContext)
        {
            dbContext = _dbContext;
        }

        public List<Ordder> GetOrder()
        {
            IEnumerable<Ordder> result = dbContext.Connection.Query<Ordder>("OrderPackage.GetOrder", commandType: CommandType.StoredProcedure);
            return result.ToList();

        }
    }
}
