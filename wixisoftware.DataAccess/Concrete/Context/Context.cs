using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using wixisoftware.Entities.Concrete;

namespace wixisoftware.DataAccess.Concrete.Context
{
    public class Context : DbContext
    {


        protected override void OnConfiguring(DbContextOptionsBuilder dbContextOptionsBuilder)
        {

            dbContextOptionsBuilder.UseSqlServer("server=WIXI\\WIXI; database= wixi; Integrated security= true; Trust Server Certificate=true;");

        }




        public DbSet<About> Abouts { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Writer> Writer { get; set; }



    }
}
