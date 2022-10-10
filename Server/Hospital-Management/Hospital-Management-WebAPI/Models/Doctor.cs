using System.ComponentModel.DataAnnotations;

namespace Hospital_Management_WebAPI.Models
{
    public class Doctor
    {
        [Key]
        public int id { get; set; }
        
        public string name { get; set; }
       
        public string phnNumber { get; set; }
       
        public string specialist { get; set; }
        public IList<PatientDoctor>patients { get; set; }
    }
}
