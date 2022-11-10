using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace HospitalProject.DataAccess.Abstract
{
    public interface IRepository<T>
    {
        public int Add(T entity);

        public int Update(T entity);

        public int Delete(T entity);

        List<T> GetAll(Expression<Func<T, bool>> filter = null);

        T GetById(int id);
    }
}
