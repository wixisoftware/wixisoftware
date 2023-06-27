using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using wixisoftware.Business.Abstract;
using wixisoftware.DataAccess.Abstract;
using wixisoftware.Entities.Concrete;

namespace wixisoftware.Business.Concrete
{
    public class CategoryManager : ICategoryServices
    {

        ICategoryDAL _categoryDAL;

        public CategoryManager(ICategoryDAL categoryDAL)
        {
            _categoryDAL = categoryDAL;
        }

        public void CreateCategory(Category category)
        {
            _categoryDAL.Create(category);
        }

        public void DeleteCategory(Category category)
        {
            _categoryDAL.Delete(category);
        }

        public Category GetCategory(int id)
        {
          return _categoryDAL.Get(id);
        }

        public List<Category> ReadCategory()
        {
            return _categoryDAL.GetListAll();
        }

        public void UpdateCategory(Category category)
        {
           _categoryDAL.Update(category);
        }
    }
}
