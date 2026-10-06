using Microsoft.AspNetCore.Mvc;
namespace server.Controllers;

[ApiController]
[Route("[controller]")]

public class StudentController : ControllerBase
{
    [HttpGet]
    public Student Get()
    {
        return new Student(101,"Rahul","B.Tech",21);
    }

    public sealed record Student(int Id,string Name,string Course,int Age);
}