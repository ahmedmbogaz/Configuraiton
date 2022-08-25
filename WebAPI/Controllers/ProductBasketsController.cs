using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductBasketsController : ControllerBase
    {
        private readonly IProductBasketService _productBasketService;

        public ProductBasketsController(IProductBasketService productBasketService)
        {
            _productBasketService = productBasketService;
        }

        [HttpPost("add")]
        public IActionResult Add(ProductBasket productBasket)
        {
            var result= _productBasketService.Add(productBasket);
            if (result.Success) 
            {
               return Ok(result); 
            }
            return BadRequest(result);
        }

        [HttpGet("getalldetail")]
        public IActionResult GetAll()
        {
            var result = _productBasketService.GetProductBasketDetails();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
