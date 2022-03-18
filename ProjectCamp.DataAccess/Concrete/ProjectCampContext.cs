using Microsoft.EntityFrameworkCore;
using ProjectCamp.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectCamp.DataAccess.Concrete
{
    public class ProjectCampContext: DbContext
    {
        public DbSet<About> Abouts{ get; set; }
        public DbSet<Blog> Blogs{ get; set; }
        public DbSet<Category> Categories{ get; set; }
        public DbSet<Comment> Comments{ get; set; }
        public DbSet<Contact> Contacts{ get; set; }
        public DbSet<Writer> Writers{ get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            builder.UseSqlServer("server = DESKTOP-TNFNUSJ; database = CoreBlogDb; Integrated Security =true;");
            base.OnConfiguring(builder);
        }
    }
}
