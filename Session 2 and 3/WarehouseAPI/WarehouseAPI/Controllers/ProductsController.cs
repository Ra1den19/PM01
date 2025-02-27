using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WarehouseAPI.Models;

namespace WarehouseAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public ProductsController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet("warehouse/{warehouseId}")]
        public async Task<ActionResult<IEnumerable<Products>>> GetProductsInWarehouse(long warehouseId)
        {
            var products = await _context.ProductsInWarehouses
                .Where(p => p.WarehouseID == warehouseId)
                .Include(p => p.Product)
                .Select(p => p.Product)
                .ToListAsync();

            if (products == null || !products.Any())
            {
                return NotFound();
            }

            return Ok(products);
        }

        [HttpPost]
        public async Task<ActionResult<Products>> PostProduct(Products product)
        {
            _context.Products.Add(product);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetProductsInWarehouse), new { id = product.ProductId }, product);
        }
    }
}
