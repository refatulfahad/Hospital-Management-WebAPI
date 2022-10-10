using Hospital_Management_WebAPI.CustomClass;
using Hospital_Management_WebAPI.Data;
using Hospital_Management_WebAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using static System.Reflection.Metadata.BlobBuilder;

namespace Hospital_Management_WebAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class DoctorController : ControllerBase
    {
        private readonly ApplicationDbContext applicationDbContext;
        public DoctorController(ApplicationDbContext applicationDbContext)
        {
            this.applicationDbContext = applicationDbContext;
        }
        [HttpGet]
        public async Task<IActionResult> getDoctorList()
        {
            var result = await applicationDbContext.tbl_Doctors.ToListAsync();
            return Ok(result);
        }
        [HttpPost]
        public async Task<IActionResult> addDoctor([FromBody] Doctor1 doctor)
        {
            var data = new Doctor()
            {
                name = doctor.name,
                phnNumber = doctor.phnNumber,
                specialist = doctor.specialist,
            };
            await applicationDbContext.tbl_Doctors.AddAsync(data);
            await applicationDbContext.SaveChangesAsync();
            return Ok(doctor);
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> updateDoctor([FromRoute]int id, Doctor1 doctor)
        {
            var data=await applicationDbContext.tbl_Doctors.FindAsync(id);
            if (data != null)
            {
                
                if (doctor.name != null)
                {data.name = doctor.name; }
                
                if(doctor.phnNumber != null)
                {
                    data.phnNumber = doctor.phnNumber;
                }
                
                if (doctor.specialist != null)
                {
                    data.specialist = doctor.specialist;
                }
                //applicationDbContext.tbl_Doctors.Update(data);
                await applicationDbContext.SaveChangesAsync();
                return Ok();
            }
            
            return NotFound();
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> deleteDoctor([FromRoute]int id)
        {
            var data = await applicationDbContext.tbl_Doctors.FindAsync(id);
            if(data != null)
            {
                applicationDbContext.tbl_Doctors.Remove(data);
                await applicationDbContext.SaveChangesAsync();
                return Ok();
            }
            
            return NotFound();
        }
    }
}
