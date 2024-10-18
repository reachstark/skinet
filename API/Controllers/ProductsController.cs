
using Core.Entities;
using Infrastructure.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers;

// Attributes
[ApiController]
[Route("api/[controller]")]

// We derive from a ControllerBase class to return JSON responses.
public class ProductsController : ControllerBase
{
    private readonly StoreContext context;

    // Inject StoreContext into the controller
    public ProductsController(StoreContext context)
    {
        this.context = context;
    }

    // Methods
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Product>>> GetProducts()
    {
        return await context.Products.ToListAsync();
    }

    [HttpGet("{id:int}")]
    public async Task<ActionResult<Product>> GetProduct(int id)
    {
        var product = await context.Products.FindAsync(id);

        if (product == null) return NotFound();
        
        return product;
    }

    [HttpPost]
    public async Task<ActionResult<Product>> CreateProduct(Product product)
    {
        context.Products.Add(product);
        await context.SaveChangesAsync();
        return product;
    }
}
