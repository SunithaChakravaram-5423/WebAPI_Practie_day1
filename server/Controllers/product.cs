using Microsoft.AspNetCore.Mvc;
namespace server.Controllers;

[ApiController]
[Route("[controller]")]

public class ProductController : ControllerBase
{
    [HttpGet(Name ="Product")]

    public Product Get()
    {
        return new Product(1, "Laptop", 75000, "Dell");
    }

    public sealed record Product(int id, string name, int price, string brand);
}