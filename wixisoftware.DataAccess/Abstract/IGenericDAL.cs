using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using wixisoftware.Entities.Concrete;

namespace wixisoftware.DataAccess.Abstract
{
    public interface IGenericDAL<T> where T : class
    {
        void Create(T t);
        void Update(T t);
        void Delete(T t);
        T Get(int id);

        List<T> GetListAll();
        List<T> GetListAll(Expression<Func<T,bool>> filter);

    }
}
