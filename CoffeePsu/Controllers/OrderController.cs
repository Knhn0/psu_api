using CoffeePsu.Domain.Contracts;
using CoffeePsu.Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace CoffeePsu.Controllers
{
    public class OrderController : BaseController
    {
        private readonly IOrderService _orderService;
        public OrderController(IOrderService orderService)
        {
            _orderService = orderService;
        }
        [HttpGet]
        public IEnumerable<OrderModel> Get(OrderModel order)
        {
            return (IEnumerable<OrderModel>)order;
        }

        /*[HttpGet]
        [ActionName("Get Id")]
        public IEnumerable<OrderModel> Get(OrderModel order)
        {
            
        }*/

        [HttpPost]
        public ActionResult Post(OrderModel order)
        {
            _orderService.CreateOrder(order);
            var result = _orderService.CreateOrder(order);
            if (result == null)
            {
                return BadRequest("Your result is null");
            }
            return Ok($"Ok. Your result is {result}");
        }
    }
}
