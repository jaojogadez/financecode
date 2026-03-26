using Microsoft.AspNetCore.Mvc;
using MinhaLojinha.Models;
using MinhaLojinha.Models.Data;

namespace MinhaLojinha.Controllers;

[ApiController]
[Route("[controller]")]
public class ProductController : ControllerBase
{
    private readonly AppDbContext _context;
    public ProductController (AppDbContext dbContext)
    {
        _context = dbContext;

    }

    [HttpGet("All")]
    public List<Product> GetAll()
    {
        List<Product> listProduct = _context.Products.ToList();
        return listProduct;
    }

    [HttpPost("Create")]
    public ActionResult<Product> Create(Product product)
    {
        if (product != null)
        {
            _context.Add(product);
            _context.SaveChanges();
            return Ok(product);
        }

        return BadRequest();
    }

    [HttpPost("Update")]
    public ActionResult<Product> Update(Product product)
    {
        if (product != null)
        {
            _context.Update(product);
            _context.SaveChanges();
            return Ok(product);
        }

        return BadRequest();
    }
}