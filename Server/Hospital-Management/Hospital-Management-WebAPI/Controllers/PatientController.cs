using Hospital_Management_WebAPI.CustomClass;
using Hospital_Management_WebAPI.Data;
using Hospital_Management_WebAPI.Migrations;
using Hospital_Management_WebAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Hospital_Management_WebAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class PatientController : ControllerBase
    {
        private readonly ApplicationDbContext applicationDbContext;
        public PatientController(ApplicationDbContext applicationDbContext)
        {
            this.applicationDbContext = applicationDbContext;
        }
        [HttpGet]
        public async Task<IActionResult> getAllPatients()
        {
            var data = await applicationDbContext.tbl_Patients.ToListAsync();
            return Ok(data);
        }
        [HttpPost]
        //[Produces(typeof(patient1))]
        public Patient addPatient(patient1 patient)
        {

            Patient data = new Patient
            {
                name = patient.name,
                gender = patient.gender,
                age = patient.age,
                phnNumber = patient.phnNumber,

            };
            applicationDbContext.tbl_Patients.Add(data);
            applicationDbContext.SaveChanges();
            foreach (var id in patient.doctorId)
            {
                PatientDoctor pd = new PatientDoctor
                {
                    DoctorId = id,
                    PatientId = data.id,
                };

                applicationDbContext.tbl_PatientDoctor.Add(pd);
                applicationDbContext.SaveChanges();
                //data.doctors.Add(pd);
            }

            return data;
        }
        [HttpGet("{id}")]
        public IActionResult appointmentId(int id)
        {
            var data= (from a in applicationDbContext.tbl_PatientDoctor
                       where a.PatientId == id
                       select a.DoctorId);
            return Ok(data);
        }
        [HttpPut("{id}")]
        public IActionResult updatePatient(int id,patient1 patient)
        {
            var data=applicationDbContext.tbl_Patients.FirstOrDefault(x => x.id == id);
            if (patient.name != null) {data.name=patient.name;}
            if(patient.gender != null) { data.gender=patient.gender;}
            if (patient.phnNumber != null) { data.phnNumber = patient.phnNumber; }
            if (patient.age != 0) { data.age = patient.age; }
            //applicationDbContext.tbl_Patients.Update(data);
            applicationDbContext.SaveChanges();
            if (patient.doctorId != null)
            {
                while (true)
                {
                    var list = (from a in applicationDbContext.tbl_PatientDoctor
                                where a.PatientId == id
                                select a).FirstOrDefault();
                    if (list == null) break;
                    applicationDbContext.tbl_PatientDoctor.Remove(list);
                    applicationDbContext.SaveChanges();
                }
                foreach (var Id in patient.doctorId)
                {
                    PatientDoctor pd = new PatientDoctor
                    {
                        DoctorId = Id,
                        PatientId = id,
                    };

                    applicationDbContext.tbl_PatientDoctor.Add(pd);
                    applicationDbContext.SaveChanges();
                }
            }
            return Ok();
        }
        [HttpGet("{id}")]
        public IActionResult detailsPatient(int id)
        {
            var data = (from a in applicationDbContext.tbl_PatientDoctor
                        from b in applicationDbContext.tbl_Doctors
                        where a.PatientId == id && a.DoctorId == b.id
                        select new
                        {
                            id = b.id,
                            name = b.name,
                            phnNumber = b.phnNumber,
                            specialist = b.specialist,
                            PatientId = a.PatientId
                        }).ToList();
            return Ok(data);
        }
        [HttpDelete("{id}")]
        public IActionResult deletePatient(int id)
        {
            var data=applicationDbContext.tbl_Patients.Find(id);
            applicationDbContext.tbl_Patients.Remove(data);
            applicationDbContext.SaveChanges();
            while (true)
            {
                var list = (from a in applicationDbContext.tbl_PatientDoctor
                            where a.PatientId == id
                            select a).FirstOrDefault();
                if (list == null) break;
                applicationDbContext.tbl_PatientDoctor.Remove(list);
                applicationDbContext.SaveChanges();
            }
            return Ok();
        }
    }
}
