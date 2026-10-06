using Microsoft.AspNetCore.Mvc;

namespace server.Controllers;

[ApiController]
[Route("[controller]")]

public class EmployeeController : ControllerBase
{
    [HttpPost]

    public Employee? Post(EmployeeReq req)
    {
        if(req.id == 101)
        {
            return new Employee(101, "Rahul", "IT");   
        }
        return null;
    }
    public sealed record EmployeeReq(int id);
    public sealed record Employee(int id, string name, string department);
}