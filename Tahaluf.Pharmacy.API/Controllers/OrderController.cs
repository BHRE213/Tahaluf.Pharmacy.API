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
            orderService=_orderService;
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
        [HttpPost]
        [Route("GetOrderBettwenTwoDates")]
        public List<MedicneOrederDTO> GetOrderBettwenTwoDates(OrderSearchDTO orderSearchDTO)
        {
            return orderService.GetOrderBettwenTwoDates(orderSearchDTO);
        }


    }
}
