using Microsoft.AspNetCore.Mvc;
using System;
using Weeblantis.BusinessLogic.Services.Product;
using Weeblantis.Core.Dtos.Product;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Weeblantis.WebApi.Controllers.Product
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductCategoryController : ControllerBase
    {
        private IProductCategoryService _productCategoryService;
        public ProductCategoryController(IProductCategoryService productCategoryService)
        {
            _productCategoryService = productCategoryService;
        }

        // POST api/<ProductCategoryController>
        [HttpPost()]
        public ActionResult<ProductCategoryDto> CreateProduct([FromBody] ProductCategoryDto productCategoryDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            try
            {
                var productCategory = _productCategoryService.AddProductCategory(productCategoryDto);
                return CreatedAtAction(nameof(GetProductCategory), new { id = productCategory.Id }, productCategory);
            }
            catch (Exception e)
            {
                return StatusCode(500);
            }
            
        }

        // GET api/<ProductCategoryController>
        [HttpGet]
        public void GetAllProductCategories()
        {

        }

        // GET api/<ProductCategoryController>/5
        [HttpGet("{id}")]
        public ActionResult<ProductCategoryDto> GetProductCategory(int id)
        {
            if (id == 0)
            {
                return BadRequest();
            }
            var productCategory = _productCategoryService.GetProductCategoryById(id);
            return Ok(productCategory);
        }
    }
}
