using Core.Entities;  //  IEntity için
using Microsoft.EntityFrameworkCore;   // EntityFramework'den DbContext'i miras aalabilmek için.
using System;
using System.Collections.Generic;
using System.Linq;  // SingleOrDefault, ToList ve Where için
using System.Linq.Expressions;  // Expression için
using System.Text;

namespace Core.DataAccess.EntityFramework
{
    public class EfEntityRepositoryBase<TEntity, TContext>:IEntityRepository<TEntity> //EfCarDal'a Add, Delete,Update, List operasyonlarında temel olması için yazdık. burada parametre yolluyoruz.
        where TEntity : class, IEntity, new()  // TEntity nasıl olmalı, ne olmalı. Kuralları belirledik.
        where TContext : DbContext, new()  // TContext nasıl olmalı, ne olmalı. Kuralları belirledik.
    {
        public void Add(TEntity entity)
        {
            using (TContext context = new TContext())   // IDisposable pattern implementation of c#. using ile daha performanslı. iş bitince garbage collector siler.
            {
                var addedEntity = context.Entry(entity); //referansı yakala
                addedEntity.State = EntityState.Added;   //bu aslında eklenecek bir nesne
                context.SaveChanges();                   //ve şimdi ekle
            }
        }

        public void Delete(TEntity entity)
        {
            using (TContext context = new TContext())   // IDisposable pattern implementation of c#. using ile daha performanslı. iş bitince garbage collector siler.
            {
                var deletedEntity = context.Entry(entity); //referansı yakala
                deletedEntity.State = EntityState.Deleted; //bu aslında silinecek bir nesne
                context.SaveChanges();                     //ve şimdi sil
            }
        }

        public TEntity Get(Expression<Func<TEntity, bool>> filter)
        {
            //tek data getirecek
            using (TContext context = new TContext())   // IDisposable pattern implementation of c#. using ile daha performanslı. iş bitince garbage collector siler.
            {
                return context.Set<TEntity>().SingleOrDefault(filter);
            }
        }

        public List<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null)
        {
            using (TContext context = new TContext())   // IDisposable pattern implementation of c#. using ile daha performanslı. iş bitince garbage collector siler.
            {
                return filter == null ? context.Set<TEntity>().ToList() : context.Set<TEntity>().Where(filter).ToList();
            }
        }

        public void Update(TEntity entity)
        {
            using (TContext context = new TContext())   // IDisposable pattern implementation of c#. using ile daha performanslı. iş bitince garbage collector siler.
            {
                var updatedEntity = context.Entry(entity);
                updatedEntity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
