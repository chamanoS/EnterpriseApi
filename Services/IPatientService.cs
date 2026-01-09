using HelloEnterpriseApi.Models;

namespace HelloEnterpriseApi.Services;

public interface IPatientService
{
    Task<List<Patient>> GetAllAsync();
    Task<Patient> AddAsync(Patient patient);
}
