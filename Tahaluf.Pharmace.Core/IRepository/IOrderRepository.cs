using System;
using System.Collections.Generic;
using System.Text;
using Tahaluf.Pharmace.Core.Data.DTO;
using Tahaluf.Pharmacy.API.Data;

namespace Tahaluf.Pharmace.Core.IRepository
{
    public interface IOrderRepository
    {
        List<Ordder> GetOrder();
        List<getAllOrderDTO> GetAllOrder();
        bool createOrder(Ordder ordder);
        bool updateOrder(Ordder ordder);
        bool deleteOrder(int orderId);
        bool AcceptOrder(int orderId);
        bool RejectOrder(int orderId);
        List<getAllOrderDTO> GetOrderBettwenTwoDates(OrderSearchDTO orderSearchDTO);

        List<GetOrdersDTo> GetOrderById(GetOrdersDTo getOrdersDTo);
        Ordder CheckMedicineInCart(Ordder ordder);

        bool UpdateMedicineInCart(Ordder ordder);

        bool UpdateOrserStatusToCheckout(Ordder ordder);
        Card GetCardUserData(Card card);
        bool UpdateOrserStatusToPaid(Ordder ordder);
        bool UpdateBalance(Card card);
        bool ReturnStatusToIncart(Ordder ordder);
        bool UpdateOrserStatusToDone(Ordder ordder);
        List<GetOrdersDTo> GetUserOrdesHistory(GetOrdersDTo getOrdersDTo);

    }
}
