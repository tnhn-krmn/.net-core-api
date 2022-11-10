using HospitalProject.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace HospitalProject.Business.Abstract
{
    public interface IDoctorService
    {
        public int AddDoctor(Doctor category);

        public int UpdateDoctor(Doctor category);

        public int DeleteDoctor(Doctor category);

        List<Doctor> ListDoctor(Expression<Func<Doctor, bool>> filter = null);

        Doctor GetById(int id);
    }
}
