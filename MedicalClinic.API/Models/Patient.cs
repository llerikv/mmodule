using System;

namespace MedicalClinic.API.Models
{
    public class Patient
    {
        public int Id { get; set; }
        public string Pin { get; set; } = null!;
        public string FullName { get; set; } = null!;
        public DateTime BirthDate { get; set; }
    }
}
