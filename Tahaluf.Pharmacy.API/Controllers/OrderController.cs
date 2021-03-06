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
        public List<getAllOrderDTO> GetOrderBettwenTwoDates(OrderSearchDTO orderSearchDTO)
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
        public bool SendEmail( EmailDTO emailDTO)
        {
            MimeMessage message = new MimeMessage();
            MailboxAddress from = new MailboxAddress("Pharmacy", "test435@outlook.sa");
            message.From.Add(from);
            MailboxAddress to = new MailboxAddress("User", emailDTO.Email);
            message.To.Add(to);
            message.Subject= "Purchase Invoice";


            BodyBuilder bodyBuilder = new BodyBuilder();
            bodyBuilder.HtmlBody = "<h4>  Dear<that The /h4> " + emailDTO.Fullname +  
                " " +
                " <br><br>We Would Like To Inform You That Your Payment On Our Site With Total" + "<p style=\"color:blue\">(" + emailDTO.Total + ")</p>" + "Are Successfully Paid .  " + " <br>  Date:" + System.DateTime.Now;
            message.Body=bodyBuilder.ToMessageBody();



            using (var clien = new SmtpClient())
            {
                //conection 
                clien.Connect("smtp-mail.outlook.com", 587, false);
                //aunth
                clien.Authenticate("test435@outlook.sa","test123@21" );
                //send
                clien.Send(message);
                //diconnect
                clien.Disconnect(true);
                clien.Dispose();
            }

            return true;

        }
        [HttpGet]
        [Route("getallCardData")]
        public List<Card> getallCardData()
        {
            return orderService.getallCardData();
        }
        [HttpPost]
        [Route("createOrderFromUserPrescriptions")]
        public bool createOrderFromUserPrescriptions(CreateOrderDTO createOrderDTO)
        {
            return orderService.createOrderFromUserPrescriptions(createOrderDTO);
        }

        [HttpPost]
        [Route("decreaseCartItem")]
        public bool decreaseCartItem(Ordder ordder)
        {
            return orderService.decreaseCartItem(ordder);
        }   

        [HttpPost]
        [Route("increaseCartItem")]
        public bool increaseCartItem(Ordder ordder)
        {
            return orderService.increaseCartItem(ordder);
        }

    }
}
