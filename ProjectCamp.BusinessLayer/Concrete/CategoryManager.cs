using ProjectCamp.BusinessLayer.Abstract;
using ProjectCamp.DataAccess.EfCore;
using ProjectCamp.Entity.Concrete;
using System;
using System.Collections.Generic;

namespace ProjectCamp.BusinessLayer.Concrete
{
    public class CategoryManager : ICategoryService
    {
        EfCoreCategoryRepository efCoreCategoryRepository;

        public CategoryManager()
        {
            efCoreCategoryRepository = new EfCoreCategoryRepository();
        }

        public void CategoryAdd(Category category)
        {
            efCoreCategoryRepository.Add(category); 
        }

        public void CategoryDelete(Category category)
        {
            efCoreCategoryRepository.Delete(category);  
        }

        public void CategoryUpdate(Category category)
        {
            efCoreCategoryRepository.Update(category);
        }

        public List<Category> GetAll()
        {
            return efCoreCategoryRepository.GetAll();
        }

        public Category GetById(int id)
        {
            return efCoreCategoryRepository.Get(id);
        }
    }
}
