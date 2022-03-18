using Microsoft.AspNetCore.Mvc;

namespace ProjectCamp.Controllers
{
    public class CategoryController: Controller
    {
        public CategoryController()
        {

        }
        public IActionResult Index() { 
            return View();  
        }
    }
}
