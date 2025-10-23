using System;

namespace MedicalClinic.API.Entities
{
    public class Patient
    {
        public int Id { get; set; }

        public string Pin { get; set; } = null!; // 14 цифр, уникальный

        public string FullName { get; set; } = null!; // 3–200 символов

        public DateTime BirthDate { get; set; } // Дата рождения, < сегодня

        public string? Gender { get; set; } // Муж/Жен (опционально)

        public string? Phone { get; set; }

        public string? Email { get; set; }

        public string? Address { get; set; }

        public string? DocumentNumber { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}
