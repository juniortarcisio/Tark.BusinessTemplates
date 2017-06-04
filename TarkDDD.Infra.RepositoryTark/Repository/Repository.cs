using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using TarkDDD.Domain.Interfaces;
using TarkDDD.Domain.Interfaces.Repositories;

namespace TarkDDD.Infra.Data.Repository
{
    public abstract class Repository<TEntity> : IDisposable, IRepository<TEntity> where TEntity : IEntity
    {
        public TarkOrm.TarkOrm _tarkOrm;

        public Repository(TarkOrm.TarkOrm tarkOrm)
        {
            _tarkOrm = tarkOrm;
        }

        public TEntity GetById(params object[] keys)
        {
            return _tarkOrm.GetById<TEntity>(keys);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return _tarkOrm.GetAll<TEntity>();
        }
        
        public IEnumerable<TEntity> GetWhere<TProperty>(Expression<Func<TEntity, TProperty>> lambda, object value)
        {
            return _tarkOrm.GetWhere(lambda, value);
        }

        public bool ExistsById(params object[] keys)
        {
            return _tarkOrm.ExistsById<TEntity>(keys);
        }

        public bool ExistsWhere<TProperty>(Expression<Func<TEntity, TProperty>> lambda, object value)
        {
            return _tarkOrm.ExistsWhere(lambda, value);
        }

        public void Add(TEntity item)
        {
            _tarkOrm.Add(item);
        }

        public void Update(TEntity item)
        {
            _tarkOrm.Update(item);
        }

        public void Remove(TEntity item)
        {
            _tarkOrm.Remove(item);
        }

        public void RemoveById(params object[] keys)
        {
            _tarkOrm.RemoveById<TEntity>(keys);
        }

        public void Dispose()
        {
            _tarkOrm.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}
