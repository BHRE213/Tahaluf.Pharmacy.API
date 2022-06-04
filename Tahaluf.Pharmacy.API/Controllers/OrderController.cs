using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
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
        [Route("OrderPackage")]
        public List<Ordder> OrderPackage()
        {
            return orderService.OrderPackage();
        }
    }
}
