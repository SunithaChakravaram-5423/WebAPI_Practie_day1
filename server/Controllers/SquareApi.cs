using Microsoft.AspNetCore.Mvc;
namespace server.Controllers;
[ApiController]
[Route("[controller]")]

public class SquareController : ControllerBase
{
    [HttpPost]
    public int Post(Square sq){
        return sq.num*sq.num;
    }
    public sealed record Square(int num);
}