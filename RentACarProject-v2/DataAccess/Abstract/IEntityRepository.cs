using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IEntityRepository<T> where T : class, IEntity, new()  // Hepsinde aynı şeyi yazmamak için Generic Entity Repository'si oluşturduk. T yerine her seferinde ilgili nesne gelir.
    {
        List<T> GetAll(Expression<Func<T, bool>> filter = null);   // filtresiz sorgularda
        T Get(Expression<Func<T, bool>> filter);    // id ile alırken filtre uygularız
        void Add(T entity);  // ekleme
        void Update(T entity);   // güncelleme 
        void Delete(T entity);  // silme
    }
}
