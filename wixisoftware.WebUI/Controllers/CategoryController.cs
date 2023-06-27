using Microsoft.AspNetCore.Mvc;
using wixisoftware.Business.Concrete;
using wixisoftware.DataAccess.Concrete.EntityFramework;

namespace wixisoftware.WebUI.Controllers
{
    public class CategoryController : Controller
    {
        CategoryManager cm = new CategoryManager(new EfCategoryRepository());

        public IActionResult Index()
        {
            
            return View(cm.ReadCategory());
        }
    }
}
