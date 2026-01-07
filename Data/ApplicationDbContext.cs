using Microsoft.EntityFrameworkCore;
using HelloEnterpriseApi.Models;

namespace HelloEnterpriseApi.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    public DbSet<Patient> Patients => Set<Patient>();
}
