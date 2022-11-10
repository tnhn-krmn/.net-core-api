using HospitalProject.Business.Abstract;
using HospitalProject.Entity.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace HospitalProject.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        private IDoctorService _doctorService;

        public HomeController(IDoctorService doctorService)
        {
            _doctorService = doctorService;
        }

        [HttpGet]
        [Route("Get")]
        public List<Doctor> Get()
        {
            return _doctorService.ListDoctor();

        }

        [HttpGet("{id}")]
        public Doctor Get(int id)
        {
            return _doctorService.GetById(id);
        }

        [HttpPost]
        public int Post([FromBody] Doctor doctor)
        {
            return _doctorService.AddDoctor(doctor);
        }

        [HttpPut]
        public int Put([FromBody] Doctor doctor)
        {
            return _doctorService.UpdateDoctor(doctor);
        }

        [HttpDelete]
        public void Delete(int id)
        {
            var user = _doctorService.GetById(id);
            _doctorService.DeleteDoctor(user);
        }
    }
}
