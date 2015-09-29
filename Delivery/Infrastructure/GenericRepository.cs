using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using NHibernate;
using NHibernate.Linq;
using NHibernate.Util;

namespace Delivery.Infrastructure
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private readonly ISession _currentSession;

        public GenericRepository(ISession currentSession)
        {
            _currentSession = currentSession;
        }

        public void Add(T entity)
        {
            _currentSession.Save(entity);
        }

        public void AddRange(IEnumerable<T> entities)
        {
            entities?.ForEach(entity => _currentSession.Save(entity));
        }

        public void Update(T entity)
        {
            _currentSession.Update(entity);
        }

        public void Delete(T entity)
        {
            _currentSession.Delete(entity);
        }

        public void DeleteRange(IEnumerable<T> entities)
        {
            entities?.ForEach(entity => _currentSession.Delete(entity));
        }

        public IQueryable<T> All()
        {
            return _currentSession.Query<T>();
        }

        public T FindById(long id)
        {
            return _currentSession.Get<T>(id);
        }
    }
}