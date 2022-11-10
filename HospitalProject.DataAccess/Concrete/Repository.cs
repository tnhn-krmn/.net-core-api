using HospitalProject.DataAccess.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace HospitalProject.DataAccess.Concrete
{
    public class Repository<T> : IRepository<T> where T : class
    {
        Context con = new Context();
        DbSet<T> obj;


        public Repository()
        {
            obj = con.Set<T>();
        }

        public int Add(T entity)
        {
            obj.Add(entity);
            return con.SaveChanges();
        }

        public int Delete(T entity)
        {
            obj.Remove(entity);
            return con.SaveChanges();
        }

        public List<T> GetAll(Expression<Func<T, bool>> filter = null)
        {
            return obj.ToList();
        }

        public T GetById(int id)
        {
            return obj.Find(id);
        }

        public int Update(T entity)
        {
            obj.Update(entity);
            return con.SaveChanges();
        }
    }
}
