using Microsoft.EntityFrameworkCore;
using MedicalClinic.API.Entities;

namespace MedicalClinic.API.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Patient> Patients { get; set; } = null!;
    }
}

