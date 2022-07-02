using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Tahaluf.Pharmace.Core.Data.DTO;
using Tahaluf.Pharmace.Core.IService;
using Tahaluf.Pharmacy.API.Data;

namespace Tahaluf.Pharmacy.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        public readonly IOrderService orderService;
        public OrderController(IOrderService _orderService)
        {
            orderService = _orderService;
        }
        [HttpGet]

        public List<Ordder> GetOrder()
        {
            return orderService.GetOrder();
        }
        [HttpPost]
        [Route("createOrder")]
        public bool createOrder(Ordder ordder)
        {
            return orderService.createOrder(ordder);
        }
        [HttpPut]
        [Route("updateOrder")]
        public bool updateOrder(Ordder ordder)
        {
            return orderService.updateOrder(ordder);
        }
        [HttpDelete]
        [Route("deleteOrder/{orderId}")]
        public bool deleteOrder(int orderId)
        {
            return orderService.deleteOrder(orderId);
        }

        [HttpGet]
        [Route("AcceptOrder/{orderId}")]
        public bool AcceptOrder(int orderId)
        {
            return orderService.AcceptOrder(orderId);
        }
        [HttpGet]
        [Route("RejectOrder/{orderId}")]
        public bool RejectOrder(int orderId)

        { return orderService.RejectOrder(orderId); }
        [HttpPost]
        [Route("GetOrderBettwenTwoDates")]
        public List<MedicneOrederDTO> GetOrderBettwenTwoDates(OrderSearchDTO orderSearchDTO)
        {
            return orderService.GetOrderBettwenTwoDates(orderSearchDTO);
        }

        [HttpGet]
        [Route("GetAllOrder")]
        public List<getAllOrderDTO> GetAllOrder()
        {
            return orderService.GetAllOrder();
        }

        [HttpPost]
        [Route("GetOrderById")]
        public List<GetOrdersDTo> GetOrderById(GetOrdersDTo getOrdersDTo)
        {
            return orderService.GetOrderById(getOrdersDTo);
        }
        [HttpPost]
        [Route("CheckMedicineInCart")]
        public Ordder CheckMedicineInCart(Ordder ordder)
        {
            return orderService.CheckMedicineInCart(ordder);
        }

        [HttpPut]
        [Route("UpdateMedicineInCart")]
        public bool UpdateMedicineInCart(Ordder ordder)
        {
            return orderService.UpdateMedicineInCart(ordder);
        }
        [HttpPut]
        [Route("UpdateOrserStatusToCheckout")]
        public bool UpdateOrserStatusToCheckout(Ordder ordder)
        {
            return orderService.UpdateOrserStatusToCheckout(ordder);
        } 

    }
}
