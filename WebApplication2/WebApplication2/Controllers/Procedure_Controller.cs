using Microsoft.AspNetCore.Mvc;
using WebApplication2.Repositories;

namespace WebApplication2.Controllers;

[Route("api/[controller]")]
[ApiController]
public class Procedure_Controller : ControllerBase
{
    private readonly IConfiguration _configuration;
    private Procedure_Repository _procedureRepository;
    public Procedure_Controller(IConfiguration configuration,Procedure_Repository procedureRepository)
    {
        _configuration = configuration;
        _procedureRepository = procedureRepository;
    }
    
    [HttpGet]
    public IActionResult GetInfo(int Id)
    {
        if (_procedureRepository.getAnimal(Id) == null)
        {
            return NotFound();
        }
        return Ok();
    }
}