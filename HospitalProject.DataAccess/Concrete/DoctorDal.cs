using HospitalProject.DataAccess.Abstract;
using HospitalProject.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace HospitalProject.DataAccess.Concrete
{
    public class DoctorDal : Repository<Doctor>, IDoctorDal
    {
      
    }
}
