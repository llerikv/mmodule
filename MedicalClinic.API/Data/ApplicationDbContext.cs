using Microsoft.EntityFrameworkCore;
using MedicalClinic.API.Models;

namespace MedicalClinic.API.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options) { }

        public DbSet<Patient> Patients { get; set; }
    }
}
