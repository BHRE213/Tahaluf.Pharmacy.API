using System;
using System.Collections.Generic;
using System.Text;
using Tahaluf.Pharmace.Core.Data.DTO;
using Tahaluf.Pharmace.Core.IRepository;
using Tahaluf.Pharmace.Core.IService;
using Tahaluf.Pharmacy.API.Data;

namespace Tahaluf.Pharmace.Infra.Service
{
    public class OrderService: IOrderService
    {
        public readonly IOrderRepository orderRepository;
        public OrderService(IOrderRepository _orderRepository)
        {
            orderRepository=_orderRepository;
        }

        public bool createOrder(Ordder ordder)
        {
            return orderRepository.createOrder  (ordder);
        }

        public bool deleteOrder(int orderId)
        {
            return orderRepository.deleteOrder (orderId);
        }

        public List<Ordder> GetOrder()
        {
           return orderRepository.GetOrder();
        }

        public List<MedicneOrederDTO> GetOrderBettwenTwoDates(OrderSearchDTO orderSearchDTO)
        {
            return orderRepository.GetOrderBettwenTwoDates (orderSearchDTO);
        }

        public bool updateOrder(Ordder ordder)
        {
            return orderRepository.updateOrder (ordder);
        }
    }
}
