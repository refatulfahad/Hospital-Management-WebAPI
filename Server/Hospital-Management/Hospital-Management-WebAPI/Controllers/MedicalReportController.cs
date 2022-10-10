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
    public class MedicalReportController : ControllerBase
    {
        private readonly ApplicationDbContext applicationDbContext;
        public MedicalReportController(ApplicationDbContext applicationDbContext)
        {
            this.applicationDbContext = applicationDbContext;
        }
        [HttpPost]
        public IActionResult addMedicalReport(MedicalReport1 medicalReport)
        {
            var data = new MedicalReport
            {
                patientProblem = medicalReport.patientProblem,
                medicalTest = medicalReport.medicalTest,
                medicalResult = medicalReport.medicalResult,
                date = medicalReport.date,
                patientId=medicalReport.patientId,
            };
            applicationDbContext.tbl_medicalReports.Add(data);
            applicationDbContext.SaveChanges();
            return Ok();
        }
        [HttpGet]
        public IActionResult searchMedicalReport()
        {
            var data = (from a in applicationDbContext.tbl_medicalReports
                        select a);
            return Ok(data);
        }
    }
}