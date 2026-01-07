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
    public IActionResult GetPatients()
    {
        var patients = _patientService.GetAll();
        return Ok(patients);
    }

    [HttpPost]
    public IActionResult AddPatient(Patient patient)
    {
        var created = _patientService.Add(patient);
        return CreatedAtAction(nameof(GetPatients), new { id = created.Id }, created);
    }
}
