using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers;

[ApiController]
[Route("[controller]")]
public class FilmesController : ControllerBase
{
    [HttpGet]
    public IActionResult Get()
    {
        return StatusCode(200, "Filmes");
    }
}
