using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Delivery.Infrastructure
{
    public interface IGenericRepository<TEntity> where TEntity : class
    {
        IQueryable<TEntity> All();
        TEntity FindBy(Expression<Func<TEntity, bool>> expression);
        IQueryable<TEntity> FilterBy(Expression<Func<TEntity, bool>> expression);
        TEntity FindBy(int id);
        bool Add(TEntity entity);
        bool Add(IEnumerable<TEntity> items);
        bool Update(TEntity entity);
        bool Delete(TEntity entity);
        bool Delete(IEnumerable<TEntity> entities);
    }
}