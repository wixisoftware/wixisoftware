using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using wixisoftware.Business.Abstract;
using wixisoftware.DataAccess.Abstract;
using wixisoftware.DataAccess.Concrete.EntityFramework;
using wixisoftware.DataAccess.Repository;
using wixisoftware.Entities.Concrete;

namespace wixisoftware.Business.Concrete
{
    public class AboutManager : IAboutServices
    {


        //1. Versiyon Stabil Repositorye bağımlı hali 
        //AboutRepository aboutManager = new AboutRepository();


        //2. versiyon EF ile entity bazlı Repositorye bağımlı versiyon
        /*
         * 
          
         
        EfAboutRepository efAboutRepository;
        public AboutManager()
        {
            efAboutRepository = new EfAboutRepository();
        }
         EfCategoryRepository'i kullanmamızdaki dezavantaj Entity Framework'e bağımlı olmamız. 
         
         İlerde başka bir teknoloji geldiğinde projeyi ona geçirmek için neredeyse bütün katmanlardaki kodları tek tek değiştirmemiz gerekir ama interface kullanarak bu bağımlılığı yok eder ve istersek ileride daha farklı teknolojilere geçebiliriz. Avantaj olaraksa kısa vadede daha az kod yazıp daha kısa sürede projeyi bitirebiliriz.*/


        //3. Versiyon artık havuz değişse bile imzaları aynı olucağından business katmanına dokunmadan veritabanı değişikliklerini yapmak daha da kolaylaşıcak

        IAboutDAL _aboutDAL;
        public AboutManager(IAboutDAL aboutDAL)
        {
            _aboutDAL = aboutDAL;
        }
       

        public void CreateAbout(About about)
        {
          
            // ufak bir trick validasyon yapmak

            if(about.AboutDetails1 != null && about.AboutDetails1.Length <250)
            {

                _aboutDAL.Create(about);

                //aboutManager.CreateAbout(about);
            }
            else
            {
                //HataMesajı yazdır geri gönder
                _aboutDAL.Create(about);

            }


        }

        public void DeleteAbout(About about)
        {
            throw new NotImplementedException();
        }

        public About GetAbout(int id)
        {
            throw new NotImplementedException();
        }

        public List<About> ReadAbout()
        {
            throw new NotImplementedException();
        }

        public void UpdateAbout(About about)
        {
            throw new NotImplementedException();
        }
    }
}
