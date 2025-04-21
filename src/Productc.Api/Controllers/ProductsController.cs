using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Productc.Application.Abstractions;
using Productc.Domain.Entities.Products;

namespace Productc.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController(IApplicationDbContext dbContext) : ControllerBase
    {
        private readonly IApplicationDbContext dbContext = dbContext;

        [HttpGet("All")]
        public async Task<IActionResult> GetProducts()
        {
            var products = await dbContext.Products.ToListAsync();
            return Ok(products);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetProduct(Guid id)
        {
            var product = await dbContext.Products.FindAsync(id);
            if (product == null)
            {
                return NotFound();
            }
            return Ok(product);
        }
        [HttpPost("Add")]
        public async Task<IActionResult> CreateProduct([FromBody] ProductCreationDto product)
        {
            if (product == null)
            {
                return BadRequest();
            }
            Product newProduct = new()
            {
                Id = Guid.NewGuid(),
                Name = product.Name,
                Description = product.Description,
                Price = product.Price,
                ImageUrl = product.ImageUrl,
                Category = product.Category

            };
            await dbContext.Products.AddAsync(newProduct);
            var result = await dbContext.SaveChangesAsync() >0;
            return Ok(result);
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateProduct(Guid id, [FromBody] Product product)
        {
            if (id != product.Id)
            {
                return BadRequest();
            }
            var existingProduct = await dbContext.Products.FindAsync(id);
            if (existingProduct == null)
            {
                return NotFound();
            }
            existingProduct.Name = product.Name;
            existingProduct.Description = product.Description;
            existingProduct.Price = product.Price;
            existingProduct.ImageUrl = product.ImageUrl;
            existingProduct.Category = product.Category
                ;
            dbContext.Products.Update(existingProduct);
            await dbContext.SaveChangesAsync();
            return NoContent();
        }
    }

    public class ProductCreationDto
    {
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public string ImageUrl { get; set; } = string.Empty;
        public string Category { get; set; } = string.Empty;
    }
}
