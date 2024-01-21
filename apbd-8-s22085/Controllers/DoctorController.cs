using apbd_8_s22085.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace apbd_8_s22085.Controllers;

[ApiController]
[Route("[controller]")]
public class DoctorController : ControllerBase
{

    private readonly ILogger<DoctorController> _logger;

    public DoctorController(ILogger<DoctorController> logger)
    {
        _logger = logger;
    }
    
    [HttpGet]
    public async Task<IEnumerable<DoctorInfoDto>> GetDoctors()
    {
        return new List<DoctorInfoDto>();
    }
    
    [HttpGet("{id}")]
    public async Task<DoctorInfoDto> GetDoctor(int id)
    {
        return new DoctorInfoDto(1, "Jan", "Kowalski", "janko@email.com");
    }
    
    [HttpPost]
    public IActionResult AddDoctor(NewDoctorDto dto)
    {
        return Ok();
    }
    
    [HttpPut("{id}")]
    public IActionResult UpdateDoctor(int id, DoctorUpdateDto dto)
    {
        return Ok();
    }
    
    [HttpDelete("{id}")]
    public IActionResult DeleteDoctor(int id)
    {
        return Ok();
    }
}