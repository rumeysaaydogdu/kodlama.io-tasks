using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;   // EntityState'i kullanabilmek için
using System;
using System.Collections.Generic;
using System.Linq;  // SingleOrDefault için
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfBrandDal : IBrandDal
    {
        public void Add(Brand entity)
        {
            using (RentACarContext context = new RentACarContext())   // IDisposable pattern implementation of c#. using ile daha performanslı. iş bitince garbage collector siler.
            {
                var addedEntity = context.Entry(entity); //referansı yakala
                addedEntity.State = EntityState.Added;   //bu aslında eklenecek bir nesne
                context.SaveChanges();                   //ve şimdi ekle
            }
        }

        public void Delete(Brand entity)
        {
            using (RentACarContext context = new RentACarContext())   // IDisposable pattern implementation of c#. using ile daha performanslı. iş bitince garbage collector siler.
            {
                var deletedEntity = context.Entry(entity); //referansı yakala
                deletedEntity.State = EntityState.Deleted; //bu aslında silinecek bir nesne
                context.SaveChanges();                     //ve şimdi sil
            }
        }

        public Brand Get(Expression<Func<Brand, bool>> filter)
        {
            //tek data getirecek
            using (RentACarContext context = new RentACarContext())   // IDisposable pattern implementation of c#. using ile daha performanslı. iş bitince garbage collector siler.
            {
                return context.Set<Brand>().SingleOrDefault(filter);
            }
        }

        public List<Brand> GetAll(Expression<Func<Brand, bool>> filter = null)
        {
            using (RentACarContext context = new RentACarContext())   // IDisposable pattern implementation of c#. using ile daha performanslı. iş bitince garbage collector siler.
            {
                return filter == null ? context.Set<Brand>().ToList() : context.Set<Brand>().Where(filter).ToList();
            }
        }

        public void Update(Brand entity)
        {
            using (RentACarContext context = new RentACarContext())
            {
                var updatedEntity = context.Entry(entity);
                updatedEntity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
