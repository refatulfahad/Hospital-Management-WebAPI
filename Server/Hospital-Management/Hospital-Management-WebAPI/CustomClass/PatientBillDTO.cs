using System.ComponentModel.DataAnnotations;

namespace Hospital_Management_WebAPI.CustomClass
{
    public class PatientBillDTO
    {
     
        public string billType { get; set; }
        public int billAmount { get; set; }
        public string date { get; set; }
        public int patientId { get; set; }

        //public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        //{
        //    if (date.Year < 2022)
        //    {
        //        yield return new ValidationResult("Date is incorrect");
        //    }
        //}
    }
}
