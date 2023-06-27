using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using wixisoftware.DataAccess.Abstract;
using wixisoftware.DataAccess.Concrete.Context;
using wixisoftware.Entities.Concrete;

namespace wixisoftware.DataAccess.Repository
{
    public class AboutRepository 
    {

        //1. Versiyon generic olamyan ve kod tekrarına düşüren hali
        //Context c = new Context();

        //public void CreateAbout(About about)
        //{
        // c.Add(about);
        //    c.SaveChanges();
        //}

        //public void DeleteAbout(About about)
        //{
        //    c.Remove(about);
        //    c.SaveChanges();
        //}

        //public About GetAbout(int id)
        //{
        //    // eğer boş döner ise geriye null döndürmemesi için validasyon uyguladık
        //    var about = c.Abouts.Find(id);

        //    if (about !=null)
        //    {
        //        return about;
        //    }
        //    else
        //    {
        //        var aboutC = new About();

        //        aboutC.AboutID = 0;
        //        aboutC.AboutStatus = false;

        //        return aboutC;
        //    }


        //}

        //public List<About> ReadAbout()
        //{
           

        //    return c.Abouts.ToList();


        //}

        //public void UpdateAbout(About about)
        //{
        //   c.Update(about);
        //   c.SaveChanges();
        //}
    }
}
