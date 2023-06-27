using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using wixisoftware.Business.Concrete;
using wixisoftware.Entities.Concrete;
using wixisoftware.WebUI.Models;

namespace wixisoftware.WebUI.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }



        public IActionResult Test()
        {

            //AboutManager test = new AboutManager();
            //About about = new About();

            //try
            //{
            //    test.CreateAbout(about);
            //}
            //catch (Exception)
            //{

            //    throw;
            //}

            return View();

        }
    }
}