using ProjectCamp.DataAccess.Abstract;
using ProjectCamp.DataAccess.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectCamp.DataAccess.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        public void Add(T entity)
        {
            using var c = new ProjectCampContext();
            c.Add(entity);
            c.SaveChanges();
        }

        public void Delete(T entity)
        {
            using var c = new ProjectCampContext();
            c.Remove(entity);
            c.SaveChanges();
        }

        public T Get(int id)
        {
            using var c = new ProjectCampContext();
            return c.Set<T>().Find(id);
        }

        public List<T> GetAll()
        {
            using var c = new ProjectCampContext();
            return c.Set<T>().ToList(); 
        }

        public void Update(T entity)
        {
            using var c = new ProjectCampContext();
            c.Update(entity);
            c.SaveChanges();
        }
    }
}
