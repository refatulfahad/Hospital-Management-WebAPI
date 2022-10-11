using System.ComponentModel.DataAnnotations;

namespace Hospital_Management_WebAPI.Models
{
    public class DoctorVM
    {
        [Key]
        public int id { get; set; }
        [Required]
        public string name { get; set; }
        [Phone]
        public string phnNumber { get; set; }
       
        public string specialist { get; set; }
        public IList<PatientDoctor>patients { get; set; }
    }
}
