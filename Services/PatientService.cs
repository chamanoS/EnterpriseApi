using HelloEnterpriseApi.Data;
using HelloEnterpriseApi.Models;

namespace HelloEnterpriseApi.Services;

public class PatientService : IPatientService
{
    private readonly ApplicationDbContext _context;

    public PatientService(ApplicationDbContext context)
    {
        _context = context;
    }

    public List<Patient> GetAll()
    {
        return _context.Patients.ToList();
    }

    public Patient Add(Patient patient)
    {
        _context.Patients.Add(patient);
        _context.SaveChanges();
        return patient;
    }
}
