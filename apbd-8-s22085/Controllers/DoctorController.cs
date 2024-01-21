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
}