using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using wixisoftware.DataAccess.Abstract;
using wixisoftware.DataAccess.Repository;
using wixisoftware.Entities.Concrete;

namespace wixisoftware.DataAccess.Concrete.EntityFramework
{
    public class EfCommentRepository:GenericRepository<Comment>,ICommentDal
    {


    }
}
