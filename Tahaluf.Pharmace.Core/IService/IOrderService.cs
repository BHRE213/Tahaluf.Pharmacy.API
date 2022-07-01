﻿using System;
using System.Collections.Generic;
using System.Text;
using Tahaluf.Pharmace.Core.Data.DTO;
using Tahaluf.Pharmacy.API.Data;

namespace Tahaluf.Pharmace.Core.IService
{
    public interface IOrderService
    {

        List<Ordder> GetOrder();
        List<getAllOrderDTO> GetAllOrder();
        bool createOrder(Ordder ordder);
        bool updateOrder(Ordder ordder);
        bool deleteOrder(int orderId);
        List<MedicneOrederDTO> GetOrderBettwenTwoDates(OrderSearchDTO orderSearchDTO);
        bool AcceptOrder(int orderId);
        bool RejectOrder(int orderId);
        List<GetOrdersDTo> GetOrderById(GetOrdersDTo getOrdersDTo);

    }
}
