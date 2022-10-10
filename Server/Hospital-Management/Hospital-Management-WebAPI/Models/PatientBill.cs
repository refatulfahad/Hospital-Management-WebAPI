using System.ComponentModel.DataAnnotations;

namespace Hospital_Management_WebAPI.Models
{
    public class PatientBill
    {
        [Key]
        public int id { get; set; }
        public string billType { get; set; }
        public int billAmount { get; set; }
        public string date { get; set; }
        public int? patientId { get; set; }
        public Patient Patient { get; set; }
    }
}
