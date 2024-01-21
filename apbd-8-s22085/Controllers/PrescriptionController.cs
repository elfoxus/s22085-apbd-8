using apbd_8_s22085.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace apbd_8_s22085.Controllers;

[ApiController]
[Route("[controller]")]
public class PrescriptionController : ControllerBase
{
    private readonly ILogger<PrescriptionController> _logger;

    public PrescriptionController(ILogger<PrescriptionController> logger)
    {
        _logger = logger;
    }
    
    [HttpGet]
    public async Task<PrescriptionInfoDto> GetPrescriptionFor(int prescriptionId)
    {
        return new PrescriptionInfoDto(
            1,
            new DateOnly(2021, 1, 1),
            new DateOnly(2021, 1, 1),
            new DoctorInfoDto(1, "Jan", "Kowalski", ""),
            new PatientInfoDto(1, "Jan", "Kowalski", new DateOnly(1990, 1, 1)),
            new List<MedicamentInfoDto>());

    }
}