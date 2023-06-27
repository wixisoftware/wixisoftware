using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using wixisoftware.Entities.Concrete;

namespace wixisoftware.Business.Abstract
{
    public interface IBlogServices
    {

        void CreateBlog(Blog blog);
        List<Blog> ReadBlog();
        void UpdateBlog(Blog blog);
        void DeleteBlog(Blog blog);
        List<Blog> GetBlogWithCategories();

        List<Blog> GetBlogByID(int ID);
        Blog GetBlog(int id);
      
    }
}
