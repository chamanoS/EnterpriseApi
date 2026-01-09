using Microsoft.AspNetCore.Mvc;
using HelloEnterpriseApi.Models;
using HelloEnterpriseApi.Services;

namespace HelloEnterpriseApi.Controllers;

[ApiController]
[Route("api/patients")]
public class PatientsController : ControllerBase
{
    private readonly IPatientService _patientService;

    public PatientsController(IPatientService patientService)
    {
        _patientService = patientService;
    }

    [HttpGet]
    public async Task<IActionResult> GetPatients()
    {
        var patients = await _patientService.GetAllAsync();
        return Ok(patients);
    }


    [HttpPost]
    public async Task<IActionResult> AddPatient(Patient patient)
    {
        var created = await _patientService.AddAsync(patient);
        return CreatedAtAction(nameof(GetPatients), new { id = created.Id }, created);
    }

}
