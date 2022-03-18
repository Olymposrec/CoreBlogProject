using ProjectCamp.DataAccess.Abstract;
using ProjectCamp.DataAccess.Repositories;
using ProjectCamp.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectCamp.DataAccess.EfCore
{
    public class EfCoreCategoryRepository: GenericRepository<Category>, ICategoryRepository
    {
    }
}
