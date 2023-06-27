using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using wixisoftware.Business.Abstract;
using wixisoftware.DataAccess.Repository;
using wixisoftware.Entities.Concrete;

namespace wixisoftware.Business.Concrete
{
    public class WriterManager : IWriterServices
    {
        GenericRepository<Writer> repo = new GenericRepository<Writer>();


        public void CreateWriter(Writer writer)
        {
            repo.Create(writer);
        }

        public void DeleteWriter(Writer writer)
        {
            //todo ID'si 0 olanların kontrolünü gerçekleştir öyle sil 

            repo.Delete(writer);    
        }

        public Writer GetWriter(int id)
        {
            return repo.Get(id);
        }

        public List<Writer> ReadWriter()
        {
            return repo.GetListAll();
        }

        public void UpdateWriter(Writer writer)
        {
          repo.Update(writer);
        }
    }
}
