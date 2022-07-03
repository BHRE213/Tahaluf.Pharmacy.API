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
            p.Add("q", ordder.Quantity, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("da", ordder.Orderdate, dbType: DbType.DateTime, direction: ParameterDirection.Input);
            p.Add("ordstatid", ordder.Orderstatesid, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("useracid", ordder.Useraccountid, dbType: DbType.Int32, direction: ParameterDirection.Input);
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
        public bool AcceptOrder(int orderId)
        {
            var p = new DynamicParameters();
            p.Add("id", orderId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = dbContext.Connection.ExecuteAsync("OrderPackage.ACCEPTORDER", p, commandType: CommandType.StoredProcedure);
            return true;
        }
        public bool RejectOrder(int orderId)
        {
            var p = new DynamicParameters();
            p.Add("id", orderId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = dbContext.Connection.ExecuteAsync("OrderPackage.REJECTORDER", p, commandType: CommandType.StoredProcedure);
            return true;
        }

        public List<Ordder> GetOrder()
        {
            IEnumerable<Ordder> result = dbContext.Connection.Query<Ordder>("OrderPackage.GetOrder", commandType: CommandType.StoredProcedure);
            return result.ToList();

        }



        public List<getAllOrderDTO> GetAllOrder()
        {
            IEnumerable<getAllOrderDTO> result = dbContext.Connection.Query<getAllOrderDTO>("OrderPackage.getallorder", commandType: CommandType.StoredProcedure);
            return result.ToList();

        }

        public List<getAllOrderDTO> GetOrderBettwenTwoDates(OrderSearchDTO orderSearchDTO)
        {
            var p = new DynamicParameters();
            p.Add("startin", orderSearchDTO.start, dbType: DbType.DateTime, direction: ParameterDirection.Input);
            p.Add("endin", orderSearchDTO.end, dbType: DbType.DateTime, direction: ParameterDirection.Input);

            var result = dbContext.Connection.Query<getAllOrderDTO>("OrderPackage.GetBettwenTwoDates", p, commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        public bool updateOrder(Ordder ordder)
        {
            var p = new DynamicParameters();
            p.Add("id", ordder.Orderid, dbType: DbType.Double, direction: ParameterDirection.Input);

            p.Add("q", ordder.Quantity, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("da", ordder.Orderdate, dbType: DbType.DateTime, direction: ParameterDirection.Input);
            p.Add("ordstatid", ordder.Orderstates, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("useracid", ordder.Useraccount, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("medid", ordder.Medicineid, dbType: DbType.Int32, direction: ParameterDirection.Input);

            var result = dbContext.Connection.ExecuteAsync("OrderPackage.updateOrder", p, commandType: CommandType.StoredProcedure);

            return true;

        }

        public List<GetOrdersDTo> GetOrderById(GetOrdersDTo getOrdersDTo)
        {
            var p = new DynamicParameters();         

            p.Add("uid", getOrdersDTo.Useraccountid, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("osid", getOrdersDTo.Orderstatesid, dbType: DbType.Int32, direction: ParameterDirection.Input);


            IEnumerable<GetOrdersDTo> result = dbContext.Connection.Query<GetOrdersDTo>("ordderById", p, commandType: CommandType.StoredProcedure);
            return result.ToList();

        }

        public Ordder CheckMedicineInCart(Ordder ordder)
        {
            var p = new DynamicParameters();
            p.Add("uid", ordder.Useraccountid, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("mid", ordder.Medicineid, dbType: DbType.Int32, direction: ParameterDirection.Input);
            IEnumerable<Ordder> result = dbContext.Connection.Query<Ordder>("checkMedicineInCart", p, commandType: CommandType.StoredProcedure);
            return result.FirstOrDefault();
        }

        public bool UpdateMedicineInCart(Ordder ordder)
        {
            var p = new DynamicParameters();
            p.Add("uid", ordder.Useraccountid, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("mid", ordder.Medicineid, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("q", ordder.Quantity, dbType: DbType.Int32, direction: ParameterDirection.Input);

            var result = dbContext.Connection.ExecuteAsync("updateMedicneIfInCart", p, commandType: CommandType.StoredProcedure);
            return true;
        }


        public bool UpdateOrserStatusToCheckout(Ordder ordder)
        {
            var p = new DynamicParameters();
            p.Add("uid", ordder.Useraccountid, dbType: DbType.Int32, direction: ParameterDirection.Input); 
            var result = dbContext.Connection.ExecuteAsync("updateOrserStatusToCheckout", p, commandType: CommandType.StoredProcedure);
            return true;
        }

        public Card GetCardUserData(Card card)
        {
            var p = new DynamicParameters();
            p.Add("uid", card.Useraccountid, dbType: DbType.Int32, direction: ParameterDirection.Input);
            IEnumerable<Card> result = dbContext.Connection.Query<Card>("getCardUserData", p, commandType: CommandType.StoredProcedure);
            return result.FirstOrDefault();
        }

        public bool UpdateOrserStatusToPaid(Ordder ordder)
        {
            var p = new DynamicParameters();
            p.Add("uid", ordder.Useraccountid, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = dbContext.Connection.ExecuteAsync("updateOrserStatusToPaid", p, commandType: CommandType.StoredProcedure);
            return true;
        }
    }
}
