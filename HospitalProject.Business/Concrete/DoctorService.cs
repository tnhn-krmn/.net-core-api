using HospitalProject.Business.Abstract;
using HospitalProject.DataAccess.Abstract;
using HospitalProject.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace HospitalProject.Business.Concrete
{
    public class DoctorService : IDoctorService
    {
        IDoctorDal _doctorDal;

        public DoctorService(IDoctorDal doctorDal)
        {
            _doctorDal = doctorDal;
        }

        public int AddDoctor(Doctor doctor)
        {
            return _doctorDal.Add(doctor);
        }

        public int DeleteDoctor(Doctor doctor)
        {
            return _doctorDal.Delete(doctor);
        }

        public Doctor GetById(int id)
        {
            return _doctorDal.GetById(id);
        }

        public List<Doctor> ListDoctor(Expression<Func<Doctor, bool>> filter = null)
        {
            return _doctorDal.GetAll();
        }

        public int UpdateDoctor(Doctor doctor)
        {
            return _doctorDal.Update(doctor);
        }
    }
}
