using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NSK_Food_City.Database;
using NSK_Food_City.DTO.Request;
using NSK_Food_City.DTO.Response;
using NSK_Food_City.Services;

namespace NSK_Food_City.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private IProductService _iproductservice;

        public ProductController(IProductService iproductservice)
        {
            _iproductservice = iproductservice;
        }

        [HttpPost("add-product")]
        public async Task<IActionResult> addProduct(ProductRequestDTO productrequestdto)
        {
            var data = await _iproductservice.addProduct(productrequestdto);
            return Ok(data);
        }

        [HttpGet("get-all-products")]
        public async Task<IActionResult> getAllProducts()
        {
            var data = await _iproductservice.getAllProducts();
            return Ok(data);
        }

        [HttpGet("get-product-by-id/{id}")]
        public async Task<IActionResult> gettProductById(Guid id)
        {
            var data = await _iproductservice.getProductById(id);
            return Ok(data);
        }

        [HttpPut("edit-product")]
        public async Task<IActionResult> editProduct(Product product)
        {
            var data = _iproductservice.editProduct(product);
            return Ok(data);
        }
    }
}
