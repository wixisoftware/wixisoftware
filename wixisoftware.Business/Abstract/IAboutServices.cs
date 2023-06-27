using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using wixisoftware.Entities.Concrete;

namespace wixisoftware.Business.Abstract
{
    public interface IAboutServices 
    {
        void CreateAbout(About about);
        List<About> ReadAbout();
        void UpdateAbout(About about);
        void DeleteAbout(About about);

        About GetAbout(int id);

    }
}
