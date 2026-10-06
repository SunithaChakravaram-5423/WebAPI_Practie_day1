using Microsoft.AspNetCore.Mvc;

namespace server.Controllers;

[ApiController]
[Route("[controller]")]
public class GreetingController : ControllerBase
{
    [HttpPost]
    public string Post(Greeting greeting)
    {
        return $"Hello {greeting.Name}!";
    }

    public sealed record Greeting(string Name);
}