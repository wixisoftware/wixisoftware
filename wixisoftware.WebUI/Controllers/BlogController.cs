using Microsoft.AspNetCore.Mvc;
using wixisoftware.Business.Concrete;
using wixisoftware.DataAccess.Concrete.EntityFramework;

namespace wixisoftware.WebUI.Controllers
{
    public class BlogController : Controller
    {
        BlogManager Bm = new BlogManager(new EfBlogRepository());

        public IActionResult BlogAnaSayfa()
        {
            var Tablo = Bm.GetBlogWithCategories();

            return View(Tablo);
        }


        public IActionResult BlogReadAll(int id)
        {

            var veri  = Bm.GetBlogByID(id);
            return View(veri);
        }
    }
}
