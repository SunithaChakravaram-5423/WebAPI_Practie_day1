using Microsoft.AspNetCore.Mvc;
namespace server.Controllers;

[ApiController]
[Route("[controller]")]

public class LanguagesController : ControllerBase
{
    [HttpGet(Name ="Languages")]

    public string[] Get()
    {
        return ["C#", "Java", "Python", "JavaScript", "Go"];
    }
}