using Microsoft.AspNetCore.Mvc;
using Weeblantis.BusinessLogic.Services.Product;
using Weeblantis.Core.Models.Product;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Weeblantis.WebApi.Controllers.Product
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private IProductService _productService;
        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        // POST api/<ProductController>
        [HttpPost()]
        public void CreateProduct([FromBody] ProductModel product)
        {

        }

        // GET api/<ProductController>
        [HttpGet]
        public void GetAllProducts()
        {

        }
    }
}
