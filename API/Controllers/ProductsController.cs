using Core.Entities;
using Core.Interfaces;
using Infrastructure.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Zooshop.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductRepository _repo;
        public ProductController(IProductRepository repo)
        {
            _repo = repo;
        }

        // GET: api/Product
        [HttpGet]
        public async Task<ActionResult<List<Product>>> GetProducts()
        {
            var products = await _repo.GetProductsAsync();
            return Ok(products);
        }

        // GET: api/Product/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Product>> GetProduct(int id)
        {
            var product = await _repo.GetProductAsync(id);

            if (product == null)
            {
                return NotFound();
            }

            return product;
        }

        // POST: api/Product
        [HttpPost]
        public async Task AddProduct(Product product)
        {
            if (product != null)
            {
                await _repo.AddProductAsync(product);
            }
        }
        [HttpDelete("{id}")]
        public async Task DeleteProduct(int id)
        {
            await _repo.DeleteProductAsync(id);
        }
        // TODO
        // [HttpPut("{id}")]
        // public async Task<IActionResult> EditProduct(int id, [FromBody] Product product)
        // {
        //     if (id != product.Id)
        //     {
        //         return BadRequest("Product Id mismatch");
        //     }

        //     var existingProduct = await _repo.GetProductAsync(id);

        //     if (existingProduct == null)
        //     {
        //         return NotFound("Product not found");
        //     }

        //     existingProduct.Name = product.Name;
        //     existingProduct.Description = product.Description;
        //     existingProduct.Price = product.Price;

        //     await _repo.EditProductAsync(existingProduct);

        //     return Ok(existingProduct);
        // }

    }
}
