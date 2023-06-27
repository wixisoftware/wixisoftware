using Microsoft.AspNetCore.Mvc;
using wixisoftware.Business.Concrete;
using wixisoftware.DataAccess.Abstract;
using wixisoftware.DataAccess.Concrete.EntityFramework;
using wixisoftware.Entities.Concrete;

namespace wixisoftware.WebAPI.Controllers
{
    //http://localhost:5227/swagger/index.html
    [ApiController]
    [Route("api/[controller]")]
    public class BlogController : ControllerBase
    {
        BlogManager Bm = new BlogManager(new EfBlogRepository());



        //[HttpGet(Name = "GetBlog")]
        //public List<Blog> Get()
        //{

        //    return Bm.GetBlogWithCategories();
        //}

        [HttpGet(Name = "GetBlogID")]
        public List<Blog> GetID(int id)
        {

            return Bm.GetBlogByID(id);
        }

    }
}
