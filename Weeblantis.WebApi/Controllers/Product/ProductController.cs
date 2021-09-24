using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using Weeblantis.BusinessLogic.Services.Product;
using Weeblantis.Core.Dtos.Product;
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
        public ActionResult<ProductDto> CreateProduct([FromBody] ProductDto productDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            try
            {
                var product = _productService.AddProduct(productDto);
                return CreatedAtAction(nameof(GetProductById), new { id = product.Id }, product);
            }
            catch (NullReferenceException e) {
                return BadRequest();
            }
            catch (Exception e)
            {
                return StatusCode(500);
            }

        }

        // PUT api/<ProductController>/5
        [HttpPut("{id}")]
        public ActionResult<ProductDto> Put(int id, [FromBody] ProductDto productDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            try
            {
                var product = _productService.UpdateProduct(id, productDto);
                return Ok(productDto);
            }
            catch (Exception e)
            {
                return StatusCode(500);
            }
        }


        // GET api/<ProductController>
        [HttpGet]
        public ActionResult<List<ProductDto>> GetAllProducts()
        {
            var products = _productService.GetAllProducts();
            return products;
        }

        // GET api/<ProductController>/5
        [HttpGet("{id}")]
        public ActionResult<ProductDto> GetProductById(int id)
        {
            if (id == 0)
            {
                return BadRequest();
            }
            var product = _productService.GetProductById(id);
            return Ok(product);
        }
        // GET api/GetAllProductByCategoryId>5
        [HttpGet("GetAllProductByCategoryId/{id}")]
        public ActionResult<List<ProductDto>> GetAllProductByCategoryId(int id)
        {
            if (id == 0)
            {
                return BadRequest();
            }
            var products = _productService.GetAllProductsByCategory(id);
            return Ok(products);
        }
    }
}
