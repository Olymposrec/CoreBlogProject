using ProjectCamp.DataAccess.Abstract;
using ProjectCamp.DataAccess.Concrete;
using ProjectCamp.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectCamp.DataAccess.Repositories
{
    public class BlogRepository : IBlogRepository
    {
        
        public void AddBlog(Blog blog)
        {
            using var c = new ProjectCampContext();
            c.Add(blog);
            c.SaveChanges();
        }

        public void DeleteBlog(Blog blog)
        {
            using var c = new ProjectCampContext();
            c.Remove(blog);
            c.SaveChanges();
        }

        public Blog GetById(int id)
        {
            using var c = new ProjectCampContext();
            return c.Blogs.Find(id);
        }

        public List<Blog> ListAllBlog()
        {
            using var c = new ProjectCampContext();
            return c.Blogs.ToList();
        }

        public void UpdateBlog(Blog blog)
        {
            using var c = new ProjectCampContext();
            c.Update(blog);
            c.SaveChanges();
        }
    }
}
