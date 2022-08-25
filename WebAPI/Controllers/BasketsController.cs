using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BasketsController : ControllerBase
    {
        private readonly IBasketService _basketService;
        private readonly ICustomerService _customerService;

        public BasketsController(IBasketService basketService, ICustomerService customerService)
        {
            _basketService = basketService;
            _customerService = customerService;
        }


        [HttpPost("add")]
        public IActionResult Add(Basket basket, Customer customer)
        {
            var result = _basketService.Add(basket,customer);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
