using Microsoft.AspNetCore.Mvc;
namespace server.Controllers;

[ApiController]
[Route("[controller]")]

public class Student9Controller : ControllerBase
{
    [HttpPost]

    public Student9 Post(Student9 student)
    {
        return new Student9(
            "Student created successfully",
            student.Name,
            student.Age,
            student.Course
        );
    }

    public sealed record Student(
        string Name,
        int Age,
        string Course
    );

    public sealed record Student9(
        string Message,
        string Name,
        int Age,
        string Course
    );
}