using HelloEnterpriseApi.Models;

namespace HelloEnterpriseApi.Services;

public interface IPatientService
{
    List<Patient> GetAll();
    Patient Add(Patient patient);
}
