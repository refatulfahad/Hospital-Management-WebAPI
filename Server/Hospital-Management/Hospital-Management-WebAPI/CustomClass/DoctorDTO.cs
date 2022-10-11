using System.ComponentModel.DataAnnotations;

namespace Hospital_Management_WebAPI.CustomClass
{
    public class DoctorDTO
    {
        // public int? id { get; set; }
        [StringLength(10,ErrorMessage ="Name is too big")]
        public string? name { get; set; }
        [Phone]
        public string? phnNumber { get; set; }

        public string? specialist { get; set; }
    }
}
