using System;
using System.Collections.Generic;
using System.Text;
using Tahaluf.Pharmace.Core.IRepository;
using Tahaluf.Pharmace.Core.IService;

namespace Tahaluf.Pharmace.Infra.Service
{
    public class OrderService: IOrderService
    {
        public readonly IOrderRepository orderRepository;
        public OrderService(IOrderRepository _orderRepository)
        {
            orderRepository=_orderRepository;
        }
    }
}
