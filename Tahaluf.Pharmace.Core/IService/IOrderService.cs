using System;
using System.Collections.Generic;
using System.Text;
using Tahaluf.Pharmace.Core.Data.DTO;
using Tahaluf.Pharmacy.API.Data;

namespace Tahaluf.Pharmace.Core.IService
{
    public interface IOrderService
    {

        List<Ordder> GetOrder();
        bool createOrder(Ordder ordder);
        bool updateOrder(Ordder ordder);
        bool deleteOrder(int orderId);
        List<MedicneOrederDTO> GetOrderBettwenTwoDates(OrderSearchDTO orderSearchDTO);


    }
}
