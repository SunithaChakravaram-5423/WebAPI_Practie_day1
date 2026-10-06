using Microsoft.AspNetCore.Mvc;
namespace server.Controllers;

[ApiController]
[Route("[controller]")]

public class SumController : ControllerBase
{
    [HttpPost]
    public int Post(int FirstNumber, int SecondNumber)
    {
        return FirstNumber+SecondNumber;
    }
    public sealed record Sum(int FirstNumber, int SecondNumber);
}

// using Microsoft.AspNetCore.Mvc;

// namespace server.Controllers;

// [ApiController]
// [Route("[controller]")]
// public class SumController : ControllerBase
// {
//     [HttpPost]
//     public int Post(SumRequest request)
//     {
//         return request.FirstNumber + request.SecondNumber;
//     }

//     public sealed record SumRequest(int FirstNumber, int SecondNumber);
// }