﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using wixisoftware.DataAccess.Abstract;
using wixisoftware.DataAccess.Concrete.Context;

namespace wixisoftware.DataAccess.Repository
{
    public class GenericRepository<T> : IGenericDAL<T> where T : class
    {
        public void Create(T t)
        {
          
            using(Context c = new Context())
            {
                c.Add(t);
                c.SaveChanges();

            }
        }

        public void Delete(T t)
        {
            using (Context c = new Context())
            {
                c.Remove(t);
                c.SaveChanges();

            }
        }

        public T Get(int id)
        {
            using (Context c = new Context())
            {
                var test = c.Set<T>().Find(id);

                return test;

            }
        }

        public List<T> GetListAll(Expression<Func<T, bool>> filter)
        {
            using (Context c = new Context())
            {
                var test = c.Set<T>().Where(filter).ToList();

                return test;

            }
        }

        public List<T> GetListAll()
        {
            using (Context c = new Context())
            {
               return c.Set<T>().ToList();
            }
        }

        public void Update(T t)
        {
            using (Context c = new Context())
            {
                c.Update(t);
                c.SaveChanges();

            }
        }
    }
}
