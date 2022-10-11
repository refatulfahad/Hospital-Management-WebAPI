using Hospital_Management_WebAPI.CustomClass;
using Hospital_Management_WebAPI.Data;
using Hospital_Management_WebAPI.Migrations;
using Hospital_Management_WebAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Hospital_Management_WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PatientBillController : ControllerBase
    {
        private readonly ApplicationDbContext applicationDbContext;
        public PatientBillController(ApplicationDbContext applicationDbContext)
        {
            this.applicationDbContext = applicationDbContext;
        }
        [HttpPost]
        public IActionResult addPatientBill(PatientBillDTO patientBill)
        {
            var data = new PatientBill
            {
               billType=patientBill.billType,
               billAmount=patientBill.billAmount,
               date=patientBill.date,
               patientId=patientBill.patientId,
            };
            applicationDbContext.tbl_PatientBill.Add(data);
            applicationDbContext.SaveChanges();
            return Ok();
        }
        [HttpGet("{id}")]//("{id}")
        public IActionResult searchPatientBill(int id)
        {
            var data = (from a in applicationDbContext.tbl_PatientBill
                        where a.patientId == id
                        select a);
            //var data = (from a in applicationDbContext.tbl_PatientBill
            //            select a);
            return Ok(data);
        }
       //[HttpPut("{id}")]
       // public IActionResult updatePatientBill(int id,PatientBill1 patientBill1)
       // {
       //     var data = new PatientBill
       //     {
       //         Id=id,
       //         Bill_Type=patientBill1.Bill_Type,
       //         Bill_Amount=patientBill1.Bill_Amount,
       //         date=patientBill1.date,
       //         PatientId=patientBill1.PatientId
       //     };
       //     applicationDbContext.tbl_PatientBill.Update(data);
       //     applicationDbContext.SaveChanges();
       //     return Ok();
       // }

    }
}
