using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using wixisoftware.DataAccess.Abstract;
using wixisoftware.DataAccess.Concrete.Context;
using wixisoftware.DataAccess.Repository;
using wixisoftware.Entities.Concrete;

namespace wixisoftware.DataAccess.Concrete.EntityFramework
{
    public class EfBlogRepository : GenericRepository<Blog>, IBlogDal
    {
        public List<Blog> GetBlogWithCategory()
        {
            using (var c = new Context.Context())
            {
                return c.Blogs.Include(b => b.Category).ToList();

                 // hedeflenen varlığı eşliyor 
            }
        }
    }
}
