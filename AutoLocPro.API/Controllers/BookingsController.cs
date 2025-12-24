using Microsoft.AspNetCore.Mvc;

namespace AutoLocPro.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class BookingController : ControllerBase
{
    [HttpGet]
    public IActionResult GetAll()
    {
        return Ok(new[]
        {
            new { Id = 1, StartDate = "2025-01-01", EndDate = "2025-01-05" }
        });
    }
}
