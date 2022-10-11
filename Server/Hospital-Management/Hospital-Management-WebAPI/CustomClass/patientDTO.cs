using System.ComponentModel.DataAnnotations;

namespace Hospital_Management_WebAPI.CustomClass
{
    public class patientDTO
    {

        public string? name { get; set; }
        public string? gender { get; set; }
        [Range(0,100)]
        public int age { get; set; }
        [Phone]
        public string? phnNumber { get; set; }
        public List<int>? doctorId { get; set; }
    }
}
