using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using wixisoftware.Entities.Concrete;

namespace wixisoftware.Business.Abstract
{
    public interface IWriterServices
    {

        void CreateWriter(Writer writer);
        List<Writer> ReadWriter();
        void UpdateWriter(Writer writer);
        void DeleteWriter(Writer writer);

        Writer GetWriter(int id);
    }
}
