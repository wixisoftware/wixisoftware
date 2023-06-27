using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using wixisoftware.Entities.Concrete;

namespace wixisoftware.DataAccess.Abstract
{
    public interface IAboutDAL : IGenericDAL<About>
    {


        //1. Versiyondaki Generic olmayan halde bulunan Metot imzaları

        //void CreateAbout(About about);
        //void UpdateAbout(About about);
        //void DeleteAbout(About about);

        //About GetAbout(int id);
    }
}
