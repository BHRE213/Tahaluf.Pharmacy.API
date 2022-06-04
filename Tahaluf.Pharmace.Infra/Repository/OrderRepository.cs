using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using Tahaluf.Pharmace.Core.Common;
using Tahaluf.Pharmace.Core.Data.DTO;
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

        public bool createOrder(Ordder ordder)
        {
            var p = new DynamicParameters();
            p.Add("Total", ordder.Totalprice, dbType: DbType.Double, direction: ParameterDirection.Input);
            p.Add("q", ordder.Quantity, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("numberOrder", ordder.Numberofordar, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("da", ordder.Orderdate, dbType: DbType.DateTime, direction: ParameterDirection.Input);
            p.Add("ordstatid", ordder.Orderstates, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("useracid", ordder.Useraccount, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("timeo", ordder.Ordertime, dbType: DbType.Time, direction: ParameterDirection.Input);
            p.Add("medid", ordder.Medicineid, dbType: DbType.Int32, direction: ParameterDirection.Input);

            var result = dbContext.Connection.ExecuteAsync("OrderPackage.createOrder", p,commandType: CommandType.StoredProcedure);

            return true;

        }

        public bool deleteOrder(int orderId)
        {
            var p = new DynamicParameters();
            p.Add("id", orderId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = dbContext.Connection.ExecuteAsync("OrderPackage.deleteOrder",p, commandType: CommandType.StoredProcedure);
            return true;
        }

        public List<Ordder> GetOrder()
        {
            IEnumerable<Ordder> result = dbContext.Connection.Query<Ordder>("OrderPackage.GetOrder", commandType: CommandType.StoredProcedure);
            return result.ToList();

        }

        public List<MedicneOrederDTO> GetOrderBettwenTwoDates(OrderSearchDTO orderSearchDTO)
        {
            var p = new DynamicParameters();
            p.Add("startin", orderSearchDTO.start, dbType: DbType.DateTime, direction: ParameterDirection.Input);
            p.Add("endin", orderSearchDTO.end, dbType: DbType.DateTime, direction: ParameterDirection.Input);

            var result = dbContext.Connection.Query<MedicneOrederDTO>("OrderPackage.GetBettwenTwoDates", p, commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        public bool updateOrder(Ordder ordder)
        {
            var p = new DynamicParameters();
            p.Add("id", ordder.Orderid, dbType: DbType.Double, direction: ParameterDirection.Input);

            p.Add("Total", ordder.Totalprice, dbType: DbType.Double, direction: ParameterDirection.Input);
            p.Add("q", ordder.Quantity, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("numberOrder", ordder.Numberofordar, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("da", ordder.Orderdate, dbType: DbType.DateTime, direction: ParameterDirection.Input);
            p.Add("ordstatid", ordder.Orderstates, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("useracid", ordder.Useraccount, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("timeo", ordder.Ordertime, dbType: DbType.Time, direction: ParameterDirection.Input);
            p.Add("medid", ordder.Medicineid, dbType: DbType.Int32, direction: ParameterDirection.Input);

            var result = dbContext.Connection.ExecuteAsync("OrderPackage.updateOrder", p, commandType: CommandType.StoredProcedure);

            return true;

        }
    }
}
