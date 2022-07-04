using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Tahaluf.Pharmace.Core.Data.DTO;
using Tahaluf.Pharmace.Core.IService;
using Tahaluf.Pharmacy.API.Data;
using MimeKit;
using MailKit.Net.Smtp;

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

        [HttpPost]
        [Route("GetCardUserData")]
        public Card GetCardUserData(Card card)
        {
            return orderService.GetCardUserData(card);
        }
        [HttpPut]
        [Route("UpdateOrserStatusToPaid")]
        public bool UpdateOrserStatusToPaid(Ordder ordder)
        {
            return orderService.UpdateOrserStatusToPaid(ordder);
        }
        [HttpPut]
        [Route("UpdateBalance")]
        public bool UpdateBalance(Card card)
        {
            return orderService.UpdateBalance(card);
        }
        [HttpPut]
        [Route("ReturnStatusToIncart")]
        public bool ReturnStatusToIncart(Ordder ordder)
        {
            return orderService.ReturnStatusToIncart(ordder);
        }

        [HttpPut]
        [Route("UpdateOrserStatusToDone")]
        public bool UpdateOrserStatusToDone(Ordder ordder)
        {
            return orderService.UpdateOrserStatusToDone(ordder);
        }
        [HttpPost]
        [Route("GetUserOrdesHistory")]
        public List<GetOrdersDTo> GetUserOrdesHistory(GetOrdersDTo getOrdersDTo)
        {
            return orderService.GetUserOrdesHistory(getOrdersDTo);
        }


        [HttpPost]
        [Route("SendEmail")]
        public bool SendEmail(Useraccount useraccount)
        {
            MimeMessage message = new MimeMessage();
            MailboxAddress from = new MailboxAddress("Tahaluf Elemarat",useraccount.Email );
            message.From.Add(from);
            MailboxAddress to = new MailboxAddress("Trainee", useraccount.Email);
            message.To.Add(to);
            message.Subject= "Tahaluf Elemarat";

            BodyBuilder bodyBuilder = new BodyBuilder();
            bodyBuilder.HtmlBody = "<h1> Welcome to Tahaluf Alemarat Traning<h1>";
            message.Body=bodyBuilder.ToMessageBody();



            using (var clien = new SmtpClient())
            {
                //conection 
                clien.Connect("smtp-mail.outlook.com", 587, false);
                //aunth
                clien.Authenticate(useraccount.Email, useraccount.Password);
                //send
                clien.Send(message);
                //diconnect
                clien.Disconnect(true);
                clien.Dispose();
            }

            return true;

        }

    }
}
