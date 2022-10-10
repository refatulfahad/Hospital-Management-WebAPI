using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Hospital_Management_WebAPI.Models
{
    public class MedicalReport
    {
        [Key]
        public int id { get; set; }
        public string patientProblem { get; set; }
        public string medicalTest { get; set; }
        public string medicalResult { get; set; }
        public string date { get; set; }
        public int? patientId { get; set; }
        public Patient Patient { get; set; }
    }
}
