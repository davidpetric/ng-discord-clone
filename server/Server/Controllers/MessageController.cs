namespace Api.Controllers;
using Microsoft.AspNetCore.Mvc;

[Route("[controller]")]
[ApiController]
public class MessageController : Controller
{
    [HttpGet]
    public IEnumerable<int> Index()
    {
        var test = new[] { 1, 2 };
        return test;
    }
}
