using System.ComponentModel.DataAnnotations;

namespace Hospital_Management_WebAPI.CustomClass
{
    public class MedicalReportDTO
    {
        public string patientProblem { get; set; }
        public string medicalTest { get; set; }
        public string medicalResult { get; set; }
        public string date { get; set; }
        public int patientId { get; set; }
    }
}
