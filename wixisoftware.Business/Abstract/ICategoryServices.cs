using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using wixisoftware.Entities.Concrete;

namespace wixisoftware.Business.Abstract
{
    internal interface ICategoryServices
    {
        void CreateCategory(Category category);
        List<Category> ReadCategory();
        void UpdateCategory(Category category);
        void DeleteCategory(Category category);

        Category GetCategory(int id);


    }
}
