using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace TarkDDD.Domain.Interfaces.Repositories
{
    /// <summary>
    /// The default repository pattern. 
    /// I'm using params as the Key for ID, intending to make it possible to works with legacy tables 
    /// which could contains composite PKs or not integer type fields
    /// </summary>
    /// <typeparam name="TEntity"></typeparam>
    public interface IRepository<TEntity> where TEntity : IEntity
    {
        TEntity GetById(params object[] keys);

        IEnumerable<TEntity> GetAll();

        IEnumerable<TEntity> GetWhere<TProperty>(Expression<Func<TEntity, TProperty>> lambda, object value);

        bool ExistsById(params object[] keys);

        bool ExistsWhere<TProperty>(Expression<Func<TEntity, TProperty>> lambda, object value);

        void Add(TEntity item);

        void Update(TEntity item);

        void Remove(TEntity item);

        void RemoveById(params object[] keys);
    }
}
