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
    public class EfCarDal : ICarDal
    {
        public void Add(Car entity)
        {
            using (RentACarContext context = new RentACarContext())   // IDisposable pattern implementation of c#. using ile daha performanslı. iş bitince garbage collector siler.
            {
                var addedEntity = context.Entry(entity); //referansı yakala
                addedEntity.State = EntityState.Added;   //bu aslında eklenecek bir nesne
                context.SaveChanges();                   //ve şimdi ekle
            }
        }

        public void Delete(Car entity)
        {
            using (RentACarContext context = new RentACarContext())   // IDisposable pattern implementation of c#. using ile daha performanslı. iş bitince garbage collector siler.
            {
                var deletedEntity = context.Entry(entity); //referansı yakala
                deletedEntity.State = EntityState.Deleted; //bu aslında silinecek bir nesne
                context.SaveChanges();                     //ve şimdi sil
            }
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            //tek data getirecek
            using (RentACarContext context = new RentACarContext())   // IDisposable pattern implementation of c#. using ile daha performanslı. iş bitince garbage collector siler.
            {
                return context.Set<Car>().SingleOrDefault(filter);
            }
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            using (RentACarContext context = new RentACarContext())   // IDisposable pattern implementation of c#. using ile daha performanslı. iş bitince garbage collector siler.
            {
                return filter == null ? context.Set<Car>().ToList() : context.Set<Car>().Where(filter).ToList();
            }
        }

        public void Update(Car entity)
        {
            using (RentACarContext context = new RentACarContext())   // IDisposable pattern implementation of c#. using ile daha performanslı. iş bitince garbage collector siler.
            {
                var updatedEntity = context.Entry(entity);
                updatedEntity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
