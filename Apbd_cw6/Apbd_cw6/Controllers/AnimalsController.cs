using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;

namespace Apbd_cw6.Controllers;
[ApiController]
[Route("api/[controller]")]

public class AnimalsController : ControllerBase
{
    private readonly IConfiguration _configuration;
    public AnimalsController(IConfiguration configuration)
    {
        _configuration = configuration;
    }
    
    [HttpGet]
    public IActionResult GetAnimals()
    {
        SqlConnection connection = new SqlConnection(_configuration.GetConnectionString("Default"));
        connection.Open();
        return Ok();
    }
}