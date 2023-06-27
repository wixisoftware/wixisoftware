using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using wixisoftware.Business.Abstract;
using wixisoftware.DataAccess.Abstract;
using wixisoftware.DataAccess.Repository;
using wixisoftware.Entities.Concrete;

namespace wixisoftware.Business.Concrete
{
    public class BlogManager : IBlogServices
    {
        GenericRepository<Writer> repo = new GenericRepository<Writer>();

        IBlogDal _blogDal;

        public BlogManager(IBlogDal blogDal)
        {

            _blogDal = blogDal;
        }

        public void CreateBlog(Blog blog)
        {
            _blogDal.Create(blog);
        }

        public void DeleteBlog(Blog blog)
        {
            _blogDal.Delete(blog);
        }

        public Blog GetBlog(int id)
        {
           return _blogDal.Get(id);
        }


        public List<Blog> GetBlogByID(int ID)
        {
            return _blogDal.GetListAll(h => h.BlogID == ID);
        }

        public List<Blog> GetBlogWithCategories()
        {
            return _blogDal.GetBlogWithCategory();
        }

        public List<Blog> ReadBlog()
        {
           return _blogDal.GetListAll();
        }

        public void UpdateBlog(Blog blog)
        {
            _blogDal.Update(blog);
        }
    }
}
