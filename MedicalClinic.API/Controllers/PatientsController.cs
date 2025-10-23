using Microsoft.AspNetCore.Mvc;
using MedicalClinic.API.Models;
using System.Collections.Generic;

namespace MedicalClinic.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PatientsController : ControllerBase
    {
        private static readonly List<Patient> Patients = new();

        [HttpGet]
        public IActionResult GetPatients()
        {
            return Ok(Patients);
        }

        [HttpPost]
        public IActionResult AddPatient([FromBody] Patient patient)
        {
            Patients.Add(patient);
            return Ok(patient);
        }
    }
}
