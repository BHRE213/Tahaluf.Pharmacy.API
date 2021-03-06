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
        public bool AcceptOrder(int orderId)
        {
            return orderRepository.AcceptOrder(orderId);
        }
        public bool RejectOrder(int orderId)
        {
            return orderRepository.RejectOrder(orderId);
        }
        public List<Ordder> GetOrder()
        {
           return orderRepository.GetOrder();
        }
       public List<getAllOrderDTO> GetAllOrder() { return orderRepository.GetAllOrder(); }
        public List<getAllOrderDTO> GetOrderBettwenTwoDates(OrderSearchDTO orderSearchDTO)
        {
            return orderRepository.GetOrderBettwenTwoDates(orderSearchDTO);
        }

        public bool updateOrder(Ordder ordder)
        {
            return orderRepository.updateOrder (ordder);
        }

        public List<GetOrdersDTo> GetOrderById(GetOrdersDTo getOrdersDTo)
        {
            return orderRepository.GetOrderById (getOrdersDTo);
        }

        public Ordder CheckMedicineInCart(Ordder ordder)
        {
            return orderRepository.CheckMedicineInCart (ordder);
        }
        public bool UpdateMedicineInCart(Ordder ordder)
        {
           return orderRepository.UpdateMedicineInCart(ordder);    
        }

        public bool UpdateOrserStatusToCheckout(Ordder ordder)
        {
            return orderRepository.UpdateOrserStatusToCheckout (ordder);
        }
        public Card GetCardUserData(Card card)
        {
            return orderRepository.GetCardUserData(card);
        }

        public bool UpdateOrserStatusToPaid(Ordder ordder)
        {
            return orderRepository.UpdateOrserStatusToPaid (ordder);
        }

        public bool UpdateBalance(Card card)
        {
            return orderRepository.UpdateBalance(card);
        }
        public bool ReturnStatusToIncart(Ordder ordder)
        {
            return orderRepository.ReturnStatusToIncart (ordder);
        }
        public bool UpdateOrserStatusToDone(Ordder ordder)
        {
            return orderRepository.UpdateOrserStatusToDone (ordder);
        }
        public List<GetOrdersDTo> GetUserOrdesHistory(GetOrdersDTo getOrdersDTo)
        {
            return orderRepository.GetUserOrdesHistory(getOrdersDTo);
        }
        public List<Card> getallCardData()
        {
            return orderRepository.getallCardData();
        }

        public bool createOrderFromUserPrescriptions(CreateOrderDTO createOrderDTO)
        {
            return orderRepository.createOrderFromUserPrescriptions(createOrderDTO);
        }


         public bool decreaseCartItem(Ordder ordder)
        {
            return orderRepository.decreaseCartItem(ordder);
        }

        public bool increaseCartItem(Ordder ordder)
        {
            return orderRepository.increaseCartItem(ordder);
        }
    }
}
