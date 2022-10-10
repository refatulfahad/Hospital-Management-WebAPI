using System.ComponentModel.DataAnnotations;

namespace Hospital_Management_WebAPI.Models
{
    public class Patient
    {
        [Key]
        public int id { get; set; }
        public string name { get; set; }
        public string gender { get; set; }
        public int age { get; set; }
        public string phnNumber { get; set; }
        public IList<PatientDoctor> doctors { get; set; }
    }
}
